using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Text range within a resource. All numbers are zero-based.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class SourceRange
	{
		/// <summary>
		/// Gets or sets Start line of range.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long StartLine { get; set; }
		/// <summary>
		/// Gets or sets Start column of range (inclusive).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long StartColumn { get; set; }
		/// <summary>
		/// Gets or sets End line of range
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long EndLine { get; set; }
		/// <summary>
		/// Gets or sets End column of range (exclusive).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long EndColumn { get; set; }
	}
}
