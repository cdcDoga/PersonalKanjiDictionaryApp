namespace KanjiDictionaryApp
{
    partial class AddModifyDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddModifyDeleteForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.numNumOfStroke = new System.Windows.Forms.NumericUpDown();
            this.txtKanji = new System.Windows.Forms.TextBox();
            this.lblKanji = new System.Windows.Forms.Label();
            this.lblNumOfStrokes = new System.Windows.Forms.Label();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.lblOnyomi = new System.Windows.Forms.Label();
            this.txtOnyomi = new System.Windows.Forms.TextBox();
            this.lblKunyomi = new System.Windows.Forms.Label();
            this.txtKunyomi = new System.Windows.Forms.TextBox();
            this.lblStructure = new System.Windows.Forms.Label();
            this.btnAddMeaning = new System.Windows.Forms.PictureBox();
            this.btnAddOnyomi = new System.Windows.Forms.PictureBox();
            this.btnAddKunyomi = new System.Windows.Forms.PictureBox();
            this.btnRemoveMeaning = new System.Windows.Forms.PictureBox();
            this.btnRemoveOnyomi = new System.Windows.Forms.PictureBox();
            this.btnRemoveKunyomi = new System.Windows.Forms.PictureBox();
            this.lbMeaningList = new System.Windows.Forms.ListBox();
            this.lbOnyomiList = new System.Windows.Forms.ListBox();
            this.lbKunyomiList = new System.Windows.Forms.ListBox();
            this.chkNOUN = new System.Windows.Forms.CheckBox();
            this.chkVERB = new System.Windows.Forms.CheckBox();
            this.chkADJACTIVE = new System.Windows.Forms.CheckBox();
            this.chkADVERB = new System.Windows.Forms.CheckBox();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumOfStroke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMeaning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddOnyomi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddKunyomi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveMeaning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveOnyomi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveKunyomi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTitle.Location = new System.Drawing.Point(55, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 23);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Dictionary Management";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(785, 59);
            this.pnlTop.TabIndex = 19;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(755, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 23;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // numNumOfStroke
            // 
            this.numNumOfStroke.BackColor = System.Drawing.SystemColors.Control;
            this.numNumOfStroke.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numNumOfStroke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.numNumOfStroke.Location = new System.Drawing.Point(540, 78);
            this.numNumOfStroke.Name = "numNumOfStroke";
            this.numNumOfStroke.Size = new System.Drawing.Size(162, 26);
            this.numNumOfStroke.TabIndex = 21;
            // 
            // txtKanji
            // 
            this.txtKanji.BackColor = System.Drawing.SystemColors.Control;
            this.txtKanji.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKanji.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKanji.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.txtKanji.Location = new System.Drawing.Point(143, 78);
            this.txtKanji.Name = "txtKanji";
            this.txtKanji.Size = new System.Drawing.Size(162, 26);
            this.txtKanji.TabIndex = 20;
            // 
            // lblKanji
            // 
            this.lblKanji.AutoSize = true;
            this.lblKanji.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKanji.Location = new System.Drawing.Point(88, 83);
            this.lblKanji.Name = "lblKanji";
            this.lblKanji.Size = new System.Drawing.Size(47, 17);
            this.lblKanji.TabIndex = 22;
            this.lblKanji.Text = "Kanji :";
            // 
            // lblNumOfStrokes
            // 
            this.lblNumOfStrokes.AutoSize = true;
            this.lblNumOfStrokes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumOfStrokes.Location = new System.Drawing.Point(399, 83);
            this.lblNumOfStrokes.Name = "lblNumOfStrokes";
            this.lblNumOfStrokes.Size = new System.Drawing.Size(133, 17);
            this.lblNumOfStrokes.TabIndex = 23;
            this.lblNumOfStrokes.Text = "Number of Strokes :";
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMeaning.Location = new System.Drawing.Point(34, 145);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(72, 17);
            this.lblMeaning.TabIndex = 25;
            this.lblMeaning.Text = "Meaning :";
            // 
            // txtMeaning
            // 
            this.txtMeaning.BackColor = System.Drawing.SystemColors.Control;
            this.txtMeaning.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMeaning.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMeaning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.txtMeaning.Location = new System.Drawing.Point(37, 168);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(162, 26);
            this.txtMeaning.TabIndex = 24;
            // 
            // lblOnyomi
            // 
            this.lblOnyomi.AutoSize = true;
            this.lblOnyomi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOnyomi.Location = new System.Drawing.Point(231, 145);
            this.lblOnyomi.Name = "lblOnyomi";
            this.lblOnyomi.Size = new System.Drawing.Size(66, 17);
            this.lblOnyomi.TabIndex = 27;
            this.lblOnyomi.Text = "Onyomi :";
            // 
            // txtOnyomi
            // 
            this.txtOnyomi.BackColor = System.Drawing.SystemColors.Control;
            this.txtOnyomi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOnyomi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOnyomi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.txtOnyomi.Location = new System.Drawing.Point(234, 168);
            this.txtOnyomi.Name = "txtOnyomi";
            this.txtOnyomi.Size = new System.Drawing.Size(162, 26);
            this.txtOnyomi.TabIndex = 26;
            // 
            // lblKunyomi
            // 
            this.lblKunyomi.AutoSize = true;
            this.lblKunyomi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKunyomi.Location = new System.Drawing.Point(429, 145);
            this.lblKunyomi.Name = "lblKunyomi";
            this.lblKunyomi.Size = new System.Drawing.Size(71, 17);
            this.lblKunyomi.TabIndex = 29;
            this.lblKunyomi.Text = "Kunyomi :";
            // 
            // txtKunyomi
            // 
            this.txtKunyomi.BackColor = System.Drawing.SystemColors.Control;
            this.txtKunyomi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKunyomi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKunyomi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.txtKunyomi.Location = new System.Drawing.Point(432, 168);
            this.txtKunyomi.Name = "txtKunyomi";
            this.txtKunyomi.Size = new System.Drawing.Size(162, 26);
            this.txtKunyomi.TabIndex = 28;
            // 
            // lblStructure
            // 
            this.lblStructure.AutoSize = true;
            this.lblStructure.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStructure.Location = new System.Drawing.Point(623, 145);
            this.lblStructure.Name = "lblStructure";
            this.lblStructure.Size = new System.Drawing.Size(72, 17);
            this.lblStructure.TabIndex = 31;
            this.lblStructure.Text = "Structure :";
            // 
            // btnAddMeaning
            // 
            this.btnAddMeaning.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMeaning.Image")));
            this.btnAddMeaning.Location = new System.Drawing.Point(77, 200);
            this.btnAddMeaning.Name = "btnAddMeaning";
            this.btnAddMeaning.Size = new System.Drawing.Size(28, 27);
            this.btnAddMeaning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddMeaning.TabIndex = 19;
            this.btnAddMeaning.TabStop = false;
            this.btnAddMeaning.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // btnAddOnyomi
            // 
            this.btnAddOnyomi.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOnyomi.Image")));
            this.btnAddOnyomi.Location = new System.Drawing.Point(277, 200);
            this.btnAddOnyomi.Name = "btnAddOnyomi";
            this.btnAddOnyomi.Size = new System.Drawing.Size(28, 27);
            this.btnAddOnyomi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddOnyomi.TabIndex = 32;
            this.btnAddOnyomi.TabStop = false;
            this.btnAddOnyomi.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // btnAddKunyomi
            // 
            this.btnAddKunyomi.Image = ((System.Drawing.Image)(resources.GetObject("btnAddKunyomi.Image")));
            this.btnAddKunyomi.Location = new System.Drawing.Point(472, 200);
            this.btnAddKunyomi.Name = "btnAddKunyomi";
            this.btnAddKunyomi.Size = new System.Drawing.Size(28, 27);
            this.btnAddKunyomi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddKunyomi.TabIndex = 33;
            this.btnAddKunyomi.TabStop = false;
            this.btnAddKunyomi.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // btnRemoveMeaning
            // 
            this.btnRemoveMeaning.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveMeaning.Image")));
            this.btnRemoveMeaning.Location = new System.Drawing.Point(130, 200);
            this.btnRemoveMeaning.Name = "btnRemoveMeaning";
            this.btnRemoveMeaning.Size = new System.Drawing.Size(28, 27);
            this.btnRemoveMeaning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRemoveMeaning.TabIndex = 34;
            this.btnRemoveMeaning.TabStop = false;
            this.btnRemoveMeaning.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // btnRemoveOnyomi
            // 
            this.btnRemoveOnyomi.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveOnyomi.Image")));
            this.btnRemoveOnyomi.Location = new System.Drawing.Point(330, 200);
            this.btnRemoveOnyomi.Name = "btnRemoveOnyomi";
            this.btnRemoveOnyomi.Size = new System.Drawing.Size(28, 27);
            this.btnRemoveOnyomi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRemoveOnyomi.TabIndex = 35;
            this.btnRemoveOnyomi.TabStop = false;
            this.btnRemoveOnyomi.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // btnRemoveKunyomi
            // 
            this.btnRemoveKunyomi.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveKunyomi.Image")));
            this.btnRemoveKunyomi.Location = new System.Drawing.Point(525, 200);
            this.btnRemoveKunyomi.Name = "btnRemoveKunyomi";
            this.btnRemoveKunyomi.Size = new System.Drawing.Size(28, 27);
            this.btnRemoveKunyomi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRemoveKunyomi.TabIndex = 36;
            this.btnRemoveKunyomi.TabStop = false;
            this.btnRemoveKunyomi.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // lbMeaningList
            // 
            this.lbMeaningList.BackColor = System.Drawing.SystemColors.Control;
            this.lbMeaningList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.lbMeaningList.FormattingEnabled = true;
            this.lbMeaningList.ItemHeight = 17;
            this.lbMeaningList.Location = new System.Drawing.Point(37, 233);
            this.lbMeaningList.Name = "lbMeaningList";
            this.lbMeaningList.Size = new System.Drawing.Size(162, 191);
            this.lbMeaningList.TabIndex = 37;
            // 
            // lbOnyomiList
            // 
            this.lbOnyomiList.BackColor = System.Drawing.SystemColors.Control;
            this.lbOnyomiList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.lbOnyomiList.FormattingEnabled = true;
            this.lbOnyomiList.ItemHeight = 17;
            this.lbOnyomiList.Location = new System.Drawing.Point(234, 233);
            this.lbOnyomiList.Name = "lbOnyomiList";
            this.lbOnyomiList.Size = new System.Drawing.Size(162, 191);
            this.lbOnyomiList.TabIndex = 38;
            // 
            // lbKunyomiList
            // 
            this.lbKunyomiList.BackColor = System.Drawing.SystemColors.Control;
            this.lbKunyomiList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.lbKunyomiList.FormattingEnabled = true;
            this.lbKunyomiList.ItemHeight = 17;
            this.lbKunyomiList.Location = new System.Drawing.Point(432, 233);
            this.lbKunyomiList.Name = "lbKunyomiList";
            this.lbKunyomiList.Size = new System.Drawing.Size(162, 191);
            this.lbKunyomiList.TabIndex = 39;
            // 
            // chkNOUN
            // 
            this.chkNOUN.AutoSize = true;
            this.chkNOUN.Location = new System.Drawing.Point(626, 176);
            this.chkNOUN.Name = "chkNOUN";
            this.chkNOUN.Size = new System.Drawing.Size(66, 21);
            this.chkNOUN.TabIndex = 40;
            this.chkNOUN.Text = "NOUN";
            this.chkNOUN.UseVisualStyleBackColor = true;
            // 
            // chkVERB
            // 
            this.chkVERB.AutoSize = true;
            this.chkVERB.Location = new System.Drawing.Point(626, 206);
            this.chkVERB.Name = "chkVERB";
            this.chkVERB.Size = new System.Drawing.Size(58, 21);
            this.chkVERB.TabIndex = 41;
            this.chkVERB.Text = "VERB";
            this.chkVERB.UseVisualStyleBackColor = true;
            // 
            // chkADJACTIVE
            // 
            this.chkADJACTIVE.AutoSize = true;
            this.chkADJACTIVE.Location = new System.Drawing.Point(626, 236);
            this.chkADJACTIVE.Name = "chkADJACTIVE";
            this.chkADJACTIVE.Size = new System.Drawing.Size(96, 21);
            this.chkADJACTIVE.TabIndex = 42;
            this.chkADJACTIVE.Text = "ADJACTIVE";
            this.chkADJACTIVE.UseVisualStyleBackColor = true;
            // 
            // chkADVERB
            // 
            this.chkADVERB.AutoSize = true;
            this.chkADVERB.Location = new System.Drawing.Point(626, 266);
            this.chkADVERB.Name = "chkADVERB";
            this.chkADVERB.Size = new System.Drawing.Size(77, 21);
            this.chkADVERB.TabIndex = 43;
            this.chkADVERB.Text = "ADVERB";
            this.chkADVERB.UseVisualStyleBackColor = true;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUpdate.ForeColor = System.Drawing.Color.Coral;
            this.btnAddUpdate.Location = new System.Drawing.Point(626, 393);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(128, 31);
            this.btnAddUpdate.TabIndex = 44;
            this.btnAddUpdate.Text = "UPDATE";
            this.btnAddUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Coral;
            this.btnDelete.Location = new System.Drawing.Point(626, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 31);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddModifyDeleteForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(785, 470);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.chkADVERB);
            this.Controls.Add(this.chkADJACTIVE);
            this.Controls.Add(this.chkVERB);
            this.Controls.Add(this.chkNOUN);
            this.Controls.Add(this.lbKunyomiList);
            this.Controls.Add(this.lbOnyomiList);
            this.Controls.Add(this.lbMeaningList);
            this.Controls.Add(this.btnRemoveKunyomi);
            this.Controls.Add(this.btnRemoveOnyomi);
            this.Controls.Add(this.btnRemoveMeaning);
            this.Controls.Add(this.btnAddKunyomi);
            this.Controls.Add(this.btnAddOnyomi);
            this.Controls.Add(this.btnAddMeaning);
            this.Controls.Add(this.lblStructure);
            this.Controls.Add(this.lblKunyomi);
            this.Controls.Add(this.txtKunyomi);
            this.Controls.Add(this.lblOnyomi);
            this.Controls.Add(this.txtOnyomi);
            this.Controls.Add(this.lblMeaning);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.lblNumOfStrokes);
            this.Controls.Add(this.lblKanji);
            this.Controls.Add(this.numNumOfStroke);
            this.Controls.Add(this.txtKanji);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddModifyDeleteForm";
            this.Text = "AddModifyDeleteForm";
            this.Load += new System.EventHandler(this.AddModifyDeleteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumOfStroke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMeaning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddOnyomi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddKunyomi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveMeaning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveOnyomi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveKunyomi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.NumericUpDown numNumOfStroke;
        private System.Windows.Forms.TextBox txtKanji;
        private System.Windows.Forms.Label lblKanji;
        private System.Windows.Forms.Label lblNumOfStrokes;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.Label lblOnyomi;
        private System.Windows.Forms.TextBox txtOnyomi;
        private System.Windows.Forms.Label lblKunyomi;
        private System.Windows.Forms.TextBox txtKunyomi;
        private System.Windows.Forms.Label lblStructure;
        private System.Windows.Forms.PictureBox btnAddMeaning;
        private System.Windows.Forms.PictureBox btnAddOnyomi;
        private System.Windows.Forms.PictureBox btnAddKunyomi;
        private System.Windows.Forms.PictureBox btnRemoveMeaning;
        private System.Windows.Forms.PictureBox btnRemoveOnyomi;
        private System.Windows.Forms.PictureBox btnRemoveKunyomi;
        private System.Windows.Forms.ListBox lbMeaningList;
        private System.Windows.Forms.ListBox lbOnyomiList;
        private System.Windows.Forms.ListBox lbKunyomiList;
        private System.Windows.Forms.CheckBox chkNOUN;
        private System.Windows.Forms.CheckBox chkVERB;
        private System.Windows.Forms.CheckBox chkADJACTIVE;
        private System.Windows.Forms.CheckBox chkADVERB;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox btnClose;
    }
}