using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns metainfo entries for all known stylesheets.
	/// </summary>
	[Command(ProtocolName.CSS.GetAllStyleSheets)]
	[SupportedBy("iOS-9.3")]
	public class GetAllStyleSheetsCommand
	{
	}
}
