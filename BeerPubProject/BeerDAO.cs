#region Imports

//C# imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

//Project imports
using BeerPubProject.Model;

#endregion

namespace BeerPubProject.Database
{
    public class BeerDAO
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=BeerPubDB;User Id=sa;Password=password;";

        #region CRUD methods

        public int CreateBeerInDB(Beer b)
        {
            //initialize connection
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                //open connection
                conn.Open();

                //setup DB command and execute it           
                string cmdText = "INSERT INTO Beer VALUES ('" + b.Name + "'," + b.Volume + "," + b.Price + ")";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.ExecuteNonQuery();

                return 1; //all went good :)
            }
            catch (Exception err) 
            {
                MessageBox.Show(err.ToString()); //display message box with error
                return -1;             
            }
            finally
            { conn.Close(); }
        }

        public List<Beer> RetrieveBeersFromDB()
        {
            //initialize connection
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                //open connection
                conn.Open();

                //setup DB command and execute it                
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Beer", conn);
                DataTable personTable = new DataTable();
                da.Fill(personTable);

                List<Beer> beerList = new List<Beer>();

                //run through all rows in result set, map each row to a person object and add it to list
                foreach (DataRow dr in personTable.Rows)
                {
                    Beer b = new Beer();

                    #region Map DataRow to Person object

                    b.Name = dr["name"].ToString();
                    b.Volume = Convert.ToInt32(dr["volume"].ToString());
                    b.Price = Convert.ToInt32(dr["price"].ToString());                  

                    #endregion

                    beerList.Add(b);
                }

                return beerList;
            }
            catch (Exception err) 
            {
                MessageBox.Show(err.ToString()); //display message box with error
                return null; 
            }
            finally { conn.Close(); }
        }

        
        public int UpdateBeerInDB(Beer b)
        {
            //initialize connection
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                //open connection
                conn.Open();

                //setup DB command and execute it
                string cmdText = "UPDATE Beer SET volume =" + b.Volume + ",price=" + b.Price + " WHERE name='" + b.Name + "'";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.ExecuteNonQuery();

                return 1; //all went good :)
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString()); //display message box with error
                return -1; //something went wrong :( 
            }
            finally { conn.Close(); }

        }

        
        public int DeleteBeerInDB(string beerName)
        {
            //initialize connection
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                //open connection
                conn.Open();

                //setup DB command and execute it
                string cmdText = "DELETE FROM Beer WHERE name ='" + beerName + "'";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.ExecuteNonQuery();

                return 1; //all went good :)
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString()); //display message box with error
                return -1; //something went wrong :(
            }
            finally { conn.Close(); }
        }

        #endregion
    }
}
