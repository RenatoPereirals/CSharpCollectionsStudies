namespace LINQ
{
    public class ListProcessor() : Linq()
    {
        public override void ProcessData<T>(IEnumerable<T> data)
        {
            var processedData = data.Where(item => item != null).ToList();
            PrintData(processedData);
        }
    }
}