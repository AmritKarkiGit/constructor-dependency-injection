public interface ISecurityCameraService
{
	void ConnectRemotely();    
}

public class GoogleNest:ISecurityCameraService
{
	public void ConnectRemotely() { Console.WriteLine("Google Nest Security Camera Service Called."); }

}

public class AmazonAlexa:ISecurityCameraService
{
	public void ConnectRemotely() { Console.WriteLine("Amazon Alexa Security Camera Service Called."); }
}

public class MyClient
{
	private ISecurityCameraService _scs;

	public MyClient(ISecurityCameraService scs)
    {
		this._scs = scs;
		
    }

	public void GetConnected()
    {
		this._scs.ConnectRemotely();
    }
}

class Program
{
	static void Main(string[] agrs)
    {
		GoogleNest gs = new GoogleNest();

		MyClient mc1 = new MyClient(gs);
		mc1.GetConnected();

		AmazonAlexa aa = new AmazonAlexa();
		MyClient mc2 = new MyClient(aa);
		mc2.GetConnected();
    }
}