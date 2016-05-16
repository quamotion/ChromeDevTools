using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Inspector
{
	[Event(ProtocolName.Inspector.EvaluateForTestInFrontend)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class EvaluateForTestInFrontendEvent
	{
		/// <summary>
		/// Gets or sets TestCallId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long TestCallId { get; set; }
		/// <summary>
		/// Gets or sets Script
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Script { get; set; }
	}
}
