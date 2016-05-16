using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Reloads given page optionally ignoring the cache.
	/// </summary>
	[Command(ProtocolName.Page.Reload)]
	[SupportedBy("Chrome-Tip")]
	public class ReloadCommand
	{
		/// <summary>
		/// Gets or sets If true, browser cache is ignored (as if the user pressed Shift+refresh).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IgnoreCache { get; set; }
		/// <summary>
		/// Gets or sets If set, the script will be injected into all frames of the inspected page after reload.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScriptToEvaluateOnLoad { get; set; }
	}
}
