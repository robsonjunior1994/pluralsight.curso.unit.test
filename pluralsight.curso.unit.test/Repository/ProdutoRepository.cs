namespace pluralsight.curso.unit.test.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        public string GetById(int id)
        {
            return "produto 01";
        }
    }
}
