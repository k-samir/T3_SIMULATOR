using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    public class Personnage
    {
        private int id { get; set; }
        private int fatigue { get; set; }
        private int nvSavoir { get; set; }
        private int pA { get; set; }
        private int prenom { get; set; }
        private int sociabilite { get; set; }
        private int stress { get; set; }
        private int tempsConsacre { get; set; }

        public void calculFatigue()
        {
            throw new System.NotImplementedException();
        }

        public void calculNvSavoir()
        {
            throw new System.NotImplementedException();
        }

        public void calculPA()
        {
            throw new System.NotImplementedException();
        }

        public void calculSociabilite()
        {
            throw new System.NotImplementedException();
        }

        public void calculStress()
        {
            throw new System.NotImplementedException();
        }

        public void faireAction(Action action)
        {
            throw new System.NotImplementedException();
        }
    }
}