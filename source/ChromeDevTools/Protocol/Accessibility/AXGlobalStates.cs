using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Accessibility{
	/// <summary>
	/// States which apply to every AX node.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public enum AXGlobalStates
	{
			Disabled,
			Hidden,
			HiddenRoot,
			Invalid,
	}
}
