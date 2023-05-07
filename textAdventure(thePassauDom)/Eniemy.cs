namespace textAdventure_thePassauDom_;

public class Eniemy : Ientity
{
    public string EntityName { get; set; }
    public string EntityLittleDescription { get; set; }
    public int EntityHP { get; set; }

    public void entityDescription(string eniemyDescription)
    {
        Console.WriteLine(eniemyDescription);
    }
}