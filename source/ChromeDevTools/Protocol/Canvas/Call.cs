using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class Call
	{
		/// <summary>
		/// Gets or sets ContextId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ContextId { get; set; }
		/// <summary>
		/// Gets or sets FunctionName
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or sets Arguments
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CallArgument[] Arguments { get; set; }
		/// <summary>
		/// Gets or sets Result
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CallArgument Result { get; set; }
		/// <summary>
		/// Gets or sets IsDrawingCall
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IsDrawingCall { get; set; }
		/// <summary>
		/// Gets or sets IsFrameEndCall
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IsFrameEndCall { get; set; }
		/// <summary>
		/// Gets or sets Property
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Property { get; set; }
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CallArgument Value { get; set; }
		/// <summary>
		/// Gets or sets SourceURL
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or sets LineNumber
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets ColumnNumber
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ColumnNumber { get; set; }
	}
}
