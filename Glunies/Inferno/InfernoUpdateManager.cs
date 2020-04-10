using Glunies.Audio;
using Il2CppDummyDll;
using System;
using Zenject;

namespace Glunies.Inferno
{
	public class InfernoUpdateManager : ITickable
	{
		[Attribute(Name="InjectAttribute", RVA="0x1064A50", Offset="0x1064A50")]
		[FieldOffset(Offset="0x10")]
		private InfernoStateMachine _stateMachine;

		[Attribute(Name="InjectAttribute", RVA="0x1064A60", Offset="0x1064A60")]
		[FieldOffset(Offset="0x18")]
		private AudioSystem _audioSystem;

		[Address(RVA="0x15246A0", Offset="0x15246A0", VA="0x15246A0")]
		public InfernoUpdateManager()
		{
		}

		[Address(RVA="0x152463C", Offset="0x152463C", VA="0x152463C", Slot="4")]
		public void Tick()
		{
		}
	}
}