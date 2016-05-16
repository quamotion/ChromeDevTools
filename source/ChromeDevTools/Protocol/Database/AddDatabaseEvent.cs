using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Database
{
	[Event(ProtocolName.Database.AddDatabase)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class AddDatabaseEvent
	{
		/// <summary>
		/// Gets or sets Database
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public Database Database { get; set; }
	}
}
