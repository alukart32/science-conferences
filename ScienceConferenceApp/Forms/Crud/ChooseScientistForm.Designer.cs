namespace ScienceConferenceApp.Forms.Crud
{
    partial class ChooseScientistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseScientistForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewScientistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BackButton = new System.Windows.Forms.Button();
            this.scientistIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseScientist = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewScientistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scientistIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.chooseScientist});
            this.dataGridView1.DataSource = this.viewScientistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 379);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // viewScientistBindingSource
            // 
            this.viewScientistBindingSource.DataSource = typeof(ScienceConferenceApp.Model.ViewScientist);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(631, 407);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(84, 31);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // scientistIdDataGridViewTextBoxColumn
            // 
            this.scientistIdDataGridViewTextBoxColumn.DataPropertyName = "scientistId";
            this.scientistIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.scientistIdDataGridViewTextBoxColumn.Name = "scientistIdDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "secondName";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "secondName";
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "degree";
            this.degreeDataGridViewTextBoxColumn.HeaderText = "degree";
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "companyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "companyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // chooseScientist
            // 
            this.chooseScientist.HeaderText = "";
            this.chooseScientist.Name = "chooseScientist";
            this.chooseScientist.Text = "select";
            this.chooseScientist.UseColumnTextForButtonValue = true;
            this.chooseScientist.Width = 50;
            // 
            // ChooseScientistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseScientistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseScientistForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChooseScientistForm_FormClosed);
            this.Load += new System.EventHandler(this.ChooseScientistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewScientistBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource viewScientistBindingSource;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn scientistIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn chooseScientist;
    }
}