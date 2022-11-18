using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace otopark_son.Models
{
    public class OtoparklarBaglanti
    {
        public int otoparkId { get; set; }
        public int aracId { get; set; }

        public List<SelectListItem> otoparkList { get; set; }
        public List<SelectListItem> aracList { get; set; }
    }
}