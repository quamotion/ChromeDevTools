using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Evaluates a given trace call argument or its result.
	/// </summary>
	[CommandResponse(ProtocolName.Canvas.EvaluateTraceLogCallArgument)]
	[SupportedBy("Chrome-Tip")]
	public class EvaluateTraceLogCallArgumentCommandResponse
	{
		/// <summary>
		/// Gets or sets Object wrapper for the evaluation result.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Runtime.RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or sets State of the <code>Resource</code> object.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ResourceState ResourceState { get; set; }
	}
}
