using textAdventure_thePassauDom_;

class program
{
    public static void Main(string[] args)
    {
        Player Player1 = new Player();
        Player1.Name = "Lucy";
        Player1.hp = 30;
        Player1.sp = 70;
        Human Human1 = new Human();
        Human1.EntityName = "Franz Ferdinant";
        Human1.EntityLittleDescription = "der verkommene adlige.";
        Human1.EntityHP = 20;
        Human1.hp = 5;

        Human1.EntityDescription();
        Console.ReadKey();

        Console.WriteLine(Player1.Name + " macht sich auf einen Angriff gefasst.");
        Console.ReadKey();

        Human1.EntityAttack();
        Console.ReadKey();

        //Berechnung
        Player1.hp = Player1.hp - Human1.hp;

        Console.WriteLine(Player1.Name + " hat noch " + Player1.hp + " Lebenspunkte");
        Console.ReadKey();
    }

}
/* 
 * Control (MainMenu, Inventory, FightMenu)
 * Attack (Buffs, Debuffs, Weapon)
 * Places (DonauAnlegestelle -> Wittgasse -> Ludwigstraße (domPlatz domhofBrunnen (Steinweg -> Berggasse -> Höllgasse, Gasthof ->Nußbaumgasse) -> Bossroom(inside))) 
 * Items (Healing Potion, Mikrophasertuch, Key zum dom, CreationStone, Weiße Rose)
 */