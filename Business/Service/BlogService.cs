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
    public class BlogService : IBlogService
    {
        public RepoBase<Blog, TravelContext> Repo { get; set; } = new Repo<Blog, TravelContext>();

        public Result Add(BlogModel model)
        {
            if (Repo.Query().Any(blog => blog.Baslik.Trim().ToUpper() == model.Baslik.Trim().ToUpper()))
                return new ErrorResult("Girdiğiniz Blog Adına sahip kayıt bulunmaktadır.");

            Blog entity = new Blog()
            {
                Baslik = model.Baslik.Trim(),
                Aciklama = model.Aciklama.Trim(),
                BlogImage = model.BlogImage ,
                Tarih = model.Tarih

            };
            Repo.Add(entity);
            return new SuccessResult("Blog başarıyla eklendi...");

        }
    
    

        public Result Delete(int id)
        {
            Blog entity = Repo.Query(b => b.Id == id, "Yorumlar").SingleOrDefault();//ilişkili ürünleri çekmiş olduk
            if (entity.Yorumlar != null && entity.Yorumlar.Count > 0)
            {
                return new ErrorResult("Silmek istediğiniz Blog ile ilgili Yorumlar bulunmaktadır. ");
            }
            Repo.Delete(entity);
            return new SuccessResult("Blog Silindi");
        }

        public void Dispose()
        {
            Repo.Dispose();
        }

        public IQueryable<BlogModel> Query()
        {
            return Repo.Query("Yorumlar").Select(b => new BlogModel()
            {
                Aciklama = b.Aciklama,
                Baslik = b.Baslik,
                BlogImage = b.BlogImage,
                Tarih = b.Tarih,
                Id = b.Id,
                Blogid = b.Id,
                Mail =b.Mail,
                   
                   //KullaniciAdi=b.Yorumlar.KullaniciAdi,

            });

        }

        public Result Update(BlogModel model)
        {
            if (Repo.Query().Any(k => k.Baslik.ToUpper() == model.Baslik.ToUpper().Trim() && k.Id != model.Id))
                return new ErrorResult("Girdiğiniz Blog adına sahip kayıt bulunmaktadır!");
            Blog entity = Repo.Query(k => k.Id == model.Id).SingleOrDefault();
            if (entity == null)
                return new ErrorResult("Blog kaydı bulunamadı!");
            entity.Baslik = model.Baslik.Trim();
            entity.Aciklama = model.Aciklama?.Trim();
            entity.Tarih = model.Tarih;
            entity.BlogImage = model.BlogImage;
            Repo.Update(entity);
            return new SuccessResult("Blog başarıyla güncellendi.");
        }
    }
}
