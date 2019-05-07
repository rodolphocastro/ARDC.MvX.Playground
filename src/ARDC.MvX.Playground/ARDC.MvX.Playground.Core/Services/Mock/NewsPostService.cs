using ARDC.MvX.Playground.Core.Generators;
using ARDC.MvX.Playground.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ARDC.MvX.Playground.Core.Services.Mock
{
    public class NewsPostService : INewsPostService
    {
        private IList<NewsPost> _noticias;

        public NewsPostService()
        {
            _noticias = NewsGenerator.GenerateNewsPost(20).ToList();
        }

        public NewsPost Get(int id)
        {
            NewsPost noticia;

            try
            {
                noticia = _noticias.Where(n => n.Id == id).SingleOrDefault();
            }
            catch (Exception)
            {
                noticia = _noticias.Where(n => n.Id == id).FirstOrDefault();
            }

            return noticia;
        }

        public IList<NewsPost> GetAll()
        {
            return _noticias;
        }

        public Task<IList<NewsPost>> GetAllAsync(CancellationToken ct)
        {
            return Task.FromResult(_noticias);
        }

        public Task<NewsPost> GetAsync(int id, CancellationToken ct)
        {
            NewsPost noticia;

            try
            {
                noticia = _noticias.Where(n => n.Id == id).SingleOrDefault();
            }
            catch (Exception)
            {
                noticia = _noticias.Where(n => n.Id == id).FirstOrDefault();
            }

            return Task.FromResult(noticia);
        }
    }
}
