using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Glunies
{
	[Serializable]
	public class PopupViewSerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x1064440", Offset="0x1064440")]
		[FieldOffset(Offset="0x28")]
		public List<Button> CloseHandlers;

		[Address(RVA="0x152AE28", Offset="0x152AE28", VA="0x152AE28")]
		public PopupViewSerializedFields()
		{
		}
	}
}