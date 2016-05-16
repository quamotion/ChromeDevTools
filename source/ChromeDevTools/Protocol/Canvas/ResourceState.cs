using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Resource state.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class ResourceState
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets TraceLogId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string TraceLogId { get; set; }
		/// <summary>
		/// Gets or sets Describes current <code>Resource</code> state.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ResourceStateDescriptor[] Descriptors { get; set; }
		/// <summary>
		/// Gets or sets Screenshot image data URL.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ImageURL { get; set; }
	}
}
