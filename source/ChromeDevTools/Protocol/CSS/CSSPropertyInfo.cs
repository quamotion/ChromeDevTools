using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class CSSPropertyInfo
	{
		/// <summary>
		/// Gets or sets Property name.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Longhand property names.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string[] Longhands { get; set; }
		/// <summary>
		/// Gets or sets Supported values for this property.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string[] Values { get; set; }
	}
}
