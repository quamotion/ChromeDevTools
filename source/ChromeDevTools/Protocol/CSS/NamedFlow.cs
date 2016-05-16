using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// This object represents a Named Flow.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class NamedFlow
	{
		/// <summary>
		/// Gets or sets The document node id.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long DocumentNodeId { get; set; }
		/// <summary>
		/// Gets or sets Named Flow identifier.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets The "overset" attribute of a Named Flow.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool Overset { get; set; }
		/// <summary>
		/// Gets or sets An array of nodes that flow into the Named Flow.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long[] Content { get; set; }
		/// <summary>
		/// Gets or sets An array of regions associated with the Named Flow.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public Region[] Regions { get; set; }
	}
}
