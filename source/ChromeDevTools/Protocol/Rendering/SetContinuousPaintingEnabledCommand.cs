using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Rendering
{
	/// <summary>
	/// Requests that backend enables continuous painting
	/// </summary>
	[Command(ProtocolName.Rendering.SetContinuousPaintingEnabled)]
	[SupportedBy("Chrome-Tip")]
	public class SetContinuousPaintingEnabledCommand
	{
		/// <summary>
		/// Gets or sets True for enabling cointinuous painting
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Enabled { get; set; }
	}
}
