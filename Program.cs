using Sres.Net.EEIP;

namespace CamozziTest
{
    class Program
    {
	static void Main(string[] args)
	    {
		EEIPClient e = new EEIPClient();
		Console.WriteLine("Registering session...");
		e.O_T_Length = 40;
		e.T_O_Length = 64;
		string ip = "10.32.100.24";
		if (args.Length == 1)
		    ip = args[1];
		e.RegisterSession(ip);

		Console.WriteLine(BitConverter.ToString(e.GetAttributeSingle(0x64, 1, 7)));

		Console.WriteLine("Opening comms");
		Console.WriteLine(e.Detect_T_O_Length());
		Console.WriteLine(e.Detect_O_T_Length());
		e.ForwardOpen();

		Console.WriteLine("Reading IO Data");
		Console.WriteLine(BitConverter.ToString(e.T_O_IOData));
		Console.WriteLine(BitConverter.ToString(e.O_T_IOData));

		Console.WriteLine("Writing IO Data");
		for (int i = 0; i < 16; i++) {
		    e.T_O_IOData[i] = 0xFF;
		    e.O_T_IOData[i] = 0xFF;
		}
		Console.WriteLine("Writing data");

		e.ForwardClose();
		e.UnRegisterSession();
	    }
    }
}
