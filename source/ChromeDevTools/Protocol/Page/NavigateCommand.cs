using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Navigates current page to the given URL.
	/// </summary>
	[Command(ProtocolName.Page.Navigate)]
	[SupportedBy("Chrome-Tip")]
	public class NavigateCommand
	{
		/// <summary>
		/// Gets or sets URL to navigate the page to.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Url { get; set; }
	}
}
