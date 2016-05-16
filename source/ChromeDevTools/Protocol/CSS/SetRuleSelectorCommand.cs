using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>
	[Command(ProtocolName.CSS.SetRuleSelector)]
	[SupportedBy("Chrome-Tip")]
	public class SetRuleSelectorCommand
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
		/// Gets or sets Selector
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Selector { get; set; }
	}
}
