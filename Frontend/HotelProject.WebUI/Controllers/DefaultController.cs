﻿using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public PartialViewResult _SubscribePartial()
        {
            return PartialView();

        }
        [HttpPost]
        public async Task<IActionResult> _SubscribePartial(CreateSubscribeDto createSubscribeDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSubscribeDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Burayı güncelledik
            var response = await client.PostAsync("http://localhost:28187/api/Subscribe", stringContent);

            if (response.IsSuccessStatusCode)
            {
                // Başarılı olduğunda ne yapmak istiyorsanız
            }
            else
            {
                // Hata durumunda ne yapmak istiyorsanız
            }

            return RedirectToAction("Index", "Default");
        }




    }
}
