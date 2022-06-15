using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLabs_TheCompany
{
    public partial class MainForm : Form
    {
        
        public PersonEntry PersonForm;

        public MainForm()
        {
            InitializeComponent();
            StartUp();
        }

        void StartUp()
        {
            PersonForm = new PersonEntry();
        }

        private void bt_AddPerson_Click(object sender, EventArgs e)
        {

            //DBMngr.StartDB();
            //DBMngr.GetAllPersons();
            PersonForm.Show();
        }
    }
}
