namespace Uyghurdev
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.cbSubDirectory = new System.Windows.Forms.CheckBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFileExt = new System.Windows.Forms.TextBox();
            this.lbExtentions = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFreq = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDirectory);
            this.groupBox1.Controls.Add(this.cbSubDirectory);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مۇندەرىجە (Folder)";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(88, 53);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(335, 20);
            this.txtDirectory.TabIndex = 4;
            this.txtDirectory.TextChanged += new System.EventHandler(this.txtDirectory_TextChanged);
            // 
            // cbSubDirectory
            // 
            this.cbSubDirectory.AutoSize = true;
            this.cbSubDirectory.Location = new System.Drawing.Point(6, 91);
            this.cbSubDirectory.Name = "cbSubDirectory";
            this.cbSubDirectory.Size = new System.Drawing.Size(282, 17);
            this.cbSubDirectory.TabIndex = 3;
            this.cbSubDirectory.Text = "تارماق مۇندەرىجىلەردىنمۇ سۈزسۇن (Retrieve subfolder)";
            this.cbSubDirectory.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(6, 51);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "تاللاش (set)";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Specify the source directory.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "مەنبە ھۆججەت(لەر) تۇرۇشلۇق مۇندەرىجىنى تاللاڭ.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFileExt);
            this.groupBox2.Controls.Add(this.lbExtentions);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 144);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مەنبە ھۆججەتلەرنىڭ تىپى (File types)";
            // 
            // txtFileExt
            // 
            this.txtFileExt.Location = new System.Drawing.Point(115, 30);
            this.txtFileExt.Name = "txtFileExt";
            this.txtFileExt.Size = new System.Drawing.Size(106, 20);
            this.txtFileExt.TabIndex = 3;
            this.txtFileExt.Text = "txt";
            this.txtFileExt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbExtentions
            // 
            this.lbExtentions.FormattingEnabled = true;
            this.lbExtentions.Items.AddRange(new object[] {
            "txt",
            "html",
            "htm"});
            this.lbExtentions.Location = new System.Drawing.Point(9, 30);
            this.lbExtentions.Name = "lbExtentions";
            this.lbExtentions.Size = new System.Drawing.Size(100, 95);
            this.lbExtentions.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(115, 102);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "ئۆچۈرۈش (Remove)";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(115, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "قوشۇش (Add)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(292, 277);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(155, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "سۈزۈشنى باشلاش (Start)";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(248, 171);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(190, 58);
            this.label3.TabIndex = 1;
            this.label3.Text = "سۈزۈلگەن سۆزلەر مەزكۇر پروگرامما ھۆججىتى تۇرۇشلۇق مۇندەرىجىدىكى sozler_[t].txt نا" +
    "ملىق ھۆججەتكە ساقلىنىدۇ .";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(272, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 54);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tokens will be saved into the file \"sozler_[t].txt\" at the application direcotry." +
    "";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbFreq
            // 
            this.cbFreq.Checked = true;
            this.cbFreq.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFreq.Location = new System.Drawing.Point(12, 287);
            this.cbFreq.Name = "cbFreq";
            this.cbFreq.Size = new System.Drawing.Size(227, 40);
            this.cbFreq.TabIndex = 3;
            this.cbFreq.Text = "سۆزلەرنىڭ كۆرۈلۈش چاستوتىسىنى قوشۇش (Add word frequency)";
            this.cbFreq.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(462, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(276, 17);
            this.toolStripStatusLabel1.Text = "ئاپتورى مەردان ھوشۇر (mardan.hoshur@gmail.com)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 384);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbFreq);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "ئۇيغۇرچە سۆز سۈزگۈ (Uyghur Tokenizer)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSubDirectory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFileExt;
        private System.Windows.Forms.ListBox lbExtentions;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbFreq;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}