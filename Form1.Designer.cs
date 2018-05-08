namespace hehhehehhe
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
            this.panelLoty = new System.Windows.Forms.Panel();
            this.przyciskAdmin = new System.Windows.Forms.Button();
            this.przyciskZarzadzaj = new System.Windows.Forms.Button();
            this.przyciskRezerwuj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wylotu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docelowe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godzinaOdlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godzinaprzylot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRezerw = new System.Windows.Forms.Panel();
            this.textKraj = new System.Windows.Forms.TextBox();
            this.textNrtel = new System.Windows.Forms.TextBox();
            this.textNazwisko = new System.Windows.Forms.TextBox();
            this.textImie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.przyciskDalej = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelKarta = new System.Windows.Forms.Panel();
            this.boxNrmiejsca = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.przyciskAkceptuj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkPriority = new System.Windows.Forms.CheckBox();
            this.checkBagaz = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelLoty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelRezerw.SuspendLayout();
            this.panelKarta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxNrmiejsca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLoty
            // 
            this.panelLoty.Controls.Add(this.przyciskAdmin);
            this.panelLoty.Controls.Add(this.przyciskZarzadzaj);
            this.panelLoty.Controls.Add(this.przyciskRezerwuj);
            this.panelLoty.Controls.Add(this.dataGridView1);
            this.panelLoty.Location = new System.Drawing.Point(1, 16);
            this.panelLoty.Name = "panelLoty";
            this.panelLoty.Size = new System.Drawing.Size(787, 533);
            this.panelLoty.TabIndex = 0;
            // 
            // przyciskAdmin
            // 
            this.przyciskAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przyciskAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przyciskAdmin.Location = new System.Drawing.Point(663, 503);
            this.przyciskAdmin.Name = "przyciskAdmin";
            this.przyciskAdmin.Size = new System.Drawing.Size(108, 28);
            this.przyciskAdmin.TabIndex = 3;
            this.przyciskAdmin.Text = "Administrator";
            this.przyciskAdmin.UseVisualStyleBackColor = true;
            // 
            // przyciskZarzadzaj
            // 
            this.przyciskZarzadzaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przyciskZarzadzaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przyciskZarzadzaj.Location = new System.Drawing.Point(103, 503);
            this.przyciskZarzadzaj.Name = "przyciskZarzadzaj";
            this.przyciskZarzadzaj.Size = new System.Drawing.Size(164, 28);
            this.przyciskZarzadzaj.TabIndex = 2;
            this.przyciskZarzadzaj.Text = "Zarządzaj rezerwacją";
            this.przyciskZarzadzaj.UseVisualStyleBackColor = true;
            // 
            // przyciskRezerwuj
            // 
            this.przyciskRezerwuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przyciskRezerwuj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przyciskRezerwuj.Location = new System.Drawing.Point(11, 503);
            this.przyciskRezerwuj.Name = "przyciskRezerwuj";
            this.przyciskRezerwuj.Size = new System.Drawing.Size(86, 28);
            this.przyciskRezerwuj.TabIndex = 1;
            this.przyciskRezerwuj.Text = "Rezerwuj";
            this.przyciskRezerwuj.UseVisualStyleBackColor = true;
            this.przyciskRezerwuj.Click += new System.EventHandler(this.przyciskRezerwuj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wylotu,
            this.docelowe,
            this.godzinaOdlot,
            this.godzinaprzylot,
            this.data});
            this.dataGridView1.Location = new System.Drawing.Point(11, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // wylotu
            // 
            this.wylotu.HeaderText = "Lotnisko wylotu";
            this.wylotu.Name = "wylotu";
            this.wylotu.ReadOnly = true;
            // 
            // docelowe
            // 
            this.docelowe.HeaderText = "Lotnisko docelowe";
            this.docelowe.Name = "docelowe";
            this.docelowe.ReadOnly = true;
            // 
            // godzinaOdlot
            // 
            this.godzinaOdlot.HeaderText = "Godzina odlotu";
            this.godzinaOdlot.Name = "godzinaOdlot";
            this.godzinaOdlot.ReadOnly = true;
            // 
            // godzinaprzylot
            // 
            this.godzinaprzylot.HeaderText = "Godzina przylotu";
            this.godzinaprzylot.Name = "godzinaprzylot";
            this.godzinaprzylot.ReadOnly = true;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // panelRezerw
            // 
            this.panelRezerw.Controls.Add(this.textKraj);
            this.panelRezerw.Controls.Add(this.textNrtel);
            this.panelRezerw.Controls.Add(this.textNazwisko);
            this.panelRezerw.Controls.Add(this.textImie);
            this.panelRezerw.Controls.Add(this.label5);
            this.panelRezerw.Controls.Add(this.label4);
            this.panelRezerw.Controls.Add(this.przyciskDalej);
            this.panelRezerw.Controls.Add(this.label2);
            this.panelRezerw.Controls.Add(this.label1);
            this.panelRezerw.Location = new System.Drawing.Point(1, 44);
            this.panelRezerw.Name = "panelRezerw";
            this.panelRezerw.Size = new System.Drawing.Size(784, 511);
            this.panelRezerw.TabIndex = 2;
            // 
            // textKraj
            // 
            this.textKraj.Location = new System.Drawing.Point(340, 184);
            this.textKraj.Name = "textKraj";
            this.textKraj.Size = new System.Drawing.Size(301, 20);
            this.textKraj.TabIndex = 8;
            // 
            // textNrtel
            // 
            this.textNrtel.Location = new System.Drawing.Point(340, 137);
            this.textNrtel.Name = "textNrtel";
            this.textNrtel.Size = new System.Drawing.Size(301, 20);
            this.textNrtel.TabIndex = 7;
            // 
            // textNazwisko
            // 
            this.textNazwisko.Location = new System.Drawing.Point(340, 92);
            this.textNazwisko.Name = "textNazwisko";
            this.textNazwisko.Size = new System.Drawing.Size(301, 20);
            this.textNazwisko.TabIndex = 6;
            // 
            // textImie
            // 
            this.textImie.Location = new System.Drawing.Point(340, 45);
            this.textImie.Name = "textImie";
            this.textImie.Size = new System.Drawing.Size(301, 20);
            this.textImie.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(76, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kraj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(76, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numer telefonu";
            // 
            // przyciskDalej
            // 
            this.przyciskDalej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przyciskDalej.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przyciskDalej.Location = new System.Drawing.Point(690, 465);
            this.przyciskDalej.Name = "przyciskDalej";
            this.przyciskDalej.Size = new System.Drawing.Size(81, 32);
            this.przyciskDalej.TabIndex = 2;
            this.przyciskDalej.Text = "Dalej";
            this.przyciskDalej.UseVisualStyleBackColor = true;
            this.przyciskDalej.Click += new System.EventHandler(this.przyciskDalej_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(76, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(76, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // panelKarta
            // 
            this.panelKarta.Controls.Add(this.boxNrmiejsca);
            this.panelKarta.Controls.Add(this.label7);
            this.panelKarta.Controls.Add(this.label6);
            this.panelKarta.Controls.Add(this.pictureBox1);
            this.panelKarta.Controls.Add(this.przyciskAkceptuj);
            this.panelKarta.Controls.Add(this.label3);
            this.panelKarta.Controls.Add(this.checkPriority);
            this.panelKarta.Controls.Add(this.checkBagaz);
            this.panelKarta.Controls.Add(this.label8);
            this.panelKarta.Location = new System.Drawing.Point(1, 24);
            this.panelKarta.Name = "panelKarta";
            this.panelKarta.Size = new System.Drawing.Size(784, 540);
            this.panelKarta.TabIndex = 3;
            // 
            // boxNrmiejsca
            // 
            this.boxNrmiejsca.Location = new System.Drawing.Point(353, 206);
            this.boxNrmiejsca.Maximum = new decimal(new int[] {
            156,
            0,
            0,
            0});
            this.boxNrmiejsca.Name = "boxNrmiejsca";
            this.boxNrmiejsca.Size = new System.Drawing.Size(67, 20);
            this.boxNrmiejsca.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(11, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Wybieram miejsce nr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(11, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chcę wykupić priority pass! - 50zł";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hehhehehhe.Properties.Resources.A319_Kadrowane530PNG;
            this.pictureBox1.Location = new System.Drawing.Point(493, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 530);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // przyciskAkceptuj
            // 
            this.przyciskAkceptuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przyciskAkceptuj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przyciskAkceptuj.Location = new System.Drawing.Point(677, 476);
            this.przyciskAkceptuj.Name = "przyciskAkceptuj";
            this.przyciskAkceptuj.Size = new System.Drawing.Size(94, 29);
            this.przyciskAkceptuj.TabIndex = 3;
            this.przyciskAkceptuj.Text = "Akceptuj!";
            this.przyciskAkceptuj.UseVisualStyleBackColor = true;
            this.przyciskAkceptuj.Click += new System.EventHandler(this.przyciskZarezerwuj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chcę wykupić bagaż rejstrowany! - 110zł";
            // 
            // checkPriority
            // 
            this.checkPriority.AutoSize = true;
            this.checkPriority.Location = new System.Drawing.Point(353, 138);
            this.checkPriority.Name = "checkPriority";
            this.checkPriority.Size = new System.Drawing.Size(15, 14);
            this.checkPriority.TabIndex = 1;
            this.checkPriority.UseVisualStyleBackColor = true;
            // 
            // checkBagaz
            // 
            this.checkBagaz.AutoSize = true;
            this.checkBagaz.Location = new System.Drawing.Point(353, 65);
            this.checkBagaz.Name = "checkBagaz";
            this.checkBagaz.Size = new System.Drawing.Size(15, 14);
            this.checkBagaz.TabIndex = 0;
            this.checkBagaz.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(3, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(468, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Miejsca 1-6 oraz 55-66 to miejsca z większą przestrzenią na nogi!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelLoty);
            this.Controls.Add(this.panelKarta);
            this.Controls.Add(this.panelRezerw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLoty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelRezerw.ResumeLayout(false);
            this.panelRezerw.PerformLayout();
            this.panelKarta.ResumeLayout(false);
            this.panelKarta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxNrmiejsca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoty;
        private System.Windows.Forms.Panel panelRezerw;
        private System.Windows.Forms.Panel panelKarta;
        private System.Windows.Forms.Button przyciskAkceptuj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkPriority;
        private System.Windows.Forms.CheckBox checkBagaz;
        private System.Windows.Forms.Button przyciskDalej;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button przyciskRezerwuj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wylotu;
        private System.Windows.Forms.DataGridViewTextBoxColumn docelowe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button przyciskAdmin;
        private System.Windows.Forms.Button przyciskZarzadzaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown boxNrmiejsca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textKraj;
        private System.Windows.Forms.TextBox textNrtel;
        private System.Windows.Forms.TextBox textNazwisko;
        private System.Windows.Forms.TextBox textImie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzinaOdlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzinaprzylot;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
    }
}

