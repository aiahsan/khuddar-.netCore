using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhuddarVsModals.Interfaces;
using KhuddarVsModals.Models.ShadiMubarakServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KhuddarVS.Areas.user.Controllers.API.shadimubarakServices
{
    [Route("api/[controller]")]
    [ApiController]
    [Area("User")]

    public class ShadiMubarakItemsController : ControllerBase
    {
        IUnitOfWork _repository = null;
        public ShadiMubarakItemsController(IUnitOfWork repository)
        {

            _repository = repository;
        }


        [HttpPost]
        [Route("~/Api/shadhuMubrak/post/alnikah")]
        public async Task<IActionResult> postalnikah([FromBody] IEnumerable<KhuddarAlNikkahServicesItems> requestModel)
        {
            if (requestModel.Count() > 0)
            {
                _repository.AlNikkahServicesItems.AddRange(requestModel);
                await _repository.asyncComplete();
                return Ok();
            }
            //var item = await _query.Create(requestModel);
            // var model = _mapper.Map<ExpenseModel>(item);
            return BadRequest();
        }

      
        [HttpGet]
        [Route("~/Api/shadhuMubrak/get/alnikah")]
        public async Task<IActionResult> getalnikah()
        {
            var result = await _repository.AlNikkahServicesItems.asyncGetAll();
            return Ok(result.Where(x => x.deleteStatus == false));

        }

        [HttpPost]
        [Route("~/api/shadhuMubrak/update/alnikah")]
        public async Task<IActionResult> updatealnikah([FromBody] KhuddarAlNikkahServicesItems requestModel)
        {
            if (requestModel != null)
            {
                var model = await _repository.AlNikkahServicesItems.asyncFirstOrDefault(x => x.Id == requestModel.Id);
                if (model != null)
                {
                    model.serviceName = requestModel.serviceName;
                    model.UnitCost= requestModel.UnitCost;
                    model.status = requestModel.status;


                    await _repository.asyncComplete();
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("~/api/shadhuMubrak/delete/alnikah")]

        public async Task<IActionResult> deletealnikah(int? id)
        {
            if (id != null)
            {
                var result = await _repository.AlNikkahServicesItems.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    result.deleteStatus = true;
                    await _repository.asyncComplete();
                    return Ok(1);
                }
            }
            return BadRequest();
        }


        //Barat



        [HttpPost]
        [Route("~/Api/shadhuMubrak/post/barat")]
        public async Task<IActionResult> postbarat([FromBody] IEnumerable<KhuddarBaraatServicesItems> requestModel)
        {
            if (requestModel.Count() > 0)
            {
                _repository.BaraatServicesItems.AddRange(requestModel);
                await _repository.asyncComplete();
                return Ok();
            }
            //var item = await _query.Create(requestModel);
            // var model = _mapper.Map<ExpenseModel>(item);
            return BadRequest();
        }

        [HttpGet]
        [Route("~/Api/shadhuMubrak/get/barat")]
        public async Task<IActionResult> getbarat()
        {
            var result = await _repository.BaraatServicesItems.asyncGetAll();
            return Ok(result.Where(x => x.deleteStatus == false));

        }
        [HttpPost]
        [Route("~/api/shadhuMubrak/update/barat")]
        public async Task<IActionResult> updatebarat([FromBody] KhuddarBaraatServicesItems requestModel)
        {
            if (requestModel != null)
            {
                var model = await _repository.BaraatServicesItems.asyncFirstOrDefault(x => x.Id == requestModel.Id);
                if (model != null)
                {
                    model.serviceName = requestModel.serviceName;
                    model.UnitCost = requestModel.UnitCost;
                    model.status = requestModel.status;


                    await _repository.asyncComplete();
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("~/api/shadhuMubrak/delete/barat")]

        public async Task<IActionResult> deletebarat(int? id)
        {
            if (id != null)
            {
                var result = await _repository.BaraatServicesItems.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    result.deleteStatus = true;
                    await _repository.asyncComplete();
                    return Ok(1);
                }
            }
            return BadRequest();
        }



        //Food and Food



        [HttpPost]
        [Route("~/Api/shadhuMubrak/post/foodandfood")]
        public async Task<IActionResult> postfoodandfood([FromBody] IEnumerable<KhuddarFoodandFoodServicesItem> requestModel)
        {
            if (requestModel.Count() > 0)
            {
                _repository.FoodandFoodServicesItem.AddRange(requestModel);
                await _repository.asyncComplete();
                return Ok();
            }
            //var item = await _query.Create(requestModel);
            // var model = _mapper.Map<ExpenseModel>(item);
            return BadRequest();
        }

        [HttpGet]
        [Route("~/Api/shadhuMubrak/get/foodandfood")]
        public async Task<IActionResult> getfoodandfood()
        {
            var result = await _repository.FoodandFoodServicesItem.asyncGetAll();
            return Ok(result.Where(x => x.deleteStatus == false));

        }
        [HttpPost]
        [Route("~/api/shadhuMubrak/update/foodandfood")]
        public async Task<IActionResult> updatefoodandfood([FromBody] KhuddarFoodandFoodServicesItem requestModel)
        {
            if (requestModel != null)
            {
                var model = await _repository.FoodandFoodServicesItem.asyncFirstOrDefault(x => x.Id == requestModel.Id);
                if (model != null)
                {
                    model.serviceName = requestModel.serviceName;
                    model.UnitCost = requestModel.UnitCost;
                    model.status = requestModel.status;


                    await _repository.asyncComplete();
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("~/api/shadhuMubrak/delete/foodandfood")]

        public async Task<IActionResult> deletefoodandfood(int? id)
        {
            if (id != null)
            {
                var result = await _repository.FoodandFoodServicesItem.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    result.deleteStatus = true;
                    await _repository.asyncComplete();
                    return Ok(1);
                }
            }
            return BadRequest();
        }



        //furniture



        [HttpPost]
        [Route("~/Api/shadhuMubrak/post/furniture")]
        public async Task<IActionResult> postfurniture([FromBody] IEnumerable<KhuddarFurnitureServicesItem> requestModel)
        {
            if (requestModel.Count() > 0)
            {
                _repository.FurnitureServicesItem.AddRange(requestModel);
                await _repository.asyncComplete();
                return Ok();
            }
            //var item = await _query.Create(requestModel);
            // var model = _mapper.Map<ExpenseModel>(item);
            return BadRequest();
        }

        [HttpGet]
        [Route("~/Api/shadhuMubrak/get/furniture")]
        public async Task<IActionResult> getfurniture()
        {
            var result = await _repository.FurnitureServicesItem.asyncGetAll();
            return Ok(result.Where(x => x.deleteStatus == false));

        }
        [HttpPost]
        [Route("~/api/shadhuMubrak/update/furniture")]
        public async Task<IActionResult> updatefurniture([FromBody] KhuddarFurnitureServicesItem requestModel)
        {
            if (requestModel != null)
            {
                var model = await _repository.FurnitureServicesItem.asyncFirstOrDefault(x => x.Id == requestModel.Id);
                if (model != null)
                {
                    model.serviceName = requestModel.serviceName;
                    model.UnitCost = requestModel.UnitCost;
                    model.status = requestModel.status;


                    await _repository.asyncComplete();
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("~/api/shadhuMubrak/delete/furniture")]

        public async Task<IActionResult> deletefurniture(int? id)
        {
            if (id != null)
            {
                var result = await _repository.FurnitureServicesItem.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    result.deleteStatus = true;
                    await _repository.asyncComplete();
                    return Ok(1);
                }
            }
            return BadRequest();
        }


        //groomsaloon



        [HttpPost]
        [Route("~/Api/shadhuMubrak/post/groomsaloon")]
        public async Task<IActionResult> postgroomsaloon([FromBody] IEnumerable<KhuddarGroomSalonServicesItem> requestModel)
        {
            if (requestModel.Count() > 0)
            {
                _repository.GroomSalonServicesItem.AddRange(requestModel);
                await _repository.asyncComplete();
                return Ok();
            }
            //var item = await _query.Create(requestModel);
            // var model = _mapper.Map<ExpenseModel>(item);
            return BadRequest();
        }

        [HttpGet]
        [Route("~/Api/shadhuMubrak/get/groomsaloon")]
        public async Task<IActionResult> getgroomsaloon()
        {
            var result = await _repository.GroomSalonServicesItem.asyncGetAll();
            return Ok(result.Where(x => x.deleteStatus == false));

        }
        [HttpPost]
        [Route("~/api/shadhuMubrak/update/groomsaloon")]
        public async Task<IActionResult> updategroomsaloon([FromBody] KhuddarGroomSalonServicesItem requestModel)
        {
            if (requestModel != null)
            {
                var model = await _repository.GroomSalonServicesItem.asyncFirstOrDefault(x => x.Id == requestModel.Id);
                if (model != null)
                {
                    model.serviceName = requestModel.serviceName;
                    model.UnitCost = requestModel.UnitCost;
                    model.status = requestModel.status;


                    await _repository.asyncComplete();
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("~/api/shadhuMubrak/delete/groomsaloon")]

        public async Task<IActionResult> deletegroomsaloon(int? id)
        {
            if (id != null)
            {
                var result = await _repository.GroomSalonServicesItem.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    result.deleteStatus = true;
                    await _repository.asyncComplete();
                    return Ok(1);
                }
            }
            return BadRequest();
        }

        //MarrigeBanquet



        [HttpPost]
        [Route("~/Api/shadhuMubrak/post/MarrigeBanquet")]
        public async Task<IActionResult> postMarrigeBanquet([FromBody] IEnumerable<KhuddarMarrigeBanquetServicesItem> requestModel)
        {
            if (requestModel.Count() > 0)
            {
                _repository.MarrigeBanquetServicesItem.AddRange(requestModel);
                await _repository.asyncComplete();
                return Ok();
            }
            //var item = await _query.Create(requestModel);
            // var model = _mapper.Map<ExpenseModel>(item);
            return BadRequest();
        }

        [HttpGet]
        [Route("~/Api/shadhuMubrak/get/MarrigeBanquet")]
        public async Task<IActionResult> getMarrigeBanquet()
        {
            var result = await _repository.MarrigeBanquetServicesItem.asyncGetAll();
            return Ok(result.Where(x => x.deleteStatus == false));

        }
        [HttpPost]
        [Route("~/api/shadhuMubrak/update/MarrigeBanquet")]
        public async Task<IActionResult> updateMarrigeBanquet([FromBody] KhuddarMarrigeBanquetServicesItem requestModel)
        {
            if (requestModel != null)
            {
                var model = await _repository.MarrigeBanquetServicesItem.asyncFirstOrDefault(x => x.Id == requestModel.Id);
                if (model != null)
                {
                    model.serviceName = requestModel.serviceName;
                    model.UnitCost = requestModel.UnitCost;
                    model.status = requestModel.status;


                    await _repository.asyncComplete();
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("~/api/shadhuMubrak/delete/MarrigeBanquet")]

        public async Task<IActionResult> deleteMarrigeBanquet(int? id)
        {
            if (id != null)
            {
                var result = await _repository.MarrigeBanquetServicesItem.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    result.deleteStatus = true;
                    await _repository.asyncComplete();
                    return Ok(1);
                }
            }
            return BadRequest();
        }
        //RentAHappyCar



        [HttpPost]
        [Route("~/Api/shadhuMubrak/post/RentAHappyCar")]
        public async Task<IActionResult> postRentAHappyCar([FromBody] IEnumerable<KhuddarRentAHappyCarServicesItem> requestModel)
        {
            if (requestModel.Count() > 0)
            {
                _repository.RentAHappyCarServicesItem.AddRange(requestModel);
                await _repository.asyncComplete();
                return Ok();
            }
            //var item = await _query.Create(requestModel);
            // var model = _mapper.Map<ExpenseModel>(item);
            return BadRequest();
        }

        [HttpGet]
        [Route("~/Api/shadhuMubrak/get/RentAHappyCar")]
        public async Task<IActionResult> getRentAHappyCar()
        {
            var result = await _repository.RentAHappyCarServicesItem.asyncGetAll();
            return Ok(result.Where(x => x.deleteStatus == false));

        }
        [HttpPost]
        [Route("~/api/shadhuMubrak/update/RentAHappyCar")]
        public async Task<IActionResult> updateRentAHappyCar([FromBody] KhuddarRentAHappyCarServicesItem requestModel)
        {
            if (requestModel != null)
            {
                var model = await _repository.RentAHappyCarServicesItem.asyncFirstOrDefault(x => x.Id == requestModel.Id);
                if (model != null)
                {
                    model.serviceName = requestModel.serviceName;
                    model.UnitCost = requestModel.UnitCost;
                    model.status = requestModel.status;


                    await _repository.asyncComplete();
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("~/api/shadhuMubrak/delete/RentAHappyCar")]

        public async Task<IActionResult> deleteRentAHappyCar(int? id)
        {
            if (id != null)
            {
                var result = await _repository.RentAHappyCarServicesItem.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    result.deleteStatus = true;
                    await _repository.asyncComplete();
                    return Ok(1);
                }
            }
            return BadRequest();
        }
         //Valima



        [HttpPost]
        [Route("~/Api/shadhuMubrak/post/Valima")]
        public async Task<IActionResult> postValima([FromBody] IEnumerable<KhuddarValimaServicesItem> requestModel)
        {
            if (requestModel.Count() > 0)
            {
                _repository.ValimaServicesItem.AddRange(requestModel);
                await _repository.asyncComplete();
                return Ok();
            }
            //var item = await _query.Create(requestModel);
            // var model = _mapper.Map<ExpenseModel>(item);
            return BadRequest();
        }

        [HttpGet]
        [Route("~/Api/shadhuMubrak/get/Valima")]
        public async Task<IActionResult> getValima()
        {
            var result = await _repository.ValimaServicesItem.asyncGetAll();
            return Ok(result.Where(x => x.deleteStatus == false));

        }
        [HttpPost]
        [Route("~/api/shadhuMubrak/update/Valima")]
        public async Task<IActionResult> updateValima([FromBody] KhuddarValimaServicesItem requestModel)
        {
            if (requestModel != null)
            {
                var model = await _repository.ValimaServicesItem.asyncFirstOrDefault(x => x.Id == requestModel.Id);
                if (model != null)
                {
                    model.serviceName = requestModel.serviceName;
                    model.UnitCost = requestModel.UnitCost;
                    model.status = requestModel.status;


                    await _repository.asyncComplete();
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("~/api/shadhuMubrak/delete/Valima")]

        public async Task<IActionResult> deleteValima(int? id)
        {
            if (id != null)
            {
                var result = await _repository.ValimaServicesItem.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    result.deleteStatus = true;
                    await _repository.asyncComplete();
                    return Ok(1);
                }
            }
            return BadRequest();
        }

    }
}
