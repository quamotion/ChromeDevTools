using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Parses JavaScript source code for errors.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.Parse)]
	[SupportedBy("iOS-9.3")]
	public class ParseCommandResponse
	{
		/// <summary>
		/// Gets or sets Parse result.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Result { get; set; }
		/// <summary>
		/// Gets or sets Parse error message.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Message { get; set; }
		/// <summary>
		/// Gets or sets Range in the source where the error occurred.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public ErrorRange Range { get; set; }
	}
}
