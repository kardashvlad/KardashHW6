﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KardashHW6
{
    internal class Book
    {
        //[JsonIgnore]
        public int PublishingHouseId { get; set; }
        //[JsonPropertyName("Name")]
        public string Title { get; set; }
        public PublishingHouse PublishingHouse { get; set; }
    }
}
