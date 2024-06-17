Console.WriteLine("Exemplo de ICollection<T>.");

ICollectionStudies colecaoEstudos = new();

// Adicionando elementos
colecaoEstudos.AddElement(1);
colecaoEstudos.AddElement(2);
colecaoEstudos.AddElement(3);

// Verificando a presença de um elemento
int elementoProcurado1 = 2;
Console.WriteLine($"Contém o elemento {elementoProcurado1}: {colecaoEstudos.ContainsElement(elementoProcurado1)}");

// Removendo um elemento
colecaoEstudos.RemoveElement(2);

// Imprimindo os elementos
Console.WriteLine("Elementos na coleção:");
colecaoEstudos.PrintElements();

// Copiando elementos para um array
int[] array = new int[colecaoEstudos.Numeros.Count];
colecaoEstudos.CopyToElements(array, 0);

Console.WriteLine("Elementos no array:");
foreach (var item in array)
{
    Console.WriteLine(item);
}