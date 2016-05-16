using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Description of an isolated world.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class ExecutionContextDescription
	{
		/// <summary>
		/// Gets or sets Unique id of the execution context. It can be used to specify in which execution context script evaluation should be performed.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Id { get; set; }
		/// <summary>
		/// Gets or sets True if this is a context where inpspected web page scripts run. False if it is a content script isolated context.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IsPageContext { get; set; }
		/// <summary>
		/// Gets or sets Execution context origin.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets Human readable name describing given context.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Id of the owning frame. May be an empty string if the context is not associated with a frame.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
	}
}
