using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    public class Action
    {
        //Attributs des actions 
        private string nom;





        // DELETE ME
        // KILL ME
        // TAKE ME TO THE GRAVEYARD
        // PLEAAAAAASEEEEEEE
        // #throwedToTheBin
        // #balanceTonCodeur



        /*
        Nombre d'appels de l'action, on pourra alors déterminer si une tâche est accomplie en fonction
        du nombre d'appels effectués
        */
        private int nbAppels = 0;

        public Action(string nom)
        {
            this.nom = nom;
        }

        public string getNomAction()
        {
            return this.nom;
        }

        public int getNbAppels()
        {
            return this.nbAppels;
        }

        public void setNbAppels()
        {
            this.nbAppels++;
        }

    }
}