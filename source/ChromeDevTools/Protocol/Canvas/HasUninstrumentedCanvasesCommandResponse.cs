using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Checks if there is any uninstrumented canvas in the inspected page.
	/// </summary>
	[CommandResponse(ProtocolName.Canvas.HasUninstrumentedCanvases)]
	[SupportedBy("Chrome-Tip")]
	public class HasUninstrumentedCanvasesCommandResponse
	{
		/// <summary>
		/// Gets or sets Result
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Result { get; set; }
	}
}
