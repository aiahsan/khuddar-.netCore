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
    public class VideosController : ControllerBase
    {
        IUnitOfWork _repository = null;
        public VideosController(IUnitOfWork repository)
        {

            _repository = repository;
        }

        [HttpPost]
        [Route("~/Api/postVideo")]
        public async Task<IActionResult> postVideo([FromBody] IEnumerable<KhuddarEarnToPLayVideo> requestModel)
        {
            if (requestModel.Count() > 0)
            {
                _repository.EarnToPLayVideo.AddRange(requestModel);
                await _repository.asyncComplete();
                return Ok();
            }
            //var item = await _query.Create(requestModel);
            // var model = _mapper.Map<ExpenseModel>(item);
            return BadRequest();
        }

        [HttpPost]
        [Route("~/api/updatevideo")]
        public async Task<IActionResult> updatecategory([FromBody] KhuddarEarnToPLayVideo requestModel)
        {
            if (requestModel != null)
            {
                var model = await _repository.EarnToPLayVideo.asyncFirstOrDefault(x => x.Id == requestModel.Id);
                if (model != null)
                {
                    model.amount= requestModel.amount;
                    model.videoId= requestModel.videoId;
                    model.date = DateTime.Now;
                    model.source= requestModel.source;
                    model.amount= requestModel.amount;
                    model.title= requestModel.title;
                    model.thumbnail= requestModel.thumbnail;
                    model.expiryDate= requestModel.expiryDate;
                    model.date = DateTime.Now;

                    model.status = requestModel.status;


                    await _repository.asyncComplete();
                    return Ok();
                }
            }
            return BadRequest();
        }
        [Route("~/Api/getVideo")]
        [HttpGet]
        public async Task<IActionResult> getVideo()
        {
            var videos = await _repository.EarnToPLayVideo.asyncGetAll();
            return Ok(videos.Where(x=>x.deleteStatus==false));
        } 
        [Route("~/Api/deleteVideo")]
        [HttpGet]
        public async Task<IActionResult> deleteVideo(int id)
        {
            var video = await _repository.EarnToPLayVideo.asyncFirstOrDefault(x => x.Id == id);

            if(video!=null)
            {
                video.deleteStatus = true;
               await _repository.asyncComplete();
                return Ok(1);
            }
            return BadRequest();
        }


    }
}
