using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhuddarVsModals.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace KhuddarVS.Areas.Admin.Controllers
{
   
        [Area("admin")]
        public class ShadhiMubarakController : Controller
        {

            IUnitOfWork _repository = null;
            private readonly IWebHostEnvironment webHostEnvironment;

            public ShadhiMubarakController(IUnitOfWork repostiry, IWebHostEnvironment hostEnvironment)
            {
                _repository = repostiry;
                webHostEnvironment = hostEnvironment;

            }
        [Route("~/ShadhiMubarak/alnikah/item")]
        public IActionResult alnikaitem()
        {
            return View();
        }
        [Route("~/ShadhiMubarak/alnikah/items/{id?}")]

        public async Task<IActionResult> alnikaitems(int? id)
        {
            if (id != null)
            {
                var result = await _repository.AlNikkahServicesItems.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    return View(result);
                }
            }
            return View();
        }

        [Route("~/ShadhiMubarak/barat/item")]
        public IActionResult baratitem()
        {
            return View();
        }
        [Route("~/ShadhiMubarak/barat/items/{id?}")]

        public async Task<IActionResult> baratitems(int? id)
        {
            if (id != null)
            {
                var result = await _repository.BaraatServicesItems.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    return View(result);
                }
            }
            return View();
        }

        [Route("~/ShadhiMubarak/foodandfood/item")]
        public IActionResult foodandfooditem()
        {
            return View();
        }
        [Route("~/ShadhiMubarak/foodandfood/items/{id?}")]

        public async Task<IActionResult> foodandfooditems(int? id)
        {
            if (id != null)
            {
                var result = await _repository.FoodandFoodServicesItem.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    return View(result);
                }
            }
            return View();
        }


        [Route("~/ShadhiMubarak/furniture/item")]
        public IActionResult furnitureitem()
        {
            return View();
        }
        [Route("~/ShadhiMubarak/furniture/items/{id?}")]

        public async Task<IActionResult> furnitureitems(int? id)
        {
            if (id != null)
            {
                var result = await _repository.FurnitureServicesItem.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    return View(result);
                }
            }
            return View();
        }
         [Route("~/ShadhiMubarak/groomsaloon/item")]
        public IActionResult groomsaloonitem()
        {
            return View();
        }
        [Route("~/ShadhiMubarak/groomsaloon/items/{id?}")]
        public async Task<IActionResult> groomsaloonitems(int? id)
        {
            if (id != null)
            {
                var result = await _repository.GroomSalonServicesItem.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    return View(result);
                }
            }
            return View();
        }

        [Route("~/ShadhiMubarak/MarrigeBanquet/item")]
        public IActionResult MarrigeBanquetitem()
        {
            return View();
        }
        [Route("~/ShadhiMubarak/MarrigeBanquet/items/{id?}")]
        public async Task<IActionResult> MarrigeBanquetitems(int? id)
        {
            if (id != null)
            {
                var result = await _repository.MarrigeBanquetServicesItem.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    return View(result);
                }
            }
            return View();
        }

        [Route("~/ShadhiMubarak/RentAHappyCar/item")]
        public IActionResult RentAHappyCaritem()
        {
            return View();
        }
        [Route("~/ShadhiMubarak/RentAHappyCar/items/{id?}")]
        public async Task<IActionResult> RentAHappyCaritems(int? id)
        {
            if (id != null)
            {
                var result = await _repository.RentAHappyCarServicesItem.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    return View(result);
                }
            }
            return View();
        }  
        
        [Route("~/ShadhiMubarak/Valima/item")]
        public IActionResult Valimaitem()
        {
            return View();
        }
        [Route("~/ShadhiMubarak/Valima/items/{id?}")]
        public async Task<IActionResult> Valimaitems(int? id)
        {
            if (id != null)
            {
                var result = await _repository.ValimaServicesItem.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    return View(result);
                }
            }
            return View();
        }

    }
}
