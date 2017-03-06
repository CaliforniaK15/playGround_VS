using static System.Console;

namespace ConsoleApplication3
{
    public abstract class sample
    {
        public abstract void donothing();
    }

    internal class subsample : sample
    {
        public override void donothing()
        {
            WriteLine("I got abstracted");
        }
    }

    internal sealed class myseal
    {
        public int mon { get; set; }
    }

    internal static class mmmm{

    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            subsample sam = new subsample();

            myseal ny = new myseal();
            
            sam.donothing();
            Read();
        }
    }
}