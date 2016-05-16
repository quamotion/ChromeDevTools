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
		[SupportedBy("iOS-9.3")]
		public Runtime.RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or sets True if the result was thrown during the evaluation.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public bool WasThrown { get; set; }
		/// <summary>
		/// Gets or sets Exception details.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ExceptionDetails ExceptionDetails { get; set; }
		/// <summary>
		/// Gets or sets If the result was saved, this is the $n index that can be used to access the value.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long SavedResultIndex { get; set; }
	}
}
