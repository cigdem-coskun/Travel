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
    public interface IHomeService : IService<BlogModel, Blog, TravelContext>
    {
        IQueryable<BlogModel> Query(int id);
    }
    public class HomeService : IHomeService
    {
        public RepoBase<Blog, TravelContext> Repo { get; set; } = new Repo<Blog, TravelContext>();

        public Result Add(BlogModel model)
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

        public IQueryable<BlogModel> Query(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<BlogModel> Query()
        {
            return Repo.Query().Select(j => new BlogModel()
            {
               
                 BlogImage=j.BlogImage,
                  Baslik=j.Baslik,
                   Aciklama=j.Aciklama,
                   Tarih=j.Tarih,
                    Blogid=j.Id

            });
        }

        public Result Update(BlogModel model)
        {
            throw new NotImplementedException();
        }
    }
}
