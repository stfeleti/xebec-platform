using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XebecPortal.Client.GamifiedEnvBeta.Utils
{
    public class State
    {
        public int Id { get; set; }

        public string UserEmail { get; set; }

        public string Role { get; set; }

        public int PageNumber { get; set; } = 1;


    }
}