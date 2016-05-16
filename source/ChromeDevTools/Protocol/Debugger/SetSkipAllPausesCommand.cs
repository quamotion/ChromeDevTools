using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Makes page not interrupt on any pauses (breakpoint, exception, dom exception etc).
	/// </summary>
	[Command(ProtocolName.Debugger.SetSkipAllPauses)]
	[SupportedBy("Chrome-Tip")]
	public class SetSkipAllPausesCommand
	{
		/// <summary>
		/// Gets or sets New value for skip pauses state.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Skipped { get; set; }
	}
}
