Console.WriteLine("Exemplo de IList<T>.");

IListStudies colecaoEstudos2 = new();

// Adicionando elementos
colecaoEstudos2.AddElement(1);
colecaoEstudos2.AddElement(2);
colecaoEstudos2.AddElement(3);

// Adicionando uma coleção de elementos
colecaoEstudos2.AddRangeElements(new List<int> { 4, 5, 6 });

// Verificando a presença de um elemento
int elementoProcurado3 = 3;
Console.WriteLine($"Contém o elemento {elementoProcurado3}: {colecaoEstudos2.ContainsElement(elementoProcurado3)}");

// Obtendo e definindo elementos por índice
int index = 2;
Console.WriteLine($"Elemento no índice {index}: {colecaoEstudos2.GetElementAt(index)}");
colecaoEstudos2.SetElementAt(index, 10);
Console.WriteLine($"Novo valor no índice {index}: {colecaoEstudos2.GetElementAt(index)}");

// Removendo um elemento por valor
colecaoEstudos2.RemoveElement(4);

// Removendo um elemento por índice
colecaoEstudos2.RemoveAtElement(0);

// Imprimindo os elementos
Console.WriteLine("Elementos na coleção:");
colecaoEstudos2.PrintElements();