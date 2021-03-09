using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using concexionDB.DOMINIO;
using concexionDB.DAO;

namespace concexionDB.NEGOCIO

{
    class ClsLoguo
    {
        clsDAO DAO = new clsDAO();
        
        public Boolean accederLogue(ClsLogueDominio domi)
        {

            for (int i =0; i<DAO.Administrador.Length;i++) {
                if (domi.User.Equals(DAO.Administrador[i]) && domi.Pass.Equals(DAO.pasworkAdministrador[i])) {
                return true;
            
            
            }
            }
            return false;
        }


    }
}
