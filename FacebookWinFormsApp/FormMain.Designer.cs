namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.Windows.Forms.Label m_CreatedTimeLabel;
            System.Windows.Forms.Label m_LastEditTimeLabel;
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabControlFeatures = new System.Windows.Forms.TabControl();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.mCommentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_CreatedTimeTextBox = new System.Windows.Forms.TextBox();
            this.m_LastEditTimeTextBox = new System.Windows.Forms.TextBox();
            this.PictureBoxPictureUrl = new System.Windows.Forms.PictureBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.tabPageFriends = new System.Windows.Forms.TabPage();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.tabPagePages = new System.Windows.Forms.TabPage();
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.tabPageTimers = new System.Windows.Forms.TabPage();
            m_CreatedTimeLabel = new System.Windows.Forms.Label();
            m_LastEditTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabControlFeatures.SuspendLayout();
            this.tabPagePosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mCommentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPictureUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // m_CreatedTimeLabel
            // 
            m_CreatedTimeLabel.AutoSize = true;
            m_CreatedTimeLabel.Location = new System.Drawing.Point(254, 23);
            m_CreatedTimeLabel.Name = "m_CreatedTimeLabel";
            m_CreatedTimeLabel.Size = new System.Drawing.Size(73, 13);
            m_CreatedTimeLabel.TabIndex = 1;
            m_CreatedTimeLabel.Text = "Created Time:";
            // 
            // m_LastEditTimeLabel
            // 
            m_LastEditTimeLabel.AutoSize = true;
            m_LastEditTimeLabel.Location = new System.Drawing.Point(254, 49);
            m_LastEditTimeLabel.Name = "m_LastEditTimeLabel";
            m_LastEditTimeLabel.Size = new System.Drawing.Size(77, 13);
            m_LastEditTimeLabel.TabIndex = 3;
            m_LastEditTimeLabel.Text = "Last Edit Time:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(179, 23);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(12, 41);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(179, 23);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(207, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(52, 52);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 53;
            this.pictureBoxProfile.TabStop = false;
            // 
            // tabControlFeatures
            // 
            this.tabControlFeatures.Controls.Add(this.tabPagePosts);
            this.tabControlFeatures.Controls.Add(this.tabPageGroups);
            this.tabControlFeatures.Controls.Add(this.tabPageFriends);
            this.tabControlFeatures.Controls.Add(this.tabPageEvents);
            this.tabControlFeatures.Controls.Add(this.tabPagePages);
            this.tabControlFeatures.Controls.Add(this.tabPageAlbums);
            this.tabControlFeatures.Controls.Add(this.tabPageTimers);
            this.tabControlFeatures.Location = new System.Drawing.Point(12, 157);
            this.tabControlFeatures.Name = "tabControlFeatures";
            this.tabControlFeatures.SelectedIndex = 0;
            this.tabControlFeatures.Size = new System.Drawing.Size(700, 300);
            this.tabControlFeatures.TabIndex = 54;
            // 
            // tabPagePosts
            // 
            this.tabPagePosts.AutoScroll = true;
            this.tabPagePosts.Controls.Add(this.listBoxComments);
            this.tabPagePosts.Controls.Add(m_CreatedTimeLabel);
            this.tabPagePosts.Controls.Add(this.m_CreatedTimeTextBox);
            this.tabPagePosts.Controls.Add(m_LastEditTimeLabel);
            this.tabPagePosts.Controls.Add(this.m_LastEditTimeTextBox);
            this.tabPagePosts.Controls.Add(this.PictureBoxPictureUrl);
            this.tabPagePosts.Controls.Add(this.listBoxPosts);
            this.tabPagePosts.Location = new System.Drawing.Point(4, 22);
            this.tabPagePosts.Name = "tabPagePosts";
            this.tabPagePosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePosts.Size = new System.Drawing.Size(692, 274);
            this.tabPagePosts.TabIndex = 0;
            this.tabPagePosts.Text = "Posts";
            this.tabPagePosts.UseVisualStyleBackColor = true;
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.Location = new System.Drawing.Point(505, 72);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(148, 108);
            this.listBoxComments.TabIndex = 7;
            // 
            // mCommentsBindingSource
            // 
            this.mCommentsBindingSource.DataMember = "m_Comments";
            this.mCommentsBindingSource.DataSource = this.iPostBindingSource;
            // 
            // iPostBindingSource
            // 
            this.iPostBindingSource.DataSource = typeof(Common.Contracts.IPost);
            // 
            // m_CreatedTimeTextBox
            // 
            this.m_CreatedTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iPostBindingSource, "m_CreatedTime", true));
            this.m_CreatedTimeTextBox.Location = new System.Drawing.Point(348, 20);
            this.m_CreatedTimeTextBox.Name = "m_CreatedTimeTextBox";
            this.m_CreatedTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.m_CreatedTimeTextBox.TabIndex = 2;
            // 
            // m_LastEditTimeTextBox
            // 
            this.m_LastEditTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iPostBindingSource, "m_LastEditTime", true));
            this.m_LastEditTimeTextBox.Location = new System.Drawing.Point(348, 46);
            this.m_LastEditTimeTextBox.Name = "m_LastEditTimeTextBox";
            this.m_LastEditTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.m_LastEditTimeTextBox.TabIndex = 4;
            // 
            // PictureBoxPictureUrl
            // 
            this.PictureBoxPictureUrl.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.iPostBindingSource, "m_PictureUrl", true));
            this.PictureBoxPictureUrl.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.iPostBindingSource, "m_PictureUrl", true));
            this.PictureBoxPictureUrl.Location = new System.Drawing.Point(348, 72);
            this.PictureBoxPictureUrl.Name = "PictureBoxPictureUrl";
            this.PictureBoxPictureUrl.Size = new System.Drawing.Size(100, 100);
            this.PictureBoxPictureUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxPictureUrl.TabIndex = 6;
            this.PictureBoxPictureUrl.TabStop = false;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.iPostBindingSource;
            this.listBoxPosts.DisplayMember = "m_MSG";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(7, 7);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(220, 212);
            this.listBoxPosts.TabIndex = 0;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(692, 274);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // tabPageFriends
            // 
            this.tabPageFriends.Location = new System.Drawing.Point(4, 22);
            this.tabPageFriends.Name = "tabPageFriends";
            this.tabPageFriends.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFriends.Size = new System.Drawing.Size(692, 274);
            this.tabPageFriends.TabIndex = 2;
            this.tabPageFriends.Text = "Friends";
            this.tabPageFriends.UseVisualStyleBackColor = true;
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.Location = new System.Drawing.Point(4, 22);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEvents.Size = new System.Drawing.Size(692, 274);
            this.tabPageEvents.TabIndex = 3;
            this.tabPageEvents.Text = "Events";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // tabPagePages
            // 
            this.tabPagePages.Location = new System.Drawing.Point(4, 22);
            this.tabPagePages.Name = "tabPagePages";
            this.tabPagePages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePages.Size = new System.Drawing.Size(692, 274);
            this.tabPagePages.TabIndex = 4;
            this.tabPagePages.Text = "Pages";
            this.tabPagePages.UseVisualStyleBackColor = true;
            // 
            // tabPageAlbums
            // 
            this.tabPageAlbums.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlbums.Name = "tabPageAlbums";
            this.tabPageAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlbums.Size = new System.Drawing.Size(692, 274);
            this.tabPageAlbums.TabIndex = 5;
            this.tabPageAlbums.Text = "Albums";
            this.tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // tabPageTimers
            // 
            this.tabPageTimers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTimers.Name = "tabPageTimers";
            this.tabPageTimers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTimers.Size = new System.Drawing.Size(692, 274);
            this.tabPageTimers.TabIndex = 6;
            this.tabPageTimers.Text = "Timers";
            this.tabPageTimers.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(725, 470);
            this.Controls.Add(this.tabControlFeatures);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabControlFeatures.ResumeLayout(false);
            this.tabPagePosts.ResumeLayout(false);
            this.tabPagePosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mCommentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPictureUrl)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TabControl tabControlFeatures;
        private System.Windows.Forms.TabPage tabPagePosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.TabPage tabPageFriends;
        private System.Windows.Forms.TabPage tabPageEvents;
        private System.Windows.Forms.TabPage tabPagePages;
        private System.Windows.Forms.TabPage tabPageAlbums;
        private System.Windows.Forms.TabPage tabPageTimers;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.TextBox m_CreatedTimeTextBox;
        private System.Windows.Forms.BindingSource iPostBindingSource;
        private System.Windows.Forms.TextBox m_LastEditTimeTextBox;
        private System.Windows.Forms.PictureBox PictureBoxPictureUrl;
        private System.Windows.Forms.BindingSource mCommentsBindingSource;
    }
}

