using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MasterMind
{
    public partial class game : Form
    {
        //--------------------------------
        private List<color> searchedColor = new List<color>();
        private Random rnd = new Random();
        private color[] tipedColors = new color[53];
        private int tipedColorPieces = 5;
        private int actual = 0;
        private Thread th;
        private int sec = 0;
        private int row = 1;
        private bool plus = true;
        private bool fullRow = true;
        private int goodSpace = 0;
        private int goodTip = 0;
        //--------------------------------

        private void searchedColorAdd()
        {
            for (int i = 0; i < 4; i++)
            {
                int random = rnd.Next(1, 7);
                color add = new color(i+1, random, true);   
                searchedColor.Add(add);
            }
        }

        private void tipedColor()
        {
            switch (tipedColorPieces)
            {
                case 5:
                    if (plus)
                    {
                        picture5.Visible = true;
                        picture5.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture5.Visible = false;
                    }
                    break;
                case 6:
                    if (plus)
                    {
                        picture6.Visible = true;
                        picture6.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture6.Visible = false;
                    }
                    break;
                case 7:
                    if (plus)
                    {
                        picture7.Visible = true;
                        picture7.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture7.Visible = false;
                    }
                    break;
                case 8:
                    if (plus)
                    {
                        picture8.Visible = true;
                        picture8.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture8.Visible = false;
                    }
                    break;
                case 9:
                    if (plus)
                    {
                        picture9.Visible = true;
                        picture9.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture9.Visible = false;
                    }
                    break;
                case 10:
                    if (plus)
                    {
                        picture10.Visible = true;
                        picture10.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture10.Visible = false;
                    }
                    break;
                case 11:
                    if (plus)
                    {
                        picture11.Visible = true;
                        picture11.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture11.Visible = false;
                    }
                    break;
                case 12:
                    if (plus)
                    {
                        picture12.Visible = true;
                        picture12.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture12.Visible = false;
                    }
                    break;
                case 13:
                    if (plus)
                    {
                        picture13.Visible = true;
                        picture13.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture13.Visible = false;
                    }
                    break;
                case 14:
                    if (plus)
                    {
                        picture14.Visible = true;
                        picture14.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture14.Visible = false;
                    }
                    break;
                case 15:
                    if (plus)
                    {
                        picture15.Visible = true;
                        picture15.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture15.Visible = false;
                    }
                    break;
                case 16:
                    if (plus)
                    {
                        picture16.Visible = true;
                        picture16.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture16.Visible = false;
                    }
                    break;
                case 17:
                    if (plus)
                    {
                        picture17.Visible = true;
                        picture17.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture17.Visible = false;
                    }
                    break;
                case 18:
                    if (plus)
                    {
                        picture18.Visible = true;
                        picture18.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture18.Visible = false;
                    }
                    break;
                case 19:
                    if (plus)
                    {
                        picture19.Visible = true;
                        picture19.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture19.Visible = false;
                    }
                    break;
                case 20:
                    if (plus)
                    {
                        picture20.Visible = true;
                        picture20.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture20.Visible = false;
                    }
                    break;
                case 21:
                    if (plus)
                    {
                        picture21.Visible = true;
                        picture21.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture21.Visible = false;
                    }
                    break;
                case 22:
                    if (plus)
                    {
                        picture22.Visible = true;
                        picture22.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture22.Visible = false;
                    }
                    break;
                case 23:
                    if (plus)
                    {
                        picture23.Visible = true;
                        picture23.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture23.Visible = false;
                    }
                    break;
                case 24:
                    if (plus)
                    {
                        picture24.Visible = true;
                        picture24.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture24.Visible = false;
                    }
                    break;
                case 25:
                    if (plus)
                    {
                        picture25.Visible = true;
                        picture25.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture25.Visible = false;
                    }
                    break;
                case 26:
                    if (plus)
                    {
                        picture26.Visible = true;
                        picture26.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture26.Visible = false;
                    }
                    break;
                case 27:
                    if (plus)
                    {
                        picture27.Visible = true;
                        picture27.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture27.Visible = false;
                    }
                    break;
                case 28:
                    if (plus)
                    {
                        picture28.Visible = true;
                        picture28.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture28.Visible = false;
                    }
                    break;
                case 29:
                    if (plus)
                    {
                        picture29.Visible = true;
                        picture29.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture29.Visible = false;
                    }
                    break;
                case 30:
                    if (plus)
                    {
                        picture30.Visible = true;
                        picture30.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture30.Visible = false;
                    }
                    break;
                case 31:
                    if (plus)
                    {
                        picture31.Visible = true;
                        picture31.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture31.Visible = false;
                    }
                    break;
                case 32:
                    if (plus)
                    {
                        picture32.Visible = true;
                        picture32.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture32.Visible = false;
                    }
                    break;
                case 33:
                    if (plus)
                    {
                        picture33.Visible = true;
                        picture33.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture33.Visible = false;
                    }
                    break;
                case 34:
                    if (plus)
                    {
                        picture34.Visible = true;
                        picture34.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture34.Visible = false;
                    }
                    break;
                case 35:
                    if (plus)
                    {
                        picture35.Visible = true;
                        picture35.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture35.Visible = false;
                    }
                    break;
                case 36:
                    if (plus)
                    {
                        picture36.Visible = true;
                        picture36.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture36.Visible = false;
                    }
                    break;
                case 37:
                    if (plus)
                    {
                        picture37.Visible = true;
                        picture37.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture37.Visible = false;
                    }
                    break;
                case 38:
                    if (plus)
                    {
                        picture38.Visible = true;
                        picture38.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture38.Visible = false;
                    }
                    break;
                case 39:
                    if (plus)
                    {
                        picture39.Visible = true;
                        picture39.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture39.Visible = false;
                    }
                    break;
                case 40:
                    if (plus)
                    {
                        picture40.Visible = true;
                        picture40.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture40.Visible = false;
                    }
                    break;
                case 41:
                    if (plus)
                    {
                        picture41.Visible = true;
                        picture41.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture41.Visible = false;
                    }
                    break;
                case 42:
                    if (plus)
                    {
                        picture42.Visible = true;
                        picture42.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture42.Visible = false;
                    }
                    break;
                case 43:
                    if (plus)
                    {
                        picture43.Visible = true;
                        picture43.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture43.Visible = false;
                    }
                    break;
                case 44:
                    if (plus)
                    {
                        picture44.Visible = true;
                        picture44.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture44.Visible = false;
                    }
                    break;
                case 45:
                    if (plus)
                    {
                        picture45.Visible = true;
                        picture45.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture45.Visible = false;
                    }
                    break;
                case 46:
                    if (plus)
                    {
                        picture46.Visible = true;
                        picture46.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture46.Visible = false;
                    }
                    break;
                case 47:
                    if (plus)
                    {
                        picture47.Visible = true;
                        picture47.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture47.Visible = false;
                    }
                    break;
                case 48:
                    if (plus)
                    {
                        picture48.Visible = true;
                        picture48.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture48.Visible = false;
                    }
                    break;
                case 49:
                    if (plus)
                    {
                        picture49.Visible = true;
                        picture49.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture49.Visible = false;
                    }
                    break;
                case 50:
                    if (plus)
                    {
                        picture50.Visible = true;
                        picture50.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture50.Visible = false;
                    }
                    break;
                case 51:
                    if (plus)
                    {
                        picture51.Visible = true;
                        picture51.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture51.Visible = false;
                    }
                    break;
                case 52:
                    if (plus)
                    {
                        picture52.Visible = true;
                        picture52.BackgroundImage = Image.FromFile(tipedColors[tipedColorPieces].Color1 + ".png");
                    }
                    else
                    {
                        picture52.Visible = false;
                    }
                    break;
            }
        }

        private void painting()
        {
            picture1.BackgroundImage = Image.FromFile(searchedColor[0].Color1 + ".png");
            picture2.BackgroundImage = Image.FromFile(searchedColor[1].Color1 + ".png");
            picture3.BackgroundImage = Image.FromFile(searchedColor[2].Color1 + ".png");
            picture4.BackgroundImage = Image.FromFile(searchedColor[3].Color1 + ".png");
        }

        public game()
        {
            InitializeComponent();
            searchedColorAdd();
            painting();
            timeTimer.Start();
        }

        private void tipRed_Click(object sender, EventArgs e)
        {
            int pos = 0;
            if (tipedColorPieces%4 == 0)
            {
                pos = 4;

            }
            else if (tipedColorPieces%3 == 0)
            {
                pos = 3;
            }
            else if (tipedColorPieces%2 == 0)
            {
                pos = 2;
            }
            else
            {
                pos = 1;
            }
            actual++;
            if (actual<5)
            {
                fullRow = false;
                tipedColors[tipedColorPieces] = new color(pos, 5, false);
                tipedColor();
                tipedColorPieces++;
            }
        }

        private void tipYellow_Click(object sender, EventArgs e)
        {
            int pos = 0;
            if (tipedColorPieces % 4 == 0)
            {
                pos = 4;

            }
            else if (tipedColorPieces % 3 == 0)
            {
                pos = 3;
            }
            else if (tipedColorPieces % 2 == 0)
            {
                pos = 2;
            }
            else
            {
                pos = 1;
            }
            actual++;
            if (actual < 5)
            {
                fullRow = false;
                tipedColors[tipedColorPieces] = new color(pos, 4, false);
                tipedColor();
                tipedColorPieces++;
            }
        }

        private void tipGreen_Click(object sender, EventArgs e)
        {
            int pos = 0;
            if (tipedColorPieces % 4 == 0)
            {
                pos = 4;

            }
            else if (tipedColorPieces % 3 == 0)
            {
                pos = 3;
            }
            else if (tipedColorPieces % 2 == 0)
            {
                pos = 2;
            }
            else
            {
                pos = 1;
            }
            actual++;
            if (actual < 5)
            {
                fullRow = false;
                tipedColors[tipedColorPieces] = new color(pos, 6, false);
                tipedColor();
                tipedColorPieces++;
            }
        }

        private void tipLightBlue_Click(object sender, EventArgs e)
        {
            int pos = 0;
            if (tipedColorPieces % 4 == 0)
            {
                pos = 4;

            }
            else if (tipedColorPieces % 3 == 0)
            {
                pos = 3;
            }
            else if (tipedColorPieces % 2 == 0)
            {
                pos = 2;
            }
            else
            {
                pos = 1;
            }
            actual++;
            if (actual < 5)
            {
                fullRow = false;
                tipedColors[tipedColorPieces] = new color(pos, 3, false);
                tipedColor();
                tipedColorPieces++;
            }
        }

        private void tipDarkBlue_Click(object sender, EventArgs e)
        {
            int pos = 0;
            if (tipedColorPieces % 4 == 0)
            {
                pos = 4;

            }
            else if (tipedColorPieces % 3 == 0)
            {
                pos = 3;
            }
            else if (tipedColorPieces % 2 == 0)
            {
                pos = 2;
            }
            else
            {
                pos = 1;
            }
            actual++;
            if (actual < 5)
            {
                fullRow = false;
                tipedColors[tipedColorPieces] = new color(pos, 2, false);
                tipedColor();
                tipedColorPieces++;
            }
        }

        private void tipPurple_Click(object sender, EventArgs e)
        {
            int pos = 0;
            if (tipedColorPieces % 4 == 0)
            {
                pos = 4;

            }
            else if (tipedColorPieces % 3 == 0)
            {
                pos = 3;
            }
            else if (tipedColorPieces % 2 == 0)
            {
                pos = 2;
            }
            else
            {
                pos = 1;
            }
            actual++;
            if (actual < 5)
            {
                fullRow = false;
                tipedColors[tipedColorPieces] = new color(pos, 1, false);
                tipedColor();
                tipedColorPieces++;
            }
        }

        private void undo_Click(object sender, EventArgs e)
        {
            if (fullRow == false)
            {
                plus = false;
                tipedColorPieces--;
                actual--;
                tipedColor();
                plus = true;
                if (tipedColorPieces % 4 == 1)
                {
                    fullRow = true;
                }
            }
        }

        private void endTimer_Tick(object sender, EventArgs e)
        {
            end.Visible = false;
            resultsAll.Visible = true;
            points.Visible = true;
        }

        private void results()
        {
            int k = 0;
            int l = 0;
            switch (row)
            {
                case 1:
                    for (int i = 0; i < 4; i++)
                    {
                        if (i < goodSpace)
                        {
                            switch (i)
                            {
                                case 0:
                                    result1.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 1:
                                    result2.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 2:
                                    result3.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 3:
                                    result4.BackgroundImage = Image.FromFile("red.png");
                                    break;
                            }
                            k++;
                        }
                    }
                    for (int i = k; i < 4; i++)
                    {
                        if (l < goodTip)
                        {
                            switch (i)
                            {
                                case 0:
                                    result1.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 1:
                                    result2.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 2:
                                    result3.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 3:
                                    result4.BackgroundImage = Image.FromFile("white.png");
                                    break;
                            }
                            l++;
                        }
                    }
                    break;

                case 2:
                    for (int i = 0; i < 4; i++)
                    {
                        if (i < goodSpace)
                        {
                            switch (i)
                            {
                                case 0:
                                    result5.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 1:
                                    result6.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 2:
                                    result7.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 3:
                                    result8.BackgroundImage = Image.FromFile("red.png");
                                    break;
                            }
                            k++;
                        }
                    }
                    for (int i = k; i < 4; i++)
                    {
                        if (l < goodTip)
                        {
                            switch (i)
                            {
                                case 0:
                                    result5.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 1:
                                    result6.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 2:
                                    result7.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 3:
                                    result8.BackgroundImage = Image.FromFile("white.png");
                                    break;
                            }
                            l++;
                        }
                    }
                    break;

                case 3:
                    for (int i = 0; i < 4; i++)
                    {
                        if (i < goodSpace)
                        {
                            switch (i)
                            {
                                case 0:
                                    result9.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 1:
                                    result10.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 2:
                                    result11.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 3:
                                    result12.BackgroundImage = Image.FromFile("red.png");
                                    break;
                            }
                            k++;
                        }
                    }
                    for (int i = k; i < 4; i++)
                    {
                        if (l < goodTip)
                        {
                            switch (i)
                            {
                                case 0:
                                    result9.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 1:
                                    result10.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 2:
                                    result11.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 3:
                                    result12.BackgroundImage = Image.FromFile("white.png");
                                    break;
                            }
                            l++;
                        }
                    }
                    break;

                case 4:
                    for (int i = 0; i < 4; i++)
                    {
                        if (i < goodSpace)
                        {
                            switch (i)
                            {
                                case 0:
                                    result13.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 1:
                                    result14.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 2:
                                    result15.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 3:
                                    result16.BackgroundImage = Image.FromFile("red.png");
                                    break;
                            }
                            k++;
                        }
                    }
                    for (int i = k; i < 4; i++)
                    {
                        if (l < goodTip)
                        {
                            switch (i)
                            {
                                case 0:
                                    result13.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 1:
                                    result14.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 2:
                                    result15.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 3:
                                    result16.BackgroundImage = Image.FromFile("white.png");
                                    break;
                            }
                            l++;
                        }
                    }
                    break;

                case 5:
                    for (int i = 0; i < 4; i++)
                    {
                        if (i < goodSpace)
                        {
                            switch (i)
                            {
                                case 0:
                                    result17.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 1:
                                    result18.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 2:
                                    result19.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 3:
                                    result20.BackgroundImage = Image.FromFile("red.png");
                                    break;
                            }
                            k++;
                        }
                    }
                    for (int i = k; i < 4; i++)
                    {
                        if (l < goodTip)
                        {
                            switch (i)
                            {
                                case 0:
                                    result17.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 1:
                                    result18.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 2:
                                    result19.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 3:
                                    result20.BackgroundImage = Image.FromFile("white.png");
                                    break;
                            }
                            l++;
                        }
                    }
                    break;

                case 6:
                    for (int i = 0; i < 4; i++)
                    {
                        if (i < goodSpace)
                        {
                            switch (i)
                            {
                                case 0:
                                    result21.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 1:
                                    result22.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 2:
                                    result23.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 3:
                                    result24.BackgroundImage = Image.FromFile("red.png");
                                    break;
                            }
                            k++;
                        }
                    }
                    for (int i = k; i < 4; i++)
                    {
                        if (l < goodTip)
                        {
                            switch (i)
                            {
                                case 0:
                                    result21.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 1:
                                    result22.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 2:
                                    result23.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 3:
                                    result24.BackgroundImage = Image.FromFile("white.png");
                                    break;
                            }
                            l++;
                        }
                    }
                    break;

                case 7:
                    for (int i = 0; i < 4; i++)
                    {
                        if (i < goodSpace)
                        {
                            switch (i)
                            {
                                case 0:
                                    result25.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 1:
                                    result26.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 2:
                                    result27.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 3:
                                    result28.BackgroundImage = Image.FromFile("red.png");
                                    break;
                            }
                            k++;
                        }
                    }
                    for (int i = k; i < 4; i++)
                    {
                        if (l < goodTip)
                        {
                            switch (i)
                            {
                                case 0:
                                    result25.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 1:
                                    result26.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 2:
                                    result27.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 3:
                                    result28.BackgroundImage = Image.FromFile("white.png");
                                    break;
                            }
                            l++;
                        }
                    }
                    break;

                case 8:
                    for (int i = 0; i < 4; i++)
                    {
                        if (i < goodSpace)
                        {
                            switch (i)
                            {
                                case 0:
                                    result29.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 1:
                                    result30.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 2:
                                    result31.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 3:
                                    result32.BackgroundImage = Image.FromFile("red.png");
                                    break;
                            }
                            k++;
                        }
                    }
                    for (int i = k; i < 4; i++)
                    {
                        if (l < goodTip)
                        {
                            switch (i)
                            {
                                case 0:
                                    result29.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 1:
                                    result30.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 2:
                                    result31.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 3:
                                    result32.BackgroundImage = Image.FromFile("white.png");
                                    break;
                            }
                            l++;
                        }
                    }
                    break;

                case 9:
                    for (int i = 0; i < 4; i++)
                    {
                        if (i < goodSpace)
                        {
                            switch (i)
                            {
                                case 0:
                                    result33.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 1:
                                    result34.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 2:
                                    result35.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 3:
                                    result36.BackgroundImage = Image.FromFile("red.png");
                                    break;
                            }
                            k++;
                        }
                    }
                    for (int i = k; i < 4; i++)
                    {
                        if (l < goodTip)
                        {
                            switch (i)
                            {
                                case 0:
                                    result33.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 1:
                                    result34.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 2:
                                    result35.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 3:
                                    result36.BackgroundImage = Image.FromFile("white.png");
                                    break;
                            }
                            l++;
                        }
                    }
                    break;

                case 10:
                    for (int i = 0; i < 4; i++)
                    {
                        if (i < goodSpace)
                        {
                            switch (i)
                            {
                                case 0:
                                    result37.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 1:
                                    result38.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 2:
                                    result39.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 3:
                                    result40.BackgroundImage = Image.FromFile("red.png");
                                    break;
                            }
                            k++;
                        }
                    }
                    for (int i = k; i < 4; i++)
                    {
                        if (l < goodTip)
                        {
                            switch (i)
                            {
                                case 0:
                                    result37.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 1:
                                    result38.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 2:
                                    result39.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 3:
                                    result40.BackgroundImage = Image.FromFile("white.png");
                                    break;
                            }
                            l++;
                        }
                    }
                    break;

                case 11:
                    for (int i = 0; i < 4; i++)
                    {
                        if (i < goodSpace)
                        {
                            switch (i)
                            {
                                case 0:
                                    result41.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 1:
                                    result42.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 2:
                                    result43.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 3:
                                    result44.BackgroundImage = Image.FromFile("red.png");
                                    break;
                            }
                            k++;
                        }
                    }
                    for (int i = k; i < 4; i++)
                    {
                        if (l < goodTip)
                        {
                            switch (i)
                            {
                                case 0:
                                    result41.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 1:
                                    result42.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 2:
                                    result43.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 3:
                                    result44.BackgroundImage = Image.FromFile("white.png");
                                    break;
                            }
                            l++;
                        }
                    }
                    break;

                case 12:
                    for (int i = 0; i < 4; i++)
                    {
                        if (i < goodSpace)
                        {
                            switch (i)
                            {
                                case 0:
                                    result45.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 1:
                                    result46.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 2:
                                    result47.BackgroundImage = Image.FromFile("red.png");
                                    break;
                                case 3:
                                    result48.BackgroundImage = Image.FromFile("red.png");
                                    break;
                            }
                            k++;
                        }
                    }
                    for (int i = k; i < 4; i++)
                    {
                        if (l < goodTip)
                        {
                            switch (i)
                            {
                                case 0:
                                    result45.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 1:
                                    result46.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 2:
                                    result47.BackgroundImage = Image.FromFile("white.png");
                                    break;
                                case 3:
                                    result48.BackgroundImage = Image.FromFile("white.png");
                                    break;
                            }
                            l++;
                        }
                    }
                    break;
            }
            row++;
        }

        private void full()
        {
            goodTip = 0;
            goodSpace = 0;
            int j = 0;
            for (int i = tipedColorPieces-4; i < tipedColorPieces; i++)
            {
                if (tipedColors[i].Color1 == searchedColor[j].Color1)
                {
                    goodSpace++;
                }
                j++;
            }
            if (goodSpace == 4)
            {
                this.end.BackgroundImage = Image.FromFile("win.png");
                end.Visible = true;
                end.Height = 800;
                end.Width = 1400;
                timeTimer.Stop();
                tipRed.Enabled = false;
                tipYellow.Enabled = false;
                tipGreen.Enabled = false;
                tipLightBlue.Enabled = false;
                tipDarkBlue.Enabled = false;
                tipPurple.Enabled = false;
                ok.Enabled = false;
                undo.Enabled = false;
                cover.Visible = false;
                resultsAll.Visible = false;
                points.Visible = false;
                endTimer.Start();
                point();
                points.Text = color.Points.ToString();
            }
            else
            {

                int red = 0;
                if (color.Red1 > 0 && color.Red2 > 0)
                {
                    if (color.Red1 < color.Red2)
                    {
                        red = color.Red1;
                    }
                    else
                    {
                        red = color.Red2;
                    }
                }
                int yellow = 0;
                if (color.Yellow1 > 0 && color.Yellow2 > 0)
                {
                    if (color.Yellow1 < color.Yellow2)
                    {
                        yellow = color.Yellow1;
                    }
                    else
                    {
                        yellow = color.Yellow2;
                    }
                }
                int green = 0;
                if (color.Green1 > 0 && color.Green2 > 0)
                {
                    if (color.Green1 < color.Green2)
                    {
                        green = color.Green1;
                    }
                    else
                    {
                        green = color.Green2;
                    }
                }
                int lightBlue = 0;
                if (color.LightBlue1 > 0 && color.LightBlue2 > 0)
                {
                    if (color.LightBlue1 < color.LightBlue2)
                    {
                        lightBlue = color.LightBlue1;
                    }
                    else
                    {
                        lightBlue = color.LightBlue2;
                    }
                }
                int darkBlue = 0;
                if (color.DarkBlue1 > 0 && color.DarkBlue2 > 0)
                {
                    if (color.DarkBlue1 < color.DarkBlue2)
                    {
                        darkBlue = color.DarkBlue1;
                    }
                    else
                    {
                        darkBlue = color.DarkBlue2;
                    }
                }
                int purple = 0;
                if (color.Purple1 > 0 && color.Purple2 > 0)
                {
                    if (color.Purple1 < color.Purple2)
                    {
                        purple = color.Purple1;
                    }
                    else
                    {
                        purple = color.Purple2;
                    }
                }

                goodTip = red + yellow + green + lightBlue + darkBlue + purple - goodSpace;

                if (goodTip < 0)
                {
                    goodTip = 0;
                }
                color.Red2 = 0;
                color.Yellow2 = 0;
                color.Green2 = 0;
                color.LightBlue2 = 0;
                color.DarkBlue2 = 0;
                color.Purple2 = 0;
            }
        }

        private void point()
        {
            color.Points = 13-row + color.Points;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (actual >= 4)
            {
                full();
                actual = 0;
                fullRow = true;
                results();
                if (tipedColorPieces >= 52 && goodSpace != 4)
                {
                    this.end.BackgroundImage = Image.FromFile("lose.png");
                    end.Visible = true;
                    end.Height = 800;
                    end.Width = 1400;
                    timeTimer.Stop();
                    tipRed.Enabled = false;
                    tipYellow.Enabled = false;
                    tipGreen.Enabled = false;
                    tipLightBlue.Enabled = false;
                    tipDarkBlue.Enabled = false;
                    tipPurple.Enabled = false;
                    ok.Enabled = false;
                    undo.Enabled = false;
                    cover.Visible = false;
                    resultsAll.Visible = false;
                    points.Visible = false;
                    endTimer.Start();
                }
            }
        }

        //Restart
        private void restart_Click(object sender, EventArgs e)
        {
            color.Red2 = 0;
            color.Yellow2 = 0;
            color.Green2 = 0;
            color.LightBlue2 = 0;
            color.DarkBlue2 = 0;
            color.Purple2 = 0;

            color.Red1 = 0;
            color.Yellow1 = 0;
            color.Green1 = 0;
            color.LightBlue1 = 0;
            color.DarkBlue1 = 0;
            color.Purple1 = 0;
            Close();
            th = new Thread(openGame);
            th.Start();
        }

        private void openGame()
        {
            Application.Run(new game());
        }
        //------------------------ 

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            int min = 0;
            int hour = 0;
            sec++;
            int sec2 = sec;
            while (sec2 >= 60)
            {
                if (sec2 >= 3600)
                {
                    hour++;
                    sec2 = sec2 - 3600;
                }
                else if (sec2 >= 60)
                {
                    min++;
                    sec2 = sec2 - 60;
                }
            }
            string timeString = "";
            if (hour != 0)
            {
                timeString = hour + ":" + min + ":" + sec2;
            }
            else if(sec2 < 10)
            {
                timeString = min + ":0" + sec2;
            }
            else
            {
                timeString = min + ":" + sec2;
            }
            time.Text = timeString;
        }

        private void game_Load(object sender, EventArgs e)
        {
            points.Text = color.Points.ToString();
        }
    }
}