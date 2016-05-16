using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	[Event(ProtocolName.LayerTree.LayerPainted)]
	[SupportedBy("Chrome-Tip")]
	public class LayerPaintedEvent
	{
		/// <summary>
		/// Gets or sets The id of the painted layer.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string LayerId { get; set; }
		/// <summary>
		/// Gets or sets Clip rectangle.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public DOM.Rect Clip { get; set; }
	}
}
