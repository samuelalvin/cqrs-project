﻿using MyApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Interfaces
{
    public interface IClientAppService : IDisposable
    {
        void Register(ClientViewModel customerViewModel);
        Task<IEnumerable<ClientViewModel>> GetAll();
        Task<ClientViewModel> GetById(Guid id);
        void Update(ClientViewModel customerViewModel);
        void Remove(Guid id);
    }
}
