using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Returns metadata of the entry.
	/// </summary>
	[CommandResponse(ProtocolName.FileSystem.RequestMetadata)]
	[SupportedBy("Chrome-Tip")]
	public class RequestMetadataCommandResponse
	{
		/// <summary>
		/// Gets or sets 0, if no error. Otherwise, errorCode is set to FileError::ErrorCode value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ErrorCode { get; set; }
		/// <summary>
		/// Gets or sets Contains metadata of the entry if the command completed successfully.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Metadata Metadata { get; set; }
	}
}
