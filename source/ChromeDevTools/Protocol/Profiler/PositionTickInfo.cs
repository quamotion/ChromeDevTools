using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Profiler
{
	/// <summary>
	/// Specifies a number of samples attributed to a certain source position.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class PositionTickInfo
	{
		/// <summary>
		/// Gets or sets Source line number (1-based).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Line { get; set; }
		/// <summary>
		/// Gets or sets Number of samples attributed to the source line.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Ticks { get; set; }
	}
}
