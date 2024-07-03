using Class_Studies.Lists;

Console.WriteLine("Exemplo de IEnumerable<T>.");

IEnumerableStudies colecaoEstudos1 = new();

// Adicionando elementos
colecaoEstudos1.AddElements(new List<int> { 1, 2, 3, 4, 5 });

// Verificando a presença de um elemento
int elementoProcurado2 = 3;
Console.WriteLine($"Contém o elemento {elementoProcurado2}: {colecaoEstudos1.ContainsElement(elementoProcurado2)}");

// Encontrando um elemento específico
int? elementoEncontrado = colecaoEstudos1.FindElement(x => x == 4);
Console.WriteLine($"Elemento encontrado: {elementoEncontrado}");

// Imprimindo os elementos
Console.WriteLine("Elementos na coleção:");
colecaoEstudos1.PrintElements();