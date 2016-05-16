using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Profiler
{
	/// <summary>
	/// Profile.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class CPUProfile
	{
		/// <summary>
		/// Gets or sets Head
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CPUProfileNode Head { get; set; }
		/// <summary>
		/// Gets or sets Profiling start time in seconds.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double StartTime { get; set; }
		/// <summary>
		/// Gets or sets Profiling end time in seconds.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double EndTime { get; set; }
		/// <summary>
		/// Gets or sets Ids of samples top nodes.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long[] Samples { get; set; }
		/// <summary>
		/// Gets or sets Timestamps of the samples in microseconds.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double[] Timestamps { get; set; }
	}
}
