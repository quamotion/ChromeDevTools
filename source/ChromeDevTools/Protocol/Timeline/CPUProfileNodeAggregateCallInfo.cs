using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Timeline
{
	/// <summary>
	/// Aggregate CPU Profile call info. Holds time information for all the calls that happened on a node.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class CPUProfileNodeAggregateCallInfo
	{
		/// <summary>
		/// Gets or sets Total number of calls.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double CallCount { get; set; }
		/// <summary>
		/// Gets or sets Start time for the first call.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double StartTime { get; set; }
		/// <summary>
		/// Gets or sets End time for the last call.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double EndTime { get; set; }
		/// <summary>
		/// Gets or sets Total execution time for all calls combined.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double TotalTime { get; set; }
	}
}
