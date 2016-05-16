using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Starts sending each frame using the <code>screencastFrame</code> event.
	/// </summary>
	[Command(ProtocolName.Page.StartScreencast)]
	[SupportedBy("Chrome-Tip")]
	public class StartScreencastCommand
	{
		/// <summary>
		/// Gets or sets Image compression format.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Format { get; set; }
		/// <summary>
		/// Gets or sets Compression quality from range [0..100].
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Quality { get; set; }
		/// <summary>
		/// Gets or sets Maximum screenshot width.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long MaxWidth { get; set; }
		/// <summary>
		/// Gets or sets Maximum screenshot height.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long MaxHeight { get; set; }
	}
}
