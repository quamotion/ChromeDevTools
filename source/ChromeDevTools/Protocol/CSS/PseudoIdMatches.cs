using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// CSS rule collection for a single pseudo style.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class PseudoIdMatches
	{
		/// <summary>
		/// Gets or sets Pseudo style identifier (see <code>enum PseudoId</code> in <code>ComputedStyleConstants.h</code>).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long PseudoId { get; set; }
		/// <summary>
		/// Gets or sets Matches of CSS rules applicable to the pseudo style.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RuleMatch[] Matches { get; set; }
	}
}
