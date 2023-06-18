namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            kodyDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kodPocztowyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            miejscowoscDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wojewodztwoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            powiatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kodyPocztoweBindingSource = new BindingSource(components);
            resultDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            idTextBox = new TextBox();
            kodPocztowyTextBox = new TextBox();
            adresTextBox = new TextBox();
            powiatTextBox = new TextBox();
            wojewodztwoTextBox = new TextBox();
            miejscowoscTextBox = new TextBox();
            idLabel = new Label();
            kodPocztowyLabel = new Label();
            adresLabel = new Label();
            miejscowoscLabel = new Label();
            wojewodztwoLabel = new Label();
            powiatLabel = new Label();
            efSearchButton = new Button();
            label1 = new Label();
            label2 = new Label();
            adonetSearchButton = new Button();
            dapperSearchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)kodyDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kodyPocztoweBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // kodyDataGridView
            // 
            kodyDataGridView.AllowUserToAddRows = false;
            kodyDataGridView.AllowUserToDeleteRows = false;
            kodyDataGridView.AutoGenerateColumns = false;
            kodyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kodyDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, kodPocztowyDataGridViewTextBoxColumn, adresDataGridViewTextBoxColumn, miejscowoscDataGridViewTextBoxColumn, wojewodztwoDataGridViewTextBoxColumn, powiatDataGridViewTextBoxColumn });
            kodyDataGridView.DataSource = kodyPocztoweBindingSource;
            kodyDataGridView.Location = new Point(12, 44);
            kodyDataGridView.Name = "kodyDataGridView";
            kodyDataGridView.ReadOnly = true;
            kodyDataGridView.RowTemplate.Height = 25;
            kodyDataGridView.Size = new Size(646, 534);
            kodyDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodPocztowyDataGridViewTextBoxColumn
            // 
            kodPocztowyDataGridViewTextBoxColumn.DataPropertyName = "KodPocztowy";
            kodPocztowyDataGridViewTextBoxColumn.HeaderText = "KodPocztowy";
            kodPocztowyDataGridViewTextBoxColumn.Name = "kodPocztowyDataGridViewTextBoxColumn";
            kodPocztowyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            adresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // miejscowoscDataGridViewTextBoxColumn
            // 
            miejscowoscDataGridViewTextBoxColumn.DataPropertyName = "Miejscowosc";
            miejscowoscDataGridViewTextBoxColumn.HeaderText = "Miejscowosc";
            miejscowoscDataGridViewTextBoxColumn.Name = "miejscowoscDataGridViewTextBoxColumn";
            miejscowoscDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wojewodztwoDataGridViewTextBoxColumn
            // 
            wojewodztwoDataGridViewTextBoxColumn.DataPropertyName = "Wojewodztwo";
            wojewodztwoDataGridViewTextBoxColumn.HeaderText = "Wojewodztwo";
            wojewodztwoDataGridViewTextBoxColumn.Name = "wojewodztwoDataGridViewTextBoxColumn";
            wojewodztwoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // powiatDataGridViewTextBoxColumn
            // 
            powiatDataGridViewTextBoxColumn.DataPropertyName = "Powiat";
            powiatDataGridViewTextBoxColumn.HeaderText = "Powiat";
            powiatDataGridViewTextBoxColumn.Name = "powiatDataGridViewTextBoxColumn";
            powiatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodyPocztoweBindingSource
            // 
            kodyPocztoweBindingSource.DataSource = typeof(Models.KodyPocztowe);
            // 
            // resultDataGridView
            // 
            resultDataGridView.AllowUserToAddRows = false;
            resultDataGridView.AllowUserToDeleteRows = false;
            resultDataGridView.AutoGenerateColumns = false;
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            resultDataGridView.DataSource = kodyPocztoweBindingSource;
            resultDataGridView.Location = new Point(664, 224);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.ReadOnly = true;
            resultDataGridView.RowTemplate.Height = 25;
            resultDataGridView.Size = new Size(647, 354);
            resultDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "KodPocztowy";
            dataGridViewTextBoxColumn2.HeaderText = "KodPocztowy";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Adres";
            dataGridViewTextBoxColumn3.HeaderText = "Adres";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Miejscowosc";
            dataGridViewTextBoxColumn4.HeaderText = "Miejscowosc";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Wojewodztwo";
            dataGridViewTextBoxColumn5.HeaderText = "Wojewodztwo";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Powiat";
            dataGridViewTextBoxColumn6.HeaderText = "Powiat";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(699, 44);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(158, 23);
            idTextBox.TabIndex = 2;
            // 
            // kodPocztowyTextBox
            // 
            kodPocztowyTextBox.Location = new Point(699, 101);
            kodPocztowyTextBox.Name = "kodPocztowyTextBox";
            kodPocztowyTextBox.Size = new Size(158, 23);
            kodPocztowyTextBox.TabIndex = 3;
            // 
            // adresTextBox
            // 
            adresTextBox.Location = new Point(699, 156);
            adresTextBox.Name = "adresTextBox";
            adresTextBox.Size = new Size(158, 23);
            adresTextBox.TabIndex = 4;
            // 
            // powiatTextBox
            // 
            powiatTextBox.Location = new Point(923, 156);
            powiatTextBox.Name = "powiatTextBox";
            powiatTextBox.Size = new Size(158, 23);
            powiatTextBox.TabIndex = 7;
            // 
            // wojewodztwoTextBox
            // 
            wojewodztwoTextBox.Location = new Point(923, 101);
            wojewodztwoTextBox.Name = "wojewodztwoTextBox";
            wojewodztwoTextBox.Size = new Size(158, 23);
            wojewodztwoTextBox.TabIndex = 6;
            // 
            // miejscowoscTextBox
            // 
            miejscowoscTextBox.Location = new Point(923, 44);
            miejscowoscTextBox.Name = "miejscowoscTextBox";
            miejscowoscTextBox.Size = new Size(158, 23);
            miejscowoscTextBox.TabIndex = 5;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(699, 26);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 8;
            idLabel.Text = "Id";
            // 
            // kodPocztowyLabel
            // 
            kodPocztowyLabel.AutoSize = true;
            kodPocztowyLabel.Location = new Point(699, 83);
            kodPocztowyLabel.Name = "kodPocztowyLabel";
            kodPocztowyLabel.Size = new Size(79, 15);
            kodPocztowyLabel.TabIndex = 9;
            kodPocztowyLabel.Text = "KodPocztowy";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Location = new Point(699, 138);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new Size(37, 15);
            adresLabel.TabIndex = 10;
            adresLabel.Text = "Adres";
            // 
            // miejscowoscLabel
            // 
            miejscowoscLabel.AutoSize = true;
            miejscowoscLabel.Location = new Point(923, 26);
            miejscowoscLabel.Name = "miejscowoscLabel";
            miejscowoscLabel.Size = new Size(75, 15);
            miejscowoscLabel.TabIndex = 11;
            miejscowoscLabel.Text = "Miejscowosc";
            // 
            // wojewodztwoLabel
            // 
            wojewodztwoLabel.AutoSize = true;
            wojewodztwoLabel.Location = new Point(923, 83);
            wojewodztwoLabel.Name = "wojewodztwoLabel";
            wojewodztwoLabel.Size = new Size(82, 15);
            wojewodztwoLabel.TabIndex = 12;
            wojewodztwoLabel.Text = "Wojewodztwo";
            // 
            // powiatLabel
            // 
            powiatLabel.AutoSize = true;
            powiatLabel.Location = new Point(923, 138);
            powiatLabel.Name = "powiatLabel";
            powiatLabel.Size = new Size(43, 15);
            powiatLabel.TabIndex = 13;
            powiatLabel.Text = "Powiat";
            // 
            // efSearchButton
            // 
            efSearchButton.Location = new Point(1124, 43);
            efSearchButton.Name = "efSearchButton";
            efSearchButton.Size = new Size(183, 23);
            efSearchButton.TabIndex = 14;
            efSearchButton.Text = "Search (EF)";
            efSearchButton.UseVisualStyleBackColor = true;
            efSearchButton.Click += efSearchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 15;
            label1.Text = "Data from Database";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(664, 206);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 16;
            label2.Text = "Search Result";
            label2.Click += label2_Click;
            // 
            // adonetSearchButton
            // 
            adonetSearchButton.Location = new Point(1124, 101);
            adonetSearchButton.Name = "adonetSearchButton";
            adonetSearchButton.Size = new Size(183, 23);
            adonetSearchButton.TabIndex = 17;
            adonetSearchButton.Text = "Search (ADO.NET)";
            adonetSearchButton.UseVisualStyleBackColor = true;
            adonetSearchButton.Click += adonetSearchButton_Click;
            // 
            // dapperSearchButton
            // 
            dapperSearchButton.Location = new Point(1124, 156);
            dapperSearchButton.Name = "dapperSearchButton";
            dapperSearchButton.Size = new Size(183, 23);
            dapperSearchButton.TabIndex = 18;
            dapperSearchButton.Text = "Search (Dapper)";
            dapperSearchButton.UseVisualStyleBackColor = true;
            dapperSearchButton.Click += dapperSearchButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 590);
            Controls.Add(dapperSearchButton);
            Controls.Add(adonetSearchButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(efSearchButton);
            Controls.Add(powiatLabel);
            Controls.Add(wojewodztwoLabel);
            Controls.Add(miejscowoscLabel);
            Controls.Add(adresLabel);
            Controls.Add(kodPocztowyLabel);
            Controls.Add(idLabel);
            Controls.Add(powiatTextBox);
            Controls.Add(wojewodztwoTextBox);
            Controls.Add(miejscowoscTextBox);
            Controls.Add(adresTextBox);
            Controls.Add(kodPocztowyTextBox);
            Controls.Add(idTextBox);
            Controls.Add(resultDataGridView);
            Controls.Add(kodyDataGridView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)kodyDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)kodyPocztoweBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView kodyDataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kodPocztowyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wojewodztwoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn powiatDataGridViewTextBoxColumn;
        private BindingSource kodyPocztoweBindingSource;
        private DataGridView resultDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private TextBox idTextBox;
        private TextBox kodPocztowyTextBox;
        private TextBox adresTextBox;
        private TextBox powiatTextBox;
        private TextBox wojewodztwoTextBox;
        private TextBox miejscowoscTextBox;
        private Label idLabel;
        private Label kodPocztowyLabel;
        private Label adresLabel;
        private Label miejscowoscLabel;
        private Label wojewodztwoLabel;
        private Label powiatLabel;
        private Button efSearchButton;
        private Label label1;
        private Label label2;
        private Button adonetSearchButton;
        private Button dapperSearchButton;
    }
}