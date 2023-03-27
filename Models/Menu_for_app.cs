using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelis_admins
{
    class Menu_for_app {

        private const string first_message = "Ingrese el numero correspondiente" +
            " a la accion requerida \n";

        private const string main_menu_admin_level_0 =
            first_message +
            "1.  Ver listado de peliculas  \n" +
            "2.  Cerrar sesion \n";

        private const string main_menu_admin_level_1 =
            first_message +
            "1.  Ver listado de peliculas  \n" +
            "2.  Movies management  \n" +
            "3.  Cerrar sesion  \n";

        private const string main_menu_admin_level_2 =
            first_message +
            "1.  List of movies  \n" +
            "2.  Movies management  \n" +
            "3.  User management  \n" +
            "4.  Cerrar sesion/n";

        private const string menu_movies_admin =
            first_message +
            "1.  Update movie data  \n" +
            "2.  Add movie to list  \n" +
            "3.  Delete movie from list  \n" +
            "4.  Back";

        private const string menu_users_admin =
            first_message +
            "1.  Ver listado de usuarios  \n" +
            "2.  Update user  \n" +
            "3.  Add user  \n" +
            "4.  Delete usuario  \n" +
            "5.  Close session  \n" +
            "6.  Back  \n";

        void Startmenu() {
            Console.WriteLine();
        
        }
            
        
   

       

    }
}

