using Registration.Model;
using Registration.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Registration.View
{
    public partial class ListForm : Form, IListView
    {
        private IListPresenter _presenter;
        private Action _close;

        public ListForm()
        {
            InitializeComponent();
        }

        public IEnumerable<PatientModel> Patient
        {
            set
            {
                dgPatients.Rows.Clear();

                foreach (var item in value)
                {
                    dgPatients.Rows.Add(new object[] { item.Id, item.Name, item.Surname });
                }
            }
        }
        public IPresenter Presenter { set
            {
                _presenter = value as IListPresenter;
            }
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            _presenter.AddNew();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if(e.RowIndex == senderGrid.Rows.Count - 1)
            {
                return;
            }


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                senderGrid.Columns[e.ColumnIndex].Name == "View" &&
                e.RowIndex >= 0)
            {              
                _presenter.ShowPatient(new Guid(senderGrid[0, e.RowIndex].Value.ToString()));
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                senderGrid.Columns[e.ColumnIndex].Name == "Remove" &&
                e.RowIndex >= 0)
            {
                _presenter.RemovePatient(new Guid(senderGrid[0, e.RowIndex].Value.ToString()));
            }
        }

        public void BlockEdit()
        {
            bAdd.Enabled = false;
            dgPatients.Columns.RemoveAt(dgPatients.Columns.Count - 1);
        }
    }
}
