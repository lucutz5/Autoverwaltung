

public enum Status
{
	Vermietbar,
	NichtVermietbar,
	NichtVerfügbar
}
public class AutoStatus
{
	public Status status { get; set; }
	public DateTime datum { get; set; }
	public string info { get; set; }

	public AutoStatus()
	{
	}
}
