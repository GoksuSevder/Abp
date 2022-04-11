namespace ZZGYazilim.OnMuhasebe.Donemler;
public class Donem : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public string Durum { get; set; }

    public ICollection<Fatura> Faturalar { get; set; }
    public ICollection<Makbuz> Makbuzlar { get; set; }
    public ICollection<FirmaParametre> FirmaParametreler { get; set; }
}
