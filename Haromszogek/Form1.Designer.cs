
namespace Haromszogek
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
            this.btnAdatokBetoltese = new System.Windows.Forms.Button();
            this.gbHibak = new System.Windows.Forms.GroupBox();
            this.gbDHaromszog = new System.Windows.Forms.GroupBox();
            this.gbAdatok = new System.Windows.Forms.GroupBox();
            this.ofdMegnyitas = new System.Windows.Forms.OpenFileDialog();
            this.lbHibak = new System.Windows.Forms.ListBox();
            this.lbHaromszog = new System.Windows.Forms.ListBox();
            this.lbKerulet = new System.Windows.Forms.Label();
            this.lbTerulet = new System.Windows.Forms.Label();
            this.gbHibak.SuspendLayout();
            this.gbDHaromszog.SuspendLayout();
            this.gbAdatok.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdatokBetoltese
            // 
            this.btnAdatokBetoltese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdatokBetoltese.Location = new System.Drawing.Point(20, 20);
            this.btnAdatokBetoltese.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdatokBetoltese.Name = "btnAdatokBetoltese";
            this.btnAdatokBetoltese.Size = new System.Drawing.Size(142, 32);
            this.btnAdatokBetoltese.TabIndex = 0;
            this.btnAdatokBetoltese.Text = "Adatok betöltése";
            this.btnAdatokBetoltese.UseVisualStyleBackColor = true;
            this.btnAdatokBetoltese.Click += new System.EventHandler(this.btnAdatokBetoltese_Click);
            // 
            // gbHibak
            // 
            this.gbHibak.Controls.Add(this.lbHibak);
            this.gbHibak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbHibak.Location = new System.Drawing.Point(20, 60);
            this.gbHibak.Name = "gbHibak";
            this.gbHibak.Size = new System.Drawing.Size(652, 113);
            this.gbHibak.TabIndex = 1;
            this.gbHibak.TabStop = false;
            this.gbHibak.Text = "Hibák a kiválasztott állományban";
            // 
            // gbDHaromszog
            // 
            this.gbDHaromszog.Controls.Add(this.lbHaromszog);
            this.gbDHaromszog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbDHaromszog.Location = new System.Drawing.Point(20, 179);
            this.gbDHaromszog.Name = "gbDHaromszog";
            this.gbDHaromszog.Size = new System.Drawing.Size(221, 220);
            this.gbDHaromszog.TabIndex = 1;
            this.gbDHaromszog.TabStop = false;
            this.gbDHaromszog.Text = "Derékszögű háromszögek";
            // 
            // gbAdatok
            // 
            this.gbAdatok.Controls.Add(this.lbTerulet);
            this.gbAdatok.Controls.Add(this.lbKerulet);
            this.gbAdatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbAdatok.Location = new System.Drawing.Point(257, 179);
            this.gbAdatok.Name = "gbAdatok";
            this.gbAdatok.Size = new System.Drawing.Size(415, 140);
            this.gbAdatok.TabIndex = 1;
            this.gbAdatok.TabStop = false;
            this.gbAdatok.Text = "Kiválasztott derékszögű háromszög adatai";
            // 
            // ofdMegnyitas
            // 
            this.ofdMegnyitas.Filter = "Szöveg fájlok|*.txt";
            this.ofdMegnyitas.Title = "Adatfájl megnyitása";
            // 
            // lbHibak
            // 
            this.lbHibak.BackColor = System.Drawing.SystemColors.Control;
            this.lbHibak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbHibak.Enabled = false;
            this.lbHibak.FormattingEnabled = true;
            this.lbHibak.ItemHeight = 16;
            this.lbHibak.Location = new System.Drawing.Point(7, 23);
            this.lbHibak.Name = "lbHibak";
            this.lbHibak.Size = new System.Drawing.Size(639, 80);
            this.lbHibak.TabIndex = 0;
            // 
            // lbHaromszog
            // 
            this.lbHaromszog.BackColor = System.Drawing.SystemColors.Control;
            this.lbHaromszog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbHaromszog.FormattingEnabled = true;
            this.lbHaromszog.ItemHeight = 16;
            this.lbHaromszog.Location = new System.Drawing.Point(6, 22);
            this.lbHaromszog.Name = "lbHaromszog";
            this.lbHaromszog.Size = new System.Drawing.Size(209, 192);
            this.lbHaromszog.TabIndex = 0;
            this.lbHaromszog.SelectedIndexChanged += new System.EventHandler(this.lbHaromszog_SelectedIndexChanged);
            // 
            // lbKerulet
            // 
            this.lbKerulet.AutoSize = true;
            this.lbKerulet.Location = new System.Drawing.Point(23, 34);
            this.lbKerulet.Name = "lbKerulet";
            this.lbKerulet.Size = new System.Drawing.Size(69, 17);
            this.lbKerulet.TabIndex = 0;
            this.lbKerulet.Text = "Kerület = ";
            // 
            // lbTerulet
            // 
            this.lbTerulet.AutoSize = true;
            this.lbTerulet.Location = new System.Drawing.Point(23, 69);
            this.lbTerulet.Name = "lbTerulet";
            this.lbTerulet.Size = new System.Drawing.Size(69, 17);
            this.lbTerulet.TabIndex = 1;
            this.lbTerulet.Text = "Terület = ";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdatokBetoltese;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.gbAdatok);
            this.Controls.Add(this.gbDHaromszog);
            this.Controls.Add(this.gbHibak);
            this.Controls.Add(this.btnAdatokBetoltese);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Derékszögű háromszögek";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.gbHibak.ResumeLayout(false);
            this.gbDHaromszog.ResumeLayout(false);
            this.gbAdatok.ResumeLayout(false);
            this.gbAdatok.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdatokBetoltese;
        private System.Windows.Forms.GroupBox gbHibak;
        private System.Windows.Forms.GroupBox gbDHaromszog;
        private System.Windows.Forms.GroupBox gbAdatok;
        private System.Windows.Forms.OpenFileDialog ofdMegnyitas;
        private System.Windows.Forms.ListBox lbHibak;
        private System.Windows.Forms.ListBox lbHaromszog;
        private System.Windows.Forms.Label lbTerulet;
        private System.Windows.Forms.Label lbKerulet;
    }
}

