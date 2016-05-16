using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class TraceLog
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Calls
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Call[] Calls { get; set; }
		/// <summary>
		/// Gets or sets Contexts
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CallArgument[] Contexts { get; set; }
		/// <summary>
		/// Gets or sets StartOffset
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long StartOffset { get; set; }
		/// <summary>
		/// Gets or sets Alive
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Alive { get; set; }
		/// <summary>
		/// Gets or sets TotalAvailableCalls
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double TotalAvailableCalls { get; set; }
	}
}
