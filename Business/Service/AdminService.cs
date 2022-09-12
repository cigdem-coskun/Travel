using AppCore.Business.Models.Results;
using AppCore.Business.Services.Bases;
using AppCore.DataAccess.EntityFramework;
using AppCore.DataAccess.EntityFramework.Bases;
using Business.Models;
using DataAccess.Context;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public interface IAdminService :IService<AdminModel, Admin, TravelContext>
    {
       
    }
    public class AdminService : IAdminService
    {
        public RepoBase<Admin, TravelContext> Repo { get ; set; }=new  Repo<Admin, TravelContext>();

        public Result Add(AdminModel model)
        {
            throw new NotImplementedException();
        }

        public Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Repo.Dispose();
        }

        public IQueryable<AdminModel> Query()
        {
            return Repo.Query().Select(k => new AdminModel()
            {
                 Kullanici=k.Kullanici,
                 Sifre=k.Sifre
            });
        }

        public Result Update(AdminModel model)
        {
            throw new NotImplementedException();
        }
    }
}
