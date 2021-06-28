using System.Collections.Generic;

namespace Facts_Server
{
    public interface IFactsDao
    {
        ChuckNorrisFact AddFact(ChuckNorrisFact fact);
        bool DeleteFact(int id);
        List<ChuckNorrisFact> GetAllFacts();
        ChuckNorrisFact GetFactById(int id);
        bool UpdateFact(ChuckNorrisFact fact);
    }
}