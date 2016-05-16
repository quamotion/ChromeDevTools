using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Inspector
{
	[Event(ProtocolName.Inspector.Inspect)]
	[SupportedBy("Chrome-Tip")]
	public class InspectEvent
	{
		/// <summary>
		/// Gets or sets Object
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Runtime.RemoteObject Object { get; set; }
		/// <summary>
		/// Gets or sets Hints
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public object Hints { get; set; }
	}
}
