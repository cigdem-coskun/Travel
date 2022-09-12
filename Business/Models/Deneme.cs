using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Deneme
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorum> Deger2 { get; set; }
    }
}
