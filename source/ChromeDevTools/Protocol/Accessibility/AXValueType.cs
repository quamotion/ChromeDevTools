using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Accessibility{
	/// <summary>
	/// Enum of possible property types.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public enum AXValueType
	{
			Boolean,
			Tristate,
			BooleanOrUndefined,
			Idref,
			IdrefList,
			Integer,
			Number,
			String,
			Token,
			TokenList,
			DomRelation,
			Role,
			InternalRole,
	}
}
