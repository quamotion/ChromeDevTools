using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// The pause reason auxiliary data when paused because of an assertion.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class AssertPauseReason
	{
		/// <summary>
		/// Gets or sets The console.assert message string if provided.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Message { get; set; }
	}
}
