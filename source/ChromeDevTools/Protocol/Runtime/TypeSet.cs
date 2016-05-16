using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class TypeSet
	{
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Function.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsFunction { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Undefined.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsUndefined { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Null.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsNull { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Boolean.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsBoolean { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Integer.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsInteger { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Number.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsNumber { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type String.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsString { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Object.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsObject { get; set; }
		/// <summary>
		/// Gets or sets Indicates if this type description has been type Symbol.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsSymbol { get; set; }
	}
}
