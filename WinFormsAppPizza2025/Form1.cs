namespace WinFormsAppPizza2025
{
    public partial class Form1 : Form
    {
        string secilenMalzeme;
        int secilenPizzaBoyutu;
        double malzemeFiyati = 5;
        double toplamTutar = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (checkBoxBiber.Checked && !listBoxMalzemeler.Items.Contains("Biber"))
            {
                listBoxMalzemeler.Items.Add("Biber");
            }
            if (checkBoxDomates.Checked && !listBoxMalzemeler.Items.Contains("Domates"))
            {
                listBoxMalzemeler.Items.Add("Domates");
            }
            if (checkBoxMantar.Checked && !listBoxMalzemeler.Items.Contains("Mantar"))
            {
                listBoxMalzemeler.Items.Add("Mantar");
            }
            if (checkBoxMisir.Checked && !listBoxMalzemeler.Items.Contains("Mýsýr"))
            {
                listBoxMalzemeler.Items.Add("Mýsýr");
            }
            if (checkBoxSalam.Checked && !listBoxMalzemeler.Items.Contains("Salam"))
            {
                listBoxMalzemeler.Items.Add("Salam");
            }
            if (checkBoxSosis.Checked && !listBoxMalzemeler.Items.Contains("Sosis"))
            {
                listBoxMalzemeler.Items.Add("Sosis");
            }
            if (checkBoxSucuk.Checked && !listBoxMalzemeler.Items.Contains("Sucuk"))
            {
                listBoxMalzemeler.Items.Add("Sucuk");
            }
            if (checkBoxZeytin.Checked && !listBoxMalzemeler.Items.Contains("Zeytin"))
            {
                listBoxMalzemeler.Items.Add("Zeytin");
            }

        }

        private void buttonCikar_Click(object sender, EventArgs e)
        {
            if (listBoxMalzemeler.SelectedItem != null)
            {
                listBoxMalzemeler.Items.Remove(listBoxMalzemeler.SelectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen çýkarmak istediðiniz malzemeyi seçin.");
            }
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            if (radioButtonKucuk.Checked)
            {
                toplamTutar = 100 + (malzemeFiyati * listBoxMalzemeler.Items.Count);
            }
            else if (radioButtonOrta.Checked)
            {
                toplamTutar = 150 + (malzemeFiyati * listBoxMalzemeler.Items.Count);
            }
            else if (radioButtonBuyuk.Checked)
            {
                toplamTutar = 200 + (malzemeFiyati * listBoxMalzemeler.Items.Count);
            }

            textBoxFiyat.Text = toplamTutar+" TL";
        }
    }
}
