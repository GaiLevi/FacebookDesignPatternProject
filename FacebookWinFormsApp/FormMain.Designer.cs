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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabControlFeatures = new System.Windows.Forms.TabControl();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.tabPageFriends = new System.Windows.Forms.TabPage();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.tabPagePages = new System.Windows.Forms.TabPage();
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.tabPageTimers = new System.Windows.Forms.TabPage();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.labelPostCreation = new System.Windows.Forms.Label();
            this.labelPostLastUpdarte = new System.Windows.Forms.Label();
            this.pictureBoxPosts = new System.Windows.Forms.PictureBox();
            this.labelPostsComments = new System.Windows.Forms.Label();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.textBoxPostCreation = new System.Windows.Forms.TextBox();
            this.textBoxPostLastUpdarte = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabControlFeatures.SuspendLayout();
            this.tabPagePosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).BeginInit();
            this.SuspendLayout();
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
            this.tabPagePosts.Controls.Add(this.labelID);
            this.tabPagePosts.Controls.Add(this.textBoxPostLastUpdarte);
            this.tabPagePosts.Controls.Add(this.textBoxPostCreation);
            this.tabPagePosts.Controls.Add(this.labelPostsComments);
            this.tabPagePosts.Controls.Add(this.listBoxPostComments);
            this.tabPagePosts.Controls.Add(this.pictureBoxPosts);
            this.tabPagePosts.Controls.Add(this.labelPostLastUpdarte);
            this.tabPagePosts.Controls.Add(this.labelPostCreation);
            this.tabPagePosts.Controls.Add(this.listBoxPosts);
            this.tabPagePosts.Location = new System.Drawing.Point(4, 22);
            this.tabPagePosts.Name = "tabPagePosts";
            this.tabPagePosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePosts.Size = new System.Drawing.Size(692, 274);
            this.tabPagePosts.TabIndex = 0;
            this.tabPagePosts.Text = "Posts";
            this.tabPagePosts.UseVisualStyleBackColor = true;
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
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(7, 7);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(220, 212);
            this.listBoxPosts.TabIndex = 0;
            // 
            // labelPostCreation
            // 
            this.labelPostCreation.AutoSize = true;
            this.labelPostCreation.Location = new System.Drawing.Point(234, 10);
            this.labelPostCreation.Name = "labelPostCreation";
            this.labelPostCreation.Size = new System.Drawing.Size(73, 13);
            this.labelPostCreation.TabIndex = 1;
            this.labelPostCreation.Text = "Post Creation:";
            // 
            // labelPostLastUpdarte
            // 
            this.labelPostLastUpdarte.AutoSize = true;
            this.labelPostLastUpdarte.Location = new System.Drawing.Point(234, 33);
            this.labelPostLastUpdarte.Name = "labelPostLastUpdarte";
            this.labelPostLastUpdarte.Size = new System.Drawing.Size(86, 13);
            this.labelPostLastUpdarte.TabIndex = 2;
            this.labelPostLastUpdarte.Text = "Post last update:";
            // 
            // pictureBoxPosts
            // 
            this.pictureBoxPosts.Location = new System.Drawing.Point(258, 76);
            this.pictureBoxPosts.Name = "pictureBoxPosts";
            this.pictureBoxPosts.Size = new System.Drawing.Size(143, 143);
            this.pictureBoxPosts.TabIndex = 3;
            this.pictureBoxPosts.TabStop = false;
            // 
            // labelPostsComments
            // 
            this.labelPostsComments.AutoSize = true;
            this.labelPostsComments.Location = new System.Drawing.Point(435, 70);
            this.labelPostsComments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPostsComments.Name = "labelPostsComments";
            this.labelPostsComments.Size = new System.Drawing.Size(125, 13);
            this.labelPostsComments.TabIndex = 6;
            this.labelPostsComments.Text = "Selected Post Comments";
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.Location = new System.Drawing.Point(438, 85);
            this.listBoxPostComments.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(210, 69);
            this.listBoxPostComments.TabIndex = 5;
            // 
            // textBoxPostCreation
            // 
            this.textBoxPostCreation.Location = new System.Drawing.Point(326, 7);
            this.textBoxPostCreation.Name = "textBoxPostCreation";
            this.textBoxPostCreation.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostCreation.TabIndex = 7;
            // 
            // textBoxPostLastUpdarte
            // 
            this.textBoxPostLastUpdarte.Location = new System.Drawing.Point(326, 30);
            this.textBoxPostLastUpdarte.Name = "textBoxPostLastUpdarte";
            this.textBoxPostLastUpdarte.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostLastUpdarte.TabIndex = 8;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.DarkOrange;
            this.labelID.Location = new System.Drawing.Point(463, 7);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(35, 13);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "label1";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TabControl tabControlFeatures;
        private System.Windows.Forms.TabPage tabPagePosts;
        private System.Windows.Forms.TextBox textBoxPostLastUpdarte;
        private System.Windows.Forms.TextBox textBoxPostCreation;
        private System.Windows.Forms.Label labelPostsComments;
        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.PictureBox pictureBoxPosts;
        private System.Windows.Forms.Label labelPostLastUpdarte;
        private System.Windows.Forms.Label labelPostCreation;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.TabPage tabPageFriends;
        private System.Windows.Forms.TabPage tabPageEvents;
        private System.Windows.Forms.TabPage tabPagePages;
        private System.Windows.Forms.TabPage tabPageAlbums;
        private System.Windows.Forms.TabPage tabPageTimers;
        private System.Windows.Forms.Label labelID;
    }
}

