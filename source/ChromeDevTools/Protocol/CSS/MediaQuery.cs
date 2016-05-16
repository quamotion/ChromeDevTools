using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Media query descriptor.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class MediaQuery
	{
		/// <summary>
		/// Gets or sets Array of media query expressions.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public MediaQueryExpression[] Expressions { get; set; }
		/// <summary>
		/// Gets or sets Whether the media query condition is satisfied.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Active { get; set; }
	}
}
