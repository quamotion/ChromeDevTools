using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Makes backend skip steps in the sources with names matching given pattern. VM will try leave blacklisted scripts by performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
	/// </summary>
	[Command(ProtocolName.Debugger.SkipStackFrames)]
	[SupportedBy("Chrome-Tip")]
	public class SkipStackFramesCommand
	{
		/// <summary>
		/// Gets or sets Regular expression defining the scripts to ignore while stepping.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Script { get; set; }
		/// <summary>
		/// Gets or sets True, if all content scripts should be ignored.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool SkipContentScripts { get; set; }
	}
}
