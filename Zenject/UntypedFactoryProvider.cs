using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace Zenject
{
	public class UntypedFactoryProvider : IProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly List<TypeValuePair> _factoryArgs;

		[FieldOffset(Offset="0x18")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x20")]
		private readonly Type _factoryType;

		[FieldOffset(Offset="0x28")]
		private readonly Type _concreteType;

		[FieldOffset(Offset="0x30")]
		private readonly MethodInfo _createMethod;

		[Address(RVA="0x233F7C8", Offset="0x233F7C8", VA="0x233F7C8")]
		public UntypedFactoryProvider(Type factoryType, DiContainer container, List<TypeValuePair> factoryArgs)
		{
		}

		[Address(RVA="0x233FACC", Offset="0x233FACC", VA="0x233FACC", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073D08", Offset="0x1073D08")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x233FAC4", Offset="0x233FAC4", VA="0x233FAC4", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x233F998", Offset="0x233F998", VA="0x233F998")]
		private Type LookupConcreteType(Type factoryType)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E0B8", Offset="0x104E0B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static UntypedFactoryProvider.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<MethodInfo, bool> <>9__5_0;

			[FieldOffset(Offset="0x10")]
			public static Func<Type, bool> <>9__6_0;

			[FieldOffset(Offset="0x18")]
			public static Func<TypeValuePair, object> <>9__8_0;

			[Address(RVA="0x233FB90", Offset="0x233FB90", VA="0x233FB90")]
			static <>c()
			{
			}

			[Address(RVA="0x233FBF4", Offset="0x233FBF4", VA="0x233FBF4")]
			public <>c()
			{
			}

			[Address(RVA="0x233FBFC", Offset="0x233FBFC", VA="0x233FBFC")]
			internal bool <.ctor>b__5_0(MethodInfo x)
			{
				return new bool();
			}

			[Address(RVA="0x233FD10", Offset="0x233FD10", VA="0x233FD10")]
			internal object <GetAllInstancesWithInjectSplit>b__8_0(TypeValuePair x)
			{
				return null;
			}

			[Address(RVA="0x233FC68", Offset="0x233FC68", VA="0x233FC68")]
			internal bool <LookupConcreteType>b__6_0(Type x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E0C8", Offset="0x104E0C8")]
		private sealed class <GetAllInstancesWithInjectSplit>d__8 : IEnumerator<List<object>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private List<object> <>2__current;

			[FieldOffset(Offset="0x20")]
			public UntypedFactoryProvider <>4__this;

			[FieldOffset(Offset="0x28")]
			public List<TypeValuePair> args;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x234019C", Offset="0x234019C", VA="0x234019C", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x234020C", Offset="0x234020C", VA="0x234020C", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x233FB64", Offset="0x233FB64", VA="0x233FB64")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__8(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x233FD40", Offset="0x233FD40", VA="0x233FD40", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x23401A4", Offset="0x23401A4", VA="0x23401A4", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x233FD3C", Offset="0x233FD3C", VA="0x233FD3C", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}