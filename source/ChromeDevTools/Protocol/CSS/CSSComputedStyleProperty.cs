using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class CSSComputedStyleProperty
	{
		/// <summary>
		/// Gets or sets Computed style property name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Computed style property value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Value { get; set; }
	}
}
