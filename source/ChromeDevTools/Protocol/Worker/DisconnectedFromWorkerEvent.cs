using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Worker
{
	[Event(ProtocolName.Worker.DisconnectedFromWorker)]
	[SupportedBy("iOS-9.3")]
	public class DisconnectedFromWorkerEvent
	{
	}
}
