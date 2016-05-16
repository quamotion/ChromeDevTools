using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position unavailable.
	/// </summary>
	[Command(ProtocolName.Emulation.SetGeolocationOverride)]
	[SupportedBy("Chrome-Tip")]
	public class SetGeolocationOverrideCommand
	{
		/// <summary>
		/// Gets or sets Mock latitude
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Latitude { get; set; }
		/// <summary>
		/// Gets or sets Mock longitude
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Longitude { get; set; }
		/// <summary>
		/// Gets or sets Mock accuracy
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Accuracy { get; set; }
	}
}
