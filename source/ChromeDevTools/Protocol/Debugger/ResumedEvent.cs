using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Fired when the virtual machine resumed execution.
	/// </summary>
	[Event(ProtocolName.Debugger.Resumed)]
	[SupportedBy("Chrome-Tip")]
	public class ResumedEvent
	{
	}
}
