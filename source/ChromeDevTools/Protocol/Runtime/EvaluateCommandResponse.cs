using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Evaluates expression on global object.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.Evaluate)]
	[SupportedBy("Chrome-Tip")]
	public class EvaluateCommandResponse
	{
		/// <summary>
		/// Gets or sets Evaluation result.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or sets True if the result was thrown during the evaluation.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool WasThrown { get; set; }
		/// <summary>
		/// Gets or sets Exception details.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Debugger.ExceptionDetails ExceptionDetails { get; set; }
	}
}
