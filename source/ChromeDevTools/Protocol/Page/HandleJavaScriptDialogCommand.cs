using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Accepts or dismisses a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload).
	/// </summary>
	[Command(ProtocolName.Page.HandleJavaScriptDialog)]
	[SupportedBy("Chrome-Tip")]
	public class HandleJavaScriptDialogCommand
	{
		/// <summary>
		/// Gets or sets Whether to accept or dismiss the dialog.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Accept { get; set; }
		/// <summary>
		/// Gets or sets The text to enter into the dialog prompt before accepting. Used only if this is a prompt dialog.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string PromptText { get; set; }
	}
}
