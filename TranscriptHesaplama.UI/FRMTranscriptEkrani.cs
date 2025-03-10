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
            new Ders{ Ad="Veri Yap�lar�", Kredi=3, Kod="VER101" },
            new Ders{ Ad="��letim Sistemleri", Kredi=3, Kod="IS101" },
            new Ders{ Ad="Biyoloji", Kredi=2, Kod="BIO101" },
            new Ders{ Ad="T�rk�e", Kredi=1, Kod="TUR101" },
            new Ders{ Ad="Edebiyat", Kredi=2, Kod="ED101" },
            new Ders{ Ad="Tarih", Kredi=2, Kod="TAR101" }
        };
        public FRMTranscriptEkrani()
        {
            InitializeComponent();
            dgvDersler.DataSource = secilenDersler;
            dgvDersler.Columns[3].Visible = dgvDersler.Columns[4].Visible = dgvDersler.Columns[5].Visible = false;
            NotlariEkle();
        }
        public void NotlariEkle()
        {
            cmbAraSinav.Items.Add("Se�iniz");
            cmbFinal.Items.Add("Se�iniz");
            cmbAraSinav.Items.Add("Se�iniz");
            cmbFinal.Items.Add("Se�iniz");
            for (int i = 0; i <= 100; i++)
            {
                cmbAraSinav.Items.Add(i);
                cmbFinal.Items.Add(i);
            }
            //Program a��ld���nda 
            cmbAraSinav.SelectedIndex = cmbFinal.SelectedIndex = 1;
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
            //Sat�rlarda h�creye bas�nca ��kmesin diye grid'in selectionmode'unu FullRowSelect yapar�z.
            lblSecilen.Text = "SE��LEN DERS:";
            secilenDers = (Ders)dgvDersler.SelectedRows[0].DataBoundItem;
            lblSecilen.Text += " " + secilenDers.Kod + " " + secilenDers.Ad + " " + secilenDers.Kredi;
        }

        private void cmbAraSinav_SelectedIndexChanged(object sender, EventArgs e)
        {


            //Bakal�m sonra
            //if (cmbAraSinav.SelectedIndex == 0 && cmbAraSinav.DroppedDown)
            //{
            //    MessageBox.Show("L�tfen bir se�enek se�in."); cmbAraSinav.SelectedIndex = -1; // Se�imi iptal et }

            //}
            //her zaman arasinav not de�i�ti�i zaman buras� �al���r

            if (cmbAraSinav.Items.Contains("Se�iniz"))
                cmbAraSinav.Items.RemoveAt(0);

            if (secilenDers == null && cmbAraSinav.Items.Count != 102)
            {
                MessageBox.Show("L�tfen ara s�nav i�in ders se�iniz");
                return;
            }
            if (cmbAraSinav.Items.Count != 102 && cmbAraSinav.SelectedIndex == 0)
            {
                MessageBox.Show("L�tfen not se�iniz");
                return;
            }

            if (cmbAraSinav.Items.Count != 102)
                secilenDers.Vize = Convert.ToUInt32(cmbAraSinav.SelectedItem);

        }

        private void cmbFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFinal.Items.Contains("Se�iniz"))
                cmbFinal.Items.RemoveAt(0);

            if (secilenDers == null && cmbFinal.Items.Count != 102)
            {
                MessageBox.Show("L�tfen final i�in ders se�iniz");
                return;
            }
            if (cmbFinal.Items.Count != 102 && cmbFinal.SelectedIndex == 0)
            {
                MessageBox.Show("L�tfen not se�iniz");
                return;
            }

            if (cmbFinal.Items.Count != 102)
                secilenDers.Final = Convert.ToUInt32(cmbFinal.SelectedItem);

            //her zaman final not de�i�ti�i zaman buras� �al���r
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //butona t�kland��� zaman �al��acak olan metot.
            double toplam = 0;
            uint toplamKredi = 0;
            foreach (var ders in secilenDersler)
            {
                HarfNotunuAta(ders);

                toplam += (((int)ders.HarfNotu) / 10.0) * ders.Kredi;
                toplamKredi += (secilenDers.Kredi);
            }
            toplam /= toplamKredi;
            lblGNO.Text = "GNO: " + toplam.ToString();

        }

    }
}
