using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	[Command(ProtocolName.Runtime.SetCustomObjectFormatterEnabled)]
	[SupportedBy("Chrome-Tip")]
	public class SetCustomObjectFormatterEnabledCommand
	{
		/// <summary>
		/// Gets or sets Enabled
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Enabled { get; set; }
	}
}
