namespace egitimplatformu
{
    public class Ders
    {
        public string DersAdi { get; set; }  // Ders adı özelliği
        public string EgitimSaati { get; set; }  // Eğitim saati özelliği

        // Parametreli constructor
        public Ders(string dersAdi, string egitimSaati)
        {
            DersAdi = dersAdi;
            EgitimSaati = egitimSaati;
        }

        // ToString metodunu override ederek, ders bilgisini döndürür
        public override string ToString()
        {
            return $"Ders Adı: {DersAdi}, Eğitim Saati: {EgitimSaati}";
        }
    }
}
