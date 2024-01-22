using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Movie_Management
{
    internal class DatabaseConnection
    {
        private string connectionString = "Server=localhost;Database=MovieDB;User ID=sa;Password=Nohom420;";
        public SqlConnection connection = new SqlConnection();
        public List<Movie> Movies = new List<Movie>();
        public List<Image> Posters = new List<Image>();
        public List<PictureBox> Pictures = new List<PictureBox>();


        public void InsertMovies(string tableName, Movie movie)
        {
            try
            {
                byte[] posterData = File.ReadAllBytes(movie.ImagePath);

              //  MessageBox.Show("filename " + movie.fileName);
                connection.ConnectionString = connectionString;
                using (connection)
                {
                    //MessageBox.Show(tableName);
                    string sql = "INSERT INTO " + tableName + " (Title,Genre,Director,ReleaseDate,Rating,Poster,ImagePath) VALUES (@Title,@Genre,@Director,@ReleaseDate,@Rating,@Poster,@ImagePath)";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        MessageBox.Show("Execution");
                        cmd.Parameters.AddWithValue("@Title", movie.Title);
                        cmd.Parameters.AddWithValue("@Genre", movie.Genre);
                        cmd.Parameters.AddWithValue("@ReleaseDate", movie.ReleaseDate);
                        cmd.Parameters.AddWithValue("@Director", movie.Director);
                        cmd.Parameters.AddWithValue("@Rating", movie.Rating);
                        cmd.Parameters.AddWithValue("@Poster", posterData);
                        cmd.Parameters.AddWithValue("@ImagePath", movie.ImagePath);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("insert error" + ex.Message);
            }

        }


        public void RetrieveMovies(string tableName)
        {
            using (connection)
            {
                try
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT ID,Title,Genre,Director,ReleaseDate,Rating,Poster,ImagePath FROM " + tableName, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           // MessageBox.Show("HHi");
                            Movie movie = new Movie();
                            movie.Id = (int)reader["ID"];
                            movie.Title = (string)reader["Title"];
                            movie.Genre = (string)reader["Genre"];
                            movie.Director = (string)reader["Director"];
                            movie.ReleaseDate = (DateTime)reader["ReleaseDate"];
                            movie.Rating = (int)reader["Rating"];
                            movie.ImagePath = (string)reader["ImagePath"];
                            byte[] posterImage = (byte[])reader["Poster"];
                            using (MemoryStream ms = new MemoryStream(posterImage))
                            {
                                movie.Poster = Image.FromStream(ms);
                            }

                            Movies.Add(movie);
                        }
                    }

                    // CreatePictureBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("retrieve " + ex.Message);
                }
            }

        }




    }
}
