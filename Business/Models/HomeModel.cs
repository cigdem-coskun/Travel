using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class HomeModel:RecordBase
    {
        public DateTime Tarih { get; set; }
        public string BlogImage { get; set; }
        public string FotoUrl { get; set; }
        public string KullaniciAdi { get; set; }
        public string YapilanYorum { get; set; }

        public int Blogid { get; set; }
    }
}
