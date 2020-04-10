using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class AnimatorInstaller : Installer<Animator, AnimatorInstaller>
	{
		[FieldOffset(Offset="0x18")]
		private readonly Animator _animator;

		[Address(RVA="0x15AB39C", Offset="0x15AB39C", VA="0x15AB39C")]
		public AnimatorInstaller(Animator animator)
		{
		}

		[Address(RVA="0x15AB400", Offset="0x15AB400", VA="0x15AB400", Slot="7")]
		public override void InstallBindings()
		{
		}
	}
}