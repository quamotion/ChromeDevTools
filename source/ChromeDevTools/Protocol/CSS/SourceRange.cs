using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Text range within a resource. All numbers are zero-based.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class SourceRange
	{
		/// <summary>
		/// Gets or sets Start line of range.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long StartLine { get; set; }
		/// <summary>
		/// Gets or sets Start column of range (inclusive).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long StartColumn { get; set; }
		/// <summary>
		/// Gets or sets End line of range
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long EndLine { get; set; }
		/// <summary>
		/// Gets or sets End column of range (exclusive).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long EndColumn { get; set; }
	}
}
