using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class Form1 : Form
    {
        Presenter presentor;
        List<Characters> characters;

        public Form1()
        {
            InitializeComponent();
            presentor = new Presenter(new Action());
            characters = new List<Characters>();

            presentor.MainView(new MainView());
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != null)
            {
                mainText.Text += presentor.Attack(characters[listBox1.SelectedIndex]);
            }
            else
                MessageBox.Show("Выберите персонажа из списка персонажей");

        }

        private void addCharacters_Click(object sender, EventArgs e)
        {
            presentor.AddCharacters(name.Text, comboBox1.Text, comboBox2.Text, characters);

            int count = characters.Count;
            listBox1.Items.Add(characters.Last().nameGet + ": ");

        }


        private void run_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != null)
            {
                mainText.Text += presentor.Run(characters[listBox1.SelectedIndex]);
            }
            else
                MessageBox.Show("Выберите персонажа из списка персонажей");
        }

        private void health_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != null)
            {
                mainText.Text += presentor.Health(characters[listBox1.SelectedIndex]);
            }
            else
                MessageBox.Show("Выберите персонажа из списка персонажей");
        }


    }
}
