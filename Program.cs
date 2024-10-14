using StackExchange.Redis;
namespace FristRedisApp
{
    internal class Program
    {
        public static  String redisServer = "localhost";
        static void Main(string[] args)
        {
            ConnectionMultiplexer conObject =  ConnectionMultiplexer.Connect(redisServer);
            IDatabase db = conObject.GetDatabase();
            db.StringSet("GEnder", "MAle");
            string value = db.StringGet("GEnder");
            Console.WriteLine($"Value for 'Gender': {value}");
        }    
    }
}
