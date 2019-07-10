using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        //injeção de dependencia
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
             _sellerService = sellerService;
        }
        public IActionResult Index()
        {
            //retorna Lista sellerService
            var list = _sellerService.FindAll(); 
            return View(list); //retorna dados da Model na var list
        }

        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        
    }
}