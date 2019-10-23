using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App2
{
    public partial class Form1 : Form, IMainView
    {

        public event EventHandler AttackClick;
        public event EventHandler RunClick;
        public event EventHandler HealthClick;
        public event EventHandler CreateCharactersClick;


        public int index
        {
            get
            {
                if (listBox1.SelectedIndex != -1)
                    return listBox1.SelectedIndex;
                else
                    return -1;
            }
        }

        public string nameCharacters
        {
            get
            {
                if (name.Text != null)
                    return name.Text;
                else
                    return null;
            }
        }

        public string race
        {
            get
            {
                if (comboBox1.Text != null)
                    return comboBox1.Text;
                else
                    return null;
            }
        }

        public string type
        {
            get
            {
                if (comboBox2.Text != null)
                    return comboBox2.Text;
                else
                    return null;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }


        void addCharacters_Click(object sender, EventArgs e)
        {
            if (CreateCharactersClick != null)
                CreateCharactersClick(this, EventArgs.Empty);
        }

        void Attack_Click(object sender, EventArgs e)
        {
            if (AttackClick != null)
                AttackClick(this, EventArgs.Empty);
        }

        void run_Click(object sender, EventArgs e)
        {
            if (RunClick != null)
                RunClick(this, EventArgs.Empty);
        }

        void health_Click(object sender, EventArgs e)
        {
            if (HealthClick != null)
                HealthClick(this, EventArgs.Empty);
        }


        public void OnSuccessRun(Characters characters)
        {
            MessageBox.Show("Успешный забег");
            mainText.Text += characters.nameGet + " пробежит за " + characters.timeSetGet + " часа";
        }

        public void OnSuccessAttack(Characters characters)
        {
            MessageBox.Show("Успешная атака");
            mainText.Text += characters.nameGet + " атакует на " + characters.attackSetGet + " XP";
        }

        public void OnSuccessHealth(Characters characters)
        {
            MessageBox.Show("Успешное лечение");
            mainText.Text += characters.nameGet + " вылечится на " + characters.attackSetGet + " XP";
        }

        public void OnSuccessCreateCharacters(Characters characters)
        {
            MessageBox.Show("Персонаж добавлен");
            listBox1.Items.Add(characters.nameGet);
        }



    }
}
