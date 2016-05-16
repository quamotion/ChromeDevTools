using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime{
	/// <summary>
	/// Syntax error type: "none" for no error, "irrecoverable" for unrecoverable errors, "unterminated-literal" for when there is an unterminated literal, "recoverable" for when the expression is unfinished but valid so far.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public enum SyntaxErrorType
	{
			None,
			Irrecoverable,
			Unterminated_literal,
			Recoverable,
	}
}
