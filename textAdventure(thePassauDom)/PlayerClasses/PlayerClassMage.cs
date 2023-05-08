namespace textAdventure_thePassauDom_.PlayerClasses;

public class Mage
{
    public void IceBlizzard()
    {
        Player _player = new Player();
        
        string playername = _player.Name;
        Console.WriteLine(playername + " setzt ");
    }
}