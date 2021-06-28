using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SallyServer.DAO;
using SallyServer.Models;

namespace SallyServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionsDao questionsDao;

        public QuestionsController(IQuestionsDao questionsDao)
        {
            this.questionsDao = questionsDao;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult<List<Question>> GetAllQuestions()
        {
            return Ok(this.questionsDao.GetQuestions());
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public ActionResult<Question> GetQuestion(int id)
        {
            Question question = this.questionsDao.GetQuestion(id);

            if (question == null)
            {
                return NotFound();
            }

            return Ok(question);
        }

        [HttpPut("{id}")]
        public ActionResult<List<Question>> UpdateQuestion(int id, Question updatedQuestion)
        {
            Question question = this.questionsDao.GetQuestion(id);

            if (question == null)
            {
                return NotFound();
            }

            return Ok(this.questionsDao.UpdateQuestion(updatedQuestion));
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteQuestion(int id)
        {
            Question question = this.questionsDao.GetQuestion(id);

            if (question == null)
            {
                return NotFound();
            }

            this.questionsDao.Delete(id);

            return NoContent();
        }

        [HttpGet("random")]
        [AllowAnonymous]
        public ActionResult<Question> GetRandomQuestion()
        {
            Question question = this.questionsDao.GetRandomQuestion();
            if (question == null)
            {
                return NoContent();
            }

            return Ok(question);
        }

        [HttpPost]
        public ActionResult<Question> AddQuestion(Question question)
        {
            Question newQuestion = this.questionsDao.AddQuestion(question);

            return Created($"/questions/{newQuestion.Id}", newQuestion);
        }

        [HttpPost("search")]
        [AllowAnonymous]
        public ActionResult Search(QuestionSearch search)
        {
            return StatusCode((int)HttpStatusCode.NotImplemented);
        }
    }

    public class QuestionSearch
    {
        public string TitleLike { get; set; }
        public DateTime CreatedAfter { get; set; }
        public DateTime CreatedBefore { get; set; }
        public int CreatedByUserId { get; set; }
    }
}
