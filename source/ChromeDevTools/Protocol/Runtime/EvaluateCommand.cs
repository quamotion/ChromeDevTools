using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Evaluates expression on global object.
	/// </summary>
	[Command(ProtocolName.Runtime.Evaluate)]
	[SupportedBy("Chrome-Tip")]
	public class EvaluateCommand
	{
		/// <summary>
		/// Gets or sets Expression to evaluate.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Expression { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name that can be used to release multiple objects.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ObjectGroup { get; set; }
		/// <summary>
		/// Gets or sets Determines whether Command Line API should be available during the evaluation.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IncludeCommandLineAPI { get; set; }
		/// <summary>
		/// Gets or sets Specifies whether evaluation should stop on exceptions and mute console. Overrides setPauseOnException state.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool DoNotPauseOnExceptionsAndMuteConsole { get; set; }
		/// <summary>
		/// Gets or sets Specifies in which isolated context to perform evaluation. Each content script lives in an isolated context and this parameter may be used to specify one of those contexts. If the parameter is omitted or 0 the evaluation will be performed in the context of the inspected page.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ContextId { get; set; }
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
