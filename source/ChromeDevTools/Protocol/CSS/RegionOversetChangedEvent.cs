using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Fires if any of the regionOverset values changed in a Named Flow's region chain.
	/// </summary>
	[Event(ProtocolName.CSS.RegionOversetChanged)]
	[SupportedBy("iOS-9.3")]
	public class RegionOversetChangedEvent
	{
		/// <summary>
		/// Gets or sets The Named Flow containing the regions whose regionOverset values changed.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public NamedFlow NamedFlow { get; set; }
	}
}
