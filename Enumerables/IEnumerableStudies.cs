namespace Class_Studies.Lists
{
    public class IEnumerableStudies
    {
        /*A interface IEnumerable<T> permite a iteração sobre uma coleção de objetos. 
        Ela não possui métodos para modificação da coleção; apenas permite a leitura sequencial dos elementos.*/

        public IEnumerable<int> Numeros { get; private set; }

        public IEnumerableStudies()
        {
            Numeros = new List<int>();
        }

        public void AddElements(IEnumerable<int> elements)
        {
            // Adiciona elementos à coleção
            Numeros = Numeros.Concat(elements);
        }

        public bool ContainsElement(int element)
        {
            // Verifica se um elemento está na coleção
            return Numeros.Contains(element);
        }

        public int? FindElement(Func<int, bool> predicate)
        {
            // Obtém o primeiro elemento que corresponde à condição especificada
            return Numeros.FirstOrDefault(predicate);
        }

        public void PrintElements()
        {
            // Imprime os elementos da coleção
            foreach (var numero in Numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}