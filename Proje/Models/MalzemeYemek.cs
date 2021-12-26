﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class MalzemeYemek
    {
        public int Id { get; set; }
        public Malzeme Malzeme { get; set; }
        public string MalzemeMiktari { get; set; }
        public int YemekId { get; set; }
        public Yemek Yemek { get; set; }
        public int MalzemeId { get; set; }


    }
}
