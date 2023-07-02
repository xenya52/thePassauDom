namespace textAdventure_thePassauDom_.Alive;

public class mainPlayer
{
    public string playerName { get; set; }

    public int playerAge { get; set; }
    
    public string playerDescription { get; set; }

    public string currentPlayerClass { get; set; }
    
    public void characterCreeation()
    {
        //name
        Console.WriteLine("Wähle deinen namen");
        //age
        Console.WriteLine("Wie alt bist du?" );
        //description
        Console.WriteLine("Beschreibe in einem kurzen text, was dich ausmacht");
        //classChoise
        Console.WriteLine("Was trifft am besten auf dich zu?");
        Console.WriteLine("1. Um mich selber zu verteidigen, gehe ich nah an den gegner und versuche ihn mit kräftigen schlägen zu fall zu bringen.");
        Console.WriteLine("2. Ich bleibe ruhig und gelassen und versuche mit all meinem wissen die optimale lösung für das problem zu finden.");
        Console.WriteLine("3. Ich bleibe auf abstand und versuche mit einem möglichst sicheren schlag zu setzen.");
    }
}