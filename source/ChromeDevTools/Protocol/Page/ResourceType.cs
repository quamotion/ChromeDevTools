using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page{
	/// <summary>
	/// Resource type as it was perceived by the rendering engine.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public enum ResourceType
	{
			Document,
			Stylesheet,
			Image,
			Media,
			Font,
			Script,
			TextTrack,
			XHR,
			WebSocket,
			Other,
	}
}
