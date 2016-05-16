using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Evaluates expression on a given call frame.
	/// </summary>
	[Command(ProtocolName.Debugger.EvaluateOnCallFrame)]
	[SupportedBy("Chrome-Tip")]
	public class EvaluateOnCallFrameCommand
	{
		/// <summary>
		/// Gets or sets Call frame identifier to evaluate on.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string CallFrameId { get; set; }
		/// <summary>
		/// Gets or sets Expression to evaluate.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Expression { get; set; }
		/// <summary>
		/// Gets or sets String object group name to put result into (allows rapid releasing resulting object handles using <code>releaseObjectGroup</code>).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ObjectGroup { get; set; }
		/// <summary>
		/// Gets or sets Specifies whether command line API should be available to the evaluated expression, defaults to false.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IncludeCommandLineAPI { get; set; }
		/// <summary>
		/// Gets or sets Specifies whether evaluation should stop on exceptions and mute console. Overrides setPauseOnException state.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool DoNotPauseOnExceptionsAndMuteConsole { get; set; }
		/// <summary>
		/// Gets or sets Whether the result is expected to be a JSON object that should be sent by value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool ReturnByValue { get; set; }
		/// <summary>
		/// Gets or sets Whether preview should be generated for the result.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool GeneratePreview { get; set; }
	}
}
