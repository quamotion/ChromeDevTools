using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Fired when virtual machine fails to parse the script.
	/// </summary>
	[Event(ProtocolName.Debugger.ScriptFailedToParse)]
	[SupportedBy("Chrome-Tip")]
	public class ScriptFailedToParseEvent
	{
		/// <summary>
		/// Gets or sets Identifier of the script parsed.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets URL or name of the script parsed (if any).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Line offset of the script within the resource with given URL (for script tags).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long StartLine { get; set; }
		/// <summary>
		/// Gets or sets Column offset of the script within the resource with given URL.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long StartColumn { get; set; }
		/// <summary>
		/// Gets or sets Last line of the script.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long EndLine { get; set; }
		/// <summary>
		/// Gets or sets Length of the last line of the script.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long EndColumn { get; set; }
		/// <summary>
		/// Gets or sets Determines whether this script is a user extension script.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IsContentScript { get; set; }
		/// <summary>
		/// Gets or sets Determines whether this script is an internal script.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IsInternalScript { get; set; }
		/// <summary>
		/// Gets or sets URL of source map associated with script (if any).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SourceMapURL { get; set; }
		/// <summary>
		/// Gets or sets True, if this script has sourceURL.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool HasSourceURL { get; set; }
	}
}
