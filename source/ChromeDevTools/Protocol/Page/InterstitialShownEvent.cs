using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when interstitial page was shown
	/// </summary>
	[Event(ProtocolName.Page.InterstitialShown)]
	[SupportedBy("Chrome-Tip")]
	public class InterstitialShownEvent
	{
	}
}
