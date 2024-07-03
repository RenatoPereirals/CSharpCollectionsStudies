namespace LINQ
{
    public abstract class Linq()
    {
        public abstract void ProcessData<T>(IEnumerable<T> data);

        public static void PrintData<T>(IEnumerable<T> data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}