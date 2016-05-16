using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Match data for a CSS rule.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class RuleMatch
	{
		/// <summary>
		/// Gets or sets CSS rule in the match.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CSSRule Rule { get; set; }
		/// <summary>
		/// Gets or sets Matching selector indices in the rule's selectorList selectors (0-based).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long[] MatchingSelectors { get; set; }
	}
}
