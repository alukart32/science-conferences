namespace ScienceConferenceApp.Forms.SubForms
{
    partial class ParticipantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParticipantForm));
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.participantIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conferenceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateParticipant = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteParticipant = new System.Windows.Forms.DataGridViewButtonColumn();
            this.viewConferencesWithParticipantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.cbDegree = new System.Windows.Forms.ComboBox();
            this.academicDegreeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTheme = new System.Windows.Forms.ComboBox();
            this.themeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbConference = new System.Windows.Forms.ComboBox();
            this.viewConferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddConferenceButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.scientistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConferencesWithParticipantBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academicDegreeBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConferenceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 24);
            this.toolStripButton1.Text = "Contact";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(45, 24);
            this.toolStripButton2.Text = "Help";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.toolStrip1.Size = new System.Drawing.Size(1561, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.participantIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.conferenceNameDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.themeNameDataGridViewTextBoxColumn,
            this.publication,
            this.updateParticipant,
            this.deleteParticipant});
            this.dataGridView1.DataSource = this.viewConferencesWithParticipantBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(313, 53);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1192, 426);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // participantIdDataGridViewTextBoxColumn
            // 
            this.participantIdDataGridViewTextBoxColumn.DataPropertyName = "participantId";
            this.participantIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.participantIdDataGridViewTextBoxColumn.Name = "participantIdDataGridViewTextBoxColumn";
            this.participantIdDataGridViewTextBoxColumn.Width = 30;
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
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "companyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // conferenceNameDataGridViewTextBoxColumn
            // 
            this.conferenceNameDataGridViewTextBoxColumn.DataPropertyName = "conferenceName";
            this.conferenceNameDataGridViewTextBoxColumn.HeaderText = "Conference";
            this.conferenceNameDataGridViewTextBoxColumn.Name = "conferenceNameDataGridViewTextBoxColumn";
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            // 
            // themeNameDataGridViewTextBoxColumn
            // 
            this.themeNameDataGridViewTextBoxColumn.DataPropertyName = "themeName";
            this.themeNameDataGridViewTextBoxColumn.HeaderText = "Theme";
            this.themeNameDataGridViewTextBoxColumn.Name = "themeNameDataGridViewTextBoxColumn";
            // 
            // publication
            // 
            this.publication.DataPropertyName = "publication";
            this.publication.HeaderText = "Publ.";
            this.publication.Name = "publication";
            this.publication.Width = 40;
            // 
            // updateParticipant
            // 
            this.updateParticipant.HeaderText = "";
            this.updateParticipant.Name = "updateParticipant";
            this.updateParticipant.Text = "update";
            this.updateParticipant.UseColumnTextForButtonValue = true;
            this.updateParticipant.Width = 50;
            // 
            // deleteParticipant
            // 
            this.deleteParticipant.HeaderText = "";
            this.deleteParticipant.Name = "deleteParticipant";
            this.deleteParticipant.Text = "X";
            this.deleteParticipant.UseColumnTextForButtonValue = true;
            this.deleteParticipant.Width = 30;
            // 
            // viewConferencesWithParticipantBindingSource
            // 
            this.viewConferencesWithParticipantBindingSource.DataSource = typeof(ScienceConferenceApp.Model.ViewConferencesWithParticipant);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.ResetButton);
            this.panel1.Controls.Add(this.cbDegree);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbSubject);
            this.panel1.Controls.Add(this.cbTheme);
            this.panel1.Controls.Add(this.cbConference);
            this.panel1.Location = new System.Drawing.Point(16, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 426);
            this.panel1.TabIndex = 4;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.Location = new System.Drawing.Point(135, 380);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(73, 42);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // cbDegree
            // 
            this.cbDegree.DataSource = this.academicDegreeBindingSource;
            this.cbDegree.DisplayMember = "degree";
            this.cbDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDegree.FormattingEnabled = true;
            this.cbDegree.Location = new System.Drawing.Point(47, 257);
            this.cbDegree.Margin = new System.Windows.Forms.Padding(4);
            this.cbDegree.Name = "cbDegree";
            this.cbDegree.Size = new System.Drawing.Size(160, 26);
            this.cbDegree.TabIndex = 12;
            this.cbDegree.ValueMember = "degreeId";
            this.cbDegree.SelectedIndexChanged += new System.EventHandler(this.cbDegree_SelectedIndexChanged);
            // 
            // academicDegreeBindingSource
            // 
            this.academicDegreeBindingSource.DataSource = typeof(ScienceConferenceApp.Model.academicDegree);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(84, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Degree";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Controls.Add(this.GoButton);
            this.panel2.Location = new System.Drawing.Point(33, 303);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 71);
            this.panel2.TabIndex = 5;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(101, 15);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(73, 41);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoButton.Location = new System.Drawing.Point(13, 15);
            this.GoButton.Margin = new System.Windows.Forms.Padding(4);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(59, 41);
            this.GoButton.TabIndex = 7;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(84, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(84, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Theme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conference";
            // 
            // cbSubject
            // 
            this.cbSubject.DataSource = this.subjectBindingSource;
            this.cbSubject.DisplayMember = "subject1";
            this.cbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(47, 187);
            this.cbSubject.Margin = new System.Windows.Forms.Padding(4);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(160, 26);
            this.cbSubject.TabIndex = 2;
            this.cbSubject.ValueMember = "subjectId";
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(ScienceConferenceApp.Model.subject);
            // 
            // cbTheme
            // 
            this.cbTheme.DataSource = this.themeBindingSource;
            this.cbTheme.DisplayMember = "themeName";
            this.cbTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Location = new System.Drawing.Point(47, 114);
            this.cbTheme.Margin = new System.Windows.Forms.Padding(4);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(160, 26);
            this.cbTheme.TabIndex = 1;
            this.cbTheme.ValueMember = "themeId";
            this.cbTheme.SelectedIndexChanged += new System.EventHandler(this.cbTheme_SelectedIndexChanged);
            // 
            // themeBindingSource
            // 
            this.themeBindingSource.DataSource = typeof(ScienceConferenceApp.Model.theme);
            // 
            // cbConference
            // 
            this.cbConference.DataSource = this.viewConferenceBindingSource;
            this.cbConference.DisplayMember = "conferenceName";
            this.cbConference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbConference.FormattingEnabled = true;
            this.cbConference.Location = new System.Drawing.Point(47, 37);
            this.cbConference.Margin = new System.Windows.Forms.Padding(4);
            this.cbConference.Name = "cbConference";
            this.cbConference.Size = new System.Drawing.Size(160, 26);
            this.cbConference.TabIndex = 0;
            this.cbConference.ValueMember = "conferenceId";
            this.cbConference.SelectedIndexChanged += new System.EventHandler(this.cbConference_SelectedIndexChanged);
            // 
            // viewConferenceBindingSource
            // 
            this.viewConferenceBindingSource.DataSource = typeof(ScienceConferenceApp.Model.ViewConference);
            // 
            // AddConferenceButton
            // 
            this.AddConferenceButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddConferenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddConferenceButton.Location = new System.Drawing.Point(23, 495);
            this.AddConferenceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddConferenceButton.Name = "AddConferenceButton";
            this.AddConferenceButton.Size = new System.Drawing.Size(99, 41);
            this.AddConferenceButton.TabIndex = 5;
            this.AddConferenceButton.Text = "Add";
            this.AddConferenceButton.UseVisualStyleBackColor = false;
            this.AddConferenceButton.Click += new System.EventHandler(this.AddConferenceButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(1397, 495);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(108, 41);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scientistsToolStripMenuItem,
            this.conferencesToolStripMenuItem,
            this.companiesToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(65, 24);
            this.toolStripDropDownButton1.Text = "Menu";
            this.toolStripDropDownButton1.ButtonClick += new System.EventHandler(this.toolStripDropDownButton1_ButtonClick);
            // 
            // scientistsToolStripMenuItem
            // 
            this.scientistsToolStripMenuItem.Name = "scientistsToolStripMenuItem";
            this.scientistsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.scientistsToolStripMenuItem.Text = "Scientists";
            this.scientistsToolStripMenuItem.Click += new System.EventHandler(this.scientistsToolStripMenuItem_Click);
            // 
            // conferencesToolStripMenuItem
            // 
            this.conferencesToolStripMenuItem.Name = "conferencesToolStripMenuItem";
            this.conferencesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.conferencesToolStripMenuItem.Text = "Conferences";
            this.conferencesToolStripMenuItem.Click += new System.EventHandler(this.conferencesToolStripMenuItem_Click);
            // 
            // companiesToolStripMenuItem
            // 
            this.companiesToolStripMenuItem.Name = "companiesToolStripMenuItem";
            this.companiesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.companiesToolStripMenuItem.Text = "Companies";
            this.companiesToolStripMenuItem.Click += new System.EventHandler(this.companiesToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // ParticipantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 550);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddConferenceButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParticipantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParticipantForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParticipantForm_FormClosed);
            this.Load += new System.EventHandler(this.ParticipantForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConferencesWithParticipantBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academicDegreeBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConferenceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource viewConferencesWithParticipantBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTheme;
        public System.Windows.Forms.ComboBox cbConference;
        private System.Windows.Forms.ComboBox cbDegree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.BindingSource themeBindingSource;
        private System.Windows.Forms.BindingSource viewConferenceBindingSource;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.BindingSource academicDegreeBindingSource;
        private System.Windows.Forms.Button AddConferenceButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn participantIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conferenceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn themeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publication;
        private System.Windows.Forms.DataGridViewButtonColumn updateParticipant;
        private System.Windows.Forms.DataGridViewButtonColumn deleteParticipant;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ToolStripSplitButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem scientistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    }
}