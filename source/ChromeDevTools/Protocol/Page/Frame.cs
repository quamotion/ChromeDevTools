using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Information about the Frame on the page.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class Frame
	{
		/// <summary>
		/// Gets or sets Frame unique identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Parent frame identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ParentId { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the loader associated with this frame.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets Frame's name as specified in the tag.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Frame document's URL.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Frame document's security origin.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets Frame document's mimeType as determined by the browser.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string MimeType { get; set; }
	}
}
