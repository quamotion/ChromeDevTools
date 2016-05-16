using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Evaluates a given trace call argument or its result.
	/// </summary>
	[Command(ProtocolName.Canvas.EvaluateTraceLogCallArgument)]
	[SupportedBy("Chrome-Tip")]
	public class EvaluateTraceLogCallArgumentCommand
	{
		/// <summary>
		/// Gets or sets TraceLogId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string TraceLogId { get; set; }
		/// <summary>
		/// Gets or sets Index of the call to evaluate on (zero based).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long CallIndex { get; set; }
		/// <summary>
		/// Gets or sets Index of the argument to evaluate (zero based). Provide <code>-1</code> to evaluate call result.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ArgumentIndex { get; set; }
		/// <summary>
		/// Gets or sets String object group name to put result into (allows rapid releasing resulting object handles using <code>Runtime.releaseObjectGroup</code>).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ObjectGroup { get; set; }
	}
}
