using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire_Client
{
    [Serializable]
    class UserScore
    {
        public string userName { get; set; }
        public string email { get; set; }
        public int score { get; set; }
    }
}
