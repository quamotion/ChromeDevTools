using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Returns content of the directory.
	/// </summary>
	[CommandResponse(ProtocolName.FileSystem.RequestDirectoryContent)]
	[SupportedBy("Chrome-Tip")]
	public class RequestDirectoryContentCommandResponse
	{
		/// <summary>
		/// Gets or sets 0, if no error. Otherwise, errorCode is set to FileError::ErrorCode value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ErrorCode { get; set; }
		/// <summary>
		/// Gets or sets Contains all entries on directory if the command completed successfully.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Entry[] Entries { get; set; }
	}
}
