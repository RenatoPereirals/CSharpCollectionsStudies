using LINQ;

// Exemplo de uso com array
var arrayProcessor = new ArrayProcessor();
string[] dataArray = ["apple", "banana", "cherry"];
Console.WriteLine("Exemplo de LINQ em Array:");
arrayProcessor.ProcessData(dataArray);

// Exemplo de uso com lista
var listProcessor = new ListProcessor();
List<string> dataList = ["dog", "cat", "bird"];
Console.WriteLine("\nExemplo de LINQ em List:");
listProcessor.ProcessData(dataList);