using System;
using System.Windows.Forms;
using Registration.Presenter;

namespace Registration.View
{
    public partial class LoginForm : Form, ILoginView
    {
        public ILoginPresenter _presenter;

        public LoginForm()
        {
            InitializeComponent();
        }

        public string LoginName
        {
            get
            {
                return this.tbLogin.Text;
            }

            set
            {
                this.tbLogin.Text = value;
            }
        }   

        public string Password
        {
            get
            {
                return this.tbPassword.Text;
            }

            set
            {
                this.tbPassword.Text = value;
            }
        }

        public IPresenter Presenter { set
            {
                _presenter = value as ILoginPresenter;
            }
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            _presenter.LoginClick();
        }

        private void tbs_TextChanged(object sender, EventArgs e)
        {
            bLogin.Enabled = tbLogin.Text.Length > 5 && tbPassword.Text.Length >= 5;
        }
    }
}
