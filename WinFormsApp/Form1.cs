namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetComboBox();
        }

        private void SetComboBox()
        {
            List<string> polovi = new List<string> { "Muski", "Zenski", "Drugo" };
            //DOMACI: napraviti enum Pol { Muski, Zenski, Drugo } i koristiti ga umesto stringova
            cbPol.DataSource = polovi;
            cbPol.SelectedIndex = -1; // Na pocetku nije setovano ni na jedan pol (prazno je)
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            //string datumRodjenja = txtDatumRodj.Text;
            DateTime datumRodjenja = DateTime.MinValue;
            DateTime.TryParseExact(txtDatumRodj.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out datumRodjenja);

            DateTime datumRodjenja1 = monthCalendar1.SelectionStart; // Koristimo MonthCalendar za odabir datuma
            string pol = cbPol.SelectedItem?.ToString() ?? "Nije odabrano";

            //DOMACI: napraviti objekat klase Person, postaviti vrednosti property-ja i ispisati u MessageBox-u

            //MessageBox.Show($"Osoba: {ime}, rodjena {datumRodjenja}, pol: {pol}");
            MessageBox.Show($"Osoba: {ime}, rodjena {datumRodjenja1}, pol: {pol}");
        }
    }
}
