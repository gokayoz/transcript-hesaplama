using TranscriptHesaplama.UI.Data;

namespace TranscriptHesaplama.UI
{
    public partial class FRMTranscriptEkrani : Form
    {
        Ders secilenDers;
        List<Ders> secilenDersler = new List<Ders>()
        {
            new Ders{ Ad="MatematikI", Kredi=3, Kod="MAT101" },
            new Ders{ Ad="FizikI", Kredi=3, Kod="FIZ101" },
            new Ders{ Ad="Kimya", Kredi=2, Kod="KIM101" },
            new Ders{ Ad="Programlama", Kredi=4, Kod="PROG101" },
            new Ders{ Ad="Veri Yapýlarý", Kredi=3, Kod="VER101" },
            new Ders{ Ad="Ýþletim Sistemleri", Kredi=3, Kod="IS101" },
            new Ders{ Ad="Biyoloji", Kredi=2, Kod="BIO101" },
            new Ders{ Ad="Türkçe", Kredi=1, Kod="TUR101" },
            new Ders{ Ad="Edebiyat", Kredi=2, Kod="ED101" },
            new Ders{ Ad="Tarih", Kredi=2, Kod="TAR101" }
        };
        public FRMTranscriptEkrani()
        {
            InitializeComponent();
            DersleriGetir();
            NotlariEkle();
        }

        private void DersleriGetir()
        {
            dgvDersler.DataSource = null;
            dgvDersler.DataSource = secilenDersler;
        }

        public void NotlariEkle()
        {
            cmbAraSinav.Items.Add("Seçiniz");
            cmbFinal.Items.Add("Seçiniz");
            for (int i = 0; i <= 100; i++)
            {
                cmbAraSinav.Items.Add(i);
                cmbFinal.Items.Add(i);
            }
            cmbAraSinav.SelectedIndex = cmbFinal.SelectedIndex = 0;
        }
        public void HarfNotunuAta(Ders ders)
        {
            double sonNot = ders.Vize * 0.4 + ders.Final * 0.6;
            switch (sonNot)
            {
                case <= 100 and >= 90:
                    ders.HarfNotu = Enums.HarfNotu.AA;
                    break;
                case < 90 and >= 80:
                    ders.HarfNotu = Enums.HarfNotu.BA;
                    break;
                case < 80 and >= 70:
                    ders.HarfNotu = Enums.HarfNotu.BB;
                    break;
                case < 70 and >= 60:
                    ders.HarfNotu = Enums.HarfNotu.CB;
                    break;
                case < 60 and >= 55:
                    ders.HarfNotu = Enums.HarfNotu.CC;
                    break;
                case < 55 and >= 50:
                    ders.HarfNotu = Enums.HarfNotu.DC;
                    break;
                case < 50 and > 45:
                    ders.HarfNotu = Enums.HarfNotu.DD;
                    break;
                default:
                    ders.HarfNotu = Enums.HarfNotu.FF;
                    break;
            }
        }

        private void dgvDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSecilen.Text = "Seçilen Ders:";
            secilenDers = (Ders)dgvDersler.SelectedRows[0].DataBoundItem;
            lblSecilen.Text += " " + secilenDers.Kod + " " + secilenDers.Ad + " " + secilenDers.Kredi;
        }

        private void cmbAraSinav_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAraSinav.Items.Contains("Seçiniz"))
            {
                cmbAraSinav.Items.RemoveAt(0);
            }

            if (secilenDers == null && cmbAraSinav.Items.Count != 102)
            {
                MessageBox.Show("Lütfen ara sýnav için ders seçiniz");
                return;
            }
            if (cmbAraSinav.Items.Count != 102 && cmbAraSinav.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen not seçiniz");
                return;
            }

            if (cmbAraSinav.Items.Count != 102)
            {
                secilenDers.Vize = Convert.ToUInt32(cmbAraSinav.SelectedItem);
            }
        }

        private void cmbFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFinal.Items.Contains("Seçiniz"))
            {
                cmbFinal.Items.RemoveAt(0);
            }

            if (secilenDers == null && cmbFinal.Items.Count != 102)
            {
                MessageBox.Show("Lütfen final için ders seçiniz");
                return;
            }
            if (cmbFinal.Items.Count != 102 && cmbFinal.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen not seçiniz");
                return;
            }

            if (cmbFinal.Items.Count != 102)
            {
                secilenDers.Final = Convert.ToUInt32(cmbFinal.SelectedItem);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            uint toplamKredi = 0;
            foreach (var ders in secilenDersler)
            {
                toplam += (((int)ders.HarfNotu) / 10.0) * ders.Kredi;
                toplamKredi += (ders.Kredi);
            }
            toplam /= toplamKredi;
            lblGNO.Text = "GNO: " + toplam;
        }

        private void btnDersHesapla_Click(object sender, EventArgs e)
        {
            if (secilenDers != null)
            {
                if (cmbAraSinav.SelectedIndex == 0 || cmbFinal.SelectedIndex == 0)
                {
                    MessageBox.Show("Lütfen arasýnav/finali seçiniz");
                    return;
                }
                secilenDers.Vize = Convert.ToUInt32(cmbAraSinav.SelectedItem);
                secilenDers.Final = Convert.ToUInt32(cmbFinal.SelectedItem);
                HarfNotunuAta(secilenDers);
                DersleriGetir();
            }
            else
                MessageBox.Show("Lütfen ders seçiniz");
        }
    }
}
