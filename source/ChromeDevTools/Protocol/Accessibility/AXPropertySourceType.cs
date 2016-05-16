using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Accessibility{
	/// <summary>
	/// Enum of possible property sources.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public enum AXPropertySourceType
	{
			Attribute,
			Implicit,
			Style,
	}
}
