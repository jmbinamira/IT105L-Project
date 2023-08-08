using System;
//Binamira, Lanuza
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Final_OBE
{
    
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region 2010s
            Albums A1 = new Albums();
            A1.Decade = 2010;
            A1.Genre = "Hip Hop";
            A1.Title = "To Pimp a Butterfly";
            A1.Artist = "Kendrick Lamar";
            A1.Year = 2015;
            Albums A2 = new Albums();
            A2.Decade = 2010;
            A2.Genre = "Hip Hop";
            A2.Title = "My Beautiful Dark Twisted Fantasy";
            A2.Artist = "Kanye West";
            A2.Year = 2010;
            Albums A3 = new Albums();
            A3.Decade = 2010;
            A3.Genre = "Hip Hop";
            A3.Title = "Atrocity Exhibition";
            A3.Artist = "Danny Brown";
            A3.Year = 2016;
            Albums A4 = new Albums();
            A4.Decade = 2010;
            A4.Genre = "Pop/R&B";
            A4.Title = "Blonde";
            A4.Artist = "Frank Ocean";
            A4.Year = 2016;
            Albums A5 = new Albums();
            A5.Decade = 2010;
            A5.Genre = "Pop/R&B";
            A5.Title = "A Moon Shaped Pool";
            A5.Artist = "Radiohead";
            A5.Year = 2016;
            Albums A6 = new Albums();
            A6.Decade = 2010;
            A6.Genre = "Pop/R&B";
            A6.Title = "Titanic Rising";
            A6.Artist = "Weyes Blood";
            A6.Year = 2019;
            Albums A7 = new Albums();
            A7.Decade = 2010;
            A7.Genre = "Electronic";
            A7.Title = "Cosmogramma";
            A7.Artist = "Flying Lotus";
            A7.Year = 2010;
            Albums A8 = new Albums();
            A8.Decade = 2010;
            A8.Genre = "Electronic";
            A8.Title = "R Plus Seven";
            A8.Artist = "Oneohtrix Point Never";
            A8.Year = 2013;
            Albums A9 = new Albums();
            A9.Decade = 2010;
            A9.Genre = "Electronic";
            A9.Title = "2012-2017";
            A9.Artist = "Against All Logic";
            A9.Year = 2018;
            Albums A10 = new Albums();
            A10.Decade = 2010;
            A10.Genre = "Alternative/Rock";
            A10.Title = "Nonagon Infinity";
            A10.Artist = "King Gizzard and the Lizard Wizard";
            A10.Year = 2016;
            Albums A11 = new Albums();
            A11.Decade = 2010;
            A11.Genre = "Alternative/Rock";
            A11.Title = "Twin Fantasy";
            A11.Artist = "Car Seat Headrest";
            A11.Year = 2018;
            Albums A12 = new Albums();
            A12.Decade = 2010;
            A12.Genre = "Alternative/Rock";
            A12.Title = "...Like Clockwork";
            A12.Artist = "Queens of the Stone Age";
            A12.Year = 2013;
            Albums A13 = new Albums();
            A13.Decade = 2010;
            A13.Genre = "Hardcore/Metal/Punk";
            A13.Title = "Paracletus";
            A13.Artist = "Deathspell Omega";
            A13.Year = 2010;
            Albums A14 = new Albums();
            A14.Decade = 2010;
            A14.Genre = "Hardcore/Metal/Punk";
            A14.Title = "All We Love We Leave Behind";
            A14.Artist = "Converge";
            A14.Year = 2012;
            Albums A15 = new Albums();
            A15.Decade = 2010;
            A15.Genre = "Hardcore/Metal/Punk";
            A15.Title = "The Satanist";
            A15.Artist = "Behemoth";
            A15.Year = 2014;
            #endregion

            #region 2000s
            Albums A16 = new Albums();
            A16.Decade = 2000;
            A16.Genre = "Hip Hop";
            A16.Title = "Madvillainy";
            A16.Artist = "Madvillain";
            A16.Year = 2004;
            Albums A17 = new Albums();
            A17.Decade = 2000;
            A17.Genre = "Hip Hop";
            A17.Title = "The College Dropout";
            A17.Artist = "Kanye West";
            A17.Year = 2004;
            Albums A18 = new Albums();
            A18.Decade = 2000;
            A18.Genre = "Hip Hop";
            A18.Title = "Mm..Food";
            A18.Artist = "MF DOOM";
            A18.Year = 2004;
            Albums A19 = new Albums();
            A19.Decade = 2000;
            A19.Genre = "Pop/R&B";
            A19.Title = "Funeral";
            A19.Artist = "Arcade Fire";
            A19.Year = 2004;
            Albums A20 = new Albums();
            A20.Decade = 2000;
            A20.Genre = "Pop/R&B";
            A20.Title = "Merriweather Post Pavilion";
            A20.Artist = "Animal Collective";
            A20.Year = 2009;
            Albums A21 = new Albums();
            A21.Decade = 2000;
            A21.Genre = "Pop/R&B";
            A21.Title = "Yoshimi Battles the Pink Robots";
            A21.Artist = "The Flaming Lips";
            A21.Year = 2002;
            Albums A22 = new Albums();
            A22.Decade = 2000;
            A22.Genre = "Electronic";
            A22.Title = "Vespertine";
            A22.Artist = "Bjork";
            A22.Year = 2001;
            Albums A23 = new Albums();
            A23.Decade = 2000;
            A23.Genre = "Electronic";
            A23.Title = "Velocity:Design:Comfort";
            A23.Artist = "Sweet Trip";
            A23.Year = 2003;
            Albums A24 = new Albums();
            A24.Decade = 2000;
            A24.Genre = "Electronic";
            A24.Title = "Since I Left You";
            A24.Artist = "The Avalanches";
            A24.Year = 2000;
            Albums A25 = new Albums();
            A25.Decade = 2000;
            A25.Genre = "Alternative/Rock";
            A25.Title = "Kid A";
            A25.Artist = "Radiohead";
            A25.Year = 2000;
            Albums A26 = new Albums();
            A26.Decade = 2000;
            A26.Genre = "Alternative/Rock";
            A26.Title = "Lift Yr. Skinny Fists Like Antennas to Heaven!";
            A26.Artist = "Godspeed You Black Emperor!";
            A26.Year = 2000;
            Albums A27 = new Albums();
            A27.Decade = 2000;
            A27.Genre = "Alternative/Rock";
            A27.Title = "Is This It";
            A27.Artist = "The Strokes";
            A27.Year = 2001;
            Albums A28 = new Albums();
            A28.Decade = 2010;
            A28.Genre = "Hardcore/Metal/Punk";
            A28.Title = "Turn On the Bright Lights";
            A28.Artist = "Interpol";
            A28.Year = 2002;
            Albums A29 = new Albums();
            A29.Decade = 2010;
            A29.Genre = "Hardcore/Metal/Punk";
            A29.Title = "Lateralus";
            A29.Artist = "Tool";
            A29.Year = 2001;
            Albums A30 = new Albums();
            A30.Decade = 2010;
            A30.Genre = "Hardcore/Metal/Punk";
            A30.Title = "Jane Doe";
            A30.Artist = "Converge";
            A30.Year = 2001;
            #endregion

            #region 1990s
            Albums A31 = new Albums();
            A31.Decade = 1990;
            A31.Genre = "Hip Hop";
            A31.Title = "Illmatic";
            A31.Artist = "Nas";
            A31.Year = 1994;
            Albums A32 = new Albums();
            A32.Decade = 1990;
            A32.Genre = "Hip Hop";
            A32.Title = "Enter the Wu-Tang (36 Chambers)";
            A32.Artist = "Wu-Tang Clan";
            A32.Year = 1993;
            Albums A33 = new Albums();
            A33.Decade = 2000;
            A33.Genre = "Hip Hop";
            A33.Title = "The Low End Theory";
            A33.Artist = "A Tribe Called Quest";
            A33.Year = 1991;
            Albums A34 = new Albums();
            A34.Decade = 1990;
            A34.Genre = "Pop/R&B";
            A34.Title = "Loveless";
            A34.Artist = "My Bloody Valentine";
            A34.Year = 1991;
            Albums A35 = new Albums();
            A35.Decade = 1990;
            A35.Genre = "Pop/R&B";
            A35.Title = "Long Season";
            A35.Artist = "Fishmans";
            A35.Year = 1996;
            Albums A36 = new Albums();
            A36.Decade = 1990;
            A36.Genre = "Pop/R&B";
            A36.Title = "Dummy";
            A36.Artist = "Portishead";
            A36.Year = 1994;
            Albums A37 = new Albums();
            A37.Decade = 1990;
            A37.Genre = "Electronic";
            A37.Title = "Endtroducing.....";
            A37.Artist = "DJ Shadow";
            A37.Year = 1996;
            Albums A38 = new Albums();
            A38.Decade = 1990;
            A38.Genre = "Electronic";
            A38.Title = "Selected Ambient Works 85-92";
            A38.Artist = "Aphex Twin";
            A38.Year = 1992;
            Albums A39 = new Albums();
            A39.Decade = 2000;
            A39.Genre = "Electronic";
            A39.Title = "Music Has the Right to Children";
            A39.Artist = "Boards of Canada";
            A39.Year = 1998;
            Albums A40 = new Albums();
            A40.Decade = 1990;
            A40.Genre = "Alternative/Rock";
            A40.Title = "OK Computer";
            A40.Artist = "Radiohead";
            A40.Year = 1997;
            Albums A41 = new Albums();
            A41.Decade = 2000;
            A41.Genre = "Alternative/Rock";
            A41.Title = "Spiderland";
            A41.Artist = "Slint";
            A41.Year = 1991;
            Albums A42 = new Albums();
            A42.Decade = 1990;
            A42.Genre = "Alternative/Rock";
            A42.Title = "Pinkerton";
            A42.Artist = "Weezer";
            A42.Year = 1996;
            Albums A43 = new Albums();
            A43.Decade = 1990;
            A43.Genre = "Hardcore/Metal/Punk";
            A43.Title = "Painkiller";
            A43.Artist = "Judas Priest";
            A43.Year = 1990;
            Albums A44 = new Albums();
            A44.Decade = 2010;
            A44.Genre = "Hardcore/Metal/Punk";
            A44.Title = "Rage Against the Machine";
            A44.Artist = "Rage Against the Machine";
            A44.Year = 1992;
            Albums A45 = new Albums();
            A45.Decade = 1990;
            A45.Genre = "Hardcore/Metal/Punk";
            A45.Title = "Aenima";
            A45.Artist = "Tool";
            A45.Year = 1996;
            #endregion

            string[] rowa = { A1.Genre, A1.Title, A1.Artist, Convert.ToString(A1.Year) };
            var listViewItema = new ListViewItem(rowa);
            string[] rowb = { A2.Genre, A2.Title, A2.Artist, Convert.ToString(A2.Year) };
            var listViewItemb = new ListViewItem(rowb);
            string[] rowc = { A3.Genre, A3.Title, A3.Artist, Convert.ToString(A3.Year) };
            var listViewItemc = new ListViewItem(rowc);
            string[] rowd = { A4.Genre, A4.Title, A4.Artist, Convert.ToString(A4.Year) };
            var listViewItemd = new ListViewItem(rowd);
            string[] rowe = { A5.Genre, A5.Title, A5.Artist, Convert.ToString(A5.Year) };
            var listViewIteme = new ListViewItem(rowe);
            string[] rowf = { A6.Genre, A6.Title, A6.Artist, Convert.ToString(A6.Year) };
            var listViewItemf = new ListViewItem(rowf);
            string[] rowg = { A7.Genre, A7.Title, A7.Artist, Convert.ToString(A7.Year) };
            var listViewItemg = new ListViewItem(rowg);
            string[] rowh = { A8.Genre, A8.Title, A8.Artist, Convert.ToString(A8.Year) };
            var listViewItemh = new ListViewItem(rowh);
            string[] rowi = { A9.Genre, A9.Title, A9.Artist, Convert.ToString(A9.Year) };
            var listViewItemi = new ListViewItem(rowi);
            string[] rowj = { A10.Genre, A10.Title, A10.Artist, Convert.ToString(A10.Year) };
            var listViewItemj = new ListViewItem(rowj);
            string[] rowk = { A11.Genre, A11.Title, A11.Artist, Convert.ToString(A11.Year) };
            var listViewItemk = new ListViewItem(rowk);
            string[] rowl = { A12.Genre, A12.Title, A12.Artist, Convert.ToString(A12.Year) };
            var listViewIteml = new ListViewItem(rowl);
            string[] rowm = { A13.Genre, A13.Title, A13.Artist, Convert.ToString(A13.Year) };
            var listViewItemm = new ListViewItem(rowm);
            string[] rown = { A14.Genre, A14.Title, A14.Artist, Convert.ToString(A14.Year) };
            var listViewItemn = new ListViewItem(rown);
            string[] rowo = { A15.Genre, A15.Title, A15.Artist, Convert.ToString(A15.Year) };
            var listViewItemo = new ListViewItem(rowo);
            string[] rowp = { A16.Genre, A16.Title, A16.Artist, Convert.ToString(A16.Year) };
            var listViewItemp = new ListViewItem(rowp);
            string[] rowq = { A17.Genre, A17.Title, A17.Artist, Convert.ToString(A17.Year) };
            var listViewItemq = new ListViewItem(rowq);
            string[] rowr = { A18.Genre, A18.Title, A18.Artist, Convert.ToString(A18.Year) };
            var listViewItemr = new ListViewItem(rowr);
            string[] rowt = { A19.Genre, A19.Title, A19.Artist, Convert.ToString(A19.Year) };
            var listViewItemt = new ListViewItem(rowt);
          
            string[] rowu = { A20.Genre, A20.Title, A20.Artist, Convert.ToString(A20.Year) };
            var listViewItemu = new ListViewItem(rowu);
            string[] rowv = { A21.Genre, A21.Title, A21.Artist, Convert.ToString(A21.Year) };
            var listViewItemv = new ListViewItem(rowv);
            string[] roww = { A22.Genre, A22.Title, A22.Artist, Convert.ToString(A22.Year) };
            var listViewItemw = new ListViewItem(roww);
            string[] rowx = { A23.Genre, A23.Title, A23.Artist, Convert.ToString(A23.Year) };
            var listViewItemx = new ListViewItem(rowx);
            string[] rowy = { A24.Genre, A24.Title, A24.Artist, Convert.ToString(A24.Year) };
            var listViewItemy = new ListViewItem(rowy);
            string[] rowz = { A25.Genre, A25.Title, A25.Artist, Convert.ToString(A25.Year) };
            var listViewItemz = new ListViewItem(rowz);
            string[] row1 = { A26.Genre, A26.Title, A26.Artist, Convert.ToString(A26.Year) };
            var listViewItem1 = new ListViewItem(row1);
            string[] row2 = { A27.Genre, A27.Title, A27.Artist, Convert.ToString(A27.Year) };
            var listViewItem2 = new ListViewItem(row2);
            string[] row3 = { A28.Genre, A28.Title, A28.Artist, Convert.ToString(A28.Year) };
            var listViewItem3 = new ListViewItem(row3);
            string[] row4 = { A29.Genre, A29.Title, A29.Artist, Convert.ToString(A29.Year) };
            var listViewItem4 = new ListViewItem(row4);

            string[] row5 = { A30.Genre, A30.Title, A30.Artist, Convert.ToString(A30.Year) };
            var listViewItem5 = new ListViewItem(row5);
            string[] row6 = { A31.Genre, A31.Title, A31.Artist, Convert.ToString(A31.Year) };
            var listViewItem6 = new ListViewItem(row6);
            string[] row7 = { A32.Genre, A32.Title, A32.Artist, Convert.ToString(A32.Year) };
            var listViewItem7 = new ListViewItem(row7);
            string[] row8 = { A33.Genre, A33.Title, A33.Artist, Convert.ToString(A33.Year) };
            var listViewItem8 = new ListViewItem(row8);
            string[] row9 = { A34.Genre, A34.Title, A34.Artist, Convert.ToString(A34.Year) };
            var listViewItem9 = new ListViewItem(row9);
            string[] row10 = { A35.Genre, A35.Title, A35.Artist, Convert.ToString(A35.Year) };
            var listViewItem10 = new ListViewItem(row10);
            string[] row11 = { A36.Genre, A36.Title, A36.Artist, Convert.ToString(A36.Year) };
            var listViewItem11 = new ListViewItem(row11);
            string[] row12 = { A37.Genre, A37.Title, A37.Artist, Convert.ToString(A37.Year) };
            var listViewItem12 = new ListViewItem(row12);
            string[] row13 = { A38.Genre, A38.Title, A38.Artist, Convert.ToString(A38.Year) };
            var listViewItem13 = new ListViewItem(row13);
            string[] row14 = { A39.Genre, A39.Title, A39.Artist, Convert.ToString(A39.Year) };
            var listViewItem14 = new ListViewItem(row14);
            string[] row15 = { A40.Genre, A40.Title, A40.Artist, Convert.ToString(A40.Year) };
            var listViewItem15 = new ListViewItem(row15);

            string[] row16 = { A41.Genre, A41.Title, A41.Artist, Convert.ToString(A41.Year) };
            var listViewItem16 = new ListViewItem(row16);
            string[] row17 = { A42.Genre, A42.Title, A42.Artist, Convert.ToString(A42.Year) };
            var listViewItem17 = new ListViewItem(row17);
            string[] row18 = { A43.Genre, A43.Title, A43.Artist, Convert.ToString(A43.Year) };
            var listViewItem18 = new ListViewItem(row18);
            string[] row19 = { A44.Genre, A44.Title, A44.Artist, Convert.ToString(A44.Year) };
            var listViewItem19 = new ListViewItem(row19);
            string[] row20 = { A45.Genre, A45.Title, A45.Artist, Convert.ToString(A45.Year) };
            var listViewItem20 = new ListViewItem(row20);

            if (comboBox1.SelectedItem.ToString() == "All time")
            {

                 if (comboBox2.SelectedItem.ToString() == "All Genres")
                {
                    listView1.Items.Add(listViewItema);
                    listView1.Items.Add(listViewItemb);
                    listView1.Items.Add(listViewItemc);
                    listView1.Items.Add(listViewItemd);
                    listView1.Items.Add(listViewIteme);
                    listView1.Items.Add(listViewItemf);
                    listView1.Items.Add(listViewItemg);
                    listView1.Items.Add(listViewItemh);
                    listView1.Items.Add(listViewItemi);
                    listView1.Items.Add(listViewItemj);
                    listView1.Items.Add(listViewItemk);
                    listView1.Items.Add(listViewIteml);
                    listView1.Items.Add(listViewItemm);
                    listView1.Items.Add(listViewItemn);
                }
                if (comboBox2.SelectedItem.ToString() == "Hip Hop")
                {
                    listView1.Items.Add(listViewItema);
                    listView1.Items.Add(listViewItemb);
                    listView1.Items.Add(listViewItemc);
                    listView1.Items.Add(listViewItemr);
                    listView1.Items.Add(listViewItemq);
                    listView1.Items.Add(listViewItemp);
                    listView1.Items.Add(listViewItem6);
                    listView1.Items.Add(listViewItem7);
                    listView1.Items.Add(listViewItem8);
                }
                if (comboBox2.SelectedItem.ToString() == "Pop / R&B")
                {
                    listView1.Items.Add(listViewItemd);
                    listView1.Items.Add(listViewIteme);
                    listView1.Items.Add(listViewItemf);
                    listView1.Items.Add(listViewItemt);
                    listView1.Items.Add(listViewItemu);
                    listView1.Items.Add(listViewItemv);
                    listView1.Items.Add(listViewItem9);
                    listView1.Items.Add(listViewItem10);
                    listView1.Items.Add(listViewItem11);


                }
                if (comboBox2.SelectedItem.ToString() == "Electronic")
                {
                    listView1.Items.Add(listViewItemg);
                    listView1.Items.Add(listViewItemh);
                    listView1.Items.Add(listViewItemi);
                    listView1.Items.Add(listViewItemw);
                    listView1.Items.Add(listViewItemx);
                    listView1.Items.Add(listViewItemy);
                    listView1.Items.Add(listViewItem12);
                    listView1.Items.Add(listViewItem13);
                    listView1.Items.Add(listViewItem14);

                }
                if (comboBox2.SelectedItem.ToString() == "Alternative / Rock")
                {
                    listView1.Items.Add(listViewItemj);
                    listView1.Items.Add(listViewItemk);
                    listView1.Items.Add(listViewIteml);
                    listView1.Items.Add(listViewItemz);
                    listView1.Items.Add(listViewItem1);
                    listView1.Items.Add(listViewItem2);
                    listView1.Items.Add(listViewItem15);
                    listView1.Items.Add(listViewItem16);
                    listView1.Items.Add(listViewItem17);
                }
                if (comboBox2.SelectedItem.ToString() == "Hardcore / Metal / Punk")

                {
                    listView1.Items.Add(listViewItemm);
                    listView1.Items.Add(listViewItemn);
                    listView1.Items.Add(listViewItemo);
                    listView1.Items.Add(listViewItem3);
                    listView1.Items.Add(listViewItem4);
                    listView1.Items.Add(listViewItem5);
                    listView1.Items.Add(listViewItem18);
                    listView1.Items.Add(listViewItem19);
                    listView1.Items.Add(listViewItem20);
                }
            }
            if  (comboBox1.SelectedItem.ToString() == "2010")
            {
                if (comboBox2.SelectedItem.ToString() == "All Genres")
                {
                    listView1.Items.Add(listViewItemb);
                    listView1.Items.Add(listViewItemc);
                    listView1.Items.Add(listViewItemd);
                    listView1.Items.Add(listViewIteme);
                    listView1.Items.Add(listViewItemf);
                    listView1.Items.Add(listViewItemg);
                    listView1.Items.Add(listViewItemh);
                    listView1.Items.Add(listViewItemi);
                    listView1.Items.Add(listViewItemj);
                    listView1.Items.Add(listViewItemk);
                    listView1.Items.Add(listViewIteml);
                    listView1.Items.Add(listViewItemm);
                    listView1.Items.Add(listViewItemn);
                    listView1.Items.Add(listViewItemo);
                    listView1.Items.Add(listViewItema);
                }
                if (comboBox2.SelectedItem.ToString() == "Hip Hop")
                {
                    listView1.Items.Add(listViewItema);
                    listView1.Items.Add(listViewItemb);
                    listView1.Items.Add(listViewItemc);
                }
                if (comboBox2.SelectedItem.ToString() == "Pop / R&B")
                {
                    listView1.Items.Add(listViewItemd);
                    listView1.Items.Add(listViewIteme);
                    listView1.Items.Add(listViewItemf);



                }
                if (comboBox2.SelectedItem.ToString() == "Electronic")
                {
                    listView1.Items.Add(listViewItemg);
                    listView1.Items.Add(listViewItemh);
                    listView1.Items.Add(listViewItemi);


                }
                if (comboBox2.SelectedItem.ToString() == "Alternative / Rock")
                {
                    listView1.Items.Add(listViewItemj);
                    listView1.Items.Add(listViewItemk);
                    listView1.Items.Add(listViewIteml);

                }
                if (comboBox2.SelectedItem.ToString() == "Hardcore / Metal / Punk")
                {
                    listView1.Items.Add(listViewItemm);
                    listView1.Items.Add(listViewItemn);
                    listView1.Items.Add(listViewItemo);
                }
            }


            if (comboBox1.SelectedItem.ToString() == "2000s")
            {
                if (comboBox2.SelectedItem.ToString() == "All Genres")
                {
                    listView1.Items.Add(listViewItemp);
                    listView1.Items.Add(listViewItemq);
                    listView1.Items.Add(listViewItemr);
                    listView1.Items.Add(listViewItemt);
                    listView1.Items.Add(listViewItemu);
                    listView1.Items.Add(listViewItemv);
                    listView1.Items.Add(listViewItemw);
                    listView1.Items.Add(listViewItemy);
                    listView1.Items.Add(listViewItemx);
                    listView1.Items.Add(listViewItemz);
                    listView1.Items.Add(listViewIteml);
                    listView1.Items.Add(listViewItem2);
                    listView1.Items.Add(listViewItem3);
                    listView1.Items.Add(listViewItem4);
                    listView1.Items.Add(listViewItem5);
                }
                if (comboBox2.SelectedItem.ToString() == "Hip Hop")
                {
                    listView1.Items.Add(listViewItemp);
                    listView1.Items.Add(listViewItemq);
                    listView1.Items.Add(listViewItemr);
                }
                if (comboBox2.SelectedItem.ToString() == "Pop / R&B")
                {
                    listView1.Items.Add(listViewItemt);
                    listView1.Items.Add(listViewItemu);
                    listView1.Items.Add(listViewItemv);



                }
                if (comboBox2.SelectedItem.ToString() == "Electronic")
                {
                    listView1.Items.Add(listViewItemw);
                    listView1.Items.Add(listViewItemx);
                    listView1.Items.Add(listViewItemy);


                }
                if (comboBox2.SelectedItem.ToString() == "Alternative / Rock")
                {
                    listView1.Items.Add(listViewItemz);
                    listView1.Items.Add(listViewItem1);
                    listView1.Items.Add(listViewItem2);

                }
                if (comboBox2.SelectedItem.ToString() == "Hardcore / Metal / Punk")
                {
                    listView1.Items.Add(listViewItem3);
                    listView1.Items.Add(listViewItem4);
                    listView1.Items.Add(listViewItem5);
                }
            }

            if (comboBox1.SelectedItem.ToString() == "1990s")
            {
                if (comboBox2.SelectedItem.ToString() == "All Genres")
                {
                    listView1.Items.Add(listViewItem6);
                    listView1.Items.Add(listViewItem7);
                    listView1.Items.Add(listViewItem8);
                    listView1.Items.Add(listViewItem9);
                    listView1.Items.Add(listViewItem10);
                    listView1.Items.Add(listViewItem11);
                    listView1.Items.Add(listViewItem12);
                    listView1.Items.Add(listViewItem13);
                    listView1.Items.Add(listViewItem14);
                    listView1.Items.Add(listViewItem15);
                    listView1.Items.Add(listViewItem16);
                    listView1.Items.Add(listViewItem17);
                    listView1.Items.Add(listViewItem18);
                    listView1.Items.Add(listViewItem19);
                    listView1.Items.Add(listViewItem20);
                }
                if (comboBox2.SelectedItem.ToString() == "Hip Hop")
                {
                    listView1.Items.Add(listViewItem6);
                    listView1.Items.Add(listViewItem7);
                    listView1.Items.Add(listViewItem8);
                }
                if (comboBox2.SelectedItem.ToString() == "Pop / R&B")
                {
                    listView1.Items.Add(listViewItem9);
                    listView1.Items.Add(listViewItem10);
                    listView1.Items.Add(listViewItem11);



                }
                if (comboBox2.SelectedItem.ToString() == "Electronic")
                {
                    listView1.Items.Add(listViewItem12);
                    listView1.Items.Add(listViewItem13);
                    listView1.Items.Add(listViewItem14);


                }
                if (comboBox2.SelectedItem.ToString() == "Alternative / Rock")
                {
                    listView1.Items.Add(listViewItem15);
                    listView1.Items.Add(listViewItem16);
                    listView1.Items.Add(listViewItem17);

                }
                if (comboBox2.SelectedItem.ToString() == "Hardcore / Metal / Punk")
                {
                    listView1.Items.Add(listViewItem3);
                    listView1.Items.Add(listViewItem4);
                    listView1.Items.Add(listViewItem5);
                }
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }

}
