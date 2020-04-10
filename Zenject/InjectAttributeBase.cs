using Il2CppDummyDll;
using ModestTree.Util;
using System;

namespace Zenject
{
	public abstract class InjectAttributeBase : PreserveAttribute
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060A44", Offset="0x1060A44")]
		[FieldOffset(Offset="0x10")]
		private bool <Optional>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060A54", Offset="0x1060A54")]
		[FieldOffset(Offset="0x18")]
		private object <Id>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060A64", Offset="0x1060A64")]
		[FieldOffset(Offset="0x20")]
		private InjectSources <Source>k__BackingField;

		public object Id
		{
			[Address(RVA="0x1839AD0", Offset="0x1839AD0", VA="0x1839AD0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107401C", Offset="0x107401C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1839AD8", Offset="0x1839AD8", VA="0x1839AD8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107402C", Offset="0x107402C")]
			set
			{
			}
		}

		public bool Optional
		{
			[Address(RVA="0x1839ABC", Offset="0x1839ABC", VA="0x1839ABC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073FFC", Offset="0x1073FFC")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1839AC4", Offset="0x1839AC4", VA="0x1839AC4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107400C", Offset="0x107400C")]
			set
			{
			}
		}

		public InjectSources Source
		{
			[Address(RVA="0x1839AE0", Offset="0x1839AE0", VA="0x1839AE0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107403C", Offset="0x107403C")]
			get
			{
				return new InjectSources();
			}
			[Address(RVA="0x1839AE8", Offset="0x1839AE8", VA="0x1839AE8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107404C", Offset="0x107404C")]
			set
			{
			}
		}

		[Address(RVA="0x1839AB4", Offset="0x1839AB4", VA="0x1839AB4")]
		protected InjectAttributeBase()
		{
		}
	}
}