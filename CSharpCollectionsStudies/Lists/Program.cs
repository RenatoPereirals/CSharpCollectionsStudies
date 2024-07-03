using Class_Studies.Lists;

Console.WriteLine("Exemplo de List<T>.");
ListStudies program = new();

// Adicionando elementos
program.AddElement(10);
program.AddElement(5);
program.AddElement(8);

// Adicionando uma coleção de elementos
List<int> maisNumeros = [20, 15];
program.AddRangeElements(maisNumeros);

// Imprimindo os elementos
Console.WriteLine("Elementos na lista:");
program.PrintElements();

// Verificando se um elemento está na lista
int elementoProcurado = 5;
bool encontrado = program.ContainsElement(elementoProcurado);
Console.WriteLine($"O elemento {elementoProcurado} está na lista: {encontrado}");

// Removendo um elemento da lista
program.RemoveElement(8);

// Imprimindo os elementos novamente após a remoção
Console.WriteLine("Elementos na lista após remoção:");
program.PrintElements();

// Ordenando os elementos
program.SortElements();

// Imprimindo os elementos ordenados
Console.WriteLine("Elementos na lista ordenados:");
program.PrintElements();
