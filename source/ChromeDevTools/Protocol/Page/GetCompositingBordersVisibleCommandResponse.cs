using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Indicates the visibility of compositing borders.
	/// </summary>
	[CommandResponse(ProtocolName.Page.GetCompositingBordersVisible)]
	[SupportedBy("iOS-9.3")]
	public class GetCompositingBordersVisibleCommandResponse
	{
		/// <summary>
		/// Gets or sets If true, compositing borders are visible.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool Result { get; set; }
	}
}
