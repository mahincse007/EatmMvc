using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eatm.Models
{
    public class TnxCount
    {
        public int Id { get; set; }
        public int NoOfTnx {get; set; }

        public Bankac Bankac { get; set; }
        public int BankacId { get; set; }
    }
}