using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// CSS rule representation.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class CSSRule
	{
		/// <summary>
		/// Gets or sets The css style sheet identifier (absent for user agent stylesheet and user-specified stylesheet rules) this rule came from.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Rule selector data.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public SelectorList SelectorList { get; set; }
		/// <summary>
		/// Gets or sets Parent stylesheet's origin.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public StyleSheetOrigin Origin { get; set; }
		/// <summary>
		/// Gets or sets Associated style declaration.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public CSSStyle Style { get; set; }
		/// <summary>
		/// Gets or sets Media list array (for rules involving media queries). The array enumerates media queries starting with the innermost one, going outwards.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public CSSMedia[] Media { get; set; }
		/// <summary>
		/// Gets or sets The CSS rule identifier (absent for user agent stylesheet and user-specified stylesheet rules).
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public CSSRuleId RuleId { get; set; }
		/// <summary>
		/// Gets or sets Parent stylesheet resource URL (for regular rules).
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or sets Line ordinal of the rule selector start character in the resource.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long SourceLine { get; set; }
	}
}
