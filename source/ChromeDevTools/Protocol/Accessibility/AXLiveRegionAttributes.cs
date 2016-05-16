using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Accessibility{
	/// <summary>
	/// Attributes which apply to nodes in live regions.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public enum AXLiveRegionAttributes
	{
			Live,
			Atomic,
			Relevant,
			Busy,
			Root,
	}
}
