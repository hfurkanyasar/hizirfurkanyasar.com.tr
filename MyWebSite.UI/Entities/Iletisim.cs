using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.UI.Entities
{
    public class Iletisim
    {
        [Key]
        public int IletisimID { get; set; }
        
        public string Ad { get; set; }
       
        public string Mail { get; set; }

        public string Konu { get; set; }
        
        public string Mesaj { get; set; }
    }
}
