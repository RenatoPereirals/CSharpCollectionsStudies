namespace Class_Studies.Lists
{
    public class ICollectionStudies
    {
        /*A interface ICollection<T> herda de IEnumerable<T> e adiciona métodos para 
        modificar a coleção, como adicionar, remover e verificar a presença de elementos.*/

        public ICollection<int> Numeros { get; private set; }

        public ICollectionStudies()
        {
            Numeros = new List<int>();
        }

        public void AddElement(int element)
        {
            // Adiciona um elemento à coleção
            Numeros.Add(element);
        }

        public void ClearElements()
        {
            // Remove todos os elementos da coleção
            Numeros.Clear();
        }

        public bool ContainsElement(int element)
        {
            // Verifica se um elemento está na coleção
            return Numeros.Contains(element);
        }

        public void CopyToElements(int[] array, int arrayIndex)
        {
            // Copia os elementos da coleção para um array, começando em um índice específico do array
            Numeros.CopyTo(array, arrayIndex);
        }

        public bool RemoveElement(int element)
        {
            // Remove a primeira ocorrência de um elemento da coleção
            return Numeros.Remove(element);
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