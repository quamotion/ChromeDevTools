using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Sets the new stylesheet text.
	/// </summary>
	[Command(ProtocolName.CSS.SetStyleSheetText)]
	[SupportedBy("Chrome-Tip")]
	public class SetStyleSheetTextCommand
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Text
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Text { get; set; }
	}
}
