using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Information about amount of glyphs that were rendered with given font.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class PlatformFontUsage
	{
		/// <summary>
		/// Gets or sets Font's family name reported by platform.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FamilyName { get; set; }
		/// <summary>
		/// Gets or sets Amount of glyphs that were rendered with this font.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double GlyphCount { get; set; }
	}
}
