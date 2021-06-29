using SallyServer.Models;
using System.Collections.Generic;

namespace SallyServer.DAO
{
    public interface IQuestionsDao
    {
        Question AddQuestion(Question question);
        List<Question> GetQuestions();
        Question GetQuestion(int id);
        Question UpdateQuestion(Question newQuestion);
        void Delete(int id);
        Question GetRandomQuestion();
    }
}