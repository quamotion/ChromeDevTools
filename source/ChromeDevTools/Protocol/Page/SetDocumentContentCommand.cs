using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Sets given markup as the document's HTML.
	/// </summary>
	[Command(ProtocolName.Page.SetDocumentContent)]
	[SupportedBy("Chrome-Tip")]
	public class SetDocumentContentCommand
	{
		/// <summary>
		/// Gets or sets Frame id to set HTML for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets HTML content to set.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Html { get; set; }
	}
}
