namespace Oef2WindowsFormsApp1108
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbVrouw = new System.Windows.Forms.RadioButton();
            this.gbGeslacht = new System.Windows.Forms.GroupBox();
            this.gbProvincie = new System.Windows.Forms.GroupBox();
            this.rbWVL = new System.Windows.Forms.RadioButton();
            this.rbOVL = new System.Windows.Forms.RadioButton();
            this.rbAntwerp = new System.Windows.Forms.RadioButton();
            this.rbWB = new System.Windows.Forms.RadioButton();
            this.rbLim = new System.Windows.Forms.RadioButton();
            this.rbVB = new System.Windows.Forms.RadioButton();
            this.rbLuik = new System.Windows.Forms.RadioButton();
            this.rbNamen = new System.Windows.Forms.RadioButton();
            this.rbHene = new System.Windows.Forms.RadioButton();
            this.rbLux = new System.Windows.Forms.RadioButton();
            this.btnIndienen = new System.Windows.Forms.Button();
            this.lbVoornaam = new System.Windows.Forms.Label();
            this.lbAchternaam = new System.Windows.Forms.Label();
            this.lbAdres = new System.Windows.Forms.Label();
            this.lbStad = new System.Windows.Forms.Label();
            this.lbLeeftijd = new System.Windows.Forms.Label();
            this.rbBrussel = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbGeslacht.SuspendLayout();
            this.gbProvincie.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(111, 154);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 20);
            this.textBox4.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(111, 198);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(6, 19);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(46, 17);
            this.rbMan.TabIndex = 5;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbVrouw
            // 
            this.rbVrouw.AutoSize = true;
            this.rbVrouw.Location = new System.Drawing.Point(126, 19);
            this.rbVrouw.Name = "rbVrouw";
            this.rbVrouw.Size = new System.Drawing.Size(55, 17);
            this.rbVrouw.TabIndex = 6;
            this.rbVrouw.TabStop = true;
            this.rbVrouw.Text = "Vrouw";
            this.rbVrouw.UseVisualStyleBackColor = true;
            // 
            // gbGeslacht
            // 
            this.gbGeslacht.Controls.Add(this.rbMan);
            this.gbGeslacht.Controls.Add(this.rbVrouw);
            this.gbGeslacht.Location = new System.Drawing.Point(111, 239);
            this.gbGeslacht.Name = "gbGeslacht";
            this.gbGeslacht.Size = new System.Drawing.Size(217, 52);
            this.gbGeslacht.TabIndex = 7;
            this.gbGeslacht.TabStop = false;
            this.gbGeslacht.Text = "Geslacht";
            // 
            // gbProvincie
            // 
            this.gbProvincie.Controls.Add(this.rbBrussel);
            this.gbProvincie.Controls.Add(this.rbLux);
            this.gbProvincie.Controls.Add(this.rbLuik);
            this.gbProvincie.Controls.Add(this.rbNamen);
            this.gbProvincie.Controls.Add(this.rbHene);
            this.gbProvincie.Controls.Add(this.rbWB);
            this.gbProvincie.Controls.Add(this.rbLim);
            this.gbProvincie.Controls.Add(this.rbVB);
            this.gbProvincie.Controls.Add(this.rbAntwerp);
            this.gbProvincie.Controls.Add(this.rbOVL);
            this.gbProvincie.Controls.Add(this.rbWVL);
            this.gbProvincie.Location = new System.Drawing.Point(111, 310);
            this.gbProvincie.Name = "gbProvincie";
            this.gbProvincie.Size = new System.Drawing.Size(217, 276);
            this.gbProvincie.TabIndex = 8;
            this.gbProvincie.TabStop = false;
            this.gbProvincie.Text = "Provincie";
            // 
            // rbWVL
            // 
            this.rbWVL.AutoSize = true;
            this.rbWVL.Location = new System.Drawing.Point(7, 20);
            this.rbWVL.Name = "rbWVL";
            this.rbWVL.Size = new System.Drawing.Size(107, 17);
            this.rbWVL.TabIndex = 0;
            this.rbWVL.TabStop = true;
            this.rbWVL.Text = "West-Vlaanderen";
            this.rbWVL.UseVisualStyleBackColor = true;
            // 
            // rbOVL
            // 
            this.rbOVL.AutoSize = true;
            this.rbOVL.Location = new System.Drawing.Point(7, 43);
            this.rbOVL.Name = "rbOVL";
            this.rbOVL.Size = new System.Drawing.Size(104, 17);
            this.rbOVL.TabIndex = 1;
            this.rbOVL.TabStop = true;
            this.rbOVL.Text = "Oost-Vlaanderen";
            this.rbOVL.UseVisualStyleBackColor = true;
            // 
            // rbAntwerp
            // 
            this.rbAntwerp.AutoSize = true;
            this.rbAntwerp.Location = new System.Drawing.Point(7, 66);
            this.rbAntwerp.Name = "rbAntwerp";
            this.rbAntwerp.Size = new System.Drawing.Size(76, 17);
            this.rbAntwerp.TabIndex = 2;
            this.rbAntwerp.TabStop = true;
            this.rbAntwerp.Text = "Antwerpen";
            this.rbAntwerp.UseVisualStyleBackColor = true;
            // 
            // rbWB
            // 
            this.rbWB.AutoSize = true;
            this.rbWB.Location = new System.Drawing.Point(7, 135);
            this.rbWB.Name = "rbWB";
            this.rbWB.Size = new System.Drawing.Size(95, 17);
            this.rbWB.TabIndex = 5;
            this.rbWB.TabStop = true;
            this.rbWB.Text = "Waals-Brabant";
            this.rbWB.UseVisualStyleBackColor = true;
            // 
            // rbLim
            // 
            this.rbLim.AutoSize = true;
            this.rbLim.Location = new System.Drawing.Point(7, 89);
            this.rbLim.Name = "rbLim";
            this.rbLim.Size = new System.Drawing.Size(62, 17);
            this.rbLim.TabIndex = 4;
            this.rbLim.TabStop = true;
            this.rbLim.Text = "Limburg";
            this.rbLim.UseVisualStyleBackColor = true;
            // 
            // rbVB
            // 
            this.rbVB.AutoSize = true;
            this.rbVB.Location = new System.Drawing.Point(7, 112);
            this.rbVB.Name = "rbVB";
            this.rbVB.Size = new System.Drawing.Size(99, 17);
            this.rbVB.TabIndex = 3;
            this.rbVB.TabStop = true;
            this.rbVB.Text = "Vlaams-Brabant";
            this.rbVB.UseVisualStyleBackColor = true;
            // 
            // rbLuik
            // 
            this.rbLuik.AutoSize = true;
            this.rbLuik.Location = new System.Drawing.Point(7, 204);
            this.rbLuik.Name = "rbLuik";
            this.rbLuik.Size = new System.Drawing.Size(45, 17);
            this.rbLuik.TabIndex = 8;
            this.rbLuik.TabStop = true;
            this.rbLuik.Text = "Luik";
            this.rbLuik.UseVisualStyleBackColor = true;
            // 
            // rbNamen
            // 
            this.rbNamen.AutoSize = true;
            this.rbNamen.Location = new System.Drawing.Point(7, 181);
            this.rbNamen.Name = "rbNamen";
            this.rbNamen.Size = new System.Drawing.Size(59, 17);
            this.rbNamen.TabIndex = 7;
            this.rbNamen.TabStop = true;
            this.rbNamen.Text = "Namen";
            this.rbNamen.UseVisualStyleBackColor = true;
            // 
            // rbHene
            // 
            this.rbHene.AutoSize = true;
            this.rbHene.Location = new System.Drawing.Point(6, 227);
            this.rbHene.Name = "rbHene";
            this.rbHene.Size = new System.Drawing.Size(89, 17);
            this.rbHene.TabIndex = 6;
            this.rbHene.TabStop = true;
            this.rbHene.Text = "Henegouwen";
            this.rbHene.UseVisualStyleBackColor = true;
            // 
            // rbLux
            // 
            this.rbLux.AutoSize = true;
            this.rbLux.Location = new System.Drawing.Point(7, 250);
            this.rbLux.Name = "rbLux";
            this.rbLux.Size = new System.Drawing.Size(77, 17);
            this.rbLux.TabIndex = 9;
            this.rbLux.TabStop = true;
            this.rbLux.Text = "Luxemburg";
            this.rbLux.UseVisualStyleBackColor = true;
            // 
            // btnIndienen
            // 
            this.btnIndienen.Location = new System.Drawing.Point(111, 603);
            this.btnIndienen.Name = "btnIndienen";
            this.btnIndienen.Size = new System.Drawing.Size(217, 32);
            this.btnIndienen.TabIndex = 9;
            this.btnIndienen.Text = "Indienen";
            this.btnIndienen.UseVisualStyleBackColor = true;
            this.btnIndienen.Click += new System.EventHandler(this.btnIndienen_Click);
            // 
            // lbVoornaam
            // 
            this.lbVoornaam.AutoSize = true;
            this.lbVoornaam.Location = new System.Drawing.Point(13, 35);
            this.lbVoornaam.Name = "lbVoornaam";
            this.lbVoornaam.Size = new System.Drawing.Size(55, 13);
            this.lbVoornaam.TabIndex = 10;
            this.lbVoornaam.Text = "Voornaam";
            // 
            // lbAchternaam
            // 
            this.lbAchternaam.AutoSize = true;
            this.lbAchternaam.Location = new System.Drawing.Point(13, 76);
            this.lbAchternaam.Name = "lbAchternaam";
            this.lbAchternaam.Size = new System.Drawing.Size(64, 13);
            this.lbAchternaam.TabIndex = 11;
            this.lbAchternaam.Text = "Achternaam";
            // 
            // lbAdres
            // 
            this.lbAdres.AutoSize = true;
            this.lbAdres.Location = new System.Drawing.Point(13, 121);
            this.lbAdres.Name = "lbAdres";
            this.lbAdres.Size = new System.Drawing.Size(34, 13);
            this.lbAdres.TabIndex = 12;
            this.lbAdres.Text = "Adres";
            // 
            // lbStad
            // 
            this.lbStad.AutoSize = true;
            this.lbStad.Location = new System.Drawing.Point(13, 161);
            this.lbStad.Name = "lbStad";
            this.lbStad.Size = new System.Drawing.Size(29, 13);
            this.lbStad.TabIndex = 13;
            this.lbStad.Text = "Stad";
            // 
            // lbLeeftijd
            // 
            this.lbLeeftijd.AutoSize = true;
            this.lbLeeftijd.Location = new System.Drawing.Point(13, 205);
            this.lbLeeftijd.Name = "lbLeeftijd";
            this.lbLeeftijd.Size = new System.Drawing.Size(41, 13);
            this.lbLeeftijd.TabIndex = 14;
            this.lbLeeftijd.Text = "Leeftijd";
            // 
            // rbBrussel
            // 
            this.rbBrussel.AutoSize = true;
            this.rbBrussel.Location = new System.Drawing.Point(7, 158);
            this.rbBrussel.Name = "rbBrussel";
            this.rbBrussel.Size = new System.Drawing.Size(59, 17);
            this.rbBrussel.TabIndex = 10;
            this.rbBrussel.TabStop = true;
            this.rbBrussel.Text = "Brussel";
            this.rbBrussel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 648);
            this.Controls.Add(this.lbLeeftijd);
            this.Controls.Add(this.lbStad);
            this.Controls.Add(this.lbAdres);
            this.Controls.Add(this.lbAchternaam);
            this.Controls.Add(this.lbVoornaam);
            this.Controls.Add(this.btnIndienen);
            this.Controls.Add(this.gbProvincie);
            this.Controls.Add(this.gbGeslacht);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Personalia";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbGeslacht.ResumeLayout(false);
            this.gbGeslacht.PerformLayout();
            this.gbProvincie.ResumeLayout(false);
            this.gbProvincie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.RadioButton rbVrouw;
        private System.Windows.Forms.GroupBox gbGeslacht;
        private System.Windows.Forms.GroupBox gbProvincie;
        private System.Windows.Forms.RadioButton rbBrussel;
        private System.Windows.Forms.RadioButton rbLux;
        private System.Windows.Forms.RadioButton rbLuik;
        private System.Windows.Forms.RadioButton rbNamen;
        private System.Windows.Forms.RadioButton rbHene;
        private System.Windows.Forms.RadioButton rbWB;
        private System.Windows.Forms.RadioButton rbLim;
        private System.Windows.Forms.RadioButton rbVB;
        private System.Windows.Forms.RadioButton rbAntwerp;
        private System.Windows.Forms.RadioButton rbOVL;
        private System.Windows.Forms.RadioButton rbWVL;
        private System.Windows.Forms.Button btnIndienen;
        private System.Windows.Forms.Label lbVoornaam;
        private System.Windows.Forms.Label lbAchternaam;
        private System.Windows.Forms.Label lbAdres;
        private System.Windows.Forms.Label lbStad;
        private System.Windows.Forms.Label lbLeeftijd;
    }
}

