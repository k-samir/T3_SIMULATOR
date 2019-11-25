using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Classes
{
    class Reunion
    {
        private String themeReunion;
        private Boolean statut = false;

        public Reunion(String themeReunion)
        {
            this.themeReunion = themeReunion;
            this.statut = false;
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

    }


}
