using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelis_admins
{
    class Login
    {
        enum level
        {
            Nivel_0,
            Nivel_1,
            Nivel_2,
        }

        private bool logged_in = false;
    
      

        private level autorization_level { get; set; }

        void Start_login()
        {
            using var context = new example_crudContext();
            var m = context.Movies.Find(1);

            string entrada = "";
            ConsoleKeyInfo tecla;
            
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Insert Id: ");
                }
                else
                {
                    Console.WriteLine("Insert password");
                }

                do
                {
                    tecla = Console.ReadKey(true);
                   
                    // Si la tecla es una letra o un dígito, agregarla a la entrada
                    if (char.IsLetterOrDigit(tecla.KeyChar))
                    {

                        entrada += tecla.KeyChar;
                        Console.Write(tecla.KeyChar);
                        System.Threading.Thread.Sleep(350);
                        Console.Write("\b \b");
                        if (i > 0)
                        {
                            Console.Write("*");
                        }
                        
                    }
                    // Si la tecla es retroceso, eliminar el último carácter de la entrada
                    else if (tecla.Key == ConsoleKey.Backspace && entrada.Length > 0)
                    {
                        entrada = entrada.Substring(0, entrada.Length - 1);
                        Console.Write("\b \b");
                    }
                } while (tecla.Key != ConsoleKey.Enter);

            }
            

            // Mostrar la entrada censurada
            Console.WriteLine();
            Console.WriteLine("Entrada censurada: " + entrada);// get user and password then
            this.autorization_level = 0; //check in database
            //set autorization_level

        }

        bool Logged_in()
        {
            bool status = this.logged_in;
            return status;
        }

    }
}
