using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pustokclass.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Desc { get; set; }
        public string RedirectUrl { get; set; }
        public string RedirectUrlText { get; set; }
        public string Image { get; set; }
        public int Order { get; set; }
    }
}
