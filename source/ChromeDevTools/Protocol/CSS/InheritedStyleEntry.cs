using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Inherited CSS rule collection from ancestor node.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class InheritedStyleEntry
	{
		/// <summary>
		/// Gets or sets The ancestor node's inline style, if any, in the style inheritance chain.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CSSStyle InlineStyle { get; set; }
		/// <summary>
		/// Gets or sets Matches of CSS rules matching the ancestor node in the style inheritance chain.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RuleMatch[] MatchedCSSRules { get; set; }
	}
}
