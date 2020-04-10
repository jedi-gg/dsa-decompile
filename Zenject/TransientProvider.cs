using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class TransientProvider : IProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x18")]
		private readonly Type _concreteType;

		[FieldOffset(Offset="0x20")]
		private readonly object _concreteIdentifier;

		[FieldOffset(Offset="0x28")]
		private readonly List<TypeValuePair> _extraArguments;

		[Address(RVA="0x233C618", Offset="0x233C618", VA="0x233C618")]
		public TransientProvider(Type concreteType, DiContainer container, List<TypeValuePair> extraArguments, object concreteIdentifier, string bindingContext)
		{
		}

		[Address(RVA="0x233C760", Offset="0x233C760", VA="0x233C760")]
		public TransientProvider(Type concreteType, DiContainer container, List<TypeValuePair> extraArguments)
		{
		}

		[Address(RVA="0x233C76C", Offset="0x233C76C", VA="0x233C76C")]
		public TransientProvider(Type concreteType, DiContainer container)
		{
		}

		[Address(RVA="0x233C800", Offset="0x233C800", VA="0x233C800", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073CA4", Offset="0x1073CA4")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x233C7F8", Offset="0x233C7F8", VA="0x233C7F8", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x233C8D8", Offset="0x233C8D8", VA="0x233C8D8")]
		private Type GetTypeToCreate(Type contractType)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E0A8", Offset="0x104E0A8")]
		private sealed class <GetAllInstancesWithInjectSplit>d__8 : IEnumerator<List<object>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private List<object> <>2__current;

			[FieldOffset(Offset="0x20")]
			public InjectContext context;

			[FieldOffset(Offset="0x28")]
			public TransientProvider <>4__this;

			[FieldOffset(Offset="0x30")]
			public List<TypeValuePair> args;

			[FieldOffset(Offset="0x38")]
			private Type <instanceType>5__2;

			[FieldOffset(Offset="0x40")]
			private InjectArgs <injectArgs>5__3;

			[FieldOffset(Offset="0x48")]
			private object <instance>5__4;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x233CB1C", Offset="0x233CB1C", VA="0x233CB1C", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x233CB8C", Offset="0x233CB8C", VA="0x233CB8C", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x233C8AC", Offset="0x233C8AC", VA="0x233C8AC")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__8(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x233C8F0", Offset="0x233C8F0", VA="0x233C8F0", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x233CB24", Offset="0x233CB24", VA="0x233CB24", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x233C8EC", Offset="0x233C8EC", VA="0x233C8EC", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}