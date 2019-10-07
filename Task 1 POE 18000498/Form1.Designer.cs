namespace Task_1_POE_18000498
{
    partial class Form1
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.GameTick = new System.Windows.Forms.Timer(this.components);
            this.btnsave = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.txtBoxH = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBoxW = new System.Windows.Forms.TextBox();
            this.btnSetSize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(903, 704);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "groupBox1";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(968, 42);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(116, 47);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "START";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(968, 95);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(116, 46);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "PAUSE";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(1192, 59);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(59, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "ROUND: 1";
            // 
            // rtb1
            // 
            this.rtb1.Location = new System.Drawing.Point(968, 162);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(116, 133);
            this.rtb1.TabIndex = 4;
            this.rtb1.Text = "";
            // 
            // GameTick
            // 
            this.GameTick.Interval = 1000;
            this.GameTick.Tick += new System.EventHandler(this.GameTick_Tick);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(1126, 162);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(106, 46);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(1126, 249);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(106, 46);
            this.btnread.TabIndex = 6;
            this.btnread.Text = "READ";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // txtBoxH
            // 
            this.txtBoxH.Location = new System.Drawing.Point(1338, 162);
            this.txtBoxH.Multiline = true;
            this.txtBoxH.Name = "txtBoxH";
            this.txtBoxH.Size = new System.Drawing.Size(61, 20);
            this.txtBoxH.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBoxW
            // 
            this.txtBoxW.Location = new System.Drawing.Point(1405, 162);
            this.txtBoxW.Multiline = true;
            this.txtBoxW.Name = "txtBoxW";
            this.txtBoxW.Size = new System.Drawing.Size(61, 20);
            this.txtBoxW.TabIndex = 9;
            // 
            // btnSetSize
            // 
            this.btnSetSize.Location = new System.Drawing.Point(1338, 189);
            this.btnSetSize.Name = "btnSetSize";
            this.btnSetSize.Size = new System.Drawing.Size(128, 32);
            this.btnSetSize.TabIndex = 10;
            this.btnSetSize.Text = "Set Size";
            this.btnSetSize.UseVisualStyleBackColor = true;
            this.btnSetSize.Click += new System.EventHandler(this.btnSetSize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1277, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Map Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 725);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetSize);
            this.Controls.Add(this.txtBoxW);
            this.Controls.Add(this.txtBoxH);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.gb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.Timer GameTick;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.TextBox txtBoxH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBoxW;
        private System.Windows.Forms.Button btnSetSize;
        private System.Windows.Forms.Label label1;
    }
}

