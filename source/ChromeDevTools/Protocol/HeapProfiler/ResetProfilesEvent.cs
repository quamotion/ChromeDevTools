using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	[Event(ProtocolName.HeapProfiler.ResetProfiles)]
	[SupportedBy("Chrome-Tip")]
	public class ResetProfilesEvent
	{
	}
}
