using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM{
	/// <summary>
	/// Pseudo element type.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public enum PseudoType
	{
			First_line,
			First_letter,
			Before,
			After,
			Backdrop,
			Selection,
			First_line_inherited,
			Scrollbar,
			Scrollbar_thumb,
			Scrollbar_button,
			Scrollbar_track,
			Scrollbar_track_piece,
			Scrollbar_corner,
			Resizer,
			Input_list_button,
	}
}
