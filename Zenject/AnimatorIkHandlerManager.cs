using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class AnimatorIkHandlerManager : MonoBehaviour
	{
		[FieldOffset(Offset="0x18")]
		private List<IAnimatorIkHandler> _handlers;

		[Address(RVA="0x15AB394", Offset="0x15AB394", VA="0x15AB394")]
		public AnimatorIkHandlerManager()
		{
		}

		[Address(RVA="0x15AB208", Offset="0x15AB208", VA="0x15AB208")]
		[Attribute(Name="InjectAttribute", RVA="0x1073D6C", Offset="0x1073D6C")]
		public void Construct([Attribute(Name="InjectAttribute", RVA="0x1091234", Offset="0x1091234")] List<IAnimatorIkHandler> handlers)
		{
		}

		[Address(RVA="0x15AB210", Offset="0x15AB210", VA="0x15AB210")]
		public void OnAnimatorIk()
		{
		}
	}
}