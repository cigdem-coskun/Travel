using AppCore.Records.Bases;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class BlogYorumModel:RecordBase
    {
        public string KullaniciAdi { get; set; }
        public string Yorum { get; set; }

        public int Blogid { get; set; }

        public DateTime Tarih { get; set; }
        public string BlogImage { get; set; }

        [DisplayName("Konu")]
        public string Aciklama { get; set; }
        public string Baslik { get; set; }

        //public IEnumerable<Blog> Deger1 { get; set; }
        //public IEnumerable<Yorum> Deger2 { get; set; }
    }
}
