using EntityTypes_and_Mapping.Data;

namespace DataTypes_and_Mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var context = new AppDbContext();
            foreach (var item in context.OrderWithDetailsView)
            {
                Console.WriteLine(item);
            }
        }
    }
}
