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
    public interface IJoinService : IService<joinModel, Yorum,TravelContext>
    {
        IQueryable<joinModel>Qury(int id);
    }
    public class JoinService : IJoinService
    {
        public RepoBase<Yorum, TravelContext> Repo { get; set; } = new Repo<Yorum, TravelContext>();

        public Result Add(joinModel model)
        {

            Yorum entity = new Yorum()
            {
                KullaniciAdi=model.KullaniciAdi,
                 Mail=model.Mail,
                 YapilanYorum=model.YapilanYorum,
                  Blogid=model.Blogid

            };
            Repo.Add(entity);
            return new SuccessResult("Yorum başarıyla eklendi...");

        }

        public Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Repo.Dispose();
        }

        public IQueryable<joinModel> Query()
        {
            return Repo.Query("Blog").Select(j => new joinModel()
            {
                Aciklama = j.Aciklama,
                Blogid = j.Blogid,
                Baslik = j.Baslik,
                KullaniciAdi = j.KullaniciAdi,
                Mail = j.Mail,
                 YapilanYorum=j.YapilanYorum,
              


            });
        }

        public IQueryable<joinModel> Qury(int id)
        {
            return Repo.Query("Blog").Select(j => new joinModel()
            {
                 Aciklama=j.Aciklama,
                  Blogid= j.Blogid,
                   Baslik=j.Baslik,
                   KullaniciAdi=j.KullaniciAdi,
                     Mail=j.Mail
             

           });
        }

        public Result Update(joinModel model)
        {
            throw new NotImplementedException();
        }
    }
}
