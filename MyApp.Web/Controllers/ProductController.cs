﻿using System;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.Interfaces;
using MediatR;
using MyApp.Domain.Core.Notifications;
using MyApp.Application.ViewModels;

namespace MyApp.Web.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductAppService productAppService;

        public ProductController(
            IProductAppService productAppService, 
            INotificationHandler<DomainNotification> notifications) : base(notifications)
        {
            this.productAppService = productAppService;
        }

        public IActionResult Index()
        {
            var products = productAppService.GetAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ProductViewModel product)
        {
            if (!ModelState.IsValid) return View(product);
            productAppService.Create(product);

            return RedirectToAction("Index");
        }
    }
}
