using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Accessibility{
	/// <summary>
	/// States which apply to widgets.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public enum AXWidgetStates
	{
			Checked,
			Expanded,
			Pressed,
			Selected,
	}
}
