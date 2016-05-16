using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOMStorage
{
	[Event(ProtocolName.DOMStorage.DomStorageItemAdded)]
	[SupportedBy("Chrome-Tip")]
	public class DomStorageItemAddedEvent
	{
		/// <summary>
		/// Gets or sets StorageId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public StorageId StorageId { get; set; }
		/// <summary>
		/// Gets or sets Key
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Key { get; set; }
		/// <summary>
		/// Gets or sets NewValue
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string NewValue { get; set; }
	}
}
