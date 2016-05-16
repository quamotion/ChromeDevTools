using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Extra options that modify breakpoint behavior.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class BreakpointOptions
	{
		/// <summary>
		/// Gets or sets Expression to use as a breakpoint condition. When specified, debugger will only stop on the breakpoint if this expression evaluates to true.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Condition { get; set; }
		/// <summary>
		/// Gets or sets Actions to perform automatically when the breakpoint is triggered.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public BreakpointAction[] Actions { get; set; }
		/// <summary>
		/// Gets or sets Automatically continue after hitting this breakpoint and running actions.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool AutoContinue { get; set; }
		/// <summary>
		/// Gets or sets Number of times to ignore this breakpoint, before stopping on the breakpoint and running actions.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long IgnoreCount { get; set; }
	}
}
