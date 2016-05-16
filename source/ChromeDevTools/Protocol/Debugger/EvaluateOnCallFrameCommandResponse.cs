using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Evaluates expression on a given call frame.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.EvaluateOnCallFrame)]
	[SupportedBy("Chrome-Tip")]
	public class EvaluateOnCallFrameCommandResponse
	{
		/// <summary>
		/// Gets or sets Object wrapper for the evaluation result.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Runtime.RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or sets True if the result was thrown during the evaluation.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool WasThrown { get; set; }
		/// <summary>
		/// Gets or sets Exception details.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
