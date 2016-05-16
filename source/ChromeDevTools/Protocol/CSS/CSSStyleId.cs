using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// This object identifies a CSS style in a unique way.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class CSSStyleId
	{
		/// <summary>
		/// Gets or sets Enclosing stylesheet identifier.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets The style ordinal within the stylesheet.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long Ordinal { get; set; }
	}
}
