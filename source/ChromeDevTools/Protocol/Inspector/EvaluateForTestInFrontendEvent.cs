using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Inspector
{
	[Event(ProtocolName.Inspector.EvaluateForTestInFrontend)]
	[SupportedBy("Chrome-Tip")]
	public class EvaluateForTestInFrontendEvent
	{
		/// <summary>
		/// Gets or sets TestCallId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long TestCallId { get; set; }
		/// <summary>
		/// Gets or sets Script
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Script { get; set; }
	}
}
