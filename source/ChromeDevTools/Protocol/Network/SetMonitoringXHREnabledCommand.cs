using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Toggles monitoring of XMLHttpRequest. If <code>true</code>, console will receive messages upon each XHR issued.
	/// </summary>
	[Command(ProtocolName.Network.SetMonitoringXHREnabled)]
	[SupportedBy("Chrome-Tip")]
	public class SetMonitoringXHREnabledCommand
	{
		/// <summary>
		/// Gets or sets Monitoring enabled state.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Enabled { get; set; }
	}
}
