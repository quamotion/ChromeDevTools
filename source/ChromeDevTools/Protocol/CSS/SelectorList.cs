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
		public string Text { get; set; }
	}
}
