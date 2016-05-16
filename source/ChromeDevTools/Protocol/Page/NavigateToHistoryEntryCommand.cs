using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Navigates current page to the given history entry.
	/// </summary>
	[Command(ProtocolName.Page.NavigateToHistoryEntry)]
	[SupportedBy("Chrome-Tip")]
	public class NavigateToHistoryEntryCommand
	{
		/// <summary>
		/// Gets or sets Unique id of the entry to navigate to.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long EntryId { get; set; }
	}
}
