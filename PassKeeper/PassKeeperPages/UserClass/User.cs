﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeeperPages.UserClass
{
   public  class User
    {
        public string ?UserName { get; set; }
        public string ?Password { get; set; }
        public string ?LastName { get; set; }
        public string ?Mail { get; set; }
        public string ?Image { get; set; }
        public List<Account>? Accounts { get; set; } = new();
        public User()
        {
            Accounts = new List<Account>();
        }
    }
}
