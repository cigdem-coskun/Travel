using AppCore.Business.Services.Bases;
using Business.Models;
using DataAccess.Context;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service.Bases
{

    public interface IHakkimizdaService : IService<HakkimizdaModel, Hakkimizda, TravelContext>
    {
    }

}

