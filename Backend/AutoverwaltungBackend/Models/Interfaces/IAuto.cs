namespace AutoverwaltungBackend.Models.Interfaces
{
    public interface IAuto
    {
         short autoId { get; set; }
         string marke { get; set; }
         string model { get; set; }
         short baujahr { get; set; }
         float kmStand { get; set; }
         short ps { get; set; }
         string kennzeichen { get; set; }
         AutoStatus autoStatus { get; set; }
    }
}
