using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Information about the async operation.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class AsyncOperation
	{
		/// <summary>
		/// Gets or sets Unique id of the async operation.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Id { get; set; }
		/// <summary>
		/// Gets or sets String description of the async operation.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Description { get; set; }
		/// <summary>
		/// Gets or sets Stack trace where async operation was scheduled.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Console.CallFrame[] StackTrace { get; set; }
		/// <summary>
		/// Gets or sets Asynchronous stack trace where async operation was scheduled, if available.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Console.AsyncStackTrace AsyncStackTrace { get; set; }
	}
}
