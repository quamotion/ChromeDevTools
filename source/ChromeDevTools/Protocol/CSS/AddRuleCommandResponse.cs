using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Inserts a new rule with the given <code>ruleText</code> in a stylesheet with given <code>styleSheetId</code>, at the position specified by <code>location</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.AddRule)]
	[SupportedBy("Chrome-Tip")]
	public class AddRuleCommandResponse
	{
		/// <summary>
		/// Gets or sets The newly created rule.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public CSSRule Rule { get; set; }
	}
}
