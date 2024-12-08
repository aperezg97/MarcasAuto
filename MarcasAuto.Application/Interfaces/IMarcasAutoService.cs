using MarcasAuto.Domain.Entities;

namespace MarcasAuto.Application.Interfaces
{
    public interface IMarcasAutoService
    {
        public Task<List<MarcasAutoEntity>> GetAll();
    }
}
