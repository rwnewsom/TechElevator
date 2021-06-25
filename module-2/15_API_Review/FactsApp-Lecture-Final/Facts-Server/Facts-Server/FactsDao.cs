using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facts_Server
{
    public class FactsDao
    {
        private List<ChuckNorrisFact> facts;
        private int nextId;

        public FactsDao()
        {
            facts = new List<ChuckNorrisFact>();

            facts.Add(new ChuckNorrisFact(nextId++, "Chuck's legs are named law and order"));
            facts.Add(new ChuckNorrisFact(nextId++, "Chuck's keyboard has 3 keys: 0, 1, and Deploy to Production"));
            facts.Add(new ChuckNorrisFact(nextId++, "Chuck Norris’s keyboard doesn’t have a Ctrl key because nothing controls Chuck Norris."));
            facts.Add(new ChuckNorrisFact(nextId++, "COVID-19 is in quarantine after exposure to Chuck Norris"));
            facts.Add(new ChuckNorrisFact(nextId++, "Chuck Norris does not use a debugger since his code is perfect. However, if he ever made a mistake (he won't), he'd simply stare the bugs into submission."));
            facts.Add(new ChuckNorrisFact(nextId++, "Chuck Norris can read regular expressions"));
            facts.Add(new ChuckNorrisFact(nextId++, "Microsoft DID ask Chuck Norris"));
            facts.Add(new ChuckNorrisFact(nextId++, "Chuck Norris is what makes Polymorphism possible"));
            facts.Add(new ChuckNorrisFact(nextId++, "When Chuck Norris throws exceptions, it’s across the room."));
            facts.Add(new ChuckNorrisFact(nextId++, "All arrays Chuck Norris declares are of infinite size, because Chuck Norris knows no bounds."));
            facts.Add(new ChuckNorrisFact(nextId++, "Chuck Norris writes code that optimizes itself."));
            facts.Add(new ChuckNorrisFact(nextId++, "Chuck Norris doesn’t need garbage collection because he doesn’t call .Dispose(), he calls .DropKick()."));
            facts.Add(new ChuckNorrisFact(nextId++, "The only pattern Chuck Norris knows is God Object."));
            facts.Add(new ChuckNorrisFact(nextId++, "Project managers never ask Chuck Norris for estimation... ever."));
            facts.Add(new ChuckNorrisFact(nextId++, "Chuck Norris doesn’t use web standards as the web will conform to him."));
            facts.Add(new ChuckNorrisFact(nextId++, "Chuck Norris can unit test entire applications with a single assert."));
            facts.Add(new ChuckNorrisFact(nextId++, "Chuck Norris CAN divide by 0."));
            facts.Add(new ChuckNorrisFact(nextId++, "Chuck Norris can overflow your stack just by looking at it."));
            facts.Add(new ChuckNorrisFact(nextId++, "To Chuck Norris, everything contains a vulnerability."));
            facts.Add(new ChuckNorrisFact(nextId++, "Chuck Norris can access private methods."));
            facts.Add(new ChuckNorrisFact(nextId++, "Chuck Norris can instantiate abstract classes and interfaces."));
            facts.Add(new ChuckNorrisFact(nextId++, "Chuck Norris can inherit from sealed classes."));
            facts.Add(new ChuckNorrisFact(nextId++, "All baristas know Java in fear that one day Chuck Norris walks in and demands it."));
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
