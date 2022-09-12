using AppCore.Business.Models.Results;
using AppCore.DataAccess.EntityFramework;
using AppCore.DataAccess.EntityFramework.Bases;
using Business.Models;
using Business.Service.Bases;
using DataAccess.Context;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class BlogYorumModelService : IBlogYorumModelService
    {
        public RepoBase<Yorum, TravelContext> Repo { get; set; } =new  Repo<Yorum, TravelContext>();

        public Result Add(BlogYorumModel model)
        {
            throw new NotImplementedException();
        }

        public Result Delete(int id)
        {
            Yorum entity = Repo.Query(b => b.Id == id).SingleOrDefault();
        
            Repo.Delete(entity);
            return new SuccessResult("Yorum Silindi");
        }

        public void Dispose()
        {
            Repo.Dispose();
        }

        public IQueryable<BlogYorumModel> Query()
        {
            IQueryable<BlogYorumModel> query = Repo.Query().Select(b => new BlogYorumModel()
            {
                KullaniciAdi = b.KullaniciAdi,
                Yorum=b.YapilanYorum,
                Blogid = b.Blogid,
                 Aciklama=b.Aciklama,
                   Baslik=b.Baslik,
                    Mail=b.Mail,
                     Id=b.Id
                    
                    

            });
            return query;
        }

        public Result Update(BlogYorumModel model)
        {

            throw new NotImplementedException();

        }
    }
}
