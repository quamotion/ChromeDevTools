using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Container for type information that has been gathered.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class TypeDescription
	{
		/// <summary>
		/// Gets or sets If true, we were able to correlate the offset successfuly with a program location. If false, the offset may be bogus or the offset may be from a CodeBlock that hasn't executed.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsValid { get; set; }
		/// <summary>
		/// Gets or sets Least common ancestor of all Constructors if the TypeDescription has seen any structures. This string is the display name of the shared constructor function.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string LeastCommonAncestor { get; set; }
		/// <summary>
		/// Gets or sets Set of booleans for determining the aggregate type of this type description.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public TypeSet TypeSet { get; set; }
		/// <summary>
		/// Gets or sets Array of descriptions for all structures seen for this variable.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public StructureDescription[] Structures { get; set; }
		/// <summary>
		/// Gets or sets If true, this indicates that no more structures are being profiled because some maximum threshold has been reached and profiling has stopped because of memory pressure.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsTruncated { get; set; }
	}
}
