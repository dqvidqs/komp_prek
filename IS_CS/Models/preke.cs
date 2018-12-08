using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IS_CS.Models
{
    [Table("Preke")]
    public class preke
    {
        public int bar { get; set; }
        public string model { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int type_id { get; set; }
        public int worker_id { get; set; }
    }
}