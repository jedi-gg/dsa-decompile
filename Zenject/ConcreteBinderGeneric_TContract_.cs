using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class ConcreteBinderGeneric<TContract> : FromBinderGeneric<TContract>
	{
		[Address(RVA="0x1F44FD4", Offset="0x1F44FD4", VA="0x1F44FD4")]
		public ConcreteBinderGeneric(Zenject.BindInfo bindInfo, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x1F45660", Offset="0x1F45660", VA="0x1F45660")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10720B0", Offset="0x10720B0")]
		private bool <To>b__5_0(Type concreteType)
		{
			return new bool();
		}

		[Address(RVA="0x1F45534", Offset="0x1F45534", VA="0x1F45534")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10720A0", Offset="0x10720A0")]
		private IProvider <ToSelf>b__1_0(DiContainer container, Type type)
		{
			return null;
		}

		[Address(RVA="0x2AFA6D0", Offset="0x2AFA6D0", VA="0x2AFA6D0")]
		public FromBinderGeneric<TConcrete> To<TConcrete>()
		where TConcrete : TContract
		{
			return null;
		}

		[Address(RVA="0x1F451E4", Offset="0x1F451E4", VA="0x1F451E4")]
		public FromBinderNonGeneric To(params Type[] concreteTypes)
		{
			return null;
		}

		[Address(RVA="0x1F45230", Offset="0x1F45230", VA="0x1F45230")]
		public FromBinderNonGeneric To(IEnumerable<Type> concreteTypes)
		{
			return null;
		}

		[Address(RVA="0x1F453EC", Offset="0x1F453EC", VA="0x1F453EC")]
		public FromBinderNonGeneric To(Action<ConventionSelectTypesBinder> generator)
		{
			return null;
		}

		[Address(RVA="0x1F4504C", Offset="0x1F4504C", VA="0x1F4504C")]
		public FromBinderGeneric<TContract> ToSelf()
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D428", Offset="0x104D428")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x0")]
			public Type concreteType;

			[Address(RVA="0x1F44F9C", Offset="0x1F44F9C", VA="0x1F44F9C")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x1F44FC8", Offset="0x1F44FC8", VA="0x1F44FC8")]
			internal bool <To>b__1(Type contractType)
			{
				return new bool();
			}
		}
	}
}