using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MemoryPoolExpandBinder<TContract> : FactoryToChoiceIdBinder<TContract>
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FF18", Offset="0x105FF18")]
		[FieldOffset(Offset="0x0")]
		private Zenject.MemoryPoolBindInfo <MemoryPoolBindInfo>k__BackingField;

		protected Zenject.MemoryPoolBindInfo MemoryPoolBindInfo
		{
			[Address(RVA="0x23549B0", Offset="0x23549B0", VA="0x23549B0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072214", Offset="0x1072214")]
			get
			{
				return null;
			}
			[Address(RVA="0x23549B8", Offset="0x23549B8", VA="0x23549B8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072224", Offset="0x1072224")]
			private set
			{
			}
		}

		[Address(RVA="0x23548E8", Offset="0x23548E8", VA="0x23548E8")]
		public MemoryPoolExpandBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo, Zenject.MemoryPoolBindInfo poolBindInfo)
		{
		}

		[Address(RVA="0x2354A20", Offset="0x2354A20", VA="0x2354A20")]
		public FactoryToChoiceIdBinder<TContract> ExpandByDoubling()
		{
			return null;
		}

		[Address(RVA="0x23549C0", Offset="0x23549C0", VA="0x23549C0")]
		public FactoryToChoiceIdBinder<TContract> ExpandByOneAtATime()
		{
			return null;
		}
	}
}