using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Pelis_admins
{
    public partial class UserTable
    {
        internal string autorization;

        public int Id { get; set; }
        public string Username { get; set; }
        public int? Autorization { get; set; }

        private const string menu_select_field_user =
           "1. Username \n" +
           "2. Autorizacion \n" +
           "3. Cancelar operacion \n";

        public void Print_user_list()
        {

            using var context = new example_crudContext();
            foreach (var single_user in context.UserTables.ToList())
            {

                Console.WriteLine(single_user.Id + " " +
                     single_user.Username + " " +
                     single_user.Autorization);
            }

        }




        public void Update_user()
        {

            var context = new example_crudContext();
            Console.WriteLine("User list next: \n");
            Print_user_list();
            Console.WriteLine("Insert id of the user: \n");
            int current_user_id = int.Parse(Console.ReadLine());
            var m = context.UserTables.Find(current_user_id);
            Console.Clear();
            Console.WriteLine("Select field to be modified: \n");
            Console.WriteLine(menu_select_field_user);
            string field_modification = Console.ReadLine();
            switch (field_modification)
            {

                case "1":

                    Console.Clear();
                    Console.WriteLine("Insert new username: \n");
                    string username_modification = Console.ReadLine();
                    m.Username = username_modification;
                    context.Entry(m).State = EntityState.Modified;
                    context.SaveChanges();
                    break;


                case "2":

                    Console.Clear();
                    Console.WriteLine("Insert new autorization level: \n");
                    string autorization_modification = Console.ReadLine();
                    m.autorization = autorization_modification;
                    context.Entry(m).State = EntityState.Modified;
                    context.SaveChanges();
                    break;

                default:

                    Console.Clear();
                    Console.WriteLine("Error the option doesn't exist: \n"); ;
                    break;

            }

        }






    }


   
}
