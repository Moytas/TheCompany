using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLabs_TheCompany
{
    public partial class PowersForm : Form
    {
        PowersManager _powersManager = new PowersManager();

        public PowersForm()
        {
            InitializeComponent();
        }

        private void StartUp()
        {
            tb_Power.Visible = false;
            tb_PowerDescription.Visible = false;
            lb_Powers.Items.Clear();
            List<string> _powers = _powersManager.GetAllPowers();
            for (int i = 0; i < _powers.Count; i++)
            {
                lb_Powers.Items.Add(_powers[i]);
            }

            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(!tb_Power.Visible && !tb_PowerDescription.Visible)
            {
                tb_Power.Visible = true;
                tb_PowerDescription.Visible = true;
                btn_Add.Text = "Confirm";
            }
            else
            {
                btn_Add.Text = "Add New";
                tb_Power.Visible = false;
                tb_PowerDescription.Visible = false;
                if (tb_Power.Text != "" && tb_Power.Text != string.Empty && tb_PowerDescription.Text != string.Empty && tb_PowerDescription.Text != "")
                {
                    _powersManager.AddPower(tb_Power.Text, tb_PowerDescription.Text); 
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
