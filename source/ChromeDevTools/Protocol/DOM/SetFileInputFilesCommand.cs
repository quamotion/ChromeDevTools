using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Sets files for the given file input element.
	/// </summary>
	[Command(ProtocolName.DOM.SetFileInputFiles)]
	[SupportedBy("Chrome-Tip")]
	public class SetFileInputFilesCommand
	{
		/// <summary>
		/// Gets or sets Id of the file input node to set files for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Array of file paths to set.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string[] Files { get; set; }
	}
}
