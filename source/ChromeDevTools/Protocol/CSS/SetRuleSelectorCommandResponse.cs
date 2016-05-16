using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetRuleSelector)]
	[SupportedBy("Chrome-Tip")]
	public class SetRuleSelectorCommandResponse
	{
		/// <summary>
		/// Gets or sets The resulting rule after the selector modification.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CSSRule Rule { get; set; }
	}
}
