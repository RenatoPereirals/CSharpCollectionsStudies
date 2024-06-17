namespace Class_Studies.Lists
{
    public class ListStudies
    {
        /*A classe List<T> é uma implementação concreta de uma lista genérica no .NET. 
        Ela fornece métodos para adicionar, remover, buscar e manipular elementos em uma lista dinâmica.*/

        public List<int> Numeros = [];

        public void AddElement(int element)
        {
            // Adiciona um objeto ao final da lista.
            Numeros.Add(element);
        }

        public void AddRangeElements(IEnumerable<int> elements)
        {
            // Adiciona os elementos de uma coleção ao final da lista.
            Numeros.AddRange(elements);
        }

        public void ClearElements()
        {
            // Remove todos os elementos da lista.
            Numeros.Clear();
        }

        public bool ContainsElement(int element)
        {
            // Verifica se um elemento está na lista.
            return Numeros.Contains(element);
        }

        public int IndexOfElement(int element)
        {
            // Retorna o índice da primeira ocorrência de um elemento na lista.
            return Numeros.IndexOf(element);
        }

        public void InsertElement(int index, int element)
        {
            // Insere um elemento na lista em um índice específico.
            Numeros.Insert(index, element);
        }

        public bool RemoveElement(int element)
        {
            // Remove a primeira ocorrência de um elemento da lista.
            return Numeros.Remove(element);
        }

        public void RemoveAtElement(int index)
        {
            // Remove o elemento no índice especificado da lista.
            Numeros.RemoveAt(index);
        }


        public int FindElement(int number)
        {
            // Obtém o primeiro elemento que corresponde à condição especificada
            return Numeros.Find(elem => elem == number);
        }

        // Inverte a ordem dos elementos na lista.
        public void ReverseElements()
        {
            Numeros.Reverse();
        }

        // Classifica os elementos na lista usando o comparador padrão.
        public void SortElements()
        {
            Numeros.Sort();
        }


        // Executa uma ação em cada elemento da lista.
        public void PrintElements()
        {
            Numeros.ForEach(numero => Console.WriteLine(numero));
        }
    }
}