public class Mosgian:Enemy
{
    private string mycolor = "";
    public int key;
    public Mosgian(int atack,int health, int key) : base(atack,health)
    {
        
        this.key = key;
    }
    public override void Setcolor()
    {
        mycolor = "Red";
    }
}