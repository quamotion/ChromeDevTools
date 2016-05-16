using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when interstitial page was hidden
	/// </summary>
	[Event(ProtocolName.Page.InterstitialHidden)]
	[SupportedBy("Chrome-Tip")]
	public class InterstitialHiddenEvent
	{
	}
}
