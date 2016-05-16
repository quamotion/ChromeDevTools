using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOMDebugger{
	/// <summary>
	/// DOM breakpoint type.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public enum DOMBreakpointType
	{
			Subtree_modified,
			Attribute_modified,
			Node_removed,
	}
}
