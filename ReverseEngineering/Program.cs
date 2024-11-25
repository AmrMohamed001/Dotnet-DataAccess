using Microsoft.Data.SqlClient;
using ReverseEngineering.Models;

namespace ReverseEngineering;

class Program
{
    static void Main(string[] args)
    {
        // package manager console
        //    Scaffold-DbContext '[Connection String]' [Provider] [1]-DataAnnotations [2]-Context AppDbContext [3]-ContextDir Data [4]-OutputDir Entities [5]-Schema dbo [6]-Tables Speakers

        // dotnet cli
        // dotnet ef dbContext scaffold '[Connection String]' [Provider] --data-annotations --context AppDbContext --context-dir Data --output-dir Entities --schema dbo --table Speakers

        /*
         * [1] to generate the context and the entities using data annotations not fluent api
         * [2] to change the name of context
         * [3] to specify the dir of the context
         * [4] to specify the dir of entities
         * [5] to generate the entities of specific schema
         * [6] to generate only these tables
         */

        var context = new TechTalkContext();
        try
        {
            var speakers = context.Speakers.ToList();
            foreach (var item in speakers)
            {
                Console.WriteLine(item.FirstName);
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}