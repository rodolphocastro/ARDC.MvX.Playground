using ARDC.MvX.Playground.Core.Generators;
using ARDC.MvX.Playground.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ARDC.MvX.Playground.Core.Services.Mock
{
    public class ServiceItemService : IServiceItemService
    {
        private IList<ServiceItem> _servicos;

        public ServiceItemService()
        {
            _servicos = ServiceItemGenerator.GenerateServiceItem(10);
        }
        public void Add(ServiceItem serviceItem)
        {
            if (serviceItem == null)
                serviceItem = ServiceItemGenerator.GenerateServiceItem();

            _servicos.Add(serviceItem);
        }

        public Task AddAsync(ServiceItem serviceItem, CancellationToken ct)
        {
            if (serviceItem == null)
                serviceItem = ServiceItemGenerator.GenerateServiceItem();

            _servicos.Add(serviceItem);
            return Task.CompletedTask;
        }

        public void Edit(ServiceItem serviceItem)
        {
            return;
        }

        public Task EditAsync(ServiceItem serviceItem, CancellationToken ct)
        {
            return Task.CompletedTask;
        }

        public ServiceItem Get(int id)
        {
            ServiceItem servico;

            try
            {
                servico = _servicos.Where(s => s.Id == id).SingleOrDefault();
            }
            catch (Exception)
            {
                servico = _servicos.Where(s => s.Id == id).First();
            }

            return servico;
        }

        public IList<ServiceItem> GetAll()
        {
            return _servicos;
        }

        public Task<IList<ServiceItem>> GetAllAsync(CancellationToken ct)
        {
            return Task.FromResult(_servicos);
        }

        public Task<ServiceItem> GetAsync(int id, CancellationToken ct)
        {
            ServiceItem servico;

            try
            {
                servico = _servicos.Where(s => s.Id == id).SingleOrDefault();
            }
            catch (Exception)
            {
                servico = _servicos.Where(s => s.Id == id).First();
            }

            return Task.FromResult(servico);
        }

        public void Remove(int id)
        {
            _servicos.Remove(_servicos.Where(s => s.Id == id).Single());
        }

        public void RemoveAsync(int id, CancellationToken ct)
        {
            _servicos.Remove(_servicos.Where(s => s.Id == id).Single());
        }
    }
}
