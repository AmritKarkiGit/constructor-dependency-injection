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

public class SecurityCamera
{
	private ISecurityCameraService _scs;

	public SecurityCamera(ISecurityCameraService scs)
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
		GoogleNest gn = new GoogleNest();

		SecurityCamera  sc1 = new SecurityCamera(gn);
		sc1.GetConnected();

		AmazonAlexa aa = new AmazonAlexa();
		SecurityCamera sc2 = new SecurityCamera(aa);
		sc2.GetConnected();
    }
}