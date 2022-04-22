using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Spotify11
{
    public partial class Form1 : Form
    {
        string orclData = "Data source = orcl; User Id = scott; Password=tiger;";
        OracleConnection connection;
        OracleDataReader reader;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new OracleConnection(orclData);
            connection.Open();
        }

    private void searchBtn_Click(object sender, EventArgs e)
        {
             reader = IsItSong();
            if (reader.HasRows)
            {
                displaySongs();
            }
            else
            {
                reader = IsItArtist();
                if (reader.HasRows)
                {

                }
                else
                {
                    reader = IsItCategory();
                    if (reader.HasRows)
                    {
                        findCategorysSongs();
                        AddToArtistBtn.Visible = false;
                        artistList.Visible = false; 
                    }
                    else
                    {
                        MessageBox.Show("No Data found!");
                    }
                }
            }
        
        }
       
        private void findCategorysSongs()
        {
            OracleDataReader songsReader;
            int categoryId = 0;
            string categoryName = "";
            while (reader.Read())
            {
                categoryId = Convert.ToInt32(reader[0].ToString());
                categoryName = reader[1].ToString();
            }
            songsReader = getCategorySongs(categoryId);
            displayAllSongsInCategory(songsReader , categoryName);
        }

        private void displayAllSongsInCategory(OracleDataReader songReader, string categoryName)
        {
            ListViewItem song;
            string songName;

            while (songReader.Read())
            {
                // Get song info
                songName = (songReader[1].ToString());

                //fill songs lIst view
                song = new ListViewItem(songName);
                song.SubItems.Add(categoryName);
                SongsList.Items.Add(song);
            }

        }

        private OracleDataReader getCategorySongs(int categoryId)
        {
            OracleDataReader reader = null;
            OracleCommand command = new OracleCommand()
            {
                Connection = connection,
                CommandText = "select * from songs where CATEGORYID = :Id"
            };
            command.Parameters.Add("id", categoryId.ToString());
            reader = command.ExecuteReader();   

            return reader;
        }
        private OracleDataReader IsItSong()
        {
            string command = "select * from songs where Lower(songName) = :searchTextBox";
            OracleCommand command1 = new OracleCommand
            {
                Connection = connection,
                CommandText = command
            };
            command1.Parameters.Add("songName", searchTextBox.Text.ToString().ToLower());
            OracleDataReader dr = command1.ExecuteReader();

            return dr;
        }
        private OracleDataReader IsItArtist()
        {
            string command = "select * from Artist where LOWER(name) = :searchTextBox";
            OracleCommand command1 = new OracleCommand
            {
                Connection = connection,
                CommandText = command
            };
            command1.Parameters.Add("songName", searchTextBox.Text.ToString().ToLower());

            OracleDataReader dr = command1.ExecuteReader();

            return dr;
        }
        private OracleDataReader IsItCategory()
        {
            string command = "select * from SONGSCATEGORY where LOWER(CATEGORYNAME) = :searchTextBox";
            OracleCommand command1 = new OracleCommand
            {
                Connection = connection,
                CommandText = command
            };
            command1.Parameters.Add("songName", searchTextBox.Text.ToString().ToLower());

            OracleDataReader dr = command1.ExecuteReader();

            return dr;
        }

        private void displaySongs()
        {
            var artists = new HashSet<string>();
            ListViewItem song;
            string  songName , categoryName, artistName;
            int caregoryId , songId;
            
            while(reader.Read())
            {
                // Get song info
                songId = Convert.ToInt32(reader[0].ToString());
                songName = (reader[1].ToString()); 
                caregoryId = Convert.ToInt32(reader[2].ToString());
                categoryName = getCategoryName(caregoryId);
                artistName = getSongArtist(songId);

                //fill songs lIst view
                song = new ListViewItem(songName);
                song.SubItems.Add(categoryName);    
                SongsList.Items.Add(song);

                // collect songs artists;
                artists.Add(artistName);    
            }

            displayArtist(artists);
        }

        private void displayArtist(HashSet<string> artists)
        {

            foreach(string artistName in artists)
            {
               artistList.Items.Add(artistName);
            }
        }
        private string getCategoryName(int caregoryId)
        {
            string categoryName = null;
            OracleCommand command = new OracleCommand
            {
                Connection = connection,
                CommandText= "select categoryname from songscategory where  categoryid = :category_Id"
                //    CommandType = CommandType.StoredProcedure,
                //    CommandText = "GETCATEGORYNAME"
            };

            command.Parameters.Add("Id", caregoryId);
            //  command.Parameters.Add("name", OracleDbType.Varchar2, ParameterDirection.Output);
            //  command.ExecuteNonQuery();
            //  categoryName = command.Parameters["name"].Value.ToString();
            
            OracleDataReader dr = command.ExecuteReader();
            while (dr.Read())
                categoryName = (string)dr[0].ToString();

            return categoryName;
        }

        private string getSongArtist(int songId)
        {
            string artistName = null;
            OracleCommand command = new OracleCommand
            {
                Connection = connection,
               // CommandText = "select categoryname from songscategory where  categoryid = :category_Id"
                  CommandType = CommandType.StoredProcedure,
                  CommandText = "GETARTISTNAME"
            };

            command.Parameters.Add("Id", songId);
            command.Parameters.Add("name", OracleDbType.Varchar2,60, ParameterDirection.Output);
            command.ExecuteNonQuery();
            artistName = command.Parameters["name"].Value.ToString();

          //  OracleDataReader dr = command.ExecuteReader();
          //  while (dr.Read())
          //  categoryName = (string)dr[0].ToString();

            return artistName;
        }
    }
}