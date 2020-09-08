using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KhuddarVSDatabase;
using KhuddarVsModals.Interfaces;

namespace KhuddarVS.Areas.user.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    [Area("User")]
    public class AdminAPIController : ControllerBase
    {

        public IUnitOfWork _repository=null;

        public AdminAPIController(IUnitOfWork UnitOfWork)
        {
            _repository = UnitOfWork;
        }

        [Route("~/Api/users")]
        public async Task<IActionResult> getUsers()
        {
            return Ok(await _repository.User.asyncGetAll());
        }

    }
}
