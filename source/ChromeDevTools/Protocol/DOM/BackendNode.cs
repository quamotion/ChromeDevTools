using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Backend node with a friendly name.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class BackendNode
	{
		/// <summary>
		/// Gets or sets <code>Node</code>'s nodeType.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeType { get; set; }
		/// <summary>
		/// Gets or sets <code>Node</code>'s nodeName.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string NodeName { get; set; }
		/// <summary>
		/// Gets or sets BackendNodeId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long BackendNodeId { get; set; }
	}
}
