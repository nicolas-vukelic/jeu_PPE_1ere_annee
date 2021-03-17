using System;

namespace classeJeu
{
    public class Boss 
    {


        #region propriétés
        //private string nom;
        public int pv { get; private set; }
        public bool EstVivant
        { 
            get { return pv > 0; } 
        }
        //private Attaque ATT;
        //private int degats_subis;
       // private int degatsboss = 30;
        #endregion


        #region accesseurs
       /* public string getNom()
        {
            return nom;
        }



        public int getPv()
        {
            return pv;
        }

        public int getDegats_subis()
        {
            return degats_subis;
        }*/

        #endregion

        #region constructeur
        public Boss(int points)
        {
            
           // this.nom = nom;
            pv = points;
            // degats_subis = 0;
        }
        #endregion



        #region methodes

        public void Combat (Joueur personnage)
        {
            int nbPoints = Attaquer(26);
            personnage.SubitDegats(nbPoints);
            //base.Combat(joueur);
            //joueur.Subit_Degats(AttaqueBoss());
        }

        public void SubitDegats (int valeur)
        {
            pv -= valeur;
        }

        private int Attaquer(int valeur)
        {
            return Attaque.Attaquer(valeur);
        }

       /* private int AttaqueBoss()
        {
            int val = ATT.Attaquer();
            if (val == 6)
            {
                return 0;
                //return (degatsboss * val);
            }
            return (degatsboss * val);
        }*/

        #endregion

        //Boss Boss1 = new Boss ("Flavien dévoreur de dieux", 100);


        /* public void override Degats()
         {
             int degats = 
         }*/
    }
}
