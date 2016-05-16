using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Returns content of the file. Result should be sliced into [start, end).
	/// </summary>
	[CommandResponse(ProtocolName.FileSystem.RequestFileContent)]
	[SupportedBy("Chrome-Tip")]
	public class RequestFileContentCommandResponse
	{
		/// <summary>
		/// Gets or sets 0, if no error. Otherwise, errorCode is set to FileError::ErrorCode value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ErrorCode { get; set; }
		/// <summary>
		/// Gets or sets Content of the file.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Content { get; set; }
		/// <summary>
		/// Gets or sets Charset of the content if it is served as text.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Charset { get; set; }
	}
}
