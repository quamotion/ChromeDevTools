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
		public SelectorList SelectorList { get; set; }
		/// <summary>
		/// Gets or sets Parent stylesheet's origin.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public StyleSheetOrigin Origin { get; set; }
		/// <summary>
		/// Gets or sets Associated style declaration.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CSSStyle Style { get; set; }
		/// <summary>
		/// Gets or sets Media list array (for rules involving media queries). The array enumerates media queries starting with the innermost one, going outwards.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CSSMedia[] Media { get; set; }
	}
}
