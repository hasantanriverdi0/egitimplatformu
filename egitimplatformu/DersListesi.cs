using System;
using System.Collections.Generic;

namespace egitimplatformu
{
    public static class DersListesi
    {
        public static List<Ders> Dersler { get; set; }

        static DersListesi()
        {
            // Dersleri ekleyelim
            Dersler = new List<Ders>
            {
                new Ders("Matematik", "10 Saat"),
                new Ders("Fizik", "8 Saat"),
                new Ders("Kimya", "6 Saat"),
                new Ders("Biyoloji", "7 Saat"),
                new Ders("Türkçe", "5 Saat"),
                new Ders("Edebiyat", "4 Saat"),
                new Ders("Geometri", "6 Saat"),
                new Ders("Tarih", "5 Saat"),
                new Ders("Coğrafya", "4 Saat"),
                new Ders("Felsefe", "3 Saat")
            };
        }
    }
}
