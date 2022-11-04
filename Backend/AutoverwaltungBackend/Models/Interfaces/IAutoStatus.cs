using AutoverwaltungBackend.Models.Classes;

namespace AutoverwaltungBackend.Models.Interfaces
{
    public interface IAutoStatus
    {
        Status status { get; set; }
        DateTime datum { get; set; }
        string info { get; set; }
    }
}
