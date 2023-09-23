using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstMvcApp.Models
{
    public class movieDbRepository
    {
        public static List<movie> GetMovieList()
        {
            List<movie> lists = new List<movie>();
            using (SqlConnection cn = sqlhelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectmoviecmd = cn.CreateCommand();
                String selectAllMovie = "Select * from movies";
                selectmoviecmd.CommandText = selectAllMovie;
                SqlDataReader moviedr = selectmoviecmd.ExecuteReader();
                while (moviedr.Read())
                {
                  movie entity = new movie
                    {
                        Id = moviedr.GetInt32(0),
                        Title = moviedr.GetString(1),
                        language = moviedr.GetString(2),
                        Hero = moviedr.GetString(3),
                        Director = moviedr.GetString(4),
                        MusicDirector = moviedr.GetString(5),
                        ReleaseDate = moviedr.GetDateTime(6),
                        Cost = moviedr.GetInt32(7),
                        Collection = moviedr.GetInt32(8),
                        Review = moviedr.GetString(9),



                    };
                    lists.Add(entity);
                }
            }



            return lists;
        }





        public static movie GetMovieById(int id)
        {
            movie enitityFound = null;
            using (SqlConnection cn = sqlhelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectentitycmd = cn.CreateCommand();
                String selectAllEntities = "Select * from movies where Id=@id";
                selectentitycmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectentitycmd.CommandText = selectAllEntities;
                SqlDataReader moviedr = selectentitycmd.ExecuteReader();
                while (moviedr.Read())
                {
                    enitityFound = new movie
                    {
                        Id = moviedr.GetInt32(0),
                        Title = moviedr.GetString(1),
                        language = moviedr.GetString(2),
                        Hero = moviedr.GetString(3),
                        Director = moviedr.GetString(4),
                        MusicDirector = moviedr.GetString(5),
                        ReleaseDate = moviedr.GetDateTime(6),
                        Cost = moviedr.GetInt32(7),
                        Collection = moviedr.GetInt32(8),
                        Review = moviedr.GetString(9),
                    };
                }
            }





            return enitityFound;
        }
        public static int AddNewEnitity(movie newEnitity)
        {





            int query_result = 0;



            using (SqlConnection cn = sqlhelper.CreateConnection())



            {



                if (cn.State != ConnectionState.Open)



                {



                    cn.Open();



                }







                SqlCommand insertMoviecmd = cn.CreateCommand();



                String insertNewMovieQuery = "insert into Moives values( @id,@Title,@language,@Hero,@Director,@MusicDirector,@ReleaseDate,@Cost,@Collection,@Review)";



                insertMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = newEnitity.Id;



                insertMoviecmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = newEnitity.Title;



                insertMoviecmd.Parameters.Add("@Language", SqlDbType.NVarChar).Value = newEnitity.language;



                insertMoviecmd.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = newEnitity.Hero;



                insertMoviecmd.Parameters.Add("@Director", SqlDbType.NVarChar).Value = newEnitity.Director;



                insertMoviecmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = newEnitity.MusicDirector;



                insertMoviecmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = newEnitity.ReleaseDate;



                insertMoviecmd.Parameters.Add("@Cost", SqlDbType.Int).Value = newEnitity.Cost;



                insertMoviecmd.Parameters.Add("@Collection", SqlDbType.Int).Value = newEnitity.Collection;



                insertMoviecmd.Parameters.Add("@Review", SqlDbType.NVarChar).Value = newEnitity.Review;



                insertMoviecmd.CommandText = insertNewMovieQuery;



                query_result = insertMoviecmd.ExecuteNonQuery();



            }



            return query_result;



        }
        public static int UpdateMovie(movie modifiedMovie)
        {
            int query_result = 0;
            using (SqlConnection cn = sqlhelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateMoviecmd = cn.CreateCommand();
                String updateMovieQuery = "Update Moive set Title=@Title, language=@Language, Hero=@Hero, Director=@Director, MusicDirector=@MusicDirector, ReleaseDate=@ReleaseDate, Cost=@Cost, Collection=@Collection, Review=@Review where Id=@id";
                updateMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = modifiedMovie.Id;
                updateMoviecmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = modifiedMovie.Title;
                updateMoviecmd.Parameters.Add("@Language", SqlDbType.NVarChar).Value = modifiedMovie.language;
                updateMoviecmd.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = modifiedMovie.Hero;
                updateMoviecmd.Parameters.Add("@Director", SqlDbType.NVarChar).Value = modifiedMovie.Director;
                updateMoviecmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = modifiedMovie.MusicDirector;
                updateMoviecmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = modifiedMovie.ReleaseDate;
                updateMoviecmd.Parameters.Add("@Cost", SqlDbType.Int).Value = modifiedMovie.Cost;
                updateMoviecmd.Parameters.Add("@Collection", SqlDbType.Int).Value = modifiedMovie.Collection;
                updateMoviecmd.Parameters.Add("@Review", SqlDbType.NVarChar).Value = modifiedMovie.Review;
                updateMoviecmd.CommandText = updateMovieQuery;
                query_result = updateMoviecmd.ExecuteNonQuery();
            }
            return query_result;







        }




        public static int DeleteMovie(int id)
        {



            int query_result = 0;



            using (SqlConnection cn = sqlhelper.CreateConnection())



            {



                if (cn.State != ConnectionState.Open)



                {



                    cn.Open();



                }



                SqlCommand deleteMoviecmd = cn.CreateCommand();



                String deleteMovieQuery = "Delete from Moive where Id=@id";



                deleteMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = id;



                deleteMoviecmd.CommandText = deleteMovieQuery;



                query_result = deleteMoviecmd.ExecuteNonQuery();



            }



            return query_result;







        }







    }
}

