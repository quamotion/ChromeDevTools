using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Highlights DOM node with given id or with the given JavaScript object wrapper. Either nodeId or objectId must be specified.
	/// </summary>
	[Command(ProtocolName.DOM.HighlightNode)]
	[SupportedBy("Chrome-Tip")]
	public class HighlightNodeCommand
	{
		/// <summary>
		/// Gets or sets A descriptor for the highlight appearance.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public HighlightConfig HighlightConfig { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the node to highlight.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the backend node to highlight.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets JavaScript object id of the node to be highlighted.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string ObjectId { get; set; }
	}
}
