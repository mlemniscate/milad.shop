﻿using milad.Framework.Core.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.Framework.Security
{
    public class HashProvider : IHashProvider
    {
        public string Hash(string password, string saltedValue)
        {
            // TODO: wirte a hash algorithm 
            return password + saltedValue;
        }
    }
}
