using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Timeline{
	/// <summary>
	/// Timeline record type.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public enum EventType
	{
			EventDispatch,
			ScheduleStyleRecalculation,
			RecalculateStyles,
			InvalidateLayout,
			Layout,
			Paint,
			Composite,
			RenderingFrame,
			ScrollLayer,
			ParseHTML,
			TimerInstall,
			TimerRemove,
			TimerFire,
			EvaluateScript,
			MarkLoad,
			MarkDOMContent,
			TimeStamp,
			Time,
			TimeEnd,
			XHRReadyStateChange,
			XHRLoad,
			FunctionCall,
			ProbeSample,
			ConsoleProfile,
			GCEvent,
			RequestAnimationFrame,
			CancelAnimationFrame,
			FireAnimationFrame,
			WebSocketCreate,
			WebSocketSendHandshakeRequest,
			WebSocketReceiveHandshakeResponse,
			WebSocketDestroy,
	}
}
