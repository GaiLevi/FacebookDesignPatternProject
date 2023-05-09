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
            System.Windows.Forms.Label labelDescriptionGroup;
            System.Windows.Forms.Label labelDescriptionPage;
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabControlFeatures = new System.Windows.Forms.TabControl();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.m_CreatedTimeTextBox = new System.Windows.Forms.TextBox();
            this.iPostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_LastEditTimeTextBox = new System.Windows.Forms.TextBox();
            this.PictureBoxPost = new System.Windows.Forms.PictureBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.labelDescriptionGroupContent = new System.Windows.Forms.Label();
            this.iGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxGroup = new System.Windows.Forms.PictureBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.tabPageFriends = new System.Windows.Forms.TabPage();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.iEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.tabPagePages = new System.Windows.Forms.TabPage();
            this.labelDescriptionPageContent = new System.Windows.Forms.Label();
            this.iPageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.buttonEditPicture = new System.Windows.Forms.Button();
            this.buttonNextPicture = new System.Windows.Forms.Button();
            this.buttonPreviousPicture = new System.Windows.Forms.Button();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.iAlbumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageTimers = new System.Windows.Forms.TabPage();
            this.mCommentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            m_CreatedTimeLabel = new System.Windows.Forms.Label();
            m_LastEditTimeLabel = new System.Windows.Forms.Label();
            labelDescriptionGroup = new System.Windows.Forms.Label();
            labelDescriptionPage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabControlFeatures.SuspendLayout();
            this.tabPagePosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPost)).BeginInit();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).BeginInit();
            this.tabPageEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEventBindingSource)).BeginInit();
            this.tabPagePages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            this.tabPageAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iAlbumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCommentsBindingSource)).BeginInit();
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
            // labelDescriptionGroup
            // 
            labelDescriptionGroup.AutoSize = true;
            labelDescriptionGroup.Location = new System.Drawing.Point(472, 21);
            labelDescriptionGroup.Name = "labelDescriptionGroup";
            labelDescriptionGroup.Size = new System.Drawing.Size(63, 13);
            labelDescriptionGroup.TabIndex = 4;
            labelDescriptionGroup.Text = "Description:";
            // 
            // labelDescriptionPage
            // 
            labelDescriptionPage.AutoSize = true;
            labelDescriptionPage.Location = new System.Drawing.Point(472, 21);
            labelDescriptionPage.Name = "labelDescriptionPage";
            labelDescriptionPage.Size = new System.Drawing.Size(63, 13);
            labelDescriptionPage.TabIndex = 1;
            labelDescriptionPage.Text = "Description:";
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
            this.tabControlFeatures.SelectedIndexChanged += new System.EventHandler(this.tabControlFeatures_SelectedIndexChanged);
            // 
            // tabPagePosts
            // 
            this.tabPagePosts.AutoScroll = true;
            this.tabPagePosts.Controls.Add(this.listBoxComments);
            this.tabPagePosts.Controls.Add(m_CreatedTimeLabel);
            this.tabPagePosts.Controls.Add(this.m_CreatedTimeTextBox);
            this.tabPagePosts.Controls.Add(m_LastEditTimeLabel);
            this.tabPagePosts.Controls.Add(this.m_LastEditTimeTextBox);
            this.tabPagePosts.Controls.Add(this.PictureBoxPost);
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
            // m_CreatedTimeTextBox
            // 
            this.m_CreatedTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iPostBindingSource, "m_CreatedTime", true));
            this.m_CreatedTimeTextBox.Location = new System.Drawing.Point(348, 20);
            this.m_CreatedTimeTextBox.Name = "m_CreatedTimeTextBox";
            this.m_CreatedTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.m_CreatedTimeTextBox.TabIndex = 2;
            // 
            // iPostBindingSource
            // 
            this.iPostBindingSource.DataSource = typeof(Common.Contracts.IPost);
            // 
            // m_LastEditTimeTextBox
            // 
            this.m_LastEditTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iPostBindingSource, "m_LastEditTime", true));
            this.m_LastEditTimeTextBox.Location = new System.Drawing.Point(348, 46);
            this.m_LastEditTimeTextBox.Name = "m_LastEditTimeTextBox";
            this.m_LastEditTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.m_LastEditTimeTextBox.TabIndex = 4;
            // 
            // PictureBoxPost
            // 
            this.PictureBoxPost.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.iPostBindingSource, "m_PictureUrl", true));
            this.PictureBoxPost.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.iPostBindingSource, "m_PictureUrl", true));
            this.PictureBoxPost.Location = new System.Drawing.Point(348, 72);
            this.PictureBoxPost.Name = "PictureBoxPost";
            this.PictureBoxPost.Size = new System.Drawing.Size(100, 100);
            this.PictureBoxPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxPost.TabIndex = 6;
            this.PictureBoxPost.TabStop = false;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.iPostBindingSource;
            this.listBoxPosts.DisplayMember = "m_MSG";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(10, 11);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(236, 251);
            this.listBoxPosts.TabIndex = 0;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.AutoScroll = true;
            this.tabPageGroups.Controls.Add(labelDescriptionGroup);
            this.tabPageGroups.Controls.Add(this.labelDescriptionGroupContent);
            this.tabPageGroups.Controls.Add(this.pictureBoxGroup);
            this.tabPageGroups.Controls.Add(this.listBoxGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(692, 274);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // labelDescriptionGroupContent
            // 
            this.labelDescriptionGroupContent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iGroupBindingSource, "m_Description", true));
            this.labelDescriptionGroupContent.Location = new System.Drawing.Point(472, 44);
            this.labelDescriptionGroupContent.Name = "labelDescriptionGroupContent";
            this.labelDescriptionGroupContent.Size = new System.Drawing.Size(195, 218);
            this.labelDescriptionGroupContent.TabIndex = 5;
            // 
            // iGroupBindingSource
            // 
            this.iGroupBindingSource.DataSource = typeof(Common.Contracts.IGroup);
            // 
            // pictureBoxGroup
            // 
            this.pictureBoxGroup.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.iGroupBindingSource, "m_PictureUrl", true));
            this.pictureBoxGroup.Location = new System.Drawing.Point(348, 72);
            this.pictureBoxGroup.Name = "pictureBoxGroup";
            this.pictureBoxGroup.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGroup.TabIndex = 7;
            this.pictureBoxGroup.TabStop = false;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.DataSource = this.iGroupBindingSource;
            this.listBoxGroups.DisplayMember = "m_Name";
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(10, 11);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(236, 251);
            this.listBoxGroups.TabIndex = 4;
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
            this.tabPageEvents.AutoScroll = true;
            this.tabPageEvents.Controls.Add(this.pictureBoxEvent);
            this.tabPageEvents.Controls.Add(this.listBoxEvents);
            this.tabPageEvents.Location = new System.Drawing.Point(4, 22);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEvents.Size = new System.Drawing.Size(692, 274);
            this.tabPageEvents.TabIndex = 3;
            this.tabPageEvents.Text = "Events";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.iEventBindingSource, "m_PictureUrl", true));
            this.pictureBoxEvent.Location = new System.Drawing.Point(348, 72);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEvent.TabIndex = 2;
            this.pictureBoxEvent.TabStop = false;
            // 
            // iEventBindingSource
            // 
            this.iEventBindingSource.DataSource = typeof(Common.Contracts.IEvent);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.DataSource = this.iEventBindingSource;
            this.listBoxEvents.DisplayMember = "m_Name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(10, 11);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(236, 251);
            this.listBoxEvents.TabIndex = 0;
            // 
            // tabPagePages
            // 
            this.tabPagePages.AutoScroll = true;
            this.tabPagePages.Controls.Add(labelDescriptionPage);
            this.tabPagePages.Controls.Add(this.labelDescriptionPageContent);
            this.tabPagePages.Controls.Add(this.pictureBoxPage);
            this.tabPagePages.Controls.Add(this.listBoxPages);
            this.tabPagePages.Location = new System.Drawing.Point(4, 22);
            this.tabPagePages.Name = "tabPagePages";
            this.tabPagePages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePages.Size = new System.Drawing.Size(692, 274);
            this.tabPagePages.TabIndex = 4;
            this.tabPagePages.Text = "Pages";
            this.tabPagePages.UseVisualStyleBackColor = true;
            // 
            // labelDescriptionPageContent
            // 
            this.labelDescriptionPageContent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iPageBindingSource, "m_Description", true));
            this.labelDescriptionPageContent.Location = new System.Drawing.Point(472, 44);
            this.labelDescriptionPageContent.Name = "labelDescriptionPageContent";
            this.labelDescriptionPageContent.Size = new System.Drawing.Size(195, 218);
            this.labelDescriptionPageContent.TabIndex = 2;
            // 
            // iPageBindingSource
            // 
            this.iPageBindingSource.DataSource = typeof(Common.Contracts.IPage);
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.iPageBindingSource, "m_PictureUrl", true));
            this.pictureBoxPage.Location = new System.Drawing.Point(348, 72);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPage.TabIndex = 4;
            this.pictureBoxPage.TabStop = false;
            // 
            // listBoxPages
            // 
            this.listBoxPages.DataSource = this.iPageBindingSource;
            this.listBoxPages.DisplayMember = "m_Name";
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(10, 11);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(236, 251);
            this.listBoxPages.TabIndex = 0;
            // 
            // tabPageAlbums
            // 
            this.tabPageAlbums.AutoScroll = true;
            this.tabPageAlbums.Controls.Add(this.buttonEditPicture);
            this.tabPageAlbums.Controls.Add(this.buttonNextPicture);
            this.tabPageAlbums.Controls.Add(this.buttonPreviousPicture);
            this.tabPageAlbums.Controls.Add(this.pictureBoxAlbum);
            this.tabPageAlbums.Controls.Add(this.listBoxAlbums);
            this.tabPageAlbums.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlbums.Name = "tabPageAlbums";
            this.tabPageAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlbums.Size = new System.Drawing.Size(692, 274);
            this.tabPageAlbums.TabIndex = 5;
            this.tabPageAlbums.Text = "Albums";
            this.tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // buttonEditPicture
            // 
            this.buttonEditPicture.Location = new System.Drawing.Point(605, 240);
            this.buttonEditPicture.Name = "buttonEditPicture";
            this.buttonEditPicture.Size = new System.Drawing.Size(75, 23);
            this.buttonEditPicture.TabIndex = 7;
            this.buttonEditPicture.Text = "Edit";
            this.buttonEditPicture.UseVisualStyleBackColor = true;
            // 
            // buttonNextPicture
            // 
            this.buttonNextPicture.Location = new System.Drawing.Point(555, 126);
            this.buttonNextPicture.Name = "buttonNextPicture";
            this.buttonNextPicture.Size = new System.Drawing.Size(75, 23);
            this.buttonNextPicture.TabIndex = 6;
            this.buttonNextPicture.Text = "Next";
            this.buttonNextPicture.UseVisualStyleBackColor = true;
            this.buttonNextPicture.Click += new System.EventHandler(this.buttonNextPicture_Click);
            // 
            // buttonPreviousPicture
            // 
            this.buttonPreviousPicture.Location = new System.Drawing.Point(318, 126);
            this.buttonPreviousPicture.Name = "buttonPreviousPicture";
            this.buttonPreviousPicture.Size = new System.Drawing.Size(75, 23);
            this.buttonPreviousPicture.TabIndex = 5;
            this.buttonPreviousPicture.Text = "Previous";
            this.buttonPreviousPicture.UseVisualStyleBackColor = true;
            this.buttonPreviousPicture.Click += new System.EventHandler(this.buttonPreviousPicture_Click);
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.ImageLocation = "";
            this.pictureBoxAlbum.Location = new System.Drawing.Point(287, 27);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(75, 77);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 1;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.DataSource = this.iAlbumBindingSource;
            this.listBoxAlbums.DisplayMember = "m_Name";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(10, 11);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(236, 251);
            this.listBoxAlbums.TabIndex = 0;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // iAlbumBindingSource
            // 
            this.iAlbumBindingSource.DataSource = typeof(Common.Contracts.IAlbum);
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
            // mCommentsBindingSource
            // 
            this.mCommentsBindingSource.DataMember = "m_Comments";
            this.mCommentsBindingSource.DataSource = this.iPostBindingSource;
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
            ((System.ComponentModel.ISupportInitialize)(this.iPostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPost)).EndInit();
            this.tabPageGroups.ResumeLayout(false);
            this.tabPageGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).EndInit();
            this.tabPageEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEventBindingSource)).EndInit();
            this.tabPagePages.ResumeLayout(false);
            this.tabPagePages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            this.tabPageAlbums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iAlbumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCommentsBindingSource)).EndInit();
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
        private System.Windows.Forms.PictureBox PictureBoxPost;
        private System.Windows.Forms.BindingSource mCommentsBindingSource;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label labelDescriptionGroupContent;
        private System.Windows.Forms.BindingSource iGroupBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxGroup;
        private System.Windows.Forms.Label labelDescriptionPageContent;
        private System.Windows.Forms.BindingSource iPageBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.BindingSource iEventBindingSource;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.BindingSource iAlbumBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.Button buttonEditPicture;
        private System.Windows.Forms.Button buttonNextPicture;
        private System.Windows.Forms.Button buttonPreviousPicture;
    }
}

