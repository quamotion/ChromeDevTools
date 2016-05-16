using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Deletes specified entry. If the entry is a directory, the agent deletes children recursively.
	/// </summary>
	[CommandResponse(ProtocolName.FileSystem.DeleteEntry)]
	[SupportedBy("Chrome-Tip")]
	public class DeleteEntryCommandResponse
	{
		/// <summary>
		/// Gets or sets 0, if no error. Otherwise errorCode is set to FileError::ErrorCode value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ErrorCode { get; set; }
	}
}
