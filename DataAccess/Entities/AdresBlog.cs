using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class AdresBlog:RecordBase
    {
        public string AdresAcik { get; set; }
        public string Telefon { get; set; }
        public string Konum { get; set; }
    }
}
