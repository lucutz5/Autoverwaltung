using AutoverwaltungBackend.Models.Interfaces;


namespace AutoverwaltungBackend.Models.Classes
{


    public enum Status
    {
        Vermietbar,
        NichtVermietbar,
        NichtVerfügbar
    }
    public class AutoStatus : IAutoStatus
    {
        public Status status { get; set; }
        public DateTime datum { get; set; }
        public string info { get; set; }

        public AutoStatus()
        {
        }
    }

}