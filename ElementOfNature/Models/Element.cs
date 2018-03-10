using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElementOfNature.Models
{
    public class Element
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        public bool IsPresent { get; set; } //ПРОДАНИЙ ЧИ НІ "НАЯВНІСТЬ"
        public bool IsRealToMake { get; set; } //ЧИ МОЖНА ЗРОБИТИ ТАКИЙ САМИЙ
        public int Price { get; set; }
        public string Description { get; set; }
        public string Review { get; set; } // ВІДГУКИ?
    }
}