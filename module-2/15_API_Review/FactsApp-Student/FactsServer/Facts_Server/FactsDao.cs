using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactsServer
{
    public class FactsDao
    {
        private List<ChuckNorrisFact> facts;
        private int nextId;
        public FactsDao()
        {
            facts = new List<ChuckNorrisFact>();
            facts.Add(new ChuckNorrisFact(1, "Chuck's legs are named law and order"));
            facts.Add(new ChuckNorrisFact(3, "Chuck's KEYBOARD HAS 3 KEYS: 0, 1 and Deploy to Production"));
            
            nextId = facts.Count + 1;
        }

        public List<ChuckNorrisFact> GetAllFacts()
        {
            return facts;
        }

        public ChuckNorrisFact AddFact(ChuckNorrisFact fact)
        {
            fact.Id = nextId;
            nextId++;

            facts.Add(fact);

            return fact;
        }
    }
}
