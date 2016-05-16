using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Console
{
	/// <summary>
	/// Issued when new console message is added.
	/// </summary>
	[Event(ProtocolName.Console.MessageAdded)]
	[SupportedBy("Chrome-Tip")]
	public class MessageAddedEvent
	{
		/// <summary>
		/// Gets or sets Console message that has been added.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ConsoleMessage Message { get; set; }
	}
}
