using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class StructureDescription
	{
		/// <summary>
		/// Gets or sets Array of strings, where the strings represent object properties.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string[] Fields { get; set; }
		/// <summary>
		/// Gets or sets Array of strings, where the strings represent optional object properties.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string[] OptionalFields { get; set; }
		/// <summary>
		/// Gets or sets Name of the constructor.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string ConstructorName { get; set; }
		/// <summary>
		/// Gets or sets Pointer to the StructureRepresentation of the protoype if one exists.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public StructureDescription PrototypeStructure { get; set; }
		/// <summary>
		/// Gets or sets If true, it indicates that the fields in this StructureDescription may be inaccurate. I.e, there might have been fields that have been deleted before it was profiled or it has fields we haven't profiled.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsImprecise { get; set; }
	}
}
