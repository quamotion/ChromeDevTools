using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given its path. // FIXME, use XPath
	/// </summary>
	[Command(ProtocolName.DOM.PushNodeByPathToFrontend)]
	[SupportedBy("Chrome-Tip")]
	public class PushNodeByPathToFrontendCommand
	{
		/// <summary>
		/// Gets or sets Path to node in the proprietary format.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Path { get; set; }
	}
}
