using AppCore.DataAccess.EntityFramework.Bases;
using DataAccess.Context;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositorie.Bases
{
    public  class HakkimizdaRepoBase:RepoBase<Hakkimizda, TravelContext>
    {
        protected HakkimizdaRepoBase() : base()
        {

        }
        protected HakkimizdaRepoBase(TravelContext travelContext) : base(travelContext)
        {

        }
    }
}
