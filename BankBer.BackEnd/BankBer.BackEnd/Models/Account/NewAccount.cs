﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankBer.BackEnd.Models.Account
{
    public class NewAccount
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}