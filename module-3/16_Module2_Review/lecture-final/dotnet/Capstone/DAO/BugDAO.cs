using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class BugDAO : IBugDAO
    {
        private readonly string connStr;

        private const string sqlGetAll = "SELECT bug_id, title, description, resolution, isOpen, priority FROM bugs";
        private const string sqlGetOne = "SELECT bug_id, title, description, resolution, isOpen, priority FROM bugs WHERE bug_id = @bugId";
        private const string sqlDelete = "DELETE FROM bugs WHERE bug_id = @bugId";

        private const string sqlInsert = "INSERT INTO bugs (title, description, isOpen, priority, resolution) " +
                                         "VALUES(@title, @description, 1, @priority, NULL)";

        private const string sqlUpdate = "UPDATE bugs SET " +
                                            "title = @title, " +
                                            "description = @description, " +
                                            "isOpen = @isOpen, " +
                                            "priority = @priority, " +
                                            "resolution = @resolution " +
                                            "WHERE bug_id = @bugId";

        public BugDAO(string connStr)
        {
            this.connStr = connStr;
        }

        public IEnumerable<Bug> GetAllBugs()
        {
            List<Bug> bugs = new List<Bug>();

            // Connect to the database
            using (SqlConnection conn = new SqlConnection(this.connStr))
            {
                conn.Open();

                // Create our command
                SqlCommand command = new SqlCommand(sqlGetAll, conn);

                // Execute our command and loop over the results
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    bugs.Add(GetBugFromReader(reader));
                }
            }

            return bugs;
        }

        private Bug GetBugFromReader(SqlDataReader reader)
        {
            Bug bug = new Bug
            {
                Title = Convert.ToString(reader["title"]),
                Description = Convert.ToString(reader["description"]),
                Resolution = Convert.ToString(reader["resolution"]),
                IsOpen = Convert.ToBoolean(reader["isOpen"]),
                Priority = Convert.ToInt32(reader["priority"]),
                Id = Convert.ToInt32(reader["bug_id"])
            };

            return bug;
        }

        public void DeleteBug(int id)
        {
            using (SqlConnection conn = new SqlConnection(this.connStr))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(sqlDelete, conn);
                command.Parameters.AddWithValue("@bugId", id);

                command.ExecuteNonQuery();
            }
        }

        public Bug GetBugById(int id)
        {
            Bug bug = null;

            // Connect to the database
            using (SqlConnection conn = new SqlConnection(this.connStr))
            {
                conn.Open();

                // Build a command
                SqlCommand command = new SqlCommand(sqlGetOne, conn);
                command.Parameters.AddWithValue("@bugId", id); // @bugId

                // Execute the command and get the bug from the result
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    bug = GetBugFromReader(reader);
                }
            }

            return bug;
        }

        public Bug UpdateBug(Bug bug)
        {
            using (SqlConnection conn = new SqlConnection(this.connStr))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(sqlUpdate, conn);
                command.Parameters.AddWithValue("@title", bug.Title);
                command.Parameters.AddWithValue("@description", bug.Description);
                command.Parameters.AddWithValue("@priority", bug.Priority);
                command.Parameters.AddWithValue("@isOpen", bug.IsOpen);
                command.Parameters.AddWithValue("@resolution", bug.Resolution);
                command.Parameters.AddWithValue("@bugId", bug.Id);

                command.ExecuteNonQuery();
            }

            Bug updatedBug = GetBugById(bug.Id);
            return updatedBug;
        }

        public Bug InsertBug(Bug bug)
        {
            using (SqlConnection conn = new SqlConnection(this.connStr))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(sqlInsert, conn);
                command.Parameters.AddWithValue("@title", bug.Title);
                command.Parameters.AddWithValue("@description", bug.Description);
                command.Parameters.AddWithValue("@priority", bug.Priority);

                command.ExecuteNonQuery();

                // Get the ID of the newly-created bug
                command = new SqlCommand("SELECT @@IDENTITY", conn);
                int id = Convert.ToInt32(command.ExecuteScalar());

                // Set the ID so we have it for reference
                bug.Id = id;
            }

            return bug;
        }
    }
}
