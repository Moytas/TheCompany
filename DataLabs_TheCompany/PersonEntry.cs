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
    public partial class PersonEntry : Form
    {
        public DBManager DBMngr = new DBManager();
        // public EventHandler textChanged;
        // public event textAltered = new EventHandler<EventArgs>;
        private PowersForm _powersForm = new PowersForm();
        private FlawsForm _flawsForm = new FlawsForm();
        private Form2 _form2 = new Form2();

        private PersonManager _personsManager = new PersonManager();
        private PowersManager _powersManager = new PowersManager();
        private bool isSuper = false;
        private Timer _timer = new Timer();

        public PersonEntry()
        {
            InitializeComponent();
            StartUp();
            GetDB();
        }

        private void StartUp()
        {
            lbl_Messages.Text = DBMngr.StartDB();
            lb_Power.SelectedIndex = -1;
            lb_Power.Items.Clear();
            List<string> _powers = _powersManager.GetAllPowers();

            if(_powers.Count == 0)
            {
                _powersManager.AddPower("Unknown");
                lb_Power.Items.Add("Unknown");
            }
            else
            {
                for(int i = 0; i < _powers.Count; i++)
                {
                    lb_Power.Items.Add(_powers[i]);
                }
            }

            cb_Flaw.SelectedIndex = -1;
            cb_Flaw.Items.Clear();
            List<string> _flaws = _powersManager.GetAllFlaws();
            if(_flaws.Count == 0)
            {
                _flaws.Add("Unknown");
                cb_Flaw.Items.Add("Unknown");
            }
            else
            {
                for (int i = 0; i < _flaws.Count; i++)
                {
                    cb_Flaw.Items.Add(_flaws[i]);
                }
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(isSuper)
            {
                if (FieldsFilled())
                {
                    Supers newEntry = new Supers();
                    _personsManager.Add(newEntry);
                }
                else
                {
                    ShowWarning("Error");
                }
            }
            else
            {
                if (FieldsFilled())
                {
                    Person newEntry = new Person();
                    newEntry.FirstName = tb_FirstName.Text;
                    _personsManager.Add(newEntry);
                }
                else
                {
                    ShowWarning("Error");
                }
            }
        }

        private void ShowWarning(string warning)
        {
            lbl_Warning.Text = warning;
            lbl_Warning.Visible = true;
            _timer.Interval = 1500;
            _timer.Start();
            
            _timer.Tick += _timer_Tick;
        
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            lbl_Warning.Text = "";
            lbl_Warning.Visible = false;
        }

        private bool FieldsFilled()
        {
            if(lb_Power.SelectedIndex != -1 || cb_Flaw.SelectedIndex != -1)
            {
                isSuper = true;
            }
            else
            {
                isSuper = false;
            }

            if(tb_FirstName.Text != string.Empty && tb_FirstName.Text != "")
            {
                if(tb_LastName.Text != string.Empty && tb_LastName.Text != "")
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_PowerEdit_Click(object sender, EventArgs e)
        {

        }

        private void btn_FlawEdit_Click(object sender, EventArgs e)
        {

        }

        private void btn_ShowList_Click(object sender, EventArgs e)
        {
           
                _personsManager.PeopleList[0].ChangeGender();
           
        }

        private void tb_FirstName_TextChanged(object sender, EventArgs e)
        {
            if(tb_FirstName.Text.Length > 5)
            {
            }
        }

        private void GetDB()
        {
            Person p = new Person();
            //
        }
    }
}
