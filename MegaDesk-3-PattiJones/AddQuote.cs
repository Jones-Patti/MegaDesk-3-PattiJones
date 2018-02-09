using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_PattiJones
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            //populate combobox calling enums from the desk class. Ex combobox.dataSource;
            comboBox1.DataSource = Enum.GetValues(typeof(Desk.Material));
            comboBox2.DataSource = Enum.GetValues(typeof(DeskQuote.Delivery));
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            //var mainMenu = (System.Windows.Forms.MainMenu)Tag;
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GetQuote_Click(object sender, EventArgs e)
        {

        }
    }
}
