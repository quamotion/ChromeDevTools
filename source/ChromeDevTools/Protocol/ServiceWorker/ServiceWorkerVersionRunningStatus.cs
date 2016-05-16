using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public enum ServiceWorkerVersionRunningStatus
	{
			Stopped,
			Starting,
			Running,
			Stopping,
	}
}
