using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaKontrol
{
    internal class Fatura
    {
        public int Id {  get; set; }
        public string FaturaNo { get; set; }
        public decimal Tutar { get; set; }  
        public string Tip { get; set; }
    }
}
