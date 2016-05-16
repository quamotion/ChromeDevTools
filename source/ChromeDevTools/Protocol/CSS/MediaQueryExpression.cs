using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Media query expression descriptor.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class MediaQueryExpression
	{
		/// <summary>
		/// Gets or sets Media query expression value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Value { get; set; }
		/// <summary>
		/// Gets or sets Media query expression units.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Unit { get; set; }
		/// <summary>
		/// Gets or sets Media query expression feature.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Feature { get; set; }
		/// <summary>
		/// Gets or sets The associated range of the value text in the enclosing stylesheet (if available).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public SourceRange ValueRange { get; set; }
		/// <summary>
		/// Gets or sets Computed length of media query expression (if applicable).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ComputedLength { get; set; }
	}
}
