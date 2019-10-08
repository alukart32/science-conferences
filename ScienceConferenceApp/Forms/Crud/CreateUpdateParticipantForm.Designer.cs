namespace ScienceConferenceApp.Forms.Crud
{
    partial class CreateUpdateParticipantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUpdateParticipantForm));
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChooseScientistButton = new System.Windows.Forms.Button();
            this.ScientistLabel = new System.Windows.Forms.Label();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewConferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbPublication = new System.Windows.Forms.CheckBox();
            this.themeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.cbTheme = new System.Windows.Forms.ComboBox();
            this.cbConference = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConferenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(372, 334);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(91, 47);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.Location = new System.Drawing.Point(84, 334);
            this.OkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(95, 47);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Publication";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Theme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(44, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Conference";
            // 
            // ChooseScientistButton
            // 
            this.ChooseScientistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseScientistButton.Location = new System.Drawing.Point(48, 247);
            this.ChooseScientistButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChooseScientistButton.Name = "ChooseScientistButton";
            this.ChooseScientistButton.Size = new System.Drawing.Size(168, 37);
            this.ChooseScientistButton.TabIndex = 14;
            this.ChooseScientistButton.Text = "Choose Scientist";
            this.ChooseScientistButton.UseVisualStyleBackColor = true;
            this.ChooseScientistButton.Click += new System.EventHandler(this.ChooseScientistButton_Click);
            // 
            // ScientistLabel
            // 
            this.ScientistLabel.AutoSize = true;
            this.ScientistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScientistLabel.Location = new System.Drawing.Point(291, 247);
            this.ScientistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScientistLabel.Name = "ScientistLabel";
            this.ScientistLabel.Size = new System.Drawing.Size(0, 20);
            this.ScientistLabel.TabIndex = 15;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(ScienceConferenceApp.Model.subject);
            // 
            // viewConferenceBindingSource
            // 
            this.viewConferenceBindingSource.DataSource = typeof(ScienceConferenceApp.Model.ViewConference);
            // 
            // cbPublication
            // 
            this.cbPublication.AutoSize = true;
            this.cbPublication.Location = new System.Drawing.Point(404, 177);
            this.cbPublication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPublication.Name = "cbPublication";
            this.cbPublication.Size = new System.Drawing.Size(18, 17);
            this.cbPublication.TabIndex = 18;
            this.cbPublication.UseVisualStyleBackColor = true;
            this.cbPublication.CheckedChanged += new System.EventHandler(this.cbPublication_CheckedChanged);
            // 
            // themeBindingSource
            // 
            this.themeBindingSource.DataSource = typeof(ScienceConferenceApp.Model.theme);
            // 
            // cbSubject
            // 
            this.cbSubject.DataSource = this.subjectBindingSource;
            this.cbSubject.DisplayMember = "subject1";
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(310, 120);
            this.cbSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(200, 24);
            this.cbSubject.TabIndex = 16;
            this.cbSubject.ValueMember = "subjectId";
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // cbTheme
            // 
            this.cbTheme.DataSource = this.themeBindingSource;
            this.cbTheme.DisplayMember = "themeName";
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Location = new System.Drawing.Point(310, 69);
            this.cbTheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(200, 24);
            this.cbTheme.TabIndex = 19;
            this.cbTheme.ValueMember = "themeId";
            this.cbTheme.SelectedIndexChanged += new System.EventHandler(this.cbTheme_SelectedIndexChanged);
            // 
            // cbConference
            // 
            this.cbConference.DataSource = this.viewConferenceBindingSource;
            this.cbConference.DisplayMember = "conferenceName";
            this.cbConference.FormattingEnabled = true;
            this.cbConference.Location = new System.Drawing.Point(310, 26);
            this.cbConference.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbConference.Name = "cbConference";
            this.cbConference.Size = new System.Drawing.Size(200, 24);
            this.cbConference.TabIndex = 17;
            this.cbConference.ValueMember = "conferenceId";
            this.cbConference.SelectedIndexChanged += new System.EventHandler(this.cbConference_SelectedIndexChanged);
            // 
            // CreateUpdateParticipantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.ControlBox = false;
            this.Controls.Add(this.cbTheme);
            this.Controls.Add(this.cbPublication);
            this.Controls.Add(this.cbConference);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.ScientistLabel);
            this.Controls.Add(this.ChooseScientistButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateUpdateParticipantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateUpdateParticipantForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateUpdateParticipantForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateUpdateParticipantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConferenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ChooseScientistButton;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.BindingSource viewConferenceBindingSource;
        private System.Windows.Forms.CheckBox cbPublication;
        private System.Windows.Forms.BindingSource themeBindingSource;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.ComboBox cbTheme;
        private System.Windows.Forms.ComboBox cbConference;
        public System.Windows.Forms.Label ScientistLabel;
    }
}