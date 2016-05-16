using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Controls the visibility of compositing borders.
	/// </summary>
	[Command(ProtocolName.Page.SetCompositingBordersVisible)]
	[SupportedBy("iOS-9.3")]
	public class SetCompositingBordersVisibleCommand
	{
		/// <summary>
		/// Gets or sets True for showing compositing borders.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool Visible { get; set; }
	}
}
