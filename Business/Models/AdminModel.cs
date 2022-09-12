using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class AdminModel:RecordBase
    {
        public string Kullanici { get; set; }
        public string Sifre { get; set; }
    }
}
