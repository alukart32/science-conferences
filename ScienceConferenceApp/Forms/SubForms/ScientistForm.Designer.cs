namespace ScienceConferenceApp.Forms.SubForms
{
    partial class ScientistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScientistForm));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewScientistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.participantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.scientistIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateScientist = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteScientist = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DegreeLabel = new System.Windows.Forms.Label();
            this.cbDegree = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewScientistBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(798, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.updateScientist,
            this.deleteScientist});
            this.dataGridView1.DataSource = this.viewScientistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(225, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 345);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // viewScientistBindingSource
            // 
            this.viewScientistBindingSource.DataSource = typeof(ScienceConferenceApp.Model.ViewScientist);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(892, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participantsToolStripMenuItem,
            this.companiesToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // participantsToolStripMenuItem
            // 
            this.participantsToolStripMenuItem.Name = "participantsToolStripMenuItem";
            this.participantsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.participantsToolStripMenuItem.Text = "Participants";
            // 
            // companiesToolStripMenuItem
            // 
            this.companiesToolStripMenuItem.Name = "companiesToolStripMenuItem";
            this.companiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.companiesToolStripMenuItem.Text = "Companies";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton1.Text = "Contact";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton2.Text = "Help";
            // 
            // scientistIdDataGridViewTextBoxColumn
            // 
            this.scientistIdDataGridViewTextBoxColumn.DataPropertyName = "scientistId";
            this.scientistIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.scientistIdDataGridViewTextBoxColumn.Name = "scientistIdDataGridViewTextBoxColumn";
            this.scientistIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "secondName";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "degree";
            this.degreeDataGridViewTextBoxColumn.HeaderText = "Degree";
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            this.degreeDataGridViewTextBoxColumn.Width = 50;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Country";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "companyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // updateScientist
            // 
            this.updateScientist.HeaderText = "";
            this.updateScientist.Name = "updateScientist";
            this.updateScientist.Text = "update";
            this.updateScientist.UseColumnTextForButtonValue = true;
            // 
            // deleteScientist
            // 
            this.deleteScientist.HeaderText = "";
            this.deleteScientist.Name = "deleteScientist";
            this.deleteScientist.Text = "X";
            this.deleteScientist.UseColumnTextForButtonValue = true;
            this.deleteScientist.Width = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbCompany);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbCountry);
            this.panel1.Controls.Add(this.CountryLabel);
            this.panel1.Controls.Add(this.cbDegree);
            this.panel1.Controls.Add(this.DegreeLabel);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 345);
            this.panel1.TabIndex = 3;
            // 
            // DegreeLabel
            // 
            this.DegreeLabel.AutoSize = true;
            this.DegreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DegreeLabel.Location = new System.Drawing.Point(19, 15);
            this.DegreeLabel.Name = "DegreeLabel";
            this.DegreeLabel.Size = new System.Drawing.Size(55, 17);
            this.DegreeLabel.TabIndex = 4;
            this.DegreeLabel.Text = "Degree";
            // 
            // cbDegree
            // 
            this.cbDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDegree.FormattingEnabled = true;
            this.cbDegree.Location = new System.Drawing.Point(41, 42);
            this.cbDegree.Name = "cbDegree";
            this.cbDegree.Size = new System.Drawing.Size(121, 23);
            this.cbDegree.TabIndex = 5;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(41, 111);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(121, 21);
            this.cbCountry.TabIndex = 7;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryLabel.Location = new System.Drawing.Point(19, 84);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(57, 17);
            this.CountryLabel.TabIndex = 6;
            this.CountryLabel.Text = "Country";
            // 
            // cbCompany
            // 
            this.cbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(41, 179);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(121, 23);
            this.cbCompany.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Company";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.ResetButton);
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Controls.Add(this.GoButton);
            this.panel2.Location = new System.Drawing.Point(14, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 108);
            this.panel2.TabIndex = 10;
            // 
            // GoButton
            // 
            this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoButton.Location = new System.Drawing.Point(16, 15);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(44, 30);
            this.GoButton.TabIndex = 4;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(84, 15);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 30);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.Location = new System.Drawing.Point(84, 61);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 28);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(26, 410);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(72, 33);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // ScientistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 457);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScientistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScientistForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScientistForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewScientistBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource viewScientistBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem participantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn scientistIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn updateScientist;
        private System.Windows.Forms.DataGridViewButtonColumn deleteScientist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbDegree;
        private System.Windows.Forms.Label DegreeLabel;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button AddButton;
    }
}