using System;


namespace classeJeu
{

    public class MonstreBasique
    {

        
        #region propriétés
       // private string nom;
        //private int pv;
        public Attaque ATT;
        private const int degats = 5;
        //  private int degats_subis;
        public bool EstVivant { get; private set; }
        #endregion



        #region accesseurs
       /* public string getNom()
        {
            return nom;
        }*/



        /*public int getPv()
        {
            return pv;
        }*/

        /* public int getDegats_subis()
         {
             return degats_subis;
         }*/

        #endregion

        #region constructeur
        public MonstreBasique ()
        {
            ATT = new Attaque();
            EstVivant = true;
            /*this.nom = nom;
            pv = 100;
            ATT = new Attaque();
            EstVivant = true;
            //degats_subis = 0;*/
        }
        #endregion

        #region methodes
        public virtual void Combat(Joueur joueur)
        {
            int attaque_monstre = Attaquer();
            int attaque_joueur = joueur.Attaquer();
            if (attaque_monstre > attaque_joueur)
                joueur.SubitDegats(degats);

            /*base.Combat(joueur);
            joueur.Subit_Degats(AttaqueChien());*/
        }


        public void SubitDegats()
        {
            EstVivant = false;
        }

        public int Attaquer()
        {
            return Attaque.Attaquer();
        }


        /*private int AttaqueChien()
        {
            int val = ATT.Attaquer();
            if (val == 6)
            {
                return 0;
                return (degatschien * val);
            }
        }*/


        #endregion

        //  Demon Demon1 = new Demon ("yōkai 妖怪", 100);


        /* public void override Degats()
         {
             int degats = 
         }*/
    }
}
