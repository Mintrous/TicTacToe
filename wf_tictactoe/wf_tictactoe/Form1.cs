using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_tictactoe
{
    public partial class Form1 : Form
    {
        public string player = "X";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string inverte_Player()
        {
            if(player == "X")
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        public void zerar()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            player = "X";
        }

        public void ganhar()
        {
            MessageBox.Show("JOGADOR    [ " + player + " ]    GANHOU!");
            zerar();
        }

        public bool verificar(string jogador)
        {
            if(button1.Text == jogador && button4.Text == jogador && button7.Text == jogador)
            {
                ganhar();
                return true;
            }
            if (button2.Text == jogador && button5.Text == jogador && button8.Text == jogador)
            {
                ganhar();
                return true;
            }
            if (button3.Text == jogador && button6.Text == jogador && button9.Text == jogador)
            {
                ganhar();
                return true;
            }
            if (button1.Text == jogador && button2.Text == jogador && button3.Text == player)
            {
                ganhar();
                return true;
            }
            if (button4.Text == jogador && button5.Text == jogador && button6.Text == jogador)
            {
                ganhar();
                return true;
            }
            if (button7.Text == jogador && button8.Text == jogador && button9.Text == jogador)
            {
                ganhar();
                return true;
            }
            if (button1.Text == jogador && button5.Text == jogador && button9.Text == jogador)
            {
                ganhar();
                return true;
            }
            if (button3.Text == jogador && button5.Text == jogador && button7.Text == jogador)
            {
                ganhar();
                return true;
            }
            if(button1.Text.Length != 0 && button2.Text.Length != 0 && button3.Text.Length != 0 && button4.Text.Length != 0 && button5.Text.Length != 0 && button6.Text.Length != 0 && button7.Text.Length != 0 && button8.Text.Length != 0 && button9.Text.Length != 0)
            {
                MessageBox.Show("DEU VELHA!");
                zerar();
                return true;
            }
            player = inverte_Player();
            label1.Text = "JOGADOR: " + player;
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "")
            {
                button2.Text = player;
                verificar(player);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            zerar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = player;
                verificar(player);
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = player;
                verificar(player);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = player;
                verificar(player);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = player;
                verificar(player);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = player;
                verificar(player);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = player;
                verificar(player);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = player;
                verificar(player);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = player;
                verificar(player);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
