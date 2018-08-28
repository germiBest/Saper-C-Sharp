using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper
{
    public partial class Form1 : Form
    {
        int height = 10;
        int width = 10;
        int distanceBetweenButtons = 35;
        ButtonExtended[,] allButtons;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allButtons = new ButtonExtended[width, height];
            Random rng = new Random();
            for(int x = 10; (x-10) < width * distanceBetweenButtons; x += distanceBetweenButtons)
            {
                for (int y = 10; (y- 10) < height * distanceBetweenButtons; y += distanceBetweenButtons)
                {
                    ButtonExtended button = new ButtonExtended();
                    button.Location = new Point(x, y);
                    button.Size = new Size(30, 30);

                    if(rng.Next(0, 101) < 20)
                    {
                        button.isBomb = true;
                    }
                    allButtons[(x-10)/distanceBetweenButtons, (y-10)/distanceBetweenButtons] = button;
                    Controls.Add(button);
                    button.Click += new EventHandler(FieldClick);
                }
            }
        }
        void FieldClick(object sender, EventArgs e)
        {
            ButtonExtended button = (ButtonExtended)sender;
            if (button.isBomb)
            {
                Explore(button);
            }
            else
            {
                EmptyFieldClick(button);
            }
        }
        class ButtonExtended : Button
        {
            public bool isBomb;
        }
        private void Explore(ButtonExtended button)
        {
            button.BackColor = Color.Red;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (allButtons[x, y].isBomb)
                    {
                        allButtons[x, y].Text = "💣";
                    }
                }
            }
            MessageBox.Show("You lose");
            Application.Restart();
        }
        private void EmptyFieldClick(ButtonExtended button)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (allButtons[x, y] == button)
                    {
                        button.Text = "" + CountBombsAround(x, y);
                    }
                }
            }
        }
        int CountBombsAround(int xB, int yB)
        {
            int BombCount = 0;
            for (int x = xB - 1; x <= xB + 1; x++)
            {
                for (int y = yB - 1; y <= yB + 1; y++)
                {
                    if(x >= 0 && x < width && y >= 0 && y < height)
                    if (allButtons[x, y].isBomb)
                    {
                        BombCount++;
                    }
                }
            }
            return BombCount;
        }
        
    }
    
}
