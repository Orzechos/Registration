using Registration.Model;
using Registration.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Registration.View
{
    public partial class EditForm : Form, IEditView
    {
        private IEditPresenter _presenter;
        private PatientModel _patientModel;
        private bool _isEditing = true;

        public EditForm()
        {
            InitializeComponent();
        }

        public PatientModel Patient
        {
            set
            {
                _patientModel = value;

                tbName.Text = value.Name;
                tbSurname.Text = value.Surname;
                tbPesel.Text = value.Pesel;
                tbEmail.Text = value.Email;
                tbAddress.Text = value.Address;
                tbPhoneNumber.Text = value.PhoneNumber;
            }
            get
            {
                _patientModel.Name = tbName.Text;
                _patientModel.Surname = tbSurname.Text;
                _patientModel.Pesel = tbPesel.Text;
                _patientModel.Email = tbEmail.Text;
                _patientModel.Address = tbAddress.Text;
                _patientModel.PhoneNumber = tbPhoneNumber.Text;

                return _patientModel;
            }
        }

        public IPresenter Presenter
        {
            set
            {
                _presenter = value as IEditPresenter;
            }
        }

        public bool Enabled
        {
            set
            {
                _isEditing = value;

                this.Text = value ? "Edit" : "View";
                bSave.Text = value ? "Save" : "Modify";

                tbName.Enabled = value;
                tbSurname.Enabled = value;
                tbPesel.Enabled = value;
                tbEmail.Enabled = value;
                tbAddress.Enabled = value;
                tbPhoneNumber.Enabled = value;
            }
            get
            {
                return _isEditing;
            }
        }

        public void BlockSaveButton()
        {
            bSave.Enabled = false;
        }

        public void Close()
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            _presenter.SaveClick();
        }

        private void tbPesel_Validating(object sender, CancelEventArgs e)
        {
            bool res = false;

            if (tbPesel.Text.Length == 11)
            {
                res = CountSum(tbPesel.Text).Equals(tbPesel.Text[10].ToString());
            }

           ValidTextBox(sender as TextBox, res);
        }

        private void ValidTextBox(TextBox tb, bool res)
        {
            if (!res)
            {
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.BackColor = Color.White;
            }
        }

        private static string CountSum(string pesel)
        {
            int[] multiplier = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

            int sum = 0;
            for (int i = 0; i < multiplier.Length; i++)
            {
                sum += multiplier[i] * int.Parse(pesel[i].ToString());
            }

            int other = sum % 10;
            return other == 0 ? other.ToString() : (10 - other).ToString();
        }

        private void tbPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            Regex rg = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");
            Match match = rg.Match(tb.Text);

            ValidTextBox(tb, match.Success);
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(tb.Text);

            ValidTextBox(tb, match.Success);
        }
    }
}
