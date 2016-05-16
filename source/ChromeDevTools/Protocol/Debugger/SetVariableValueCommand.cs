using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Changes value of variable in a callframe or a closure. Either callframe or function must be specified. Object-based scopes are not supported and must be mutated manually.
	/// </summary>
	[Command(ProtocolName.Debugger.SetVariableValue)]
	[SupportedBy("Chrome-Tip")]
	public class SetVariableValueCommand
	{
		/// <summary>
		/// Gets or sets 0-based number of scope as was listed in scope chain. Only 'local', 'closure' and 'catch' scope types are allowed. Other scopes could be manipulated manually.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ScopeNumber { get; set; }
		/// <summary>
		/// Gets or sets Variable name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string VariableName { get; set; }
		/// <summary>
		/// Gets or sets New variable value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Runtime.CallArgument NewValue { get; set; }
		/// <summary>
		/// Gets or sets Id of callframe that holds variable.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string CallFrameId { get; set; }
		/// <summary>
		/// Gets or sets Object id of closure (function) that holds variable.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FunctionObjectId { get; set; }
	}
}
