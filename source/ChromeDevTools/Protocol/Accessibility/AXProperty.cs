using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Accessibility
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class AXProperty
	{
		/// <summary>
		/// Gets or sets The name of this property.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets The value of this property.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AXValue Value { get; set; }
	}
}
