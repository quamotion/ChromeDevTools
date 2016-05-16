using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>
	[Command(ProtocolName.CSS.SetMediaText)]
	[SupportedBy("Chrome-Tip")]
	public class SetMediaTextCommand
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Range
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or sets Text
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Text { get; set; }
	}
}
