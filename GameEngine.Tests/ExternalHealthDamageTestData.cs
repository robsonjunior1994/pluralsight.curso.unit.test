namespace GameEngine.Tests
{
    public class ExternalHealthDamageTestData
    {
        public static IEnumerable<object[]> TestData 
        {
            get 
            {
                //Esse código comentário busca a pasta saindo 3 vezes para a pasta anterior
                //string[] csvLines = File.ReadAllLines("../../../TestData.csv");

                //Já esse código funciona pois modificamos as configurações do arquivo csv para que ele
                //Sempre seja copiado para o diretório de saída 
                //btn direito em cima, propriedades, copiar para diretorio de saída sempre.
                string[] csvLines = File.ReadAllLines("TestData.csv");


                var testCases = new List<object[]>();

                foreach (var csvLine in csvLines)
                {
                    IEnumerable<int> values = csvLine.Split(',').Select(int.Parse);

                    object[] testCase = values.Cast<object>().ToArray();

                    testCases.Add(testCase);
                }
                return testCases;
            }
        }
    }
}
