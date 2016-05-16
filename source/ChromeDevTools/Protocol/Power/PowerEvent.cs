using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Power
{
	/// <summary>
	/// PowerEvent item
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class PowerEvent
	{
		/// <summary>
		/// Gets or sets Power Event Type.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Power Event Time, in milliseconds.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Power Event Value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Value { get; set; }
	}
}
