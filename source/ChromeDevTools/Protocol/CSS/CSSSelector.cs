using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// CSS selector.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class CSSSelector
	{
		/// <summary>
		/// Gets or sets Canonicalized selector text.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets Specificity (a, b, c) tuple. Included if the selector is sent in response to CSS.getMatchedStylesForNode which provides a context element.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long[] Specificity { get; set; }
		/// <summary>
		/// Gets or sets Whether or not the specificity can be dynamic. Included if the selector is sent in response to CSS.getMatchedStylesForNode which provides a context element.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool Dynamic { get; set; }
	}
}
