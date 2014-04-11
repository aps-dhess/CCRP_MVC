﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCRP.Models
{
    public class Coach
    {
        public int ID { get; set; }
        public string NameFull { get; set; }
        public string JobTitle { get; set; }
        public string EmailAddress { get; set; }
        public string ProfileImgUrl { get; set; }
        public int Subject_ID { get; set; }
    }
}