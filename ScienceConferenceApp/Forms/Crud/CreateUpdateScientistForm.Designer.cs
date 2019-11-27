namespace ScienceConferenceApp.Forms.Crud
{
    partial class CreateUpdateScientistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUpdateScientistForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.DegreeLabel = new System.Windows.Forms.Label();
            this.CompayLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbDegree = new System.Windows.Forms.ComboBox();
            this.academicDegreeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicDegreeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(263, 232);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(84, 36);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButton.Location = new System.Drawing.Point(49, 232);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(83, 36);
            this.ApplyButton.TabIndex = 1;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.Location = new System.Drawing.Point(24, 15);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNameLabel.Location = new System.Drawing.Point(24, 76);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(97, 17);
            this.SecondNameLabel.TabIndex = 3;
            this.SecondNameLabel.Text = "Second Name";
            // 
            // DegreeLabel
            // 
            this.DegreeLabel.AutoSize = true;
            this.DegreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DegreeLabel.Location = new System.Drawing.Point(270, 76);
            this.DegreeLabel.Name = "DegreeLabel";
            this.DegreeLabel.Size = new System.Drawing.Size(55, 17);
            this.DegreeLabel.TabIndex = 4;
            this.DegreeLabel.Text = "Degree";
            // 
            // CompayLabel
            // 
            this.CompayLabel.AutoSize = true;
            this.CompayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompayLabel.Location = new System.Drawing.Point(24, 136);
            this.CompayLabel.Name = "CompayLabel";
            this.CompayLabel.Size = new System.Drawing.Size(67, 17);
            this.CompayLabel.TabIndex = 5;
            this.CompayLabel.Text = "Company";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryLabel.Location = new System.Drawing.Point(270, 15);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(57, 17);
            this.CountryLabel.TabIndex = 6;
            this.CountryLabel.Text = "Country";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.cbCountry);
            this.panel1.Controls.Add(this.cbDegree);
            this.panel1.Controls.Add(this.cbCompany);
            this.panel1.Controls.Add(this.FirstNameTextBox);
            this.panel1.Controls.Add(this.SecondNameTextBox);
            this.panel1.Controls.Add(this.FirstNameLabel);
            this.panel1.Controls.Add(this.CountryLabel);
            this.panel1.Controls.Add(this.SecondNameLabel);
            this.panel1.Controls.Add(this.CompayLabel);
            this.panel1.Controls.Add(this.DegreeLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 203);
            this.panel1.TabIndex = 7;
            // 
            // cbCountry
            // 
            this.cbCountry.DataSource = this.countryBindingSource;
            this.cbCountry.DisplayMember = "code";
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(263, 35);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(64, 21);
            this.cbCountry.TabIndex = 11;
            this.cbCountry.ValueMember = "countryId";
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(ScienceConferenceApp.Model.country);
            // 
            // cbDegree
            // 
            this.cbDegree.DataSource = this.academicDegreeBindingSource;
            this.cbDegree.DisplayMember = "degree";
            this.cbDegree.FormattingEnabled = true;
            this.cbDegree.Location = new System.Drawing.Point(262, 96);
            this.cbDegree.MaxLength = 3;
            this.cbDegree.Name = "cbDegree";
            this.cbDegree.Size = new System.Drawing.Size(63, 21);
            this.cbDegree.TabIndex = 10;
            this.cbDegree.ValueMember = "degreeId";
            this.cbDegree.SelectedIndexChanged += new System.EventHandler(this.cbDegree_SelectedIndexChanged);
            // 
            // academicDegreeBindingSource
            // 
            this.academicDegreeBindingSource.DataSource = typeof(ScienceConferenceApp.Model.academicDegree);
            // 
            // cbCompany
            // 
            this.cbCompany.DataSource = this.companyBindingSource;
            this.cbCompany.DisplayMember = "companyName";
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(52, 156);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(273, 21);
            this.cbCompany.TabIndex = 9;
            this.cbCompany.ValueMember = "companyId";
            this.cbCompany.SelectedIndexChanged += new System.EventHandler(this.cbCompany_SelectedIndexChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(ScienceConferenceApp.Model.company);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(52, 35);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.FirstNameTextBox.TabIndex = 8;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.Location = new System.Drawing.Point(52, 96);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.SecondNameTextBox.TabIndex = 7;
            this.SecondNameTextBox.TextChanged += new System.EventHandler(this.SecondNameTextBox_TextChanged);
            // 
            // CreateUpdateScientistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 284);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.BackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "CreateUpdateScientistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateUpdateScientistForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateUpdateScientistForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateUpdateScientistForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicDegreeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.Label DegreeLabel;
        private System.Windows.Forms.Label CompayLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbDegree;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.BindingSource academicDegreeBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
    }
}