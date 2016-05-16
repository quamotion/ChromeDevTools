using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Requests that group of <code>BackendNodeIds</code> is released.
	/// </summary>
	[Command(ProtocolName.DOM.ReleaseBackendNodeIds)]
	[SupportedBy("iOS-9.3")]
	public class ReleaseBackendNodeIdsCommand
	{
		/// <summary>
		/// Gets or sets The backend node ids group name.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string NodeGroup { get; set; }
	}
}
