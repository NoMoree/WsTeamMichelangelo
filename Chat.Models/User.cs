﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string SessionKey { get; set; }

        public string ImageUrl { get; set; }

        //public virtual List<User> Friends { get; set; }
    }
}
