using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public enum ServiceWorkerVersionStatus
	{
			New,
			Installing,
			Installed,
			Activating,
			Activated,
			Redundant,
	}
}
