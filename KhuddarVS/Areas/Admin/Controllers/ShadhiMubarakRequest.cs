using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhuddarVsModals.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KhuddarVS.Areas.Admin.Controllers
{
    [Area("admin")]

    public class ShadhiMubarakRequest : Controller
    {
        IUnitOfWork _repository = null;
        private readonly IWebHostEnvironment webHostEnvironment;
        public ShadhiMubarakRequest(IUnitOfWork repostiry, IWebHostEnvironment hostEnvironment)
        {
            _repository = repostiry;
            webHostEnvironment = hostEnvironment;

        }

        [Route("~/ShadhiMubarak/request",Name ="shdRequests")]

        public async Task<IActionResult> shadiRequests()
        {
         
            return View();
        }
        [Route("~/ShadhiMubarak/details/user/{id?}")]

        public async Task<IActionResult> KhdUser(int ?id)
        {

           var user=await _repository.User.asyncFirstOrDefault(x => x.Id == id.Value);
            if(user!=null)
            {
                return View(user);
            }
            
            return RedirectToRoute("shdRequests");
        }

        [Route("~/ShadhiMubarak/details/Alnikkah/{id?}")]

        public async Task<IActionResult> KhdAlNikkah(int? id)
        {

            var user = await _repository.AlNikkah.asynFirstOrdefaultWithUser(x => x.Id == id.Value);
            if (user != null)
            {
                return View(user);
            }

            return RedirectToRoute("shdRequests");
        }
        
        [Route("~/ShadhiMubarak/details/Barat/{id?}")]

        public async Task<IActionResult> KhdBarat(int? id)
        {

            var user =await _repository.Barat.asynFirstOrdefaultWithUser(x => x.Id == id.Value);
            if (user != null)
            {
                return View(user);
            }

            return RedirectToRoute("shdRequests");
        }
        
        [Route("~/ShadhiMubarak/details/foodandfood/{id?}")]

        public async Task<IActionResult> Khdfoodandfood(int? id)
        {

            var user =await _repository.FoodandFood.asynFirstOrdefaultWithUser(x => x.Id == id.Value);
            if (user != null)
            {
                return View(user);
            }

            return RedirectToRoute("shdRequests");
        }
        
        [Route("~/ShadhiMubarak/details/furniture/{id?}")]

        public async Task<IActionResult> Khdfurniture(int? id)
        {

            var user =await _repository.Furniture.asynFirstOrdefaultWithUser(x => x.Id == id.Value);
            if (user != null)
            {
                return View(user);
            }

            return RedirectToRoute("shdRequests");
        }
        [Route("~/ShadhiMubarak/details/groomsaloon/{id?}")]

        public async Task<IActionResult> Khdgroomsaloon(int? id)
        {

            var user =await _repository.GroomSalon.asynFirstOrdefaultWithUser(x => x.Id == id.Value);
            if (user != null)
            {
                return View(user);
            }

            return RedirectToRoute("shdRequests");
        }
        [Route("~/ShadhiMubarak/details/rentahappycar/{id?}")]

        public async Task<IActionResult> Khdrenahappycar(int? id)
        {

            var user =await _repository.RentAHappyCar.asynFirstOrdefaultWithUser(x => x.Id == id.Value);
            if (user != null)
            {
                return View(user);
            }

            return RedirectToRoute("shdRequests");
        }
        
        [Route("~/ShadhiMubarak/details/valima/{id?}")]

        public async Task<IActionResult> Khdvalima(int? id)
        {

            var user =await _repository.Valima.asynFirstOrdefaultWithUser(x => x.Id == id.Value);
            if (user != null)
            {
                return View(user);
            }

            return RedirectToRoute("shdRequests");
        }



    }
}
