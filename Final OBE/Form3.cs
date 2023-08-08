using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_OBE
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnFDisplay_Click(object sender, EventArgs e)
        {
            #region Comedy
            Films F1 = new Films();
            F1.FGenre = "Black Comedy";
            F1.FTitle = "Pulp Fiction";
            F1.FDirector = "Quentin Tarantino";
            F1.FYear = 1994;
            Films F2 = new Films();
            F2.FGenre = "Black Comedy";
            F2.FTitle = "The Big Lebowski";
            F2.FDirector = "Joel Coen";
            F2.FYear = 1998;
            Films F3 = new Films();
            F3.FGenre = "Black Comedy";
            F3.FTitle = "Fargo";
            F3.FDirector = "Joel Coen";
            F3.FYear = 1996;
            Films F4 = new Films();
            F4.FGenre = "Absurdist Comedy";
            F4.FTitle = "Monty Python and the Holy Grail";
            F4.FDirector = "Terry Gilliam";
            F4.FYear = 1975;
            Films F5 = new Films();
            F5.FGenre = "Black Comedy";
            F5.FTitle = "Inglorious Basterds";
            F5.FDirector = "Quentin Tarantino";
            F5.FYear = 2009;
            #endregion

            #region Drama
            Films F6 = new Films();
            F6.FGenre = "Drama";
            F6.FTitle = "The Godfather";
            F6.FDirector = "Francis Ford Coppola";
            F6.FYear = 1972;
            Films F7 = new Films();
            F7.FGenre = "Psychological Drama";
            F7.FTitle = "Taxi Driver";
            F7.FDirector = "Martin Scorsese";
            F7.FYear = 1976;
            Films F8 = new Films();
            F8.FGenre = "Psychological Drama";
            F8.FTitle = "Apocalypse Now";
            F8.FDirector = "Francis Ford Coppola";
            F8.FYear = 1979;
            Films F9 = new Films();
            F9.FGenre = "Psychological Drama";
            F9.FTitle = "Mulholland Drive";
            F9.FDirector = "David Lynch";
            F9.FYear = 2001;
            Films F10 = new Films();
            F10.FGenre = "Drama";
            F10.FTitle = "There Will Be Blood";
            F10.FDirector = "Paul Thomas Anderson";
            F10.FYear = 2007;
            #endregion

            #region Horror
            Films F11 = new Films();
            F11.FGenre = "Psychological Horror";
            F11.FTitle = "The Shining";
            F11.FDirector = "Stanley Kubrick";
            F11.FYear = 1980;
            Films F12 = new Films();
            F12.FGenre = "Horror";
            F12.FTitle = "Psycho";
            F12.FDirector = "Alfred Hitchcock";
            F12.FYear = 1960;
            Films F13 = new Films();
            F13.FGenre = "Psychological Horror";
            F13.FTitle = "Rosemary's Baby";
            F13.FDirector = "Roman Polański";
            F13.FYear = 1968;
            Films F14 = new Films();
            F14.FGenre = "Psychological Horror";
            F14.FTitle = "Eraserhead ";
            F14.FDirector = "David Lynch";
            F14.FYear = 1977;
            Films F15 = new Films();
            F15.FGenre = "Horror";
            F15.FTitle = "The Texas Chain Saw Massacre ";
            F15.FDirector = "Tobe Hooper";
            F15.FYear = 1974;
            #endregion

            #region Science Fiction
            Films F16 = new Films();
            F16.FGenre = "Science Fiction";
            F16.FTitle = "2001: A Space Odyssey";
            F16.FDirector = "Stanley Kubrick";
            F16.FYear = 1968;
            Films F17 = new Films();
            F17.FGenre = "Science Fiction";
            F17.FTitle = "Stalker";
            F17.FDirector = "Andrei Tarkovsky";
            F17.FYear = 1979;
            Films F18 = new Films();
            F18.FGenre = "Science Fiction";
            F18.FTitle = "Alien ";
            F18.FDirector = "Ridley Scott";
            F18.FYear = 1979;
            Films F19 = new Films();
            F19.FGenre = "Science Fiction";
            F19.FTitle = "Blade Runner";
            F19.FDirector = "Ridley Scott";
            F19.FYear = 1982;
            Films F20 = new Films();
            F20.FGenre = "Science Fiction";
            F20.FTitle = "Neon Genesis Evangelion: The End of Evangelion";
            F20.FDirector = "Hideaki Anno";
            F20.FYear = 1997;
            #endregion

            #region Romance
            Films F21 = new Films();
            F21.FGenre = "Romance";
            F21.FTitle = "Eternal Sunshine of the Spotless Mind";
            F21.FDirector = "Michel Gondry";
            F21.FYear = 2004;
            Films F22 = new Films();
            F22.FGenre = "Romance";
            F22.FTitle = "Casablanca";
            F22.FDirector = "Michael Curtiz";
            F22.FYear = 1942;
            Films F23 = new Films();
            F23.FGenre = "Romance";
            F23.FTitle = "A Brighter Summer Day";
            F23.FDirector = "Edward Yang";
            F23.FYear = 1991;
            Films F24 = new Films();
            F24.FGenre = "Romance";
            F24.FTitle = "Lost in Translation";
            F24.FDirector = "Sofia Coppola";
            F24.FYear = 2003;
            Films F25 = new Films();
            F25.FGenre = "Romance";
            F25.FTitle = "Chungking Express";
            F25.FDirector = "Wong Kar-wai";
            F25.FYear = 1994;
            #endregion

            string[] row1 = { F1.FGenre, F1.FTitle, F1.FDirector, Convert.ToString(F1.FYear) };
            var listViewItem1 = new ListViewItem(row1);
            string[] row2 = { F2.FGenre, F2.FTitle, F2.FDirector, Convert.ToString(F2.FYear) };
            var listViewItem2 = new ListViewItem(row2);
            string[] row3 = { F3.FGenre, F3.FTitle, F3.FDirector, Convert.ToString(F3.FYear) };
            var listViewItem3 = new ListViewItem(row3);
            string[] row4 = { F4.FGenre, F4.FTitle, F4.FDirector, Convert.ToString(F4.FYear) };
            var listViewItem4 = new ListViewItem(row4);
            string[] row5 = { F5.FGenre, F5.FTitle, F5.FDirector, Convert.ToString(F5.FYear) };
            var listViewItem5 = new ListViewItem(row5);
            string[] row6 = { F6.FGenre, F6.FTitle, F6.FDirector, Convert.ToString(F6.FYear) };
            var listViewItem6 = new ListViewItem(row6);
            string[] row7 = { F7.FGenre, F7.FTitle, F7.FDirector, Convert.ToString(F7.FYear) };
            var listViewItem7 = new ListViewItem(row7);
            string[] row8 = { F8.FGenre, F8.FTitle, F8.FDirector, Convert.ToString(F8.FYear) };
            var listViewItem8 = new ListViewItem(row8);
            string[] row9 = { F9.FGenre, F9.FTitle, F9.FDirector, Convert.ToString(F9.FYear) };
            var listViewItem9 = new ListViewItem(row9);
            string[] row10 = { F10.FGenre, F10.FTitle, F10.FDirector, Convert.ToString(F10.FYear) };
            var listViewItem10 = new ListViewItem(row10);
            string[] row11 = { F11.FGenre, F11.FTitle, F11.FDirector, Convert.ToString(F11.FYear) };
            var listViewItem11 = new ListViewItem(row11);
            string[] row12 = { F12.FGenre, F12.FTitle, F12.FDirector, Convert.ToString(F12.FYear) };
            var listViewItem12 = new ListViewItem(row12);
            string[] row13 = { F13.FGenre, F13.FTitle, F13.FDirector, Convert.ToString(F13.FYear) };
            var listViewItem13 = new ListViewItem(row13);
            string[] row14 = { F14.FGenre, F14.FTitle, F14.FDirector, Convert.ToString(F14.FYear) };
            var listViewItem14 = new ListViewItem(row14);
            string[] row15 = { F15.FGenre, F15.FTitle, F15.FDirector, Convert.ToString(F15.FYear) };
            var listViewItem15 = new ListViewItem(row15);
            string[] row16 = { F16.FGenre, F16.FTitle, F16.FDirector, Convert.ToString(F16.FYear) };
            var listViewItem16 = new ListViewItem(row16);
            string[] row17 = { F17.FGenre, F17.FTitle, F17.FDirector, Convert.ToString(F17.FYear) };
            var listViewItem17 = new ListViewItem(row17);
            string[] row18 = { F18.FGenre, F18.FTitle, F18.FDirector, Convert.ToString(F18.FYear) };
            var listViewItem18 = new ListViewItem(row18);
            string[] row19 = { F19.FGenre, F19.FTitle, F19.FDirector, Convert.ToString(F19.FYear) };
            var listViewItem19 = new ListViewItem(row19);
            string[] row20 = { F20.FGenre, F20.FTitle, F20.FDirector, Convert.ToString(F20.FYear) };
            var listViewItem20 = new ListViewItem(row20);
            string[] row21 = { F21.FGenre, F21.FTitle, F21.FDirector, Convert.ToString(F21.FYear) };
            var listViewItem21 = new ListViewItem(row21);
            string[] row22 = { F22.FGenre, F22.FTitle, F22.FDirector, Convert.ToString(F22.FYear) };
            var listViewItem22 = new ListViewItem(row22);
            string[] row23 = { F23.FGenre, F23.FTitle, F23.FDirector, Convert.ToString(F23.FYear) };
            var listViewItem23 = new ListViewItem(row23);
            string[] row24 = { F24.FGenre, F24.FTitle, F24.FDirector, Convert.ToString(F24.FYear) };
            var listViewItem24 = new ListViewItem(row24);
            string[] row25 = { F25.FGenre, F25.FTitle, F25.FDirector, Convert.ToString(F25.FYear) };
            var listViewItem25 = new ListViewItem(row25);
            
            if (comboBox1.SelectedIndex== -1) { MessageBox.Show("Invalid, Please Choose a Genre");

                
            }



            else if (comboBox1.SelectedItem.ToString() == "Comedy")
            {
                listView1.Items.Add(listViewItem1);
                listView1.Items.Add(listViewItem2);
                listView1.Items.Add(listViewItem3);
                listView1.Items.Add(listViewItem4);
                listView1.Items.Add(listViewItem5);
            }
            else if (comboBox1.SelectedItem.ToString() == "Drama")
            {
                listView1.Items.Add(listViewItem6);
                listView1.Items.Add(listViewItem7);
                listView1.Items.Add(listViewItem8);
                listView1.Items.Add(listViewItem9);
                listView1.Items.Add(listViewItem10);
            }
            else if (comboBox1.SelectedItem.ToString() == "Horror")
            {
                listView1.Items.Add(listViewItem11);
                listView1.Items.Add(listViewItem12);
                listView1.Items.Add(listViewItem13);
                listView1.Items.Add(listViewItem14);
                listView1.Items.Add(listViewItem15);
            }
            else if (comboBox1.SelectedItem.ToString() == "Science Fiction")
            {
                listView1.Items.Add(listViewItem16);
                listView1.Items.Add(listViewItem17);
                listView1.Items.Add(listViewItem18);
                listView1.Items.Add(listViewItem19);
                listView1.Items.Add(listViewItem20);
            }
            else if (comboBox1.SelectedItem.ToString() == "Romance")
            {
                listView1.Items.Add(listViewItem21);
                listView1.Items.Add(listViewItem22);
                listView1.Items.Add(listViewItem23);
                listView1.Items.Add(listViewItem24);
                listView1.Items.Add(listViewItem25);



                
            }
            

        }
    }
        
}

