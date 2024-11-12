namespace GUIGame24
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
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNumber1 = new System.Windows.Forms.Button();
            this.buttonNumber2 = new System.Windows.Forms.Button();
            this.buttonNumber3 = new System.Windows.Forms.Button();
            this.buttonNumber4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonsymbol1 = new System.Windows.Forms.Button();
            this.buttonsymbol2 = new System.Windows.Forms.Button();
            this.buttonsymbol3 = new System.Windows.Forms.Button();
            this.buttonsymbol4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Location = new System.Drawing.Point(511, 392);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(100, 40);
            this.buttonAnswer.TabIndex = 6;
            this.buttonAnswer.Text = "Answer";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(405, 392);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 40);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSkip
            // 
            this.buttonSkip.Location = new System.Drawing.Point(299, 392);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(100, 40);
            this.buttonSkip.TabIndex = 9;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonNumber1);
            this.flowLayoutPanel1.Controls.Add(this.buttonNumber2);
            this.flowLayoutPanel1.Controls.Add(this.buttonNumber3);
            this.flowLayoutPanel1.Controls.Add(this.buttonNumber4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(179, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(270, 270);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // buttonNumber1
            // 
            this.buttonNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonNumber1.Location = new System.Drawing.Point(3, 3);
            this.buttonNumber1.Name = "buttonNumber1";
            this.buttonNumber1.Size = new System.Drawing.Size(125, 125);
            this.buttonNumber1.TabIndex = 0;
            this.buttonNumber1.Text = "button1";
            this.buttonNumber1.UseVisualStyleBackColor = true;
            this.buttonNumber1.Click += new System.EventHandler(this.buttonNumber1_Click);
            // 
            // buttonNumber2
            // 
            this.buttonNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonNumber2.Location = new System.Drawing.Point(134, 3);
            this.buttonNumber2.Name = "buttonNumber2";
            this.buttonNumber2.Size = new System.Drawing.Size(125, 125);
            this.buttonNumber2.TabIndex = 1;
            this.buttonNumber2.Text = "button2";
            this.buttonNumber2.UseVisualStyleBackColor = true;
            this.buttonNumber2.Click += new System.EventHandler(this.buttonNumber2_Click);
            // 
            // buttonNumber3
            // 
            this.buttonNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonNumber3.Location = new System.Drawing.Point(3, 134);
            this.buttonNumber3.Name = "buttonNumber3";
            this.buttonNumber3.Size = new System.Drawing.Size(125, 125);
            this.buttonNumber3.TabIndex = 2;
            this.buttonNumber3.Text = "button3";
            this.buttonNumber3.UseVisualStyleBackColor = true;
            this.buttonNumber3.Click += new System.EventHandler(this.buttonNumber3_Click);
            // 
            // buttonNumber4
            // 
            this.buttonNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonNumber4.Location = new System.Drawing.Point(134, 134);
            this.buttonNumber4.Name = "buttonNumber4";
            this.buttonNumber4.Size = new System.Drawing.Size(125, 125);
            this.buttonNumber4.TabIndex = 3;
            this.buttonNumber4.Text = "button4";
            this.buttonNumber4.UseVisualStyleBackColor = true;
            this.buttonNumber4.Click += new System.EventHandler(this.buttonNumber4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 420);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(354, 323);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 45);
            this.textBox1.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonsymbol1);
            this.flowLayoutPanel2.Controls.Add(this.buttonsymbol2);
            this.flowLayoutPanel2.Controls.Add(this.buttonsymbol3);
            this.flowLayoutPanel2.Controls.Add(this.buttonsymbol4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(476, 47);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(270, 270);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // buttonsymbol1
            // 
            this.buttonsymbol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonsymbol1.Location = new System.Drawing.Point(3, 3);
            this.buttonsymbol1.Name = "buttonsymbol1";
            this.buttonsymbol1.Size = new System.Drawing.Size(125, 125);
            this.buttonsymbol1.TabIndex = 1;
            this.buttonsymbol1.Text = "+";
            this.buttonsymbol1.UseVisualStyleBackColor = true;
            this.buttonsymbol1.Click += new System.EventHandler(this.buttonsymbol1_Click);
            // 
            // buttonsymbol2
            // 
            this.buttonsymbol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonsymbol2.Location = new System.Drawing.Point(134, 3);
            this.buttonsymbol2.Name = "buttonsymbol2";
            this.buttonsymbol2.Size = new System.Drawing.Size(125, 125);
            this.buttonsymbol2.TabIndex = 2;
            this.buttonsymbol2.Text = "-";
            this.buttonsymbol2.UseVisualStyleBackColor = true;
            this.buttonsymbol2.Click += new System.EventHandler(this.buttonsymbol2_Click);
            // 
            // buttonsymbol3
            // 
            this.buttonsymbol3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonsymbol3.Location = new System.Drawing.Point(3, 134);
            this.buttonsymbol3.Name = "buttonsymbol3";
            this.buttonsymbol3.Size = new System.Drawing.Size(125, 125);
            this.buttonsymbol3.TabIndex = 3;
            this.buttonsymbol3.Text = "*";
            this.buttonsymbol3.UseVisualStyleBackColor = true;
            this.buttonsymbol3.Click += new System.EventHandler(this.buttonsymbol3_Click);
            // 
            // buttonsymbol4
            // 
            this.buttonsymbol4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonsymbol4.Location = new System.Drawing.Point(134, 134);
            this.buttonsymbol4.Name = "buttonsymbol4";
            this.buttonsymbol4.Size = new System.Drawing.Size(125, 125);
            this.buttonsymbol4.TabIndex = 4;
            this.buttonsymbol4.Text = "/";
            this.buttonsymbol4.UseVisualStyleBackColor = true;
            this.buttonsymbol4.Click += new System.EventHandler(this.buttonsymbol4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(652, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Win0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonAnswer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonNumber1;
        private System.Windows.Forms.Button buttonNumber2;
        private System.Windows.Forms.Button buttonNumber3;
        private System.Windows.Forms.Button buttonNumber4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonsymbol1;
        private System.Windows.Forms.Button buttonsymbol2;
        private System.Windows.Forms.Button buttonsymbol3;
        private System.Windows.Forms.Button buttonsymbol4;
        private System.Windows.Forms.Label label1;
    }
}

