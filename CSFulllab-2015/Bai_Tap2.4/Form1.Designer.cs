namespace BaiTap2._4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Txtext = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ResLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Output1 = new System.Windows.Forms.TextBox();
            this.Output2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txtext
            // 
            this.Txtext.AutoSize = true;
            this.Txtext.Location = new System.Drawing.Point(238, 57);
            this.Txtext.Name = "Txtext";
            this.Txtext.Size = new System.Drawing.Size(204, 27);
            this.Txtext.TabIndex = 0;
            this.Txtext.Text = "Nhập vào số tự nhiên N";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(505, 57);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(131, 27);
            this.Input.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(691, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tính tổng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResLabel
            // 
            this.ResLabel.AutoSize = true;
            this.ResLabel.ForeColor = System.Drawing.Color.Blue;
            this.ResLabel.Location = new System.Drawing.Point(95, 184);
            this.ResLabel.Name = "ResLabel";
            this.ResLabel.Size = new System.Drawing.Size(75, 27);
            this.ResLabel.TabIndex = 3;
            this.ResLabel.Text = "Kết quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "S =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "S =";
            // 
            // Output1
            // 
            this.Output1.ForeColor = System.Drawing.Color.Blue;
            this.Output1.Location = new System.Drawing.Point(163, 242);
            this.Output1.Multiline = true;
            this.Output1.Name = "Output1";
            this.Output1.Size = new System.Drawing.Size(860, 41);
            this.Output1.TabIndex = 6;
            // 
            // Output2
            // 
            this.Output2.ForeColor = System.Drawing.Color.Red;
            this.Output2.Location = new System.Drawing.Point(163, 319);
            this.Output2.Multiline = true;
            this.Output2.Name = "Output2";
            this.Output2.Size = new System.Drawing.Size(860, 40);
            this.Output2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 759);
            this.Controls.Add(this.Output2);
            this.Controls.Add(this.Output1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Txtext);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Tính tổng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txtext;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ResLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Output1;
        private System.Windows.Forms.TextBox Output2;
    }
}

