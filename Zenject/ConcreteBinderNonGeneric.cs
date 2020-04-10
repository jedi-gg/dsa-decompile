using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class ConcreteBinderNonGeneric : FromBinderNonGeneric
	{
		[Address(RVA="0x15AF0D4", Offset="0x15AF0D4", VA="0x15AF0D4")]
		public ConcreteBinderNonGeneric(Zenject.BindInfo bindInfo, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x15AF678", Offset="0x15AF678", VA="0x15AF678")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10720C0", Offset="0x10720C0")]
		private IProvider <ToSelf>b__1_0(DiContainer container, Type type)
		{
			return null;
		}

		[Address(RVA="0x2AFA89C", Offset="0x2AFA89C", VA="0x2AFA89C")]
		public FromBinderNonGeneric To<TConcrete>()
		{
			return null;
		}

		[Address(RVA="0x15AF24C", Offset="0x15AF24C", VA="0x15AF24C")]
		public FromBinderNonGeneric To(params Type[] concreteTypes)
		{
			return null;
		}

		[Address(RVA="0x15AF250", Offset="0x15AF250", VA="0x15AF250")]
		public FromBinderNonGeneric To(IEnumerable<Type> concreteTypes)
		{
			return null;
		}

		[Address(RVA="0x15AF33C", Offset="0x15AF33C", VA="0x15AF33C")]
		public FromBinderNonGeneric To(Action<ConventionSelectTypesBinder> generator)
		{
			return null;
		}

		[Address(RVA="0x15AF0FC", Offset="0x15AF0FC", VA="0x15AF0FC")]
		public FromBinderNonGeneric ToSelf()
		{
			return null;
		}
	}
}