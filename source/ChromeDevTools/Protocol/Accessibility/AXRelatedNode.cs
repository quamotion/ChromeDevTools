using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Accessibility
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class AXRelatedNode
	{
		/// <summary>
		/// Gets or sets The IDRef value provided, if any.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Idref { get; set; }
		/// <summary>
		/// Gets or sets The BackendNodeId of the related node.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long BackendNodeId { get; set; }
	}
}
