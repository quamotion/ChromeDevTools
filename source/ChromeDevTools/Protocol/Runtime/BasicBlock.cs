using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// From Wikipedia: a basic block is a portion of the code within a program with only one entry point and only one exit point. This type gives the location of a basic block and if that basic block has executed.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class BasicBlock
	{
		/// <summary>
		/// Gets or sets Start offset of the basic block.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long StartOffset { get; set; }
		/// <summary>
		/// Gets or sets End offset of the basic block.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long EndOffset { get; set; }
		/// <summary>
		/// Gets or sets Indicates if the basic block has executed before.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool HasExecuted { get; set; }
	}
}
