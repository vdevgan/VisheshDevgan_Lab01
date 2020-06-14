using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisheshDevgan_Lab01.Models
{
    public static class Repository
    {
        private static List<ParticipantsResponse> responses = new List<ParticipantsResponse>();

        public static IEnumerable<ParticipantsResponse> Responses
        {
            get 
            { 
                return responses;
            }
        }
        
        public static void AddResponse(ParticipantsResponse response)
        {
            responses.Add(response);        
        }
     }
}
