using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Emulates the given media for CSS media queries.
	/// </summary>
	[Command(ProtocolName.Page.SetEmulatedMedia)]
	[SupportedBy("iOS-9.3")]
	public class SetEmulatedMediaCommand
	{
		/// <summary>
		/// Gets or sets Media type to emulate. Empty string disables the override.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Media { get; set; }
	}
}
