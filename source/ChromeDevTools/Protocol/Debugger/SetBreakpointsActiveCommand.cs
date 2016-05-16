using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Activates / deactivates all breakpoints on the page.
	/// </summary>
	[Command(ProtocolName.Debugger.SetBreakpointsActive)]
	[SupportedBy("Chrome-Tip")]
	public class SetBreakpointsActiveCommand
	{
		/// <summary>
		/// Gets or sets New value for breakpoints active state.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Active { get; set; }
	}
}
