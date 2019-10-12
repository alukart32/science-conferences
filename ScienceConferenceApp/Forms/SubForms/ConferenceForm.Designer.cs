namespace ScienceConferenceApp.Forms.SubForms
{
    partial class ConferenceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConferenceForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.conferenceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conferenceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.viewConferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDateInFilter = new System.Windows.Forms.CheckBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbConference = new System.Windows.Forms.ComboBox();
            this.conferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.themeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddConferenceButton = new System.Windows.Forms.Button();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.participantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConferenceBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(1024, 498);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(104, 41);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
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
            this.toolStrip1.Size = new System.Drawing.Size(1160, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conferenceId,
            this.conferenceNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.updButton,
            this.delButton});
            this.dataGridView1.DataSource = this.viewConferenceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(323, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(805, 426);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // conferenceId
            // 
            this.conferenceId.DataPropertyName = "conferenceId";
            this.conferenceId.HeaderText = "Id";
            this.conferenceId.Name = "conferenceId";
            this.conferenceId.Width = 30;
            // 
            // conferenceNameDataGridViewTextBoxColumn
            // 
            this.conferenceNameDataGridViewTextBoxColumn.DataPropertyName = "conferenceName";
            this.conferenceNameDataGridViewTextBoxColumn.HeaderText = "Conference";
            this.conferenceNameDataGridViewTextBoxColumn.Name = "conferenceNameDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Country";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // updButton
            // 
            this.updButton.HeaderText = "";
            this.updButton.MinimumWidth = 20;
            this.updButton.Name = "updButton";
            this.updButton.Text = "update";
            this.updButton.UseColumnTextForButtonValue = true;
            // 
            // delButton
            // 
            this.delButton.HeaderText = "";
            this.delButton.Name = "delButton";
            this.delButton.Text = "X";
            this.delButton.UseColumnTextForButtonValue = true;
            this.delButton.Width = 30;
            // 
            // viewConferenceBindingSource
            // 
            this.viewConferenceBindingSource.DataSource = typeof(ScienceConferenceApp.Model.ViewConference);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.cbDateInFilter);
            this.panel1.Controls.Add(this.ResetButton);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbCountry);
            this.panel1.Controls.Add(this.cbAddress);
            this.panel1.Controls.Add(this.cbConference);
            this.panel1.Location = new System.Drawing.Point(32, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 426);
            this.panel1.TabIndex = 3;
            // 
            // cbDateInFilter
            // 
            this.cbDateInFilter.AutoSize = true;
            this.cbDateInFilter.Location = new System.Drawing.Point(72, 231);
            this.cbDateInFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbDateInFilter.Name = "cbDateInFilter";
            this.cbDateInFilter.Size = new System.Drawing.Size(18, 17);
            this.cbDateInFilter.TabIndex = 11;
            this.cbDateInFilter.UseVisualStyleBackColor = true;
            this.cbDateInFilter.CheckedChanged += new System.EventHandler(this.cbDateInFilter_CheckedChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.Location = new System.Drawing.Point(33, 382);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(101, 41);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(33, 255);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(191, 26);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2019, 10, 5, 20, 30, 54, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            this.ClearButton.Click += new System.EventHandler(this.button2_Click);
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
            this.GoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(97, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(84, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(84, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address";
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
            // cbCountry
            // 
            this.cbCountry.DataSource = this.countryBindingSource;
            this.cbCountry.DisplayMember = "code";
            this.cbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(47, 187);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(4);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(160, 26);
            this.cbCountry.TabIndex = 2;
            this.cbCountry.ValueMember = "countryId";
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(ScienceConferenceApp.Model.country);
            // 
            // cbAddress
            // 
            this.cbAddress.DataSource = this.addressBindingSource;
            this.cbAddress.DisplayMember = "address1";
            this.cbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Location = new System.Drawing.Point(47, 114);
            this.cbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(160, 26);
            this.cbAddress.TabIndex = 1;
            this.cbAddress.ValueMember = "addressId";
            this.cbAddress.SelectedIndexChanged += new System.EventHandler(this.cbAddress_SelectedIndexChanged);
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(ScienceConferenceApp.Model.address);
            // 
            // cbConference
            // 
            this.cbConference.DataSource = this.conferenceBindingSource;
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
            // conferenceBindingSource
            // 
            this.conferenceBindingSource.DataSource = typeof(ScienceConferenceApp.Model.conference);
            // 
            // themeBindingSource
            // 
            this.themeBindingSource.DataSource = typeof(ScienceConferenceApp.Model.theme);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(ScienceConferenceApp.Model.subject);
            // 
            // AddConferenceButton
            // 
            this.AddConferenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddConferenceButton.Location = new System.Drawing.Point(323, 498);
            this.AddConferenceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddConferenceButton.Name = "AddConferenceButton";
            this.AddConferenceButton.Size = new System.Drawing.Size(99, 41);
            this.AddConferenceButton.TabIndex = 4;
            this.AddConferenceButton.Text = "Add";
            this.AddConferenceButton.UseVisualStyleBackColor = true;
            this.AddConferenceButton.Click += new System.EventHandler(this.AddConferenceButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participantsToolStripMenuItem,
            this.scientistsToolStripMenuItem,
            this.companiesToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(65, 24);
            this.toolStripDropDownButton1.Text = "Menu";
            this.toolStripDropDownButton1.ButtonClick += new System.EventHandler(this.toolStripDropDownButton1_ButtonClick);
            // 
            // participantsToolStripMenuItem
            // 
            this.participantsToolStripMenuItem.Name = "participantsToolStripMenuItem";
            this.participantsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.participantsToolStripMenuItem.Text = "Participants";
            this.participantsToolStripMenuItem.Click += new System.EventHandler(this.participantsToolStripMenuItem_Click);
            // 
            // scientistsToolStripMenuItem
            // 
            this.scientistsToolStripMenuItem.Name = "scientistsToolStripMenuItem";
            this.scientistsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.scientistsToolStripMenuItem.Text = "Scientists";
            this.scientistsToolStripMenuItem.Click += new System.EventHandler(this.scientistsToolStripMenuItem_Click);
            // 
            // companiesToolStripMenuItem
            // 
            this.companiesToolStripMenuItem.Name = "companiesToolStripMenuItem";
            this.companiesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.companiesToolStripMenuItem.Text = "Companies";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // ConferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 553);
            this.Controls.Add(this.AddConferenceButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConferenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConferenceForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConferenceForm_FormClosed);
            this.Load += new System.EventHandler(this.ConferenceForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConferenceBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbAddress;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn themeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.BindingSource conferenceBindingSource;
        private System.Windows.Forms.BindingSource themeBindingSource;
        private System.Windows.Forms.BindingSource viewConferenceBindingSource;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.BindingSource countryBindingSource;
        public System.Windows.Forms.ComboBox cbConference;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddConferenceButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn conferenceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn conferenceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn updButton;
        private System.Windows.Forms.DataGridViewButtonColumn delButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbDateInFilter;
        private System.Windows.Forms.ToolStripSplitButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem participantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    }
}