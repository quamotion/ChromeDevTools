using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// CSS style representation.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class CSSStyle
	{
		/// <summary>
		/// Gets or sets The css style sheet identifier (absent for user agent stylesheet and user-specified stylesheet rules) this rule came from.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets CSS properties in the style.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CSSProperty[] CssProperties { get; set; }
		/// <summary>
		/// Gets or sets Computed values for all shorthands found in the style.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ShorthandEntry[] ShorthandEntries { get; set; }
		/// <summary>
		/// Gets or sets Style declaration text (if available).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string CssText { get; set; }
		/// <summary>
		/// Gets or sets Style declaration range in the enclosing stylesheet (if available).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public SourceRange Range { get; set; }
	}
}
