public class Enemy
{
    private string mycolor = "";
    protected int atack = 0;
    protected int health = 100;
    public Enemy(int atack, int health)
    {
        this.atack = atack;
        this.health = health;
    }
    public virtual void Setcolor()
    {
        mycolor = "Yelow";
        
    }

}