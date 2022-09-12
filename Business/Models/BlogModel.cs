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
    public class BlogModel:RecordBase
    {
        public DateTime Tarih { get; set; }
        [DisplayName("Resim")]
        public string BlogImage { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }

        //public string Yorum { get; set; }
        public int Blogid { get; set; }
        //public Yorum Yorumlar { get; set; }

    }
}
