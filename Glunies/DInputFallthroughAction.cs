using Il2CppDummyDll;
using System;
using UnityEngine.EventSystems;

namespace Glunies
{
	public struct DInputFallthroughAction
	{
		[FieldOffset(Offset="0x0")]
		public readonly DInputFallthroughAction.ActionType Action;

		[FieldOffset(Offset="0x8")]
		public readonly PointerEventData EventData;

		[Address(RVA="0xF00AD4", Offset="0xF00AD4", VA="0xF00AD4")]
		public DInputFallthroughAction(DInputFallthroughAction.ActionType action, PointerEventData eventData)
		{
		}

		public enum ActionType
		{
			[FieldOffset(Offset="0x0")]
			OnDrag,
			[FieldOffset(Offset="0x0")]
			OnScroll
		}
	}
}