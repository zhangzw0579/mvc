﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcTest.Models
{
    public class Auction
    {

        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public decimal StartPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }


    }
}