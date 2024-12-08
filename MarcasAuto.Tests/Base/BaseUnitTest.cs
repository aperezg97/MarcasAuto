using MarcasAuto.Domain.Entities;
using MarcasAuto.Infraestructure.DBContexts;
using MarcasAuto.Infraestructure.Seeds;
using Microsoft.EntityFrameworkCore;

namespace MarcasAuto.Tests.Base
{
    public class BaseUnitTest
    {
        protected readonly MarcasAutoDBContext _dbContext;

        public BaseUnitTest()
        {
            var options = new DbContextOptionsBuilder<MarcasAutoDBContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

            _dbContext = new MarcasAutoDBContext(options);

            ConfiguraDatabase();
        }

        private void ConfiguraDatabase()
        {
            // not possible to run this on in-memory databases
            //var pendingMigrations = await context.Database.GetPendingMigrationsAsync();
            //if (pendingMigrations.Any())
            //{
            //    await context.Database.MigrateAsync();
            //}

            // running seed manually
            _dbContext.MarcasAuto.AddRange(MarcasSeed.Items);
            _dbContext.SaveChanges();
        }
    }
}