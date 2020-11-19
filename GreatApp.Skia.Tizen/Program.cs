using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace GreatApp.Skia.Tizen
{
	class Program
	{
		static void Main(string[] args)
		{
			var host = new TizenHost(() => new GreatApp.App(), args);
			host.Run();
		}
	}
}
