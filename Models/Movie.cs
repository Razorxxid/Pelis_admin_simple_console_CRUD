using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Pelis_admins
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int? Year { get; set; }
        public int? LengthMinutes { get; set; }


        private const string menu_select_field_movie =
            "1. Title \n" +
            "2. Director \n" +
            "3. Year \n" +
            "4. Lenght in minutes \n" +
            "5. Cancelar operacion \n";


        public void Create_movie()
        {

            using var context = new example_crudContext();
            Console.WriteLine("Isert name of the new movie");
            string movie_name = Console.ReadLine();
            Console.WriteLine("Insert director name");
            string director_name = Console.ReadLine();
            Console.WriteLine("Insert movie year of release");
            int movie_year = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert movie duration in minutes");
            int movie_duration= int.Parse(Console.ReadLine());

            var m = new Movie();
            m.Title = movie_name;
            m.Director = director_name;
            m.Year = movie_year;
            m.LengthMinutes = movie_duration;
            context.Movies.Add(m);
            context.SaveChanges();

            Console.WriteLine("Printing movie list for simple checking");
            Print_movies_list();
        }

        public void Print_movies_list()
        {

            using var context = new example_crudContext();
            foreach (var single_movie in context.Movies.ToList())
            {

                Console.WriteLine(single_movie.Id + " " +
                     single_movie.Title + " " +
                     single_movie.Director + " " +
                     single_movie.Year + " " +
                     single_movie.LengthMinutes + "\n");

            }

        }

        public void Update_movie()
        {

            var context = new example_crudContext();
            Console.WriteLine("Movie list next: \n");
            Print_movies_list();
            Console.WriteLine("Insert id of the movie: \n");
            int current_movie_id = int.Parse(Console.ReadLine());
            var m = context.Movies.Find(current_movie_id);
            Console.Clear();
            Console.WriteLine("Select field to be modified: \n");
            Console.WriteLine(menu_select_field_movie);
            string field_modification = Console.ReadLine();
            switch (field_modification)
            {

                case "1":

                    Console.Clear();
                    Console.WriteLine("Insert new movie title: \n");
                    string title_modification = Console.ReadLine();
                    m.Title = title_modification;
                    context.Entry(m).State = EntityState.Modified;
                    context.SaveChanges();
                    break;


                case "2":

                    Console.Clear();
                    Console.WriteLine("Insert new movie Director: \n");
                    string director_modification = Console.ReadLine();
                    m.Director = director_modification;
                    context.Entry(m).State = EntityState.Modified;
                    context.SaveChanges();
                    break;


                case "3":

                    Console.Clear();
                    Console.WriteLine("Insert new movie release Year: \n");
                    int year_modification = int.Parse(Console.ReadLine());
                    m.Year = year_modification;
                    context.Entry(m).State = EntityState.Modified;
                    context.SaveChanges();
                    break;


                case "4":

                    Console.Clear();
                    Console.WriteLine("Insert new movie  Length in Minutes: \n");
                    int lengthMinutes_modification = int.Parse(Console.ReadLine());
                    m.LengthMinutes = lengthMinutes_modification;
                    context.Entry(m).State = EntityState.Modified;
                    context.SaveChanges();
                    break;

                case "5":

                    Console.Clear();
                    break;

                default:

                    Console.Clear();
                    Console.WriteLine("Error the option doesn't exist: \n"); ;
                    break;

            }

        }

        public void Delete_movie()
        {

            var context = new example_crudContext();
            Console.WriteLine("Movie list next: \n");
            Print_movies_list();
            Console.WriteLine("Insert id of the movie to be deleted: \n");
            int current_movie_id = int.Parse(Console.ReadLine());
            var m = context.Movies.Find(current_movie_id);
            context.Remove(m);
            context.SaveChanges();

        }
  
    }

}

   
