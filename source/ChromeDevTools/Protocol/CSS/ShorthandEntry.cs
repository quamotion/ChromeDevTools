using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class ShorthandEntry
	{
		/// <summary>
		/// Gets or sets Shorthand name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Shorthand value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Value { get; set; }
	}
}
