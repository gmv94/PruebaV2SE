﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaV2SE.Entities
{
    public class BookEntities
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int pageCount { get; set; }
        public string excerpt { get; set; }
        public string publishDate { get; set; }
    }
}