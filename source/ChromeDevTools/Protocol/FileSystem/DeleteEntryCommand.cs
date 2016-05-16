using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Deletes specified entry. If the entry is a directory, the agent deletes children recursively.
	/// </summary>
	[Command(ProtocolName.FileSystem.DeleteEntry)]
	[SupportedBy("Chrome-Tip")]
	public class DeleteEntryCommand
	{
		/// <summary>
		/// Gets or sets URL of the entry to delete.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Url { get; set; }
	}
}
