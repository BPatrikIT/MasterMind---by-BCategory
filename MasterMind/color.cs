using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class color
    {
        private int IDNumber;
        private string Color;
        private int pos;

        private static int points = 0;

        private static int red1;
        private static int red2;
        private static int yellow1;
        private static int yellow2;
        private static int green1;
        private static int green2;
        private static int lightBlue1;
        private static int lightBlue2;
        private static int darkBlue1;
        private static int darkBlue2;
        private static int purple1;
        private static int purple2;

        public static int Red1 { get => red1; set => red1 = value; }
        public static int Red2 { get => red2; set => red2 = value; }
        public static int Yellow1 { get => yellow1; set => yellow1 = value; }
        public static int Yellow2 { get => yellow2; set => yellow2 = value; }
        public static int Green1 { get => green1; set => green1 = value; }
        public static int Green2 { get => green2; set => green2 = value; }
        public static int LightBlue1 { get => lightBlue1; set => lightBlue1 = value; }
        public static int LightBlue2 { get => lightBlue2; set => lightBlue2 = value; }
        public static int DarkBlue1 { get => darkBlue1; set => darkBlue1 = value; }
        public static int DarkBlue2 { get => darkBlue2; set => darkBlue2 = value; }
        public static int Purple1 { get => purple1; set => purple1 = value; }
        public static int Purple2 { get => purple2; set => purple2 = value; }

        public color(int iDNumber, int Pos, bool searched)
        {
            IDNumber = iDNumber;
            pos = Pos;
            switch (pos)
            {
                case 1:
                    Color = "Purple";
                    if (searched)
                    {
                        purple1++;
                    }
                    else
                    {
                        purple2++;
                    }
                    break;
                case 2:
                    Color = "DarkBlue";
                    if (searched)
                    {
                        darkBlue1++;
                    }
                    else
                    {
                        darkBlue2++;
                    }
                    break;
                case 3:
                    Color = "LightBlue";
                    if (searched)
                    {
                        lightBlue1++;
                    }
                    else
                    {
                        lightBlue2++;
                    }
                    break;
                case 4:
                    Color = "Yellow";
                    if (searched)
                    {
                        yellow1++;
                    }
                    else
                    {
                        yellow2++;
                    }
                    break;
                case 5:
                    Color = "Red";
                    if (searched)
                    {
                        red1++;
                    }
                    else
                    {
                        red2++;
                    }
                    break;
                case 6:
                    Color = "Green";
                    if (searched)
                    {
                        green1++;
                    }
                    else
                    {
                        green2++;
                    }
                    break;
            }
        }

        public int IDNumber1 { get => IDNumber; set => IDNumber = value; }
        public string Color1 { get => Color; set => Color = value; }
        public static int Points { get => points; set => points = value; }
    }
}