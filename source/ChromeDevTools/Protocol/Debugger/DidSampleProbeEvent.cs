using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Fires when a new probe sample is collected.
	/// </summary>
	[Event(ProtocolName.Debugger.DidSampleProbe)]
	[SupportedBy("iOS-9.3")]
	public class DidSampleProbeEvent
	{
		/// <summary>
		/// Gets or sets A collected probe sample.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public ProbeSample Sample { get; set; }
	}
}
