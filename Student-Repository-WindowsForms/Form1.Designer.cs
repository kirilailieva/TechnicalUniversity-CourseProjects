
namespace Kikk
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1_Name = new System.Windows.Forms.TextBox();
            this.textBox2_LName = new System.Windows.Forms.TextBox();
            this.textBox3_Grade = new System.Windows.Forms.TextBox();
            this.textBox4_Age = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2_Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(648, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(416, 65);
            this.label5.TabIndex = 4;
            this.label5.Text = "Student Registration";
            // 
            // textBox1_Name
            // 
            this.textBox1_Name.Location = new System.Drawing.Point(61, 245);
            this.textBox1_Name.Name = "textBox1_Name";
            this.textBox1_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox1_Name.TabIndex = 5;
            // 
            // textBox2_LName
            // 
            this.textBox2_LName.Location = new System.Drawing.Point(253, 245);
            this.textBox2_LName.Name = "textBox2_LName";
            this.textBox2_LName.Size = new System.Drawing.Size(100, 22);
            this.textBox2_LName.TabIndex = 6;
            // 
            // textBox3_Grade
            // 
            this.textBox3_Grade.Location = new System.Drawing.Point(442, 245);
            this.textBox3_Grade.Name = "textBox3_Grade";
            this.textBox3_Grade.Size = new System.Drawing.Size(100, 22);
            this.textBox3_Grade.TabIndex = 7;
            // 
            // textBox4_Age
            // 
            this.textBox4_Age.Location = new System.Drawing.Point(626, 245);
            this.textBox4_Age.Name = "textBox4_Age";
            this.textBox4_Age.Size = new System.Drawing.Size(100, 22);
            this.textBox4_Age.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(456, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_Report
            // 
            this.button2_Report.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_Report.Location = new System.Drawing.Point(594, 372);
            this.button2_Report.Name = "button2_Report";
            this.button2_Report.Size = new System.Drawing.Size(132, 44);
            this.button2_Report.TabIndex = 10;
            this.button2_Report.Text = "Get Report";
            this.button2_Report.UseVisualStyleBackColor = true;
            this.button2_Report.Click += new System.EventHandler(this.button2_Report_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2_Report);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4_Age);
            this.Controls.Add(this.textBox3_Grade);
            this.Controls.Add(this.textBox2_LName);
            this.Controls.Add(this.textBox1_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1_Name;
        private System.Windows.Forms.TextBox textBox2_LName;
        private System.Windows.Forms.TextBox textBox3_Grade;
        private System.Windows.Forms.TextBox textBox4_Age;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2_Report;
    }
}

