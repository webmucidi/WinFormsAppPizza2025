namespace WinFormsAppPizza2025
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelBaslik = new Label();
            pictureBoxLogo = new PictureBox();
            groupBoxMalzemeler = new GroupBox();
            checkBoxDomates = new CheckBox();
            checkBoxMantar = new CheckBox();
            checkBoxSalam = new CheckBox();
            checkBoxMisir = new CheckBox();
            checkBoxZeytin = new CheckBox();
            checkBoxSosis = new CheckBox();
            checkBoxBiber = new CheckBox();
            checkBoxSucuk = new CheckBox();
            groupBoxBoyut = new GroupBox();
            radioButtonBuyuk = new RadioButton();
            radioButtonOrta = new RadioButton();
            radioButtonKucuk = new RadioButton();
            listBoxMalzemeler = new ListBox();
            labelSecimler = new Label();
            buttonEkle = new Button();
            buttonHesapla = new Button();
            textBoxFiyat = new TextBox();
            labelSonuc = new Label();
            buttonCikar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            groupBoxMalzemeler.SuspendLayout();
            groupBoxBoyut.SuspendLayout();
            SuspendLayout();
            // 
            // labelBaslik
            // 
            labelBaslik.AutoSize = true;
            labelBaslik.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelBaslik.ForeColor = Color.IndianRed;
            labelBaslik.Location = new Point(274, 29);
            labelBaslik.Name = "labelBaslik";
            labelBaslik.Size = new Size(246, 30);
            labelBaslik.TabIndex = 0;
            labelBaslik.Text = "PİZZA SİPARİŞ FORMU";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.pizza;
            pictureBoxLogo.Location = new Point(611, 82);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(177, 192);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // groupBoxMalzemeler
            // 
            groupBoxMalzemeler.Controls.Add(checkBoxDomates);
            groupBoxMalzemeler.Controls.Add(checkBoxMantar);
            groupBoxMalzemeler.Controls.Add(checkBoxSalam);
            groupBoxMalzemeler.Controls.Add(checkBoxMisir);
            groupBoxMalzemeler.Controls.Add(checkBoxZeytin);
            groupBoxMalzemeler.Controls.Add(checkBoxSosis);
            groupBoxMalzemeler.Controls.Add(checkBoxBiber);
            groupBoxMalzemeler.Controls.Add(checkBoxSucuk);
            groupBoxMalzemeler.Location = new Point(40, 94);
            groupBoxMalzemeler.Name = "groupBoxMalzemeler";
            groupBoxMalzemeler.Size = new Size(269, 126);
            groupBoxMalzemeler.TabIndex = 2;
            groupBoxMalzemeler.TabStop = false;
            groupBoxMalzemeler.Text = "Malzeme seçimi(Malzeme başına +5 TL):";
            // 
            // checkBoxDomates
            // 
            checkBoxDomates.AutoSize = true;
            checkBoxDomates.Location = new Point(146, 101);
            checkBoxDomates.Name = "checkBoxDomates";
            checkBoxDomates.Size = new Size(73, 19);
            checkBoxDomates.TabIndex = 0;
            checkBoxDomates.Text = "Domates";
            checkBoxDomates.UseVisualStyleBackColor = true;
            // 
            // checkBoxMantar
            // 
            checkBoxMantar.AutoSize = true;
            checkBoxMantar.Location = new Point(13, 101);
            checkBoxMantar.Name = "checkBoxMantar";
            checkBoxMantar.Size = new Size(64, 19);
            checkBoxMantar.TabIndex = 0;
            checkBoxMantar.Text = "Mantar";
            checkBoxMantar.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalam
            // 
            checkBoxSalam.AutoSize = true;
            checkBoxSalam.Location = new Point(146, 78);
            checkBoxSalam.Name = "checkBoxSalam";
            checkBoxSalam.Size = new Size(58, 19);
            checkBoxSalam.TabIndex = 0;
            checkBoxSalam.Text = "Salam";
            checkBoxSalam.UseVisualStyleBackColor = true;
            // 
            // checkBoxMisir
            // 
            checkBoxMisir.AutoSize = true;
            checkBoxMisir.Location = new Point(13, 78);
            checkBoxMisir.Name = "checkBoxMisir";
            checkBoxMisir.Size = new Size(52, 19);
            checkBoxMisir.TabIndex = 0;
            checkBoxMisir.Text = "Mısır";
            checkBoxMisir.UseVisualStyleBackColor = true;
            // 
            // checkBoxZeytin
            // 
            checkBoxZeytin.AutoSize = true;
            checkBoxZeytin.Location = new Point(146, 53);
            checkBoxZeytin.Name = "checkBoxZeytin";
            checkBoxZeytin.Size = new Size(59, 19);
            checkBoxZeytin.TabIndex = 0;
            checkBoxZeytin.Text = "Zeytin";
            checkBoxZeytin.UseVisualStyleBackColor = true;
            // 
            // checkBoxSosis
            // 
            checkBoxSosis.AutoSize = true;
            checkBoxSosis.Location = new Point(13, 53);
            checkBoxSosis.Name = "checkBoxSosis";
            checkBoxSosis.Size = new Size(52, 19);
            checkBoxSosis.TabIndex = 0;
            checkBoxSosis.Text = "Sosis";
            checkBoxSosis.UseVisualStyleBackColor = true;
            // 
            // checkBoxBiber
            // 
            checkBoxBiber.AutoSize = true;
            checkBoxBiber.Location = new Point(146, 28);
            checkBoxBiber.Name = "checkBoxBiber";
            checkBoxBiber.Size = new Size(53, 19);
            checkBoxBiber.TabIndex = 0;
            checkBoxBiber.Text = "Biber";
            checkBoxBiber.UseVisualStyleBackColor = true;
            // 
            // checkBoxSucuk
            // 
            checkBoxSucuk.AutoSize = true;
            checkBoxSucuk.Location = new Point(13, 28);
            checkBoxSucuk.Name = "checkBoxSucuk";
            checkBoxSucuk.Size = new Size(58, 19);
            checkBoxSucuk.TabIndex = 0;
            checkBoxSucuk.Text = "Sucuk";
            checkBoxSucuk.UseVisualStyleBackColor = true;
            // 
            // groupBoxBoyut
            // 
            groupBoxBoyut.Controls.Add(radioButtonBuyuk);
            groupBoxBoyut.Controls.Add(radioButtonOrta);
            groupBoxBoyut.Controls.Add(radioButtonKucuk);
            groupBoxBoyut.Location = new Point(47, 258);
            groupBoxBoyut.Name = "groupBoxBoyut";
            groupBoxBoyut.Size = new Size(262, 101);
            groupBoxBoyut.TabIndex = 3;
            groupBoxBoyut.TabStop = false;
            groupBoxBoyut.Text = "Pizza boyutu:";
            // 
            // radioButtonBuyuk
            // 
            radioButtonBuyuk.AutoSize = true;
            radioButtonBuyuk.Location = new Point(6, 72);
            radioButtonBuyuk.Name = "radioButtonBuyuk";
            radioButtonBuyuk.Size = new Size(99, 19);
            radioButtonBuyuk.TabIndex = 0;
            radioButtonBuyuk.TabStop = true;
            radioButtonBuyuk.Text = "Büyük(200 TL)";
            radioButtonBuyuk.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrta
            // 
            radioButtonOrta.AutoSize = true;
            radioButtonOrta.Location = new Point(6, 47);
            radioButtonOrta.Name = "radioButtonOrta";
            radioButtonOrta.Size = new Size(89, 19);
            radioButtonOrta.TabIndex = 0;
            radioButtonOrta.TabStop = true;
            radioButtonOrta.Text = "Orta(150 TL)";
            radioButtonOrta.UseVisualStyleBackColor = true;
            // 
            // radioButtonKucuk
            // 
            radioButtonKucuk.AutoSize = true;
            radioButtonKucuk.Location = new Point(6, 22);
            radioButtonKucuk.Name = "radioButtonKucuk";
            radioButtonKucuk.Size = new Size(99, 19);
            radioButtonKucuk.TabIndex = 0;
            radioButtonKucuk.TabStop = true;
            radioButtonKucuk.Text = "Küçük(100 TL)";
            radioButtonKucuk.UseVisualStyleBackColor = true;
            // 
            // listBoxMalzemeler
            // 
            listBoxMalzemeler.FormattingEnabled = true;
            listBoxMalzemeler.ItemHeight = 15;
            listBoxMalzemeler.Location = new Point(440, 112);
            listBoxMalzemeler.Name = "listBoxMalzemeler";
            listBoxMalzemeler.Size = new Size(154, 109);
            listBoxMalzemeler.TabIndex = 4;
            // 
            // labelSecimler
            // 
            labelSecimler.AutoSize = true;
            labelSecimler.Location = new Point(440, 94);
            labelSecimler.Name = "labelSecimler";
            labelSecimler.Size = new Size(111, 15);
            labelSecimler.TabIndex = 5;
            labelSecimler.Text = "Seçilen malzemeler:";
            // 
            // buttonEkle
            // 
            buttonEkle.Location = new Point(333, 147);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(71, 23);
            buttonEkle.TabIndex = 6;
            buttonEkle.Text = "EKLE>";
            buttonEkle.UseVisualStyleBackColor = true;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // buttonHesapla
            // 
            buttonHesapla.Location = new Point(333, 301);
            buttonHesapla.Name = "buttonHesapla";
            buttonHesapla.Size = new Size(71, 23);
            buttonHesapla.TabIndex = 7;
            buttonHesapla.Text = "HESAPLA>";
            buttonHesapla.UseVisualStyleBackColor = true;
            buttonHesapla.Click += buttonHesapla_Click;
            // 
            // textBoxFiyat
            // 
            textBoxFiyat.Enabled = false;
            textBoxFiyat.Location = new Point(526, 297);
            textBoxFiyat.Name = "textBoxFiyat";
            textBoxFiyat.Size = new Size(68, 23);
            textBoxFiyat.TabIndex = 8;
            // 
            // labelSonuc
            // 
            labelSonuc.AutoSize = true;
            labelSonuc.Location = new Point(440, 305);
            labelSonuc.Name = "labelSonuc";
            labelSonuc.Size = new Size(80, 15);
            labelSonuc.TabIndex = 9;
            labelSonuc.Text = "Ödeme tutarı:";
            // 
            // buttonCikar
            // 
            buttonCikar.Location = new Point(333, 176);
            buttonCikar.Name = "buttonCikar";
            buttonCikar.Size = new Size(71, 23);
            buttonCikar.TabIndex = 6;
            buttonCikar.Text = "<ÇIKAR";
            buttonCikar.UseVisualStyleBackColor = true;
            buttonCikar.Click += buttonCikar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSonuc);
            Controls.Add(textBoxFiyat);
            Controls.Add(buttonHesapla);
            Controls.Add(buttonCikar);
            Controls.Add(buttonEkle);
            Controls.Add(labelSecimler);
            Controls.Add(listBoxMalzemeler);
            Controls.Add(groupBoxBoyut);
            Controls.Add(groupBoxMalzemeler);
            Controls.Add(pictureBoxLogo);
            Controls.Add(labelBaslik);
            Name = "Form1";
            Text = "win7";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            groupBoxMalzemeler.ResumeLayout(false);
            groupBoxMalzemeler.PerformLayout();
            groupBoxBoyut.ResumeLayout(false);
            groupBoxBoyut.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBaslik;
        private PictureBox pictureBoxLogo;
        private GroupBox groupBoxMalzemeler;
        private CheckBox checkBoxDomates;
        private CheckBox checkBoxMantar;
        private CheckBox checkBoxSalam;
        private CheckBox checkBoxMisir;
        private CheckBox checkBoxZeytin;
        private CheckBox checkBoxSosis;
        private CheckBox checkBoxBiber;
        private CheckBox checkBoxSucuk;
        private GroupBox groupBoxBoyut;
        private RadioButton radioButtonBuyuk;
        private RadioButton radioButtonOrta;
        private RadioButton radioButtonKucuk;
        private ListBox listBoxMalzemeler;
        private Label labelSecimler;
        private Button buttonEkle;
        private Button buttonHesapla;
        private TextBox textBoxFiyat;
        private Label labelSonuc;
        private Button buttonCikar;
    }
}
