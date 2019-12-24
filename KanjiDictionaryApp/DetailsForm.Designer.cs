namespace KanjiDictionaryApp
{
    partial class DetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsForm));
            this.lblKanji = new System.Windows.Forms.Label();
            this.chkADVERB = new System.Windows.Forms.CheckBox();
            this.chkADJACTIVE = new System.Windows.Forms.CheckBox();
            this.chkVERB = new System.Windows.Forms.CheckBox();
            this.chkNOUN = new System.Windows.Forms.CheckBox();
            this.lblStrokes = new System.Windows.Forms.Label();
            this.lblNumOfStrokes = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lbOnyomiList = new System.Windows.Forms.ListBox();
            this.btnReadOnyomi = new System.Windows.Forms.PictureBox();
            this.lblOnyomi = new System.Windows.Forms.Label();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.lbMeaningList = new System.Windows.Forms.ListBox();
            this.lblKunyomi = new System.Windows.Forms.Label();
            this.btnReadKunyomi = new System.Windows.Forms.PictureBox();
            this.lbKunyomiList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReadOnyomi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReadKunyomi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKanji
            // 
            this.lblKanji.BackColor = System.Drawing.SystemColors.Control;
            this.lblKanji.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKanji.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.lblKanji.Location = new System.Drawing.Point(141, 37);
            this.lblKanji.Name = "lblKanji";
            this.lblKanji.Size = new System.Drawing.Size(155, 155);
            this.lblKanji.TabIndex = 23;
            this.lblKanji.Text = "例";
            this.lblKanji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkADVERB
            // 
            this.chkADVERB.AutoSize = true;
            this.chkADVERB.Enabled = false;
            this.chkADVERB.Location = new System.Drawing.Point(324, 148);
            this.chkADVERB.Name = "chkADVERB";
            this.chkADVERB.Size = new System.Drawing.Size(77, 21);
            this.chkADVERB.TabIndex = 47;
            this.chkADVERB.Text = "ADVERB";
            this.chkADVERB.UseVisualStyleBackColor = true;
            // 
            // chkADJACTIVE
            // 
            this.chkADJACTIVE.AutoSize = true;
            this.chkADJACTIVE.Enabled = false;
            this.chkADJACTIVE.Location = new System.Drawing.Point(324, 118);
            this.chkADJACTIVE.Name = "chkADJACTIVE";
            this.chkADJACTIVE.Size = new System.Drawing.Size(96, 21);
            this.chkADJACTIVE.TabIndex = 46;
            this.chkADJACTIVE.Text = "ADJACTIVE";
            this.chkADJACTIVE.UseVisualStyleBackColor = true;
            // 
            // chkVERB
            // 
            this.chkVERB.AutoSize = true;
            this.chkVERB.Enabled = false;
            this.chkVERB.Location = new System.Drawing.Point(324, 88);
            this.chkVERB.Name = "chkVERB";
            this.chkVERB.Size = new System.Drawing.Size(58, 21);
            this.chkVERB.TabIndex = 45;
            this.chkVERB.Text = "VERB";
            this.chkVERB.UseVisualStyleBackColor = true;
            // 
            // chkNOUN
            // 
            this.chkNOUN.AutoSize = true;
            this.chkNOUN.Enabled = false;
            this.chkNOUN.Location = new System.Drawing.Point(324, 58);
            this.chkNOUN.Name = "chkNOUN";
            this.chkNOUN.Size = new System.Drawing.Size(66, 21);
            this.chkNOUN.TabIndex = 44;
            this.chkNOUN.Text = "NOUN";
            this.chkNOUN.UseVisualStyleBackColor = true;
            // 
            // lblStrokes
            // 
            this.lblStrokes.ForeColor = System.Drawing.Color.Coral;
            this.lblStrokes.Location = new System.Drawing.Point(35, 117);
            this.lblStrokes.Name = "lblStrokes";
            this.lblStrokes.Size = new System.Drawing.Size(74, 17);
            this.lblStrokes.TabIndex = 48;
            this.lblStrokes.Text = "STROKES";
            this.lblStrokes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumOfStrokes
            // 
            this.lblNumOfStrokes.ForeColor = System.Drawing.Color.Coral;
            this.lblNumOfStrokes.Location = new System.Drawing.Point(35, 87);
            this.lblNumOfStrokes.Name = "lblNumOfStrokes";
            this.lblNumOfStrokes.Size = new System.Drawing.Size(74, 17);
            this.lblNumOfStrokes.TabIndex = 49;
            this.lblNumOfStrokes.Text = "8";
            this.lblNumOfStrokes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(429, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 50;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbOnyomiList
            // 
            this.lbOnyomiList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(75)))));
            this.lbOnyomiList.ForeColor = System.Drawing.SystemColors.Control;
            this.lbOnyomiList.FormattingEnabled = true;
            this.lbOnyomiList.ItemHeight = 17;
            this.lbOnyomiList.Location = new System.Drawing.Point(23, 266);
            this.lbOnyomiList.Name = "lbOnyomiList";
            this.lbOnyomiList.Size = new System.Drawing.Size(134, 191);
            this.lbOnyomiList.TabIndex = 51;
            // 
            // btnReadOnyomi
            // 
            this.btnReadOnyomi.Image = ((System.Drawing.Image)(resources.GetObject("btnReadOnyomi.Image")));
            this.btnReadOnyomi.Location = new System.Drawing.Point(23, 219);
            this.btnReadOnyomi.Name = "btnReadOnyomi";
            this.btnReadOnyomi.Size = new System.Drawing.Size(35, 35);
            this.btnReadOnyomi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReadOnyomi.TabIndex = 52;
            this.btnReadOnyomi.TabStop = false;
            this.btnReadOnyomi.Click += new System.EventHandler(this.Speaker_Click);
            // 
            // lblOnyomi
            // 
            this.lblOnyomi.ForeColor = System.Drawing.Color.Coral;
            this.lblOnyomi.Location = new System.Drawing.Point(64, 237);
            this.lblOnyomi.Name = "lblOnyomi";
            this.lblOnyomi.Size = new System.Drawing.Size(93, 17);
            this.lblOnyomi.TabIndex = 53;
            this.lblOnyomi.Text = "ONYOMI";
            this.lblOnyomi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMeaning
            // 
            this.lblMeaning.ForeColor = System.Drawing.Color.Coral;
            this.lblMeaning.Location = new System.Drawing.Point(164, 237);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(134, 17);
            this.lblMeaning.TabIndex = 56;
            this.lblMeaning.Text = "MEANING";
            this.lblMeaning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMeaningList
            // 
            this.lbMeaningList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(75)))));
            this.lbMeaningList.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMeaningList.FormattingEnabled = true;
            this.lbMeaningList.ItemHeight = 17;
            this.lbMeaningList.Location = new System.Drawing.Point(164, 266);
            this.lbMeaningList.Name = "lbMeaningList";
            this.lbMeaningList.Size = new System.Drawing.Size(134, 191);
            this.lbMeaningList.TabIndex = 54;
            // 
            // lblKunyomi
            // 
            this.lblKunyomi.ForeColor = System.Drawing.Color.Coral;
            this.lblKunyomi.Location = new System.Drawing.Point(346, 237);
            this.lblKunyomi.Name = "lblKunyomi";
            this.lblKunyomi.Size = new System.Drawing.Size(93, 17);
            this.lblKunyomi.TabIndex = 59;
            this.lblKunyomi.Text = "KUNYOMI";
            this.lblKunyomi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReadKunyomi
            // 
            this.btnReadKunyomi.Image = ((System.Drawing.Image)(resources.GetObject("btnReadKunyomi.Image")));
            this.btnReadKunyomi.Location = new System.Drawing.Point(305, 219);
            this.btnReadKunyomi.Name = "btnReadKunyomi";
            this.btnReadKunyomi.Size = new System.Drawing.Size(35, 35);
            this.btnReadKunyomi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReadKunyomi.TabIndex = 58;
            this.btnReadKunyomi.TabStop = false;
            this.btnReadKunyomi.Click += new System.EventHandler(this.Speaker_Click);
            // 
            // lbKunyomiList
            // 
            this.lbKunyomiList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(75)))));
            this.lbKunyomiList.ForeColor = System.Drawing.SystemColors.Control;
            this.lbKunyomiList.FormattingEnabled = true;
            this.lbKunyomiList.ItemHeight = 17;
            this.lbKunyomiList.Location = new System.Drawing.Point(305, 266);
            this.lbKunyomiList.Name = "lbKunyomiList";
            this.lbKunyomiList.Size = new System.Drawing.Size(134, 191);
            this.lbKunyomiList.TabIndex = 57;
            // 
            // DetailsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(460, 481);
            this.Controls.Add(this.lblKunyomi);
            this.Controls.Add(this.btnReadKunyomi);
            this.Controls.Add(this.lbKunyomiList);
            this.Controls.Add(this.lblMeaning);
            this.Controls.Add(this.lbMeaningList);
            this.Controls.Add(this.lblOnyomi);
            this.Controls.Add(this.btnReadOnyomi);
            this.Controls.Add(this.lbOnyomiList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNumOfStrokes);
            this.Controls.Add(this.lblStrokes);
            this.Controls.Add(this.chkADVERB);
            this.Controls.Add(this.chkADJACTIVE);
            this.Controls.Add(this.chkVERB);
            this.Controls.Add(this.chkNOUN);
            this.Controls.Add(this.lblKanji);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReadOnyomi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReadKunyomi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKanji;
        private System.Windows.Forms.CheckBox chkADVERB;
        private System.Windows.Forms.CheckBox chkADJACTIVE;
        private System.Windows.Forms.CheckBox chkVERB;
        private System.Windows.Forms.CheckBox chkNOUN;
        private System.Windows.Forms.Label lblStrokes;
        private System.Windows.Forms.Label lblNumOfStrokes;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.ListBox lbOnyomiList;
        private System.Windows.Forms.PictureBox btnReadOnyomi;
        private System.Windows.Forms.Label lblOnyomi;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.ListBox lbMeaningList;
        private System.Windows.Forms.Label lblKunyomi;
        private System.Windows.Forms.PictureBox btnReadKunyomi;
        private System.Windows.Forms.ListBox lbKunyomiList;
    }
}