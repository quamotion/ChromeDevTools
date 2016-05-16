using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Returns displayable properties of a given object. Object group of the result is inherited from the target object. Displayable properties are own properties, internal properties, and native getters in the prototype chain (assumed to be bindings and treated like own properties for the frontend).
	/// </summary>
	[Command(ProtocolName.Runtime.GetDisplayableProperties)]
	[SupportedBy("iOS-9.3")]
	public class GetDisplayablePropertiesCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the object to return properties for.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets Whether preview should be generated for property values.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool GeneratePreview { get; set; }
	}
}
