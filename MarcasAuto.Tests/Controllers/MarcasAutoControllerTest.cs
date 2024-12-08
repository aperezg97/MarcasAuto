using MarcasAuto.Application.Services;
using MarcasAuto.Controllers;
using MarcasAuto.Infraestructure.Seeds;
using MarcasAuto.Tests.Base;

namespace MarcasAuto.Tests.Controllers
{
    public class MarcasAutoControllerTest : BaseUnitTest
    {
        [Fact]
        public async Task ShouldReturnItemsAsync()
        {
            // Arrange
            var service = new MarcasAutoService(_dbContext);
            var controller = new MarcasAutoController(service);

            // Act
            var result = await controller.GetAll();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.Count(), MarcasSeed.Items.Length);
        }
    }
}
