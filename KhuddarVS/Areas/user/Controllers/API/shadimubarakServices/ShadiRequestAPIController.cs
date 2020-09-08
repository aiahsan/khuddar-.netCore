using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhuddarVsModals.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KhuddarVS.Areas.user.Controllers.API.shadimubarakServices
{
    [Route("api/[controller]")]
    [ApiController]
    [Area("User")]

    public class ShadiRequestAPIController : ControllerBase
    {
        IUnitOfWork _repository = null;
        public ShadiRequestAPIController(IUnitOfWork repository)
        {

            _repository = repository;
        }

        [Route("~/api/shadhiRequests/get")]
        [HttpGet]
        public async Task<IActionResult> getShadiRequest()
        { 
            return Ok(await _repository.User.getShadhiRequests());
        }
    }
}
