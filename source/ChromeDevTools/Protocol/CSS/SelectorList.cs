using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Selector list data.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class SelectorList
	{
		/// <summary>
		/// Gets or sets Selectors in the list.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Selector[] Selectors { get; set; }
		/// <summary>
		/// Gets or sets Rule selector text.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets Rule selector range in the underlying resource (if available).
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public SourceRange Range { get; set; }
	}
}
