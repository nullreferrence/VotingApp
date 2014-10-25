using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VotingApp.DAL.Gateway;

namespace VotingApp.BLL
{
    class VotingBll
    {
        private VotingGateway aVotingGateway = new VotingGateway();
        public string SaveCandidateInfo(Candidate aCandidate)
        {
            if (aCandidate.Name == string.Empty || aCandidate.Symbol== string.Empty)
            {
                return "Fil up all Fields";
            }
            else
            {
                if (IsSmbolUnique(aCandidate.Symbol))
                {
                    return "Symbol already Exist";
                }
                    aVotingGateway.SaveCandisate(aCandidate);
                    return "message saved";
            }

        }

        private bool IsSmbolUnique(string symbol)
        {
            return aVotingGateway.HasThisSymbol(symbol);
        }
    }
}
