using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Console
{
	/// <summary>
	/// Enables console to refer to the node with given id via $0 (see Command Line API for more details).
	/// </summary>
	[Command(ProtocolName.Console.AddInspectedNode)]
	[SupportedBy("iOS-9.3")]
	public class AddInspectedNodeCommand
	{
		/// <summary>
		/// Gets or sets DOM node id to be accessible by means of $0 command line API.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long NodeId { get; set; }
	}
}
