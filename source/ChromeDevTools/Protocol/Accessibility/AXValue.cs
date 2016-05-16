using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Accessibility
{
	/// <summary>
	/// A single computed AX property.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class AXValue
	{
		/// <summary>
		/// Gets or sets The type of this value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AXValueType Type { get; set; }
		/// <summary>
		/// Gets or sets The computed value of this property.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public object Value { get; set; }
		/// <summary>
		/// Gets or sets The related node value, if any.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AXRelatedNode RelatedNodeValue { get; set; }
		/// <summary>
		/// Gets or sets Multiple relted nodes, if applicable.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AXRelatedNode[] RelatedNodeArrayValue { get; set; }
		/// <summary>
		/// Gets or sets The sources which contributed to the computation of this property.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AXPropertySource[] Sources { get; set; }
	}
}
