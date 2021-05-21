using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Review
    //class is in Week2Review so already using
{
    
    /// <summary>
    /// This class is responsible for tracking votes for various candidates.
    /// </summary>
    
    public class VotingMachine
    {
       
        
        public Dictionary<string, int> CandidateVotes { get; set; }

        public VotingMachine()
        {
            this.CandidateVotes = new Dictionary<string, int>();
        }


        /// <summary>
        /// Registers a vote for a specific candidate
        /// </summary>
        /// <param name="candidateName">The name of the candidate to vote for</param>
        /// <returns>Whether or not the vote was accepted</returns>


        public bool RegisterVote(string candidateName)
        {
            Console.WriteLine("Registered vote for " + candidateName);

            candidateName = candidateName.ToLower();

            if (this.CandidateVotes.ContainsKey(candidateName))
                //an additional vote
            {
                this.CandidateVotes[candidateName] += 1;
            }
            else
            //first vote recorded
            {
                this.CandidateVotes[candidateName] =1;
            }
            return true; //We allow vote
        }


        /// <summary>
        /// Calculates the winner of the election and returns their name.
        /// If nobody voted, the winner will be nobody.
        /// </summary>
        public string Winner
        {
            get
            {
                string leadingCandidate = "Nobody";
                int largestNumberOfVotes = 0;
                //loop through dictionary

                foreach(KeyValuePair<string, int> pair in this.CandidateVotes)
                {
                    string candidate = pair.Key;
                    int votes = pair.Value;

                    if (votes > largestNumberOfVotes)
                    {
                        largestNumberOfVotes = votes;
                        leadingCandidate = candidate;
                    }

                }


                return leadingCandidate;
            }
        }
    }
}
