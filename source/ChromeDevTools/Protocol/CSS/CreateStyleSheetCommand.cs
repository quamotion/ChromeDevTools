using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Creates a new special "via-inspector" stylesheet in the frame with given <code>frameId</code>.
	/// </summary>
	[Command(ProtocolName.CSS.CreateStyleSheet)]
	[SupportedBy("Chrome-Tip")]
	public class CreateStyleSheetCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the frame where "via-inspector" stylesheet should be created.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
	}
}
