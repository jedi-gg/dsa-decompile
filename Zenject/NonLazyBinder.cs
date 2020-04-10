using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class NonLazyBinder
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FF78", Offset="0x105FF78")]
		[FieldOffset(Offset="0x10")]
		private Zenject.BindInfo <BindInfo>k__BackingField;

		protected Zenject.BindInfo BindInfo
		{
			[Address(RVA="0x1834198", Offset="0x1834198", VA="0x1834198")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10722F4", Offset="0x10722F4")]
			get
			{
				return null;
			}
			[Address(RVA="0x183DE1C", Offset="0x183DE1C", VA="0x183DE1C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072304", Offset="0x1072304")]
			private set
			{
			}
		}

		[Address(RVA="0x183DDF0", Offset="0x183DDF0", VA="0x183DDF0")]
		public NonLazyBinder(Zenject.BindInfo bindInfo)
		{
		}

		[Address(RVA="0x183760C", Offset="0x183760C", VA="0x183760C")]
		public void NonLazy()
		{
		}
	}
}