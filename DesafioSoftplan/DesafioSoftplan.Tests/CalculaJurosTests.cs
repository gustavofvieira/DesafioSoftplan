using DesafioSoftplan.Domain.ViewModels;
using Xunit;

namespace DesafioSoftplan.Tests
{
    public class CalculaJurosTests
    {
        [Fact]
        public void SetaParametros_RelizaCalculo_RetornaCalculoVM()
        {
            //Arrange
            var calculoVM = new CalculaJurosVM()
            {
                ValorInical = 100,
                Meses = 5
            };

            //Act
            var jurosTotal = calculoVM.CalculaJuros(calculoVM);

            //Assert
            Assert.NotNull(jurosTotal);
            Assert.IsType<double>(jurosTotal);
            Assert.Equal(105.1, jurosTotal);
        }
    }
}
