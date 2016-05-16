using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Inserts a new rule with the given <code>ruleText</code> in a stylesheet with given <code>styleSheetId</code>, at the position specified by <code>location</code>.
	/// </summary>
	[Command(ProtocolName.CSS.AddRule)]
	[SupportedBy("Chrome-Tip")]
	public class AddRuleCommand
	{
		/// <summary>
		/// Gets or sets The css style sheet identifier where a new rule should be inserted.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets The text of a new rule.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string RuleText { get; set; }
		/// <summary>
		/// Gets or sets Text position of a new rule in the target style sheet.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public SourceRange Location { get; set; }
	}
}
