public class Doremon:Enemy
{
    //private string mycolor = "";
    //private int valueTemp = 3;

    public Doremon(int atack,int health) : base(atack,health)
    {
        
    }
    public override void Setcolor()
    {
        base.Setcolor();
        //Console.WriteLine("Gia tri nay la",valueTemp);
    }
}