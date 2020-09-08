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
    public class ShadiMubarakController : ControllerBase
    {
        IUnitOfWork _repository = null;

        public ShadiMubarakController(IUnitOfWork repostiry)
        {
            _repository = repostiry;
        }

        [HttpPost]
        [Route("~/Api/shadhiModeControl")]
        public async Task<IActionResult> shadhiModeControl([FromBody] List<KhuddarShadiMubarakUnlockMode> requestModel)
        {
            var ShadiMubarakMode =await _repository.ShadiMubarakUnlockMode.asyncGetAll();
            var listOfUpdated = new List<KhuddarShadiMubarakUnlockMode>();
            if (requestModel.Count() > 0)
            {
                foreach(var item in requestModel)
                {
                    if(ShadiMubarakMode.Any(x=>x.ServiceType==item.ServiceType))
                    {
                        listOfUpdated.Add(item);
                    }
                    else
                    {
                        _repository.ShadiMubarakUnlockMode.Add(item);
                    }
                }
                foreach(var item in listOfUpdated)
                {
                    var oldModel = _repository.ShadiMubarakUnlockMode.FirstOrDefault(x => x.ServiceType == item.ServiceType);
                    if (oldModel != null)
                    {
                        oldModel.ServiceType = item.ServiceType;
                        oldModel.status = item.status;
                        oldModel.unlockMonth = item.unlockMonth;
                    }
                }
                await _repository.asyncComplete();
                return Ok();
            }
            //var item = await _query.Create(requestModel);
            // var model = _mapper.Map<ExpenseModel>(item);
            return BadRequest();
        }

    }
}
