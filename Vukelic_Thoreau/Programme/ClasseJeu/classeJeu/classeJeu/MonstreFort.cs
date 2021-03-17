using System;

namespace classeJeu
{
    public class MonstreFort : MonstreBasique
    {


        private const int degatsMonstreFort = 10;

        public override void Combat(Joueur joueur)
        {
            base.Combat(joueur);
            joueur.SubitDegats(AttaqueMonstreFort());
        }

        private int AttaqueMonstreFort()
        {
            int valeur = Attaque.Attaquer();
            if (valeur == 6)
                return 0;
            return degatsMonstreFort * valeur;
        }

        /*#region propriétés
        private string nom;
        private int pv;
        private Attaque ATT;
        private int degatsdemon = 20;
      //  private int degats_subis;
        #endregion

    
        #region accesseurs
        public string getNom()
        {
            return nom;
        }



        public int getPv()
        {
            return pv;
        }

       /* public int getDegats_subis()
        {
            return degats_subis;
        }

        #endregion

        #region constructeur
        public Demon(string nom)
        {
            this.nom = nom;
            pv = 100;
            //degats_subis = 0;
        }
        #endregion

        #region methodes
            public override void Combat(Joueur joueur)
            {
                base.Combat(joueur);
                joueur.Subit_Degats(AttaqueDemon());
            }

        private int AttaqueDemon()
            {
                int val = ATT.Attaquer();
                if (val == 6 )
                {
                    return 0;
                    return (degatsdemon * val);
                }
            }


        #endregion

      //  Demon Demon1 = new Demon ("yōkai 妖怪", 100);


        /* public void override Degats()
         {
             int degats = 
         }*/
    }
}
