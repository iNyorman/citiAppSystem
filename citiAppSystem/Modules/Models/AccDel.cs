using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Models
{
    public class AccDel
    {
        public int Id { get; set; }
        public DateTime DelDateTime { get; set; }
        public string DelBy { get; set; }
        public string UserId { get; set; }
        public string AccountNo { get; set; }
    }
}
