using Il2CppDummyDll;
using System;

namespace Zenject
{
	public abstract class SignalBase : ISignalBase
	{
		[FieldOffset(Offset="0x10")]
		private SignalManager _manager;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10609D4", Offset="0x10609D4")]
		[FieldOffset(Offset="0x18")]
		private BindingId <SignalId>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10609E4", Offset="0x10609E4")]
		[FieldOffset(Offset="0x20")]
		private SignalSettings <Settings>k__BackingField;

		public bool HasHandler
		{
			[Address(RVA="0x2331CD8", Offset="0x2331CD8", VA="0x2331CD8", Slot="5")]
			get
			{
				return new bool();
			}
		}

		protected SignalManager Manager
		{
			[Address(RVA="0x2331C3C", Offset="0x2331C3C", VA="0x2331C3C")]
			get
			{
				return null;
			}
		}

		public int NumHandlers
		{
			[Address(RVA="0x2331C44", Offset="0x2331C44", VA="0x2331C44", Slot="4")]
			get
			{
				return new int();
			}
		}

		protected SignalSettings Settings
		{
			[Address(RVA="0x2331C34", Offset="0x2331C34", VA="0x2331C34")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073E6C", Offset="0x1073E6C")]
			get
			{
				return null;
			}
			[Address(RVA="0x2331C24", Offset="0x2331C24", VA="0x2331C24")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073E7C", Offset="0x1073E7C")]
			private set
			{
			}
		}

		protected BindingId SignalId
		{
			[Address(RVA="0x2331C2C", Offset="0x2331C2C", VA="0x2331C2C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073E4C", Offset="0x1073E4C")]
			get
			{
				return null;
			}
			[Address(RVA="0x2331C1C", Offset="0x2331C1C", VA="0x2331C1C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073E5C", Offset="0x1073E5C")]
			private set
			{
			}
		}

		[Address(RVA="0x2331D88", Offset="0x2331D88", VA="0x2331D88")]
		protected SignalBase()
		{
		}

		[Address(RVA="0x2331B64", Offset="0x2331B64", VA="0x2331B64")]
		[Attribute(Name="InjectAttribute", RVA="0x1073E3C", Offset="0x1073E3C")]
		private void Construct(SignalManager manager, SignalSettings settings, BindInfo bindInfo)
		{
		}
	}
}