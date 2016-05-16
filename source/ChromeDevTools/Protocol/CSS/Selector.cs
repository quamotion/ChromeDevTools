using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Data for a simple selector (these are delimited by commas in a selector list).
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class Selector
	{
		/// <summary>
		/// Gets or sets Selector text.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Value { get; set; }
		/// <summary>
		/// Gets or sets Selector range in the underlying resource (if available).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public SourceRange Range { get; set; }
	}
}
