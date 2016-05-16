using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Resolves JavaScript node object for given node id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.ResolveNode)]
	[SupportedBy("Chrome-Tip")]
	public class ResolveNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets JavaScript object wrapper for given node.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Runtime.RemoteObject Object { get; set; }
	}
}
