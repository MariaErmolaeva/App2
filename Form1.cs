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
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            
        }

        private void addCharacters_Click(object sender, EventArgs e)
        {
            

            
        }
    }
}
