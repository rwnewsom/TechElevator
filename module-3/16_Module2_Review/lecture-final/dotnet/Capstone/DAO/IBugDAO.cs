using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.DAO
{
    public interface IBugDAO
    {
        IEnumerable<Bug> GetAllBugs();

        Bug GetBugById(int id);

        void DeleteBug(int id);

        Bug InsertBug(Bug bug);

        Bug UpdateBug(Bug bug);
    }
}