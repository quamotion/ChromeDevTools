using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.OverlayTypes
{
	/// <summary>
	/// Data required to highlight a DOM node.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class NodeHighlightData
	{
		/// <summary>
		/// Gets or sets Scroll offset for the MainFrame's FrameView that is shared across all quads.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public Point ScrollOffset { get; set; }
		/// <summary>
		/// Gets or sets Fragments
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public FragmentHighlightData[] Fragments { get; set; }
		/// <summary>
		/// Gets or sets ElementData
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public ElementData ElementData { get; set; }
	}
}
