using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Database
{
	[Event(ProtocolName.Database.AddDatabase)]
	[SupportedBy("Chrome-Tip")]
	public class AddDatabaseEvent
	{
		/// <summary>
		/// Gets or sets Database
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Database Database { get; set; }
	}
}
