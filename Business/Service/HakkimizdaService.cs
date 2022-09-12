using AppCore.Business.Models.Results;
using AppCore.DataAccess.EntityFramework;
using AppCore.DataAccess.EntityFramework.Bases;
using Business.Models;
using Business.Service.Bases;
using DataAccess.Context;
using DataAccess.Entities;

namespace Business.Service
{
    public class HakkimizdaService : IHakkimizdaService
    {
        public RepoBase<Hakkimizda, TravelContext> Repo { get; set; } = new Repo<Hakkimizda, TravelContext>();

        public Result Add(HakkimizdaModel model)
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

        public IQueryable<HakkimizdaModel> Query()
        {
            IQueryable<HakkimizdaModel> query = Repo.Query().Select(h => new HakkimizdaModel()
            {
                Id = h.Id,
                Aciklama = h.Aciklama,
                FotoUrl = h.FotoUrl,
                 Baslik=h.Baslik,
                  Mail=h.Mail
            });
            return query;
        }

        public Result Update(HakkimizdaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
