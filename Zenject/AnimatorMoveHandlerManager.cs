using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class AnimatorMoveHandlerManager : MonoBehaviour
	{
		[FieldOffset(Offset="0x18")]
		private List<IAnimatorMoveHandler> _handlers;

		[Address(RVA="0x15AB6A0", Offset="0x15AB6A0", VA="0x15AB6A0")]
		public AnimatorMoveHandlerManager()
		{
		}

		[Address(RVA="0x15AB514", Offset="0x15AB514", VA="0x15AB514")]
		[Attribute(Name="InjectAttribute", RVA="0x1073D7C", Offset="0x1073D7C")]
		public void Construct([Attribute(Name="InjectAttribute", RVA="0x109126C", Offset="0x109126C")] List<IAnimatorMoveHandler> handlers)
		{
		}

		[Address(RVA="0x15AB51C", Offset="0x15AB51C", VA="0x15AB51C")]
		public void OnAnimatorMove()
		{
		}
	}
}