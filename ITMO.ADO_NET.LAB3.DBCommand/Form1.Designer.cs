
namespace ITMO.ADO_NET.LAB3.DBCommand
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.FillTableButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.UpdateValueButton = new System.Windows.Forms.Button();
            this.AcceptChangesButton = new System.Windows.Forms.Button();
            this.RejectChangesButton = new System.Windows.Forms.Button();
            this.CellValueTextBox = new System.Windows.Forms.TextBox();
            this.OriginalDRVTextBox = new System.Windows.Forms.TextBox();
            this.CurrentDRVTextBox = new System.Windows.Forms.TextBox();
            this.RowStateTextBox = new System.Windows.Forms.TextBox();
            this.adwetureWorksDataSet1 = new ITMO.ADO_NET.LAB3.DBCommand.AdwetureWorksDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adwetureWorksDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=WIN-OIIDCJK0MB5\\SQLEXPRESS;Initial Catalog=AdventureWorks2014;Integra" +
    "ted Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // FillTableButton
            // 
            this.FillTableButton.Location = new System.Drawing.Point(12, 4);
            this.FillTableButton.Name = "FillTableButton";
            this.FillTableButton.Size = new System.Drawing.Size(274, 24);
            this.FillTableButton.TabIndex = 10;
            this.FillTableButton.Text = "Перечень заказчиков и их контактные телефоны";
            this.FillTableButton.UseVisualStyleBackColor = true;
            this.FillTableButton.Click += new System.EventHandler(this.FillTableButton_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(292, 4);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(154, 24);
            this.AddRowButton.TabIndex = 11;
            this.AddRowButton.Text = "Добавить Заказчика";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Location = new System.Drawing.Point(12, 34);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.Size = new System.Drawing.Size(477, 378);
            this.CustomersDataGridView.TabIndex = 12;
            this.CustomersDataGridView.Click += new System.EventHandler(this.CustomersDataGridView_Click);
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // sqlDataAdapter2
            // 
            this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Person", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("BusinessEntityID", "BusinessEntityID"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("MiddleName", "MiddleName"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber")})});
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.Location = new System.Drawing.Point(636, 56);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(124, 23);
            this.DeleteRowButton.TabIndex = 13;
            this.DeleteRowButton.Text = "Удалить строку";
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // UpdateValueButton
            // 
            this.UpdateValueButton.Location = new System.Drawing.Point(636, 85);
            this.UpdateValueButton.Name = "UpdateValueButton";
            this.UpdateValueButton.Size = new System.Drawing.Size(124, 23);
            this.UpdateValueButton.TabIndex = 14;
            this.UpdateValueButton.Text = "Обновить значение";
            this.UpdateValueButton.UseVisualStyleBackColor = true;
            this.UpdateValueButton.Click += new System.EventHandler(this.UpdateValueButton_Click);
            // 
            // AcceptChangesButton
            // 
            this.AcceptChangesButton.Location = new System.Drawing.Point(636, 114);
            this.AcceptChangesButton.Name = "AcceptChangesButton";
            this.AcceptChangesButton.Size = new System.Drawing.Size(124, 23);
            this.AcceptChangesButton.TabIndex = 15;
            this.AcceptChangesButton.Text = "Сохранить изменения";
            this.AcceptChangesButton.UseVisualStyleBackColor = true;
            this.AcceptChangesButton.Click += new System.EventHandler(this.AcceptChangesButton_Click);
            // 
            // RejectChangesButton
            // 
            this.RejectChangesButton.Location = new System.Drawing.Point(636, 143);
            this.RejectChangesButton.Name = "RejectChangesButton";
            this.RejectChangesButton.Size = new System.Drawing.Size(124, 23);
            this.RejectChangesButton.TabIndex = 16;
            this.RejectChangesButton.Text = "Отменить изменения";
            this.RejectChangesButton.UseVisualStyleBackColor = true;
            this.RejectChangesButton.Click += new System.EventHandler(this.RejectChangesButton_Click);
            // 
            // CellValueTextBox
            // 
            this.CellValueTextBox.Location = new System.Drawing.Point(495, 58);
            this.CellValueTextBox.Name = "CellValueTextBox";
            this.CellValueTextBox.Size = new System.Drawing.Size(135, 20);
            this.CellValueTextBox.TabIndex = 17;
            // 
            // OriginalDRVTextBox
            // 
            this.OriginalDRVTextBox.Location = new System.Drawing.Point(495, 87);
            this.OriginalDRVTextBox.Name = "OriginalDRVTextBox";
            this.OriginalDRVTextBox.Size = new System.Drawing.Size(135, 20);
            this.OriginalDRVTextBox.TabIndex = 18;
            // 
            // CurrentDRVTextBox
            // 
            this.CurrentDRVTextBox.Location = new System.Drawing.Point(495, 116);
            this.CurrentDRVTextBox.Name = "CurrentDRVTextBox";
            this.CurrentDRVTextBox.Size = new System.Drawing.Size(135, 20);
            this.CurrentDRVTextBox.TabIndex = 19;
            // 
            // RowStateTextBox
            // 
            this.RowStateTextBox.Location = new System.Drawing.Point(495, 145);
            this.RowStateTextBox.Name = "RowStateTextBox";
            this.RowStateTextBox.Size = new System.Drawing.Size(135, 20);
            this.RowStateTextBox.TabIndex = 20;
            // 
            // adwetureWorksDataSet1
            // 
            this.adwetureWorksDataSet1.DataSetName = "AdwetureWorksDataSet";
            this.adwetureWorksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RowStateTextBox);
            this.Controls.Add(this.CurrentDRVTextBox);
            this.Controls.Add(this.OriginalDRVTextBox);
            this.Controls.Add(this.CellValueTextBox);
            this.Controls.Add(this.RejectChangesButton);
            this.Controls.Add(this.AcceptChangesButton);
            this.Controls.Add(this.UpdateValueButton);
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.CustomersDataGridView);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.FillTableButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adwetureWorksDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button FillTableButton;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.DataGridView CustomersDataGridView;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
        private AdwetureWorksDataSet adwetureWorksDataSet1;
        private System.Windows.Forms.Button DeleteRowButton;
        private System.Windows.Forms.Button UpdateValueButton;
        private System.Windows.Forms.Button AcceptChangesButton;
        private System.Windows.Forms.Button RejectChangesButton;
        private System.Windows.Forms.TextBox CellValueTextBox;
        private System.Windows.Forms.TextBox OriginalDRVTextBox;
        private System.Windows.Forms.TextBox CurrentDRVTextBox;
        private System.Windows.Forms.TextBox RowStateTextBox;
    }
}

