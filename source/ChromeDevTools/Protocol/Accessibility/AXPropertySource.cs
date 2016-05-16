using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Accessibility
{
	/// <summary>
	/// A single source for a computed AX property.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class AXPropertySource
	{
		/// <summary>
		/// Gets or sets The name/label of this source.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets What type of source this is.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AXPropertySourceType SourceType { get; set; }
		/// <summary>
		/// Gets or sets The value of this property source.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public object Value { get; set; }
		/// <summary>
		/// Gets or sets What type the value should be interpreted as.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AXValueType Type { get; set; }
		/// <summary>
		/// Gets or sets Whether the value for this property is invalid.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Invalid { get; set; }
		/// <summary>
		/// Gets or sets Reason for the value being invalid, if it is.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string InvalidReason { get; set; }
	}
}
