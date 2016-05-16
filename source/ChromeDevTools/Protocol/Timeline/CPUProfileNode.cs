using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Timeline
{
	/// <summary>
	/// CPU Profile node. Holds callsite information, execution statistics and child nodes.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class CPUProfileNode
	{
		/// <summary>
		/// Gets or sets Unique identifier for this call site.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long Id { get; set; }
		/// <summary>
		/// Gets or sets Aggregate info about all the calls that making up this node.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public CPUProfileNodeAggregateCallInfo CallInfo { get; set; }
		/// <summary>
		/// Gets or sets Function name.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or sets URL.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Line number.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets Column number.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long ColumnNumber { get; set; }
		/// <summary>
		/// Gets or sets Child nodes.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public CPUProfileNode[] Children { get; set; }
	}
}
