using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.Classes
{
    class Reunion
    {
        private String themeReunion;
        private Boolean statut = false;
        private String categorie;

        public Reunion(String themeReunion, String categorie)
        {
            this.themeReunion = themeReunion;
            this.statut = false;
            this.categorie = categorie;
        }

        public void setStatut(Boolean statut)
        {
            
            this.statut = statut;
        }

        public Boolean getStatut()
        {
            return this.statut;
        }

        public String getThemeReunion()
        {
            return this.themeReunion;
        }

        public String getCategorie()
        {
            return this.categorie;
        }
    }


}
