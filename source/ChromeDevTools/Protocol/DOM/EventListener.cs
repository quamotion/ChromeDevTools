using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// DOM interaction is implemented in terms of mirror objects that represent the actual DOM nodes. DOMNode is a base node mirror type.
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
		/// Gets or sets <code>EventListener</code>'s isAttribute.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IsAttribute { get; set; }
		/// <summary>
		/// Gets or sets Target <code>DOMNode</code> id.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
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
