using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhuddarVSDatabase;
using KhuddarVsModals.Interfaces;
using KhuddarVsModals.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KhuddarVS.Areas.user.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    [Area("User")]

    public class QuizAPIController : ControllerBase
    {
        IUnitOfWork _repository = null;
        public QuizAPIController(IUnitOfWork repository)
        {

            _repository = repository;
        }

        //quiz

        [HttpGet]
        [Route("~/Api/quizoftheday/{id}")]
        public async Task<IActionResult> getQuiz(int id)
        {
            var dataget = await _repository.Quiz.getCompleteQuizOftheDay();
            var checKdata = await _repository.QuizCompleted.asyncFirstOrDefault(x => x.userId == id && x.completionDate.Value.Date == DateTime.Now.Date);
            if (checKdata != null)
            {

                return Ok(1);

            }
            else
                return Ok(dataget);



        }
         [HttpGet]
        [Route("~/Api/quizComplete")]
        public async Task<IActionResult> getCompleteQuiz()
        {
            var dataget = await _repository.Quiz.getCompleteQuiz();
            return Ok(dataget.Where(x=>x.deleteStatus==false).ToList());



        }


        //Categores

        [HttpPost]
        [Route("~/Api/postcategory")]
       public async Task<IActionResult> postcategory([FromBody] IEnumerable<KhuddarQuizCategory> requestModel)
        {
            if(requestModel.Count()>0)
            {
                _repository.QuizCategory.AddRange(requestModel);
                await _repository.asyncComplete();
               return Ok();
            }
            //var item = await _query.Create(requestModel);
            // var model = _mapper.Map<ExpenseModel>(item);
            return BadRequest();
        }

        [HttpPost]
        [Route("~/Api/postquizes")]
        public async Task<IActionResult> postquiz([FromBody] IEnumerable<KhuddarQuiz> requestModel)
        {
            if (requestModel.Count() > 0)
            {
                _repository.Quiz.AddRange(requestModel);
                await _repository.asyncComplete();
                return Ok();
            }
            //var item = await _query.Create(requestModel);
            // var model = _mapper.Map<ExpenseModel>(item);
            return BadRequest();
        }

        [HttpGet]
        [Route("~/Api/getcategories")]
       public async Task<IActionResult> getcategories()
        {
            var result = await _repository.QuizCategory.asyncGetAll();
            return Ok(result.Where(x=>x.deleteStatus==false));

        }

        [HttpPost]
        [Route("~/api/updatecategory")]
        public async Task<IActionResult> updatecategory([FromBody] KhuddarQuizCategory requestModel)
        {
            if (requestModel != null)
            {
                var model = await _repository.QuizCategory.asyncFirstOrDefault(x => x.Id == requestModel.Id);
                if (model != null)
                {
                    model.Category = requestModel.Category;
                    model.status = requestModel.status;


                    await _repository.asyncComplete();
                    return Ok();
                }
            }
            return BadRequest();
        }
        
       [HttpGet]
       [Route("~/api/deleteCategory")]

       public async Task<IActionResult> deleteCategory(int? id)
        {
            if(id!=null)
            {
            var result=  await  _repository.QuizCategory.asyncFirstOrDefault(x => x.Id == id.Value);
            if(result!=null)
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
