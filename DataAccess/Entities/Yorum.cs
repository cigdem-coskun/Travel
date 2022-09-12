using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Yorum:RecordBase
    {
       

        public string KullaniciAdi { get; set; }
        public string YapilanYorum { get; set; }
        
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
