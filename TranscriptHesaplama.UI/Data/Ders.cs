using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranscriptHesaplama.UI.Enums;

namespace TranscriptHesaplama.UI.Data
{
    public class Ders
    {
        public string Ad { get; set; }

        public string Kod { get; set; }

        public uint Kredi { get; set; }

        public uint Vize { get; set; }

        public uint Final { get; set; }

        public HarfNotu? HarfNotu { get; set; }
    }
}
