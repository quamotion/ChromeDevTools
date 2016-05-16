using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// This object represents a region that flows from a Named Flow.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class Region
	{
		/// <summary>
		/// Gets or sets The "overset" attribute of a Named Flow.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string RegionOverset { get; set; }
		/// <summary>
		/// Gets or sets The corresponding DOM node id.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long NodeId { get; set; }
	}
}
