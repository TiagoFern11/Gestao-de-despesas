using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PAP
{
    public static class SessaoSistema

    {
        //usuario

        private static string _Email;

        private static string _Palavrapasse;



        public static string EmailUsuario

        {

            get { return SessaoSistema._Email; }

            set { SessaoSistema._Email = value; }

        }


        public static string PasswordUsuario

        {

            get { return SessaoSistema._Palavrapasse; }

            set { SessaoSistema._Palavrapasse = value; }

        }
    }
}
