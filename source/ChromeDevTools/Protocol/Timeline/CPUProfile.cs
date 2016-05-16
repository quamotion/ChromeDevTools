using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Timeline
{
	/// <summary>
	/// Profile.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class CPUProfile
	{
		/// <summary>
		/// Gets or sets Top level nodes in the stack.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public CPUProfileNode[] RootNodes { get; set; }
		/// <summary>
		/// Gets or sets IdleTime
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double IdleTime { get; set; }
	}
}
