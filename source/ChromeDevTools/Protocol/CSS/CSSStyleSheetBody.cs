using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// CSS stylesheet contents.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class CSSStyleSheetBody
	{
		/// <summary>
		/// Gets or sets The stylesheet identifier.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Stylesheet resource URL.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public CSSRule[] Rules { get; set; }
		/// <summary>
		/// Gets or sets Stylesheet resource contents (if available).
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Text { get; set; }
	}
}
