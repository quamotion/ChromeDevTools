using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Sets attribute for an element with given id.
	/// </summary>
	[Command(ProtocolName.DOM.SetAttributeValue)]
	[SupportedBy("Chrome-Tip")]
	public class SetAttributeValueCommand
	{
		/// <summary>
		/// Gets or sets Id of the element to set attribute for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Attribute name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Attribute value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Value { get; set; }
	}
}
