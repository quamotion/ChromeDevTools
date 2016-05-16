using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Continues execution until specific location is reached.
	/// </summary>
	[Command(ProtocolName.Debugger.ContinueToLocation)]
	[SupportedBy("Chrome-Tip")]
	public class ContinueToLocationCommand
	{
		/// <summary>
		/// Gets or sets Location to continue to.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Location Location { get; set; }
		/// <summary>
		/// Gets or sets Allows breakpoints at the intemediate positions inside statements.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool InterstatementLocation { get; set; }
	}
}
