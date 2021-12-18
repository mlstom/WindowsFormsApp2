
namespace WindowsFormsApp2
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_index = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_redovan = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_index = new System.Windows.Forms.Label();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.lbl_redovan = new System.Windows.Forms.Label();
            this.txt_jmbg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(210, 66);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(143, 20);
            this.txt_id.TabIndex = 0;
            // 
            // txt_ime
            // 
            this.txt_ime.Location = new System.Drawing.Point(210, 146);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(143, 20);
            this.txt_ime.TabIndex = 1;
            // 
            // txt_index
            // 
            this.txt_index.Location = new System.Drawing.Point(210, 104);
            this.txt_index.Name = "txt_index";
            this.txt_index.Size = new System.Drawing.Size(143, 20);
            this.txt_index.TabIndex = 2;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Location = new System.Drawing.Point(210, 185);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(143, 20);
            this.txt_prezime.TabIndex = 3;
            // 
            // txt_redovan
            // 
            this.txt_redovan.Location = new System.Drawing.Point(210, 256);
            this.txt_redovan.Name = "txt_redovan";
            this.txt_redovan.Size = new System.Drawing.Size(143, 20);
            this.txt_redovan.TabIndex = 4;
            this.txt_redovan.TextChanged += new System.EventHandler(this.txt_redovan_TextChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(78, 65);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "ID";
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.Location = new System.Drawing.Point(78, 107);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(33, 13);
            this.lbl_index.TabIndex = 6;
            this.lbl_index.Text = "Index";
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Location = new System.Drawing.Point(76, 152);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(24, 13);
            this.lbl_ime.TabIndex = 7;
            this.lbl_ime.Text = "Ime";
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Location = new System.Drawing.Point(76, 188);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(44, 13);
            this.lbl_prezime.TabIndex = 8;
            this.lbl_prezime.Text = "Prezime";
            // 
            // lbl_redovan
            // 
            this.lbl_redovan.AutoSize = true;
            this.lbl_redovan.Location = new System.Drawing.Point(78, 259);
            this.lbl_redovan.Name = "lbl_redovan";
            this.lbl_redovan.Size = new System.Drawing.Size(51, 13);
            this.lbl_redovan.TabIndex = 9;
            this.lbl_redovan.Text = "Redovan";
            this.lbl_redovan.Click += new System.EventHandler(this.lbl_redovan_Click);
            // 
            // txt_jmbg
            // 
            this.txt_jmbg.Location = new System.Drawing.Point(210, 220);
            this.txt_jmbg.Name = "txt_jmbg";
            this.txt_jmbg.Size = new System.Drawing.Size(143, 20);
            this.txt_jmbg.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "jmbg";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 22);
            this.button3.TabIndex = 14;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(412, 311);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 22);
            this.button4.TabIndex = 15;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(126, 369);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 40);
            this.button5.TabIndex = 16;
            this.button5.Text = "obrisi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(297, 368);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 40);
            this.button6.TabIndex = 17;
            this.button6.Text = "update";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(481, 369);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 50);
            this.button7.TabIndex = 18;
            this.button7.Text = "dodaj";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_jmbg);
            this.Controls.Add(this.lbl_redovan);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.lbl_ime);
            this.Controls.Add(this.lbl_index);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_redovan);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_index);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.txt_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_index;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_redovan;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_index;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label lbl_redovan;
        private System.Windows.Forms.TextBox txt_jmbg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

