using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Profiler
{
	/// <summary>
	/// CPU Profile node. Holds callsite information, execution statistics and child nodes.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class CPUProfileNode
	{
		/// <summary>
		/// Gets or sets Function name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or sets Script identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets URL.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets 1-based line number of the function start position.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets 1-based column number of the function start position.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ColumnNumber { get; set; }
		/// <summary>
		/// Gets or sets Number of samples where this node was on top of the call stack.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long HitCount { get; set; }
		/// <summary>
		/// Gets or sets Call UID.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double CallUID { get; set; }
		/// <summary>
		/// Gets or sets Child nodes.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CPUProfileNode[] Children { get; set; }
		/// <summary>
		/// Gets or sets The reason of being not optimized. The function may be deoptimized or marked as don't optimize.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string DeoptReason { get; set; }
		/// <summary>
		/// Gets or sets Unique id of the node.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Id { get; set; }
		/// <summary>
		/// Gets or sets An array of source position ticks.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public PositionTickInfo[] PositionTicks { get; set; }
	}
}
