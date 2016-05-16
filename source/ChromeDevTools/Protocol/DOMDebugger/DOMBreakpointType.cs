using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOMDebugger{
	/// <summary>
	/// DOM breakpoint type.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public enum DOMBreakpointType
	{
			Subtree_modified,
			Attribute_modified,
			Node_removed,
	}
}
