using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositorie.Bases
{
    public  class HakkimizdaRepo:HakkimizdaRepoBase
    {
        protected HakkimizdaRepo() : base()
        {

        }
        public HakkimizdaRepo(TravelContext travelContext) : base(travelContext)
        {

        }
    }
}
