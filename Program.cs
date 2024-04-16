internal class Program
{
    private static void Main(string[] args)
    {
        Mosgian myMosgian = new Mosgian(1,2,5);
        
        Doremon dom = new Doremon(2,3);
        if (dom is Enemy)
        {
            Console.WriteLine("Gia tri la{0}",dom.atack);
            Console.WriteLine("Gia tri la{0}",dom.health);
            dom.Setcolor();
        }
    }
}