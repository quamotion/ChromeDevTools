using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.CSS{
	/// <summary>
	/// The property status: "active" if the property is effective in the style, "inactive" if the property is overridden by a same-named property in this style later on, "disabled" if the property is disabled by the user, "style" (implied if absent) if the property is reported by the browser rather than by the CSS source parser.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public enum CSSPropertyStatus
	{
			Active,
			Inactive,
			Disabled,
			Style,
	}
}
