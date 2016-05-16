using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Shows / hides color picker
	/// </summary>
	[Command(ProtocolName.Page.SetColorPickerEnabled)]
	[SupportedBy("Chrome-Tip")]
	public class SetColorPickerEnabledCommand
	{
		/// <summary>
		/// Gets or sets Shows / hides color picker
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Enabled { get; set; }
	}
}
