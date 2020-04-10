using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class ConventionSelectTypesBinder
	{
		[FieldOffset(Offset="0x10")]
		private readonly ConventionBindInfo _bindInfo;

		[Address(RVA="0x15AF4F8", Offset="0x15AF4F8", VA="0x15AF4F8")]
		public ConventionSelectTypesBinder(ConventionBindInfo bindInfo)
		{
		}

		[Address(RVA="0x15B3250", Offset="0x15B3250", VA="0x15B3250")]
		public ConventionFilterTypesBinder AllAbstractClasses()
		{
			return null;
		}

		[Address(RVA="0x15B3040", Offset="0x15B3040", VA="0x15B3040")]
		public ConventionFilterTypesBinder AllClasses()
		{
			return null;
		}

		[Address(RVA="0x15B3358", Offset="0x15B3358", VA="0x15B3358")]
		public ConventionFilterTypesBinder AllInterfaces()
		{
			return null;
		}

		[Address(RVA="0x15B3148", Offset="0x15B3148", VA="0x15B3148")]
		public ConventionFilterTypesBinder AllNonAbstractClasses()
		{
			return null;
		}

		[Address(RVA="0x15B303C", Offset="0x15B303C", VA="0x15B303C")]
		public ConventionFilterTypesBinder AllTypes()
		{
			return null;
		}

		[Address(RVA="0x15B2FD4", Offset="0x15B2FD4", VA="0x15B2FD4")]
		private ConventionFilterTypesBinder CreateNextBinder()
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D568", Offset="0x104D568")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ConventionSelectTypesBinder.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<Type, bool> <>9__4_0;

			[FieldOffset(Offset="0x10")]
			public static Func<Type, bool> <>9__5_0;

			[FieldOffset(Offset="0x18")]
			public static Func<Type, bool> <>9__6_0;

			[FieldOffset(Offset="0x20")]
			public static Func<Type, bool> <>9__7_0;

			[Address(RVA="0x15B3460", Offset="0x15B3460", VA="0x15B3460")]
			static <>c()
			{
			}

			[Address(RVA="0x15B34C4", Offset="0x15B34C4", VA="0x15B34C4")]
			public <>c()
			{
			}

			[Address(RVA="0x15B355C", Offset="0x15B355C", VA="0x15B355C")]
			internal bool <AllAbstractClasses>b__6_0(Type t)
			{
				return new bool();
			}

			[Address(RVA="0x15B34CC", Offset="0x15B34CC", VA="0x15B34CC")]
			internal bool <AllClasses>b__4_0(Type t)
			{
				return new bool();
			}

			[Address(RVA="0x15B35B8", Offset="0x15B35B8", VA="0x15B35B8")]
			internal bool <AllInterfaces>b__7_0(Type t)
			{
				return new bool();
			}

			[Address(RVA="0x15B34FC", Offset="0x15B34FC", VA="0x15B34FC")]
			internal bool <AllNonAbstractClasses>b__5_0(Type t)
			{
				return new bool();
			}
		}
	}
}