using Moq;
using pluralsight.curso.unit.test.Repository;
using pluralsight.curso.unit.test.Service;

namespace TestProject
{
    public class ProdutoServiceTests
    {
        [Fact]
        public void Test1()
        {
            var mockRepository = new Mock<IProdutoRepository>();
            var produtoService = new ProdutoService(mockRepository.Object);

            var retorno = produtoService.GetInternal("1");
        }
    }
}