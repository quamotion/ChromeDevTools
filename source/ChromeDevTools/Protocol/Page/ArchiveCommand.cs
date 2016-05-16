using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Grab an archive of the page.
	/// </summary>
	[Command(ProtocolName.Page.Archive)]
	[SupportedBy("iOS-9.3")]
	public class ArchiveCommand
	{
	}
}
