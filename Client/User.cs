﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire_Client
{
    [Serializable]
    class User
    {
        public string userName { get; set; }
        public string email { get; set; }
        public string password { get; set; }       
    }
}
