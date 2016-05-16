using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	[Event(ProtocolName.LayerTree.LayerTreeDidChange)]
	[SupportedBy("Chrome-Tip")]
	public class LayerTreeDidChangeEvent
	{
		/// <summary>
		/// Gets or sets Layer tree, absent if not in the comspositing mode.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Layer[] Layers { get; set; }
	}
}
