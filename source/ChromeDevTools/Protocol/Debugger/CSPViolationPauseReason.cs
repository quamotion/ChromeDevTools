using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// The pause reason auxiliary data when paused because of a Content Security Policy directive.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class CSPViolationPauseReason
	{
		/// <summary>
		/// Gets or sets The CSP directive that blocked script execution.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Directive { get; set; }
	}
}
