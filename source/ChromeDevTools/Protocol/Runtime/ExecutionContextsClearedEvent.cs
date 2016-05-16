using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Issued when all executionContexts were cleared in browser
	/// </summary>
	[Event(ProtocolName.Runtime.ExecutionContextsCleared)]
	[SupportedBy("Chrome-Tip")]
	public class ExecutionContextsClearedEvent
	{
	}
}
