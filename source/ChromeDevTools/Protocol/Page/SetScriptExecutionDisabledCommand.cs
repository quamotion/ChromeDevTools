using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Switches script execution in the page.
	/// </summary>
	[Command(ProtocolName.Page.SetScriptExecutionDisabled)]
	[SupportedBy("iOS-9.3")]
	public class SetScriptExecutionDisabledCommand
	{
		/// <summary>
		/// Gets or sets Whether script execution should be disabled in the page.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool Value { get; set; }
	}
}
