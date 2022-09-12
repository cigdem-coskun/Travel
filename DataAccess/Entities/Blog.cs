using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccess.Entities
{
    public class Blog : RecordBase
    {
       
        public DateTime Tarih { get; set; }
        public string BlogImage { get; set; }
        public List<Yorum> Yorumlar {get; set; }
    }
}
