using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Fired when a canvas context has been created in the given frame. The context may not be instrumented (see hasUninstrumentedCanvases command).
	/// </summary>
	[Event(ProtocolName.Canvas.ContextCreated)]
	[SupportedBy("Chrome-Tip")]
	public class ContextCreatedEvent
	{
		/// <summary>
		/// Gets or sets Identifier of the frame containing a canvas with a context.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
	}
}
