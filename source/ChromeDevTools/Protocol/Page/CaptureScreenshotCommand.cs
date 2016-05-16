using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Capture page screenshot.
	/// </summary>
	[Command(ProtocolName.Page.CaptureScreenshot)]
	[SupportedBy("Chrome-Tip")]
	public class CaptureScreenshotCommand
	{
	}
}
