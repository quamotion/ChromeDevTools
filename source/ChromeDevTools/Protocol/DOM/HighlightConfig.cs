using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Configuration data for the highlighting of page elements.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class HighlightConfig
	{
		/// <summary>
		/// Gets or sets Whether the node info tooltip should be shown (default: false).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public bool ShowInfo { get; set; }
		/// <summary>
		/// Gets or sets Whether the rulers should be shown (default: false).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool ShowRulers { get; set; }
		/// <summary>
		/// Gets or sets Whether the extension lines from node to the rulers should be shown (default: false).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool ShowExtensionLines { get; set; }
		/// <summary>
		/// Gets or sets The content box highlight fill color (default: transparent).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RGBA ContentColor { get; set; }
		/// <summary>
		/// Gets or sets The padding highlight fill color (default: transparent).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RGBA PaddingColor { get; set; }
		/// <summary>
		/// Gets or sets The border highlight fill color (default: transparent).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RGBA BorderColor { get; set; }
		/// <summary>
		/// Gets or sets The margin highlight fill color (default: transparent).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RGBA MarginColor { get; set; }
		/// <summary>
		/// Gets or sets The event target element highlight fill color (default: transparent).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RGBA EventTargetColor { get; set; }
		/// <summary>
		/// Gets or sets The shape outside fill color (default: transparent).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RGBA ShapeColor { get; set; }
		/// <summary>
		/// Gets or sets The shape margin fill color (default: transparent).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RGBA ShapeMarginColor { get; set; }
	}
}
