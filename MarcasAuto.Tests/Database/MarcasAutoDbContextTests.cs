using MarcasAuto.Infraestructure.Seeds;
using MarcasAuto.Tests.Base;

namespace MarcasAuto.Tests.Database
{
    public class MarcasAutoDbContextTests : BaseUnitTest
    {
        [Fact]
        public void TestDatabaseIsSavingAndRetrievingData()
        {
            // Arrange
            string expectedUserId = MarcasSeed.Items[0].Id;
            string expectedUserName = MarcasSeed.Items[0].Make;

            // Act: Perform the action to be tested
            var actualUser = _dbContext.MarcasAuto.FirstOrDefault(e => e.Id == expectedUserId);

            // Assert: Verify the result
            Assert.NotNull(actualUser);
            Assert.Equal(expectedUserName, actualUser.Make);
        }
    }
}
