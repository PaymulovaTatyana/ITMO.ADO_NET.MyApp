using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITMO.ADO_NET.LAB3.DBCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomersDataGridView.DataSource = adwetureWorksDataSet1.Person;
            CustomersDataGridView.MultiSelect = false;
            CustomersDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            CustomersDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void FillTableButton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter2.Fill(adwetureWorksDataSet1.Person);

        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            AdwetureWorksDataSet.PersonRow NewRow =(AdwetureWorksDataSet.PersonRow)adwetureWorksDataSet1.Person.NewRow();
            NewRow.BusinessEntityID = 20778;
            NewRow.FirstName = "Tatyana";
            NewRow.MiddleName = "Aleksandrovna";
            NewRow.LastName = "Paymulova";
            try
            {
                adwetureWorksDataSet1.Person.Rows.Add(NewRow);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Row Failed");
            }

        }
        private AdwetureWorksDataSet.PersonRow GetSelectedRow()
        {
            String SelectedBusinessEntityID = CustomersDataGridView.CurrentRow.Cells["BusinessEntityID"].Value.ToString();
            AdwetureWorksDataSet.PersonRow SelectedRow = adwetureWorksDataSet1.Person.FindByBusinessEntityID(int.Parse(SelectedBusinessEntityID));
            return SelectedRow;
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().Delete();
        }
        private void UpdateRowVersionDisplay()
        {
            try
            {
                CurrentDRVTextBox.Text = GetSelectedRow()[CustomersDataGridView.CurrentCell.OwningColumn.Name, DataRowVersion.Current].ToString();
            }
            catch (Exception ex)
            {
                CurrentDRVTextBox.Text = ex.Message;
            }
            try
            {
                OriginalDRVTextBox.Text = GetSelectedRow()[CustomersDataGridView.CurrentCell.OwningColumn.Name, DataRowVersion.Original].ToString();
            }
            catch (Exception ex)
            {
                OriginalDRVTextBox.Text = ex.Message;
            }
            RowStateTextBox.Text = GetSelectedRow().RowState.ToString();

        }

        private void UpdateValueButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow()[CustomersDataGridView.CurrentCell.OwningColumn.Name] = CellValueTextBox.Text;
            UpdateRowVersionDisplay();

        }

        private void CustomersDataGridView_Click(object sender, EventArgs e)
        {
            CellValueTextBox.Text = CustomersDataGridView.CurrentCell.Value.ToString();
            UpdateRowVersionDisplay();
        }

        private void AcceptChangesButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().AcceptChanges();
            UpdateRowVersionDisplay();
        }

        private void RejectChangesButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().RejectChanges();
            UpdateRowVersionDisplay();

        }
    }
}
