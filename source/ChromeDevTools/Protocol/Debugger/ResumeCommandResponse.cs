using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Resumes JavaScript execution.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.Resume)]
	[SupportedBy("Chrome-Tip")]
	public class ResumeCommandResponse
	{
	}
}
