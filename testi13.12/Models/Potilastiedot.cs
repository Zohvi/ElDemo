using System;
using System.Collections.Generic;

namespace testi13._12.Models
{
    public partial class Potilastiedot
    {
        public int Idasiakas { get; set; }
        public string Nimi { get; set; }
        public string Laji { get; set; }
        public string Rotu { get; set; }
        public int? Idomistaja { get; set; }
        public int? Ideläinlääkäri { get; set; }
    }
}
