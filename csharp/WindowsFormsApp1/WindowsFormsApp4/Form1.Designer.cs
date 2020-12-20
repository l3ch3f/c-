
namespace WindowsFormsApp4
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
            this.btnToon = new System.Windows.Forms.Button();
            this.txtCijfer2 = new System.Windows.Forms.TextBox();
            this.txtCijfer1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnToon
            // 
            this.btnToon.Location = new System.Drawing.Point(324, 316);
            this.btnToon.Name = "btnToon";
            this.btnToon.Size = new System.Drawing.Size(75, 23);
            this.btnToon.TabIndex = 0;
            this.btnToon.Text = "Toon cijfers";
            this.btnToon.UseVisualStyleBackColor = true;
            this.btnToon.Click += new System.EventHandler(this.btnToon_Click);
            // 
            // txtCijfer2
            // 
            this.txtCijfer2.Location = new System.Drawing.Point(324, 256);
            this.txtCijfer2.Name = "txtCijfer2";
            this.txtCijfer2.Size = new System.Drawing.Size(100, 20);
            this.txtCijfer2.TabIndex = 1;
            this.txtCijfer2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCijfer1
            // 
            this.txtCijfer1.Location = new System.Drawing.Point(324, 196);
            this.txtCijfer1.Name = "txtCijfer1";
            this.txtCijfer1.Size = new System.Drawing.Size(100, 20);
            this.txtCijfer1.TabIndex = 2;
            this.txtCijfer1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cijfer 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cijfer 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCijfer1);
            this.Controls.Add(this.txtCijfer2);
            this.Controls.Add(this.btnToon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToon;
        private System.Windows.Forms.TextBox txtCijfer2;
        private System.Windows.Forms.TextBox txtCijfer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

