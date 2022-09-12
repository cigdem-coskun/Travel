using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class iletisim:RecordBase
    {
        public string AdSoyad { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
    }
}
