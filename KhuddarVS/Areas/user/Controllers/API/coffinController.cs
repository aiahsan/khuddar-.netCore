using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhuddarVsModals.Interfaces;
using KhuddarVsModals.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KhuddarVS.Areas.user.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class coffinController : ControllerBase
    {
        IUnitOfWork _repository = null;

        public coffinController(IUnitOfWork repository)
        {

            _repository = repository;

        }

        [HttpPost]
        [Route("~/Api/postcoffinservice")]
        public async Task<IActionResult> postcoffinservice([FromBody] IEnumerable<KhuddarServices> requestModel)
        {
            if (requestModel.Count() > 0)
            {
                _repository.CoffinServices.AddRange(requestModel);
                await _repository.asyncComplete();
                return Ok();
            }
            //var item = await _query.Create(requestModel);
            // var model = _mapper.Map<ExpenseModel>(item);
            return BadRequest();
        }

        
        [HttpGet]
        [Route("~/Api/getcoffinservices")]
        public async Task<IActionResult> getcoffinservices()
        {
            var result = await _repository.CoffinServices.asyncGetAll();
            return Ok(result.Where(x => x.deleteStatus == false));

        }

        [HttpPost]
        [Route("~/api/updatecoffinservice")]
        public async Task<IActionResult> updatecoffinservice([FromBody] KhuddarServices requestModel)
        {
            if (requestModel != null)
            {
                var model = await _repository.CoffinServices.asyncFirstOrDefault(x => x.Id == requestModel.Id);
                if (model != null)
                {
                    model.ServiceName = requestModel.ServiceName;
                    model.status = requestModel.status;


                    await _repository.asyncComplete();
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("~/api/deletecoffinservice")]

        public async Task<IActionResult> deletecoffinservice(int? id)
        {
            if (id != null)
            {
                var result = await _repository.CoffinServices.asyncFirstOrDefault(x => x.Id == id.Value);
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
