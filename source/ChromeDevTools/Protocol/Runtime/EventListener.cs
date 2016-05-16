using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Object event listener.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class EventListener
	{
		/// <summary>
		/// Gets or sets <code>EventListener</code>'s type.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets <code>EventListener</code>'s useCapture.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool UseCapture { get; set; }
		/// <summary>
		/// Gets or sets Handler code location.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Debugger.Location Location { get; set; }
		/// <summary>
		/// Gets or sets Event handler function value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Runtime.RemoteObject Handler { get; set; }
	}
}
