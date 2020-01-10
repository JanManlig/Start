namespace Kalender2
{
    partial class make_account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.programmieren123DataSet = new Kalender2.Programmieren123DataSet();
            this.nutzerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nutzerTableAdapter = new Kalender2.Programmieren123DataSetTableAdapters.NutzerTableAdapter();
            this.tableAdapterManager = new Kalender2.Programmieren123DataSetTableAdapters.TableAdapterManager();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmieren123DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutzerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.nacnameDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.passwdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nutzerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // programmieren123DataSet
            // 
            this.programmieren123DataSet.DataSetName = "Programmieren123DataSet";
            this.programmieren123DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nutzerBindingSource
            // 
            this.nutzerBindingSource.DataMember = "Nutzer";
            this.nutzerBindingSource.DataSource = this.programmieren123DataSet;
            // 
            // nutzerTableAdapter
            // 
            this.nutzerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NutzerTableAdapter = this.nutzerTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kalender2.Programmieren123DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            // 
            // nacnameDataGridViewTextBoxColumn
            // 
            this.nacnameDataGridViewTextBoxColumn.DataPropertyName = "Nacname";
            this.nacnameDataGridViewTextBoxColumn.HeaderText = "Nacname";
            this.nacnameDataGridViewTextBoxColumn.Name = "nacnameDataGridViewTextBoxColumn";
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "E-Mail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            // 
            // passwdDataGridViewTextBoxColumn
            // 
            this.passwdDataGridViewTextBoxColumn.DataPropertyName = "Passwd";
            this.passwdDataGridViewTextBoxColumn.HeaderText = "Passwd";
            this.passwdDataGridViewTextBoxColumn.Name = "passwdDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nutzerBindingSource, "Passwd", true));
            this.label1.Location = new System.Drawing.Point(28, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // make_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "make_account";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.make_account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmieren123DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutzerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Programmieren123DataSet programmieren123DataSet;
        private System.Windows.Forms.BindingSource nutzerBindingSource;
        private Programmieren123DataSetTableAdapters.NutzerTableAdapter nutzerTableAdapter;
        private Programmieren123DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}