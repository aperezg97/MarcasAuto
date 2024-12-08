using MarcasAuto.Application.Interfaces;
using MarcasAuto.Domain.Entities;
using MarcasAuto.Infraestructure.DBContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcasAuto.Application.Services
{
    public class MarcasAutoService : IMarcasAutoService
    {
        private MarcasAutoDBContext _marcasAutoDBContext { get; set; }

        public MarcasAutoService(MarcasAutoDBContext marcasAutoDBContext)
        {
            _marcasAutoDBContext = marcasAutoDBContext;
        }

        public async Task<List<MarcasAutoEntity>> GetAll()
        {
            return await _marcasAutoDBContext.Set<MarcasAutoEntity>().ToListAsync();
        }
    }
}
