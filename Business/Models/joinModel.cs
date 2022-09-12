using AppCore.Records.Bases;
using DataAccess.Context;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    
   public class joinModel:RecordBase
    {

        public string KullaniciAdi { get; set; }
        public string YapilanYorum { get; set; }

        public int Blogid { get; set; }
        public DateTime Tarih { get; set; }
        public string BlogImage { get; set; }
    }
}
