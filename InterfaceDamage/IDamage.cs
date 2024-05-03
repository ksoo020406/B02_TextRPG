namespace B02_TextRPG
{
    public interface IDamage
    {
        string Name { get; }
        int Level { get; }
        int Health { get; set; }
        int Attack { get; }
        int Defense { get; }
        int Gold { get; }
        bool isDead { get; set; }

        int Attackopp(IDamage opp);
    }
}



