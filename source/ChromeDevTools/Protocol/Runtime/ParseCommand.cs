using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Parses JavaScript source code for errors.
	/// </summary>
	[Command(ProtocolName.Runtime.Parse)]
	[SupportedBy("iOS-9.3")]
	public class ParseCommand
	{
		/// <summary>
		/// Gets or sets Source code to parse.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Source { get; set; }
	}
}
