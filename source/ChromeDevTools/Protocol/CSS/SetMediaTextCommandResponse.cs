using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetMediaText)]
	[SupportedBy("Chrome-Tip")]
	public class SetMediaTextCommandResponse
	{
		/// <summary>
		/// Gets or sets The resulting CSS media rule after modification.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CSSMedia Media { get; set; }
	}
}
