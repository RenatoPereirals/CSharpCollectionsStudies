namespace LINQ
{
    public class ArrayProcessor : Linq
    {
        public ArrayProcessor() : base() { }

        public override void ProcessData<T>(IEnumerable<T> data)
        {
            // Implementação específica para arrays
            var processedData = data.Select(item => item!.ToString()!.ToUpper()).ToArray();
            PrintData(processedData);
        }
    }
}