using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Range of an error in source code.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class ErrorRange
	{
		/// <summary>
		/// Gets or sets Start offset of range (inclusive).
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long StartOffset { get; set; }
		/// <summary>
		/// Gets or sets End offset of range (exclusive).
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long EndOffset { get; set; }
	}
}
