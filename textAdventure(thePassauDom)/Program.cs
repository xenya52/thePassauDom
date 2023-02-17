class Program
{
    public static void Main(string[] args)
    {
        //Objekte
        Me Nikki = new Me("Nikki",50,50);
        Goblin goblin1 = new Goblin("Fred",10,0,3);
        Abilities Attack1 = new Abilities("Angriff","Greift an",10,5);
        //Ausführung
        //Du willst nun, als Nikki, goblin1 mit attack1 angreifen <3 
    }

}

//Klassen
//Primary
abstract class HPSPName
{
    //Eigenschaften
    public int Hp { get; set; }
    public int Sp { get; set; }
    public string PlayerName { get; set; }
    //Methoden
    //Kunstruktoren
}
//Secondary

class Abilities : HPSPName
{
    //Eigenschaften
    public string AbiName { get; set; }
    public string AbiDescription { get; set; }
    public int AbiDamage { get; set; }
    public int AbiCosts { get; set; }
    //Methoden
    public void Attack()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("[ " + PlayerName + " benutzt " + AbiName + " und macht " + AbiDamage + " schaden. Es werden " + AbiCosts + " Sp abgezogen. ]");
    }
    //Konstruktoren
    public Abilities (string _AbiName, string _AbiDescription, int _AbiDamage, int _AbiCosts)
    {
        _AbiName = AbiName;
        _AbiDescription = AbiDescription;
        _AbiDamage = AbiDamage;
        _AbiCosts = AbiCosts;
    }
}
class Me : HPSPName
{
    //Konstruktor
    public Me (string _PlayerName, int _Hp, int _Sp)
    {
        _PlayerName = PlayerName;
        _Hp = Hp;
        _Sp = Sp;
    }
}
class Goblin : HPSPName
{
    //Eigenschaft
    public int GoblinAngriff { get; set; }
    //Konstruktor
    public Goblin (string _PlayerName, int _Hp, int _Sp, int _GoblinAngriff)
    {
        _PlayerName = PlayerName;
        _Hp = Hp;
        _Sp = Sp;
        GoblinAngriff = _GoblinAngriff;
    }
}