using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Releases layer snapshot captured by the back-end.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.ReleaseSnapshot)]
	[SupportedBy("Chrome-Tip")]
	public class ReleaseSnapshotCommandResponse
	{
	}
}
