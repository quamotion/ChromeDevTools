using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Edits JavaScript source live.
	/// </summary>
	[Command(ProtocolName.Debugger.SetScriptSource)]
	[SupportedBy("Chrome-Tip")]
	public class SetScriptSourceCommand
	{
		/// <summary>
		/// Gets or sets Id of the script to edit.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets New content of the script.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScriptSource { get; set; }
		/// <summary>
		/// Gets or sets  If true the change will not actually be applied. Preview mode may be used to get result description without actually modifying the code.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Preview { get; set; }
	}
}
