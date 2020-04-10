using Il2CppDummyDll;
using System;

namespace Glunies.Inferno
{
	public class SettingsController : AInfernoController
	{
		[Address(RVA="0x15256CC", Offset="0x15256CC", VA="0x15256CC")]
		public SettingsController()
		{
		}

		[Address(RVA="0x1525600", Offset="0x1525600", VA="0x1525600", Slot="4")]
		public override void Initialize(Action finished)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051238", Offset="0x1051238")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x10")]
			public Action finished;

			[Address(RVA="0x15256C4", Offset="0x15256C4", VA="0x15256C4")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x15256D4", Offset="0x15256D4", VA="0x15256D4")]
			internal void <Initialize>b__0(SettingsView view)
			{
			}
		}
	}
}