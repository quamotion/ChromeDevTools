using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions or no exceptions. Initial pause on exceptions state is <code>none</code>.
	/// </summary>
	[Command(ProtocolName.Debugger.SetPauseOnExceptions)]
	[SupportedBy("Chrome-Tip")]
	public class SetPauseOnExceptionsCommand
	{
		/// <summary>
		/// Gets or sets Pause on exceptions mode.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string State { get; set; }
	}
}
