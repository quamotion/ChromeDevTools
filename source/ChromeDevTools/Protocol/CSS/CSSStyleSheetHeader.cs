using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// CSS stylesheet metainformation.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class CSSStyleSheetHeader
	{
		/// <summary>
		/// Gets or sets The stylesheet identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Owner frame identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Stylesheet resource URL.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or sets URL of source map associated with the stylesheet (if any).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SourceMapURL { get; set; }
		/// <summary>
		/// Gets or sets Stylesheet origin.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public StyleSheetOrigin Origin { get; set; }
		/// <summary>
		/// Gets or sets Stylesheet title.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Title { get; set; }
		/// <summary>
		/// Gets or sets The backend id for the owner node of the stylesheet.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long OwnerNode { get; set; }
		/// <summary>
		/// Gets or sets Denotes whether the stylesheet is disabled.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Disabled { get; set; }
		/// <summary>
		/// Gets or sets Whether the sourceURL field value comes from the sourceURL comment.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool HasSourceURL { get; set; }
		/// <summary>
		/// Gets or sets Whether this stylesheet is created for STYLE tag by parser. This flag is not set for document.written STYLE tags.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IsInline { get; set; }
		/// <summary>
		/// Gets or sets Line offset of the stylesheet within the resource (zero based).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double StartLine { get; set; }
		/// <summary>
		/// Gets or sets Column offset of the stylesheet within the resource (zero based).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double StartColumn { get; set; }
	}
}
