using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Inspector
{
	/// <summary>
	/// Fired when the backend has alternate domains that need to be activated.
	/// </summary>
	[Event(ProtocolName.Inspector.ActivateExtraDomains)]
	[SupportedBy("iOS-9.3")]
	public class ActivateExtraDomainsEvent
	{
		/// <summary>
		/// Gets or sets Domain names that need activation
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string[] Domains { get; set; }
	}
}
