using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Shows / hides color picker
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetColorPickerEnabled)]
	[SupportedBy("Chrome-Tip")]
	public class SetColorPickerEnabledCommandResponse
	{
	}
}
