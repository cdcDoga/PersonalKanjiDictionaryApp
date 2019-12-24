namespace KanjiDictionaryApp
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.panelTabBar = new System.Windows.Forms.Panel();
            this.btnKanaPage = new System.Windows.Forms.Button();
            this.panelTabStick = new System.Windows.Forms.Panel();
            this.btnManagementTab = new System.Windows.Forms.Button();
            this.btnSearchTab = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pbAccount = new System.Windows.Forms.PictureBox();
            this.lblKana = new System.Windows.Forms.Label();
            this.txtKana = new System.Windows.Forms.TextBox();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.lblNumOfStroke = new System.Windows.Forms.Label();
            this.numNumOfStroke = new System.Windows.Forms.NumericUpDown();
            this.lbKanjiList = new System.Windows.Forms.ListBox();
            this.lblKanjiList = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnAddNewKanji = new System.Windows.Forms.Button();
            this.lblDoubleClickInfo = new System.Windows.Forms.Label();
            this.panelTabBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumOfStroke)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTabBar
            // 
            this.panelTabBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panelTabBar.Controls.Add(this.btnKanaPage);
            this.panelTabBar.Controls.Add(this.panelTabStick);
            this.panelTabBar.Controls.Add(this.btnManagementTab);
            this.panelTabBar.Controls.Add(this.btnSearchTab);
            this.panelTabBar.Controls.Add(this.pbIcon);
            this.panelTabBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTabBar.Location = new System.Drawing.Point(0, 0);
            this.panelTabBar.Name = "panelTabBar";
            this.panelTabBar.Size = new System.Drawing.Size(162, 488);
            this.panelTabBar.TabIndex = 2;
            // 
            // btnKanaPage
            // 
            this.btnKanaPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKanaPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKanaPage.FlatAppearance.BorderSize = 0;
            this.btnKanaPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKanaPage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKanaPage.Image = ((System.Drawing.Image)(resources.GetObject("btnKanaPage.Image")));
            this.btnKanaPage.Location = new System.Drawing.Point(0, 359);
            this.btnKanaPage.Name = "btnKanaPage";
            this.btnKanaPage.Size = new System.Drawing.Size(159, 98);
            this.btnKanaPage.TabIndex = 4;
            this.btnKanaPage.Text = "Kana";
            this.btnKanaPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKanaPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKanaPage.UseVisualStyleBackColor = true;
            this.btnKanaPage.Click += new System.EventHandler(this.btnKanaPage_Click);
            // 
            // panelTabStick
            // 
            this.panelTabStick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelTabStick.Location = new System.Drawing.Point(154, 172);
            this.panelTabStick.Name = "panelTabStick";
            this.panelTabStick.Size = new System.Drawing.Size(5, 80);
            this.panelTabStick.TabIndex = 3;
            // 
            // btnManagementTab
            // 
            this.btnManagementTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnManagementTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagementTab.FlatAppearance.BorderSize = 0;
            this.btnManagementTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagementTab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManagementTab.Image = ((System.Drawing.Image)(resources.GetObject("btnManagementTab.Image")));
            this.btnManagementTab.Location = new System.Drawing.Point(0, 259);
            this.btnManagementTab.Name = "btnManagementTab";
            this.btnManagementTab.Size = new System.Drawing.Size(159, 104);
            this.btnManagementTab.TabIndex = 2;
            this.btnManagementTab.Text = "Management";
            this.btnManagementTab.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManagementTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnManagementTab.UseVisualStyleBackColor = true;
            this.btnManagementTab.Click += new System.EventHandler(this.btnManagementTab_Click);
            // 
            // btnSearchTab
            // 
            this.btnSearchTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearchTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchTab.FlatAppearance.BorderSize = 0;
            this.btnSearchTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchTab.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTab.Image")));
            this.btnSearchTab.Location = new System.Drawing.Point(0, 164);
            this.btnSearchTab.Name = "btnSearchTab";
            this.btnSearchTab.Size = new System.Drawing.Size(159, 104);
            this.btnSearchTab.TabIndex = 1;
            this.btnSearchTab.Text = "Search";
            this.btnSearchTab.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearchTab.UseVisualStyleBackColor = true;
            this.btnSearchTab.Click += new System.EventHandler(this.btnSearchTab_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(13, 12);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(132, 134);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.pbAccount);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.Coral;
            this.panelTop.Location = new System.Drawing.Point(162, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(688, 44);
            this.panelTop.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTitle.Location = new System.Drawing.Point(6, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 23);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Personal Kanji Dictionary";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.Location = new System.Drawing.Point(250, 11);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(389, 26);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "user mail";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbAccount
            // 
            this.pbAccount.Image = ((System.Drawing.Image)(resources.GetObject("pbAccount.Image")));
            this.pbAccount.Location = new System.Drawing.Point(643, 8);
            this.pbAccount.Name = "pbAccount";
            this.pbAccount.Size = new System.Drawing.Size(37, 31);
            this.pbAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAccount.TabIndex = 1;
            this.pbAccount.TabStop = false;
            this.pbAccount.Click += new System.EventHandler(this.pbAccount_Click);
            this.pbAccount.MouseLeave += new System.EventHandler(this.pbAccount_MouseLeave);
            this.pbAccount.MouseHover += new System.EventHandler(this.pbAccount_MouseHover);
            // 
            // lblKana
            // 
            this.lblKana.AutoSize = true;
            this.lblKana.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKana.Location = new System.Drawing.Point(209, 92);
            this.lblKana.Name = "lblKana";
            this.lblKana.Size = new System.Drawing.Size(101, 17);
            this.lblKana.TabIndex = 4;
            this.lblKana.Text = "It sounds like...";
            // 
            // txtKana
            // 
            this.txtKana.BackColor = System.Drawing.SystemColors.Control;
            this.txtKana.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKana.ForeColor = System.Drawing.Color.DarkGray;
            this.txtKana.Location = new System.Drawing.Point(212, 115);
            this.txtKana.Name = "txtKana";
            this.txtKana.Size = new System.Drawing.Size(162, 26);
            this.txtKana.TabIndex = 5;
            this.txtKana.Text = "Hiragana/Katakana";
            this.txtKana.Enter += new System.EventHandler(this.txtKana_Enter);
            this.txtKana.Leave += new System.EventHandler(this.txtKana_Leave);
            // 
            // txtMeaning
            // 
            this.txtMeaning.BackColor = System.Drawing.SystemColors.Control;
            this.txtMeaning.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMeaning.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMeaning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.txtMeaning.Location = new System.Drawing.Point(212, 205);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(162, 26);
            this.txtMeaning.TabIndex = 7;
            this.txtMeaning.Enter += new System.EventHandler(this.txtMeaning_Enter);
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMeaning.Location = new System.Drawing.Point(209, 182);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(111, 17);
            this.lblMeaning.TabIndex = 6;
            this.lblMeaning.Text = "English Meaning";
            // 
            // lblNumOfStroke
            // 
            this.lblNumOfStroke.AutoSize = true;
            this.lblNumOfStroke.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumOfStroke.Location = new System.Drawing.Point(209, 272);
            this.lblNumOfStroke.Name = "lblNumOfStroke";
            this.lblNumOfStroke.Size = new System.Drawing.Size(124, 17);
            this.lblNumOfStroke.TabIndex = 8;
            this.lblNumOfStroke.Text = "Number of strokes";
            // 
            // numNumOfStroke
            // 
            this.numNumOfStroke.BackColor = System.Drawing.SystemColors.Control;
            this.numNumOfStroke.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numNumOfStroke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.numNumOfStroke.Location = new System.Drawing.Point(212, 295);
            this.numNumOfStroke.Name = "numNumOfStroke";
            this.numNumOfStroke.Size = new System.Drawing.Size(162, 26);
            this.numNumOfStroke.TabIndex = 10;
            this.numNumOfStroke.Enter += new System.EventHandler(this.numNumOfStroke_Enter);
            // 
            // lbKanjiList
            // 
            this.lbKanjiList.BackColor = System.Drawing.SystemColors.Control;
            this.lbKanjiList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.lbKanjiList.FormattingEnabled = true;
            this.lbKanjiList.ItemHeight = 17;
            this.lbKanjiList.Location = new System.Drawing.Point(570, 115);
            this.lbKanjiList.Name = "lbKanjiList";
            this.lbKanjiList.Size = new System.Drawing.Size(233, 310);
            this.lbKanjiList.TabIndex = 11;
            this.lbKanjiList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbKanjiList_MouseDoubleClick);
            // 
            // lblKanjiList
            // 
            this.lblKanjiList.AutoSize = true;
            this.lblKanjiList.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKanjiList.Location = new System.Drawing.Point(567, 92);
            this.lblKanjiList.Name = "lblKanjiList";
            this.lblKanjiList.Size = new System.Drawing.Size(62, 17);
            this.lblKanjiList.TabIndex = 12;
            this.lblKanjiList.Text = "Kanji List";
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(407, 164);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(129, 115);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAddNewKanji
            // 
            this.btnAddNewKanji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewKanji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewKanji.Enabled = false;
            this.btnAddNewKanji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewKanji.Location = new System.Drawing.Point(212, 382);
            this.btnAddNewKanji.Name = "btnAddNewKanji";
            this.btnAddNewKanji.Size = new System.Drawing.Size(162, 31);
            this.btnAddNewKanji.TabIndex = 5;
            this.btnAddNewKanji.Text = "Add a New Kanji";
            this.btnAddNewKanji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddNewKanji.UseVisualStyleBackColor = true;
            this.btnAddNewKanji.Visible = false;
            this.btnAddNewKanji.Click += new System.EventHandler(this.btnAddNewKanji_Click);
            // 
            // lblDoubleClickInfo
            // 
            this.lblDoubleClickInfo.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoubleClickInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDoubleClickInfo.Location = new System.Drawing.Point(570, 428);
            this.lblDoubleClickInfo.Name = "lblDoubleClickInfo";
            this.lblDoubleClickInfo.Size = new System.Drawing.Size(233, 21);
            this.lblDoubleClickInfo.TabIndex = 13;
            this.lblDoubleClickInfo.Text = "Double click to see details*";
            this.lblDoubleClickInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SearchForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(850, 488);
            this.Controls.Add(this.lblDoubleClickInfo);
            this.Controls.Add(this.btnAddNewKanji);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblKanjiList);
            this.Controls.Add(this.lbKanjiList);
            this.Controls.Add(this.numNumOfStroke);
            this.Controls.Add(this.lblNumOfStroke);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.lblMeaning);
            this.Controls.Add(this.txtKana);
            this.Controls.Add(this.lblKana);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelTabBar);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Text = "SEARCH";
            this.panelTabBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumOfStroke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTabBar;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Button btnSearchTab;
        private System.Windows.Forms.Button btnManagementTab;
        private System.Windows.Forms.Panel panelTabStick;
        private System.Windows.Forms.Button btnKanaPage;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pbAccount;
        private System.Windows.Forms.Label lblKana;
        private System.Windows.Forms.TextBox txtKana;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.Label lblNumOfStroke;
        private System.Windows.Forms.NumericUpDown numNumOfStroke;
        private System.Windows.Forms.ListBox lbKanjiList;
        private System.Windows.Forms.Label lblKanjiList;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnAddNewKanji;
        private System.Windows.Forms.Label lblDoubleClickInfo;
        private System.Windows.Forms.Label lblTitle;
    }
}

