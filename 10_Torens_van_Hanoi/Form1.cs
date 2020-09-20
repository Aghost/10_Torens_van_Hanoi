using System;
using System.Windows.Forms;

namespace _10_Torens_van_Hanoi
{
    public partial class Form1 : Form
    {
        char[] StickA = { '1', '2', '3' };
        char[] StickB = { ' ', ' ', ' ' };
        char[] StickC = { ' ', ' ', ' ' };


        public Form1()
        {
            InitializeComponent();
            Init_Stick();

            H_Move(3, 'A', 'C', 'B');
            PrintSticks();
        }

        private void Init_Stick()
        {

        }

        private void H_Move (int n, char from, char to, char via)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move from:{from} to:{to}");

            } else
            {
                H_Move(n -1, from, via, to);
                H_Move(1, from, to, via);
                H_Move(n -1, via, to, from);
            }

        }

        private void PrintSticks()
        {
            char[][] Sticks = { StickA, StickB, StickC };

            foreach (char[] stick in Sticks)
            {
                foreach (char chr in stick)
                {
                    Console.Write(chr);
                }

                Console.WriteLine("");
            }
        }

    }
}
