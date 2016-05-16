using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Switches script execution in the page.
	/// </summary>
	[Command(ProtocolName.Emulation.SetScriptExecutionDisabled)]
	[SupportedBy("Chrome-Tip")]
	public class SetScriptExecutionDisabledCommand
	{
		/// <summary>
		/// Gets or sets Whether script execution should be disabled in the page.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Value { get; set; }
	}
}
