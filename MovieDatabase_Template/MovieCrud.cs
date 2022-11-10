namespace MovieDatabase_Template
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MovieDatabase;
    using MySql.Data.MySqlClient;

    public class MovieCrud
    {
        string connString = "";
        MySqlConnection cnn = null;

        public MovieCrud(string connString) 
        {
            cnn = new MySqlConnection(connString);
            VerifyDatabase();
            SeedDatabaseIfEmpty();
        }

        private void SeedDatabaseIfEmpty()
        {
            string sql = "SELECT COUNT(*) FROM actor";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
            {
                SeedActors();
            }

            sql = "SELECT COUNT(*) FROM movie";
            cmd = new MySqlCommand(sql, cnn);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
            {
                SeedMovies();
            }

            sql = "SELECT COUNT(*) FROM movie_actor";
            cmd = new MySqlCommand(sql, cnn);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
            {
                SeedMovieActors();
            }
            
        }

        private void SeedMovieActors()
        {
            
        }

        private void SeedMovies()
        {
            throw new NotImplementedException();
        }

        private void SeedActors()
        {
            throw new NotImplementedException();
        }

        private void VerifyDatabase()
        {
            string sql = "";
            MySqlCommand cmd = null;
            
            // Skapa databasen om den inte finns
            //cnn.Open();
            //sql = "CREATE DATABASE IF NOT EXISTS moviedb";
            //cmd = new MySqlCommand(sql, cnn);
            //cmd.ExecuteNonQuery();
            //cnn.Close();

            // Skapa tabellen om den inte finns
            sql = "CREATE TABLE IF NOT EXISTS Movies (id INT NOT NULL AUTO_INCREMENT, title VARCHAR(100), year INT, PRIMARY KEY (id))";
            cmd = new MySqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();

            // Skapa tabellen om den inte finns
            sql = "CREATE TABLE IF NOT EXISTS Actors (id INT NOT NULL AUTO_INCREMENT, name VARCHAR(100), bornyear INT, PRIMARY KEY (id))";
            cmd = new MySqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();

            // Skapa tabellen om den inte finns
            sql = "CREATE TABLE IF NOT EXISTS MovieActor (movieid INT, actorid INT)";
            cmd = new MySqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }

        public void AddMovie(Movie movie)
        {
            // Kolla om filmen redan finns, uppdatera i så fall
            // Om inte, lägg till filmen i databasen
            // Lägg till skådespelarna i databasen
            // Lägg till relationen mellan filmen och skådespelarna i databasen
        }

        public void AddActor(Actor actor)
        {
            // Kolla om skådespelaren finns i databasen
            // Uppdatera i så fall annars
            // Lägg till skådespelaren i databasen
        }

        public void AddActorToMovie(Actor actor, Movie movie)
        {
            // Kolla om relationen finns i databasen, i så fall är du klar
            // Annars lägg till relationen mellan filmen och skådespelaren i databasen
        }

        public List<Movie> GetMovies()
        {
            // Hämta alla filmer från databasen
            // Hämta alla skådespelare från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Skapa en lista med filmer
            // Lägg till skådespelarna till filmerna
            // Returnera listan med filmer
        }

        public List<Movie> GetMoviesContaining(string search)
        {
            // Hämta alla matchande filmer från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla relaterade skådespelare från databasen
            // Skapa en lista med filmer
            // Lägg till skådespelarna till filmerna
            // Returnera listan med filmer
        }

        public List<Movie> GetMoviesFromYear(int year)
        {
            // Hämta alla matchande filmer från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla relaterade skådespelare från databasen
            // Skapa en lista med filmer
            // Lägg till skådespelarna till filmerna
            // Returnera listan med filmer
        }

        public List<Movie> GetMovie(int Id)
        {
            // Hämta matchande film från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla relaterade skådespelare från databasen
            // Skapa en lista med filmer
            // Lägg till skådespelarna till filmerna
            // Returnera listan med filmer
        }

        public List<Movie> GetMovie(string name)
        {
            // Hämta matchande film från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla relaterade skådespelare från databasen
            // Skapa en lista med filmer
            // Lägg till skådespelarna till filmerna
            // Returnera listan med filmer
        }


        public List<Actor> GetActors()
        {
            // Hämta alla skådespelare från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla matchande filmer från databasen
            // Skapa en lista med skådespelare
            // Lägg till filmerna till skådespelarna
            // Returnera listan med skådespelare
        }

        public List<Actor> GetActorsInMovie(Movie movie)
        {
            // Hämta alla skådespelare från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla matchande filmer från databasen
            // Skapa en lista med skådespelare
            // Lägg till filmerna till skådespelarna
            // Returnera listan med skådespelare
        }

        public List<Movie> GetMoviesWithActor(Actor actor)
        {
            // Hämta alla skådespelare från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla matchande filmer från databasen
            // Skapa en lista med skådespelare
            // Lägg till filmerna till skådespelarna
            // Returnera listan med skådespelare
        }

        public List<Movie> GetMoviesWithActor(string actorName)
        {
            // Hämta alla skådespelare från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla matchande filmer från databasen
            // Skapa en lista med skådespelare
            // Lägg till filmerna till skådespelarna
            // Returnera listan med skådespelare
        }

        public List<Movie> GetMoviesWithActor(int actorId)
        {
            // Hämta alla skådespelare från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla matchande filmer från databasen
            // Skapa en lista med skådespelare
            // Lägg till filmerna till skådespelarna
            // Returnera listan med skådespelare
        }

        public void DeleteActor(int actorId)
        {
            // Ta bort skådespelaren från databasen
            // Ta bort alla relationer mellan skådespelaren och filmerna från databasen
        }

        public void DeleteMove(int moveId)
        {
            // Ta bort filmen från databasen
            // Ta bort alla relationer mellan filmen och skådespelarna från databasen
        }
    }
}
