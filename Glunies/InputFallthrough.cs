using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Glunies
{
	public class InputFallthrough : MonoBehaviour, IDragHandler, IEventSystemHandler, IScrollHandler
	{
		[Attribute(Name="InjectAttribute", RVA="0x106414C", Offset="0x106414C")]
		[FieldOffset(Offset="0x18")]
		private DispatchSystem _dispatchSystem;

		[Address(RVA="0x1526BE4", Offset="0x1526BE4", VA="0x1526BE4")]
		public InputFallthrough()
		{
		}

		[Address(RVA="0x1526ABC", Offset="0x1526ABC", VA="0x1526ABC", Slot="4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Address(RVA="0x1526B50", Offset="0x1526B50", VA="0x1526B50", Slot="5")]
		public void OnScroll(PointerEventData data)
		{
		}
	}
}