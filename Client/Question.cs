using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire_Client
{
    [Serializable]
    class Question
    {
        public string question { get; set; }
        public string correctAnswer { get; set; }
        public List<string> answers { get; set; }
    }
}
