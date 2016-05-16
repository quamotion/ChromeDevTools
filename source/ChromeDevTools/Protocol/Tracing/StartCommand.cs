using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Tracing
{
	/// <summary>
	/// Start trace events collection.
	/// </summary>
	[Command(ProtocolName.Tracing.Start)]
	[SupportedBy("Chrome-Tip")]
	public class StartCommand
	{
		/// <summary>
		/// Gets or sets Category/tag filter
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Categories { get; set; }
		/// <summary>
		/// Gets or sets Tracing options
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Options { get; set; }
		/// <summary>
		/// Gets or sets If set, the agent will issue bufferUsage events at this interval, specified in milliseconds
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double BufferUsageReportingInterval { get; set; }
	}
}
