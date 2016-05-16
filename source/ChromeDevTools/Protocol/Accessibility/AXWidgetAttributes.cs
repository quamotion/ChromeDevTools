using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Accessibility{
	/// <summary>
	/// Attributes which apply to widgets.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public enum AXWidgetAttributes
	{
			Autocomplete,
			Haspopup,
			Level,
			Multiselectable,
			Orientation,
			Multiline,
			Readonly,
			Required,
			Valuemin,
			Valuemax,
			Valuetext,
	}
}
