using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	[Event(ProtocolName.LayerTree.LayerTreeDidChange)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class LayerTreeDidChangeEvent
	{
		/// <summary>
		/// Gets or sets Layer tree, absent if not in the comspositing mode.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public Layer[] Layers { get; set; }
	}
}
