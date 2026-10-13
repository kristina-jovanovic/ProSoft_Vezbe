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
            cbGrad.SelectedItem = o.Grad;
        }

        private void SetComboBox()
        {
            List<string> polovi = Enum.GetNames<Pol>().ToList();
            cbPol.DataSource = polovi;
            cbPol.SelectedIndex = -1; // Na pocetku nije setovano ni na jedan pol (prazno je)

            List<Grad> gradovi = [ new Grad(11000, "Beograd"), new Grad(21000, "Novi Sad"),
            new Grad(18000, "Nis")];
            cbGrad.DataSource = gradovi;
            cbGrad.DisplayMember = "Naziv";
            cbGrad.SelectedIndex = -1;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            if(!DateTime.TryParseExact(txtDatumRodj.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime datumRodjenja))
            {
                MessageBox.Show("Unesite datum rodjenja!");
            }

            DateTime datumRodjenja1 = monthCalendar1.SelectionStart;
            string pol = cbPol.SelectedItem?.ToString() ?? "Nije odabrano";

            Osoba o = new Osoba
            {
                ImeIPrezime = ime,
                DatumRodjenja = datumRodjenja,
                Pol = Enum.Parse<Pol>(pol),
                Grad = (Grad)cbGrad.SelectedItem
            };
            MessageBox.Show($"Osoba: {ime}, rodjena {datumRodjenja1}, pol: {pol}, grad: {o.Grad.Naziv}");
        }

        private void cbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grad odabraniGrad = (Grad)cbGrad.SelectedItem;
            lblOdabraniGrad.Text = $"{odabraniGrad?.Ptt} {odabraniGrad?.Naziv}";
        }
    }
}
