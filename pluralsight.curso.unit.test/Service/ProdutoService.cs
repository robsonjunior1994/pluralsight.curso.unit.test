using pluralsight.curso.unit.test.Repository;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject")]

namespace pluralsight.curso.unit.test.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public string GetById(int id)
        {
            string produto = _produtoRepository.GetById(id);

            if (string.IsNullOrWhiteSpace(produto)) 
            {
                return "produto não foi encontrado";
            }

            return produto;
        }

        internal string GetInternal(string name) 
        {
            return "internalProduto";
        }
    }
}
