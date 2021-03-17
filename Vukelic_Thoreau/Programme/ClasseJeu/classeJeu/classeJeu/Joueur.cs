using System;

namespace classeJeu
{
    public class Joueur
    {

       

        #region propriétés
       // private string nom;
       // private int score;
        public int pv { get; private set; }
       // private Random random;
        private Attaque ATT;
       // private int Degats;
        public bool EstVivant
        { get { return pv > 0; } }
        #endregion


       /* #region accesseurs
        public string getNom()
        {
            return nom;
        }

        public void setNom(string value)
            {
                nom = value;
            }
        public int getScore()
        {
            return score;
        }

       /* public int getPv()
        {
            return pv;
        }

        public int getDegats()
        {
            return Degats;
        }
        

        #endregion*/

        #region constructeur
        public Joueur(int points)
        {
           // this.nom = pNom;
           // score = 0;
            pv = points;
           // ATT = new Attaque();
           // Degats = 20;


        }
        #endregion

        #region méthodes

        public void Combat(MonstreBasique monstre)
        {
            int attaque_joueur = Attaquer();
            int attaque_monstre = monstre.Attaquer();
    
            if (attaque_joueur >= attaque_monstre )
                monstre.SubitDegats();
            
        }

        public void Combat(Boss boss)
        {
            int nbPoints = Attaque.Attaquer(26);
            boss.SubitDegats(nbPoints);
        }

        public int Attaquer()
        {
            //ATT = new Attaque();
          //  ATT.Attaquer();
            return Attaque.Attaquer();
        }

        public int Attquer(int valeur)
        {
            return Attaque.Attaquer(valeur);
        }

        private bool attaque_loupee()
        {
            return Attaque.Attaquer() <= 2;
        }

        public void SubitDegats (int degats)
        {
            if (!attaque_loupee())
            {
                pv -= degats;
            }
        }

       /* public Attaque()
        {
            random = new Random();
        }

         public int Attaquer()
        {
            return random.Next(1, 7);
        }
        */
        #endregion

    

    }
 
}