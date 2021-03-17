using System;


public class Attaque
{

    private static Random random = new Random();



    public static  int Attaquer()
    {
        return random.Next(1, 7);
    }

    public static int Attaquer(int valeur )
    {
        return random.Next(1, valeur);
    }
}
