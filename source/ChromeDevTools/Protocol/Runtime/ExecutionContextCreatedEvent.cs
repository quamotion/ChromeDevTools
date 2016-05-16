using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Issued when new execution context is created.
	/// </summary>
	[Event(ProtocolName.Runtime.ExecutionContextCreated)]
	[SupportedBy("Chrome-Tip")]
	public class ExecutionContextCreatedEvent
	{
		/// <summary>
		/// Gets or sets A newly created execution contex.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ExecutionContextDescription Context { get; set; }
	}
}
