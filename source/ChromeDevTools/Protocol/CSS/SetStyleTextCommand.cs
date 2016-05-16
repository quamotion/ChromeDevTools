using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Sets the new <code>text</code> for the respective style.
	/// </summary>
	[Command(ProtocolName.CSS.SetStyleText)]
	[SupportedBy("iOS-9.3")]
	public class SetStyleTextCommand
	{
		/// <summary>
		/// Gets or sets StyleId
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public CSSStyleId StyleId { get; set; }
		/// <summary>
		/// Gets or sets Text
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Text { get; set; }
	}
}
