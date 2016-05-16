using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Sets the new <code>text</code> for the respective style.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetStyleText)]
	[SupportedBy("iOS-9.3")]
	public class SetStyleTextCommandResponse
	{
		/// <summary>
		/// Gets or sets The resulting style after the text modification.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public CSSStyle Style { get; set; }
	}
}
