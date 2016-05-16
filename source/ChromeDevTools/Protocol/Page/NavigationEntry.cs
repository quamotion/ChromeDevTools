using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Navigation history entry.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class NavigationEntry
	{
		/// <summary>
		/// Gets or sets Unique id of the navigation history entry.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Id { get; set; }
		/// <summary>
		/// Gets or sets URL of the navigation history entry.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Title of the navigation history entry.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Title { get; set; }
	}
}
