using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Console
{
	/// <summary>
	/// Console message.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class ConsoleMessage
	{
		/// <summary>
		/// Gets or sets Message source.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Source { get; set; }
		/// <summary>
		/// Gets or sets Message severity.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Level { get; set; }
		/// <summary>
		/// Gets or sets Message text.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets Console message type.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Script ID of the message origin.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets URL of the message origin.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Line number in the resource that generated this message.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long Line { get; set; }
		/// <summary>
		/// Gets or sets Column number in the resource that generated this message.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long Column { get; set; }
		/// <summary>
		/// Gets or sets Repeat count for repeated messages.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long RepeatCount { get; set; }
		/// <summary>
		/// Gets or sets Message parameters in case of the formatted message.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public Runtime.RemoteObject[] Parameters { get; set; }
		/// <summary>
		/// Gets or sets JavaScript stack trace for assertions and error messages.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public CallFrame[] StackTrace { get; set; }
		/// <summary>
		/// Gets or sets Asynchronous JavaScript stack trace that preceded this message, if available.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AsyncStackTrace AsyncStackTrace { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the network request associated with this message.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string NetworkRequestId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp, when this message was fired.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the context where this message was created
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ExecutionContextId { get; set; }
	}
}
