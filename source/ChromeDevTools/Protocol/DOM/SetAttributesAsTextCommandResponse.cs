using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Sets attributes on element with given id. This method is useful when user edits some existing attribute value and types in several attribute name/value pairs.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetAttributesAsText)]
	[SupportedBy("Chrome-Tip")]
	public class SetAttributesAsTextCommandResponse
	{
	}
}
