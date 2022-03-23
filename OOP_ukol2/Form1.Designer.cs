namespace OOP_ukol2
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vytvorit = new System.Windows.Forms.Button();
            this.textBox_znacka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_spotreba = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.kilometry = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rozjezd = new System.Windows.Forms.Label();
            this.rozjet = new System.Windows.Forms.Button();
            this.zastavit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.spotreba = new System.Windows.Forms.Label();
            this.doba = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vytvorit
            // 
            this.vytvorit.Location = new System.Drawing.Point(230, 39);
            this.vytvorit.Name = "vytvorit";
            this.vytvorit.Size = new System.Drawing.Size(75, 23);
            this.vytvorit.TabIndex = 0;
            this.vytvorit.Text = "Vytvořit auto";
            this.vytvorit.UseVisualStyleBackColor = true;
            this.vytvorit.Click += new System.EventHandler(this.vytvorit_Click);
            // 
            // textBox_znacka
            // 
            this.textBox_znacka.Location = new System.Drawing.Point(124, 15);
            this.textBox_znacka.Name = "textBox_znacka";
            this.textBox_znacka.Size = new System.Drawing.Size(100, 20);
            this.textBox_znacka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zadej značku auta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zadej spotřebu auta:";
            // 
            // textBox_spotreba
            // 
            this.textBox_spotreba.Location = new System.Drawing.Point(124, 41);
            this.textBox_spotreba.Name = "textBox_spotreba";
            this.textBox_spotreba.Size = new System.Drawing.Size(100, 20);
            this.textBox_spotreba.TabIndex = 3;
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(311, 18);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(75, 43);
            this.info.TabIndex = 5;
            this.info.Text = "Zobrazit info o autě";
            this.info.UseVisualStyleBackColor = true;
            this.info.Visible = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Celkem ujeto km:";
            // 
            // kilometry
            // 
            this.kilometry.AutoSize = true;
            this.kilometry.Location = new System.Drawing.Point(157, 70);
            this.kilometry.Name = "kilometry";
            this.kilometry.Size = new System.Drawing.Size(21, 13);
            this.kilometry.TabIndex = 7;
            this.kilometry.Text = "km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Čas rozjezdu:";
            // 
            // rozjezd
            // 
            this.rozjezd.AutoSize = true;
            this.rozjezd.Location = new System.Drawing.Point(157, 97);
            this.rozjezd.Name = "rozjezd";
            this.rozjezd.Size = new System.Drawing.Size(33, 13);
            this.rozjezd.TabIndex = 9;
            this.rozjezd.Text = "hodin";
            // 
            // rozjet
            // 
            this.rozjet.Location = new System.Drawing.Point(230, 68);
            this.rozjet.Name = "rozjet";
            this.rozjet.Size = new System.Drawing.Size(75, 23);
            this.rozjet.TabIndex = 10;
            this.rozjet.Text = "Rozjet";
            this.rozjet.UseVisualStyleBackColor = true;
            this.rozjet.Visible = false;
            this.rozjet.Click += new System.EventHandler(this.rozjet_Click);
            // 
            // zastavit
            // 
            this.zastavit.Location = new System.Drawing.Point(311, 68);
            this.zastavit.Name = "zastavit";
            this.zastavit.Size = new System.Drawing.Size(75, 23);
            this.zastavit.TabIndex = 11;
            this.zastavit.Text = "Zastavit";
            this.zastavit.UseVisualStyleBackColor = true;
            this.zastavit.Visible = false;
            this.zastavit.Click += new System.EventHandler(this.zastavit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Celková spotřeba:";
            // 
            // spotreba
            // 
            this.spotreba.AutoSize = true;
            this.spotreba.Location = new System.Drawing.Point(157, 120);
            this.spotreba.Name = "spotreba";
            this.spotreba.Size = new System.Drawing.Size(23, 13);
            this.spotreba.TabIndex = 13;
            this.spotreba.Text = "litrů";
            // 
            // doba
            // 
            this.doba.AutoSize = true;
            this.doba.Location = new System.Drawing.Point(157, 147);
            this.doba.Name = "doba";
            this.doba.Size = new System.Drawing.Size(33, 13);
            this.doba.TabIndex = 15;
            this.doba.Text = "hodin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Celkem ujeto hodin:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 174);
            this.Controls.Add(this.doba);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.spotreba);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zastavit);
            this.Controls.Add(this.rozjet);
            this.Controls.Add(this.rozjezd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kilometry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_spotreba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_znacka);
            this.Controls.Add(this.vytvorit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Auto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vytvorit;
        private System.Windows.Forms.TextBox textBox_znacka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_spotreba;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kilometry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rozjezd;
        private System.Windows.Forms.Button rozjet;
        private System.Windows.Forms.Button zastavit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label spotreba;
        private System.Windows.Forms.Label doba;
        private System.Windows.Forms.Label label7;
    }
}

