using Domain;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly Osoba o;

        public Form1()
        {
            InitializeComponent();
            SetComboBox();
        }

        public Form1(Osoba o)
        {
            this.o = o;
            InitializeComponent();
            SetComboBox();
            PopuniPodatke();
        }

        private void PopuniPodatke()
        {
            txtIme.Text = o.ImeIPrezime;
            txtDatumRodj.Text = o.DatumRodjenja.ToString("dd.MM.yyyy.");
            cbPol.SelectedItem = o.Pol.ToString();
            monthCalendar1.SelectionStart = o.DatumRodjenja;
            monthCalendar1.MaxSelectionCount = 1;
        }

        private void SetComboBox()
        {
            List<string> polovi = Enum.GetNames<Pol>().ToList();
            cbPol.DataSource = polovi;
            cbPol.SelectedIndex = -1; // Na pocetku nije setovano ni na jedan pol (prazno je)
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            //string datumRodjenja = txtDatumRodj.Text;
            DateTime datumRodjenja = DateTime.MinValue;
            DateTime.TryParseExact(txtDatumRodj.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out datumRodjenja);

            DateTime datumRodjenja1 = monthCalendar1.SelectionStart; 
            string pol = cbPol.SelectedItem?.ToString() ?? "Nije odabrano";

            Osoba o = new Osoba
            {
                ImeIPrezime = ime,
                DatumRodjenja = datumRodjenja,
                Pol = Enum.Parse<Pol>(pol)
            };
            MessageBox.Show($"Osoba: {ime}, rodjena {datumRodjenja1}, pol: {pol}");
        }
    }
}
