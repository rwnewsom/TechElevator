using SallyServer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SallyServer.DAO
{
    public class QuestionsSqlDao : IQuestionsDao
    {
        private readonly string connectionString;

        public QuestionsSqlDao(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Question> GetQuestions()
        {
            List<Question> result = new List<Question>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT question_id, user_id, question, answer FROM questions", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(GetQuestionFromReader(reader));
                }
            }

            return result;
        }


        public Question GetQuestion(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT TOP 1 question_id, user_id, question, answer FROM questions WHERE question_id = @questionId", conn);
                cmd.Parameters.AddWithValue("@questionId", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return GetQuestionFromReader(reader);
                }
            }

            return null;
        }

        public Question AddQuestion(Question question)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO questions (user_id, question, answer) VALUES (@userId, @question, @answer); SELECT @@IDENTITY;", conn);
                cmd.Parameters.AddWithValue("@userId", question.UserId);
                cmd.Parameters.AddWithValue("@question", question.Text);
                cmd.Parameters.AddWithValue("@answer", question.Answer);

                question.Id = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return question;
        }

        private Question GetQuestionFromReader(SqlDataReader reader)
        {
            return new Question()
            {
                Id = Convert.ToInt32(reader["question_id"]),
                UserId = Convert.ToInt32(reader["user_id"]),
                Text = Convert.ToString(reader["question"]),
                Answer = Convert.ToString(reader["answer"]),
            };
        }

        public Question UpdateQuestion(Question newQuestion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE questions SET question = @question, answer = @answer WHERE question_id = @questionId", conn);
                cmd.Parameters.AddWithValue("@questionId", newQuestion.Id);
                cmd.Parameters.AddWithValue("@question", newQuestion.Text);
                cmd.Parameters.AddWithValue("@answer", newQuestion.Answer);
                cmd.ExecuteNonQuery();
            }

            return GetQuestion(newQuestion.Id);
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM questions WHERE question_id = @questionId", conn);
                cmd.Parameters.AddWithValue("@questionId", id);

                cmd.ExecuteNonQuery();
            }
        }

        private readonly Random randomizer = new Random();

        public Question GetRandomQuestion()
        {
            List<Question> questions = this.GetQuestions();

            if (questions.Count <= 0)
            {
                return null;
            }

            int index = this.randomizer.Next(questions.Count);
            Question question = questions[index];

            return question;
        }
    }
}
