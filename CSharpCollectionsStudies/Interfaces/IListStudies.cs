namespace Class_Studies.Lists
{
    public class IListStudies
    {
        /*A interface IList<T> herda de ICollection<T> e adiciona métodos para acessar 
        elementos por índice e modificar elementos na coleção. */

        public IList<int> Numeros { get; private set; }

        public IListStudies()
        {
            Numeros = new List<int>();
        }

        public void AddElement(int element)
        {
            // Adiciona um elemento à coleção
            Numeros.Add(element);
        }

        public void AddRangeElements(IEnumerable<int> elements)
        {
            // Adiciona os elementos de uma coleção ao final da lista. 
            foreach (var element in elements)
            {
                Numeros.Add(element);
            }
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

        public int IndexOfElement(int element)
        {
            // Obtém o índice de um elemento
            return Numeros.IndexOf(element);
        }

        public void InsertElement(int index, int element)
        {
            // Insere um elemento na coleção em um índice específico
            Numeros.Insert(index, element);
        }

        public void RemoveAtElement(int index)
        {
            // Remove o elemento no índice especificado da coleção
            Numeros.RemoveAt(index);
        }

        public bool RemoveElement(int element)
        {
            // Remove a primeira ocorrência de um elemento da coleção
            return Numeros.Remove(element);
        }

        public int GetElementAt(int index)
        {
            // Obtém ou define o elemento no índice especificado
            return Numeros[index];
        }

        public void SetElementAt(int index, int value)
        {
            // Define o elemento no índice especificado
            Numeros[index] = value;
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