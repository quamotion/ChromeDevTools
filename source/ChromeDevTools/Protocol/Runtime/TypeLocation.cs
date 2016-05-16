using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Describes the location of an expression we want type information for.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class TypeLocation
	{
		/// <summary>
		/// Gets or sets What kind of type information do we want (normal, function return values, 'this' statement).
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long TypeInformationDescriptor { get; set; }
		/// <summary>
		/// Gets or sets sourceID uniquely identifying a script
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string SourceID { get; set; }
		/// <summary>
		/// Gets or sets character offset for assignment range
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long Divot { get; set; }
	}
}
