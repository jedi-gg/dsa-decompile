using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Zenject
{
	public class ScriptableObjectResourceProvider : IProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x18")]
		private readonly Type _resourceType;

		[FieldOffset(Offset="0x20")]
		private readonly string _resourcePath;

		[FieldOffset(Offset="0x28")]
		private readonly List<TypeValuePair> _extraArguments;

		[FieldOffset(Offset="0x30")]
		private readonly object _concreteIdentifier;

		[FieldOffset(Offset="0x38")]
		private readonly bool _createNew;

		[Address(RVA="0x18364B8", Offset="0x18364B8", VA="0x18364B8")]
		public ScriptableObjectResourceProvider(string resourcePath, Type resourceType, DiContainer container, object concreteIdentifier, List<TypeValuePair> extraArguments, bool createNew)
		{
		}

		[Address(RVA="0x1847FCC", Offset="0x1847FCC", VA="0x1847FCC", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073B5C", Offset="0x1073B5C")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x1847FC4", Offset="0x1847FC4", VA="0x1847FC4", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E008", Offset="0x104E008")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ScriptableObjectResourceProvider.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<UnityEngine.Object, UnityEngine.Object> <>9__8_0;

			[Address(RVA="0x18480A4", Offset="0x18480A4", VA="0x18480A4")]
			static <>c()
			{
			}

			[Address(RVA="0x1848108", Offset="0x1848108", VA="0x1848108")]
			public <>c()
			{
			}

			[Address(RVA="0x1848110", Offset="0x1848110", VA="0x1848110")]
			internal UnityEngine.Object <GetAllInstancesWithInjectSplit>b__8_0(UnityEngine.Object x)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E018", Offset="0x104E018")]
		private sealed class <GetAllInstancesWithInjectSplit>d__8 : IEnumerator<List<object>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private List<object> <>2__current;

			[FieldOffset(Offset="0x20")]
			public InjectContext context;

			[FieldOffset(Offset="0x28")]
			public ScriptableObjectResourceProvider <>4__this;

			[FieldOffset(Offset="0x30")]
			public List<TypeValuePair> args;

			[FieldOffset(Offset="0x38")]
			private List<object> <objects>5__2;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x1848548", Offset="0x1848548", VA="0x1848548", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x18485B8", Offset="0x18485B8", VA="0x18485B8", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1848078", Offset="0x1848078", VA="0x1848078")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__8(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x184817C", Offset="0x184817C", VA="0x184817C", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1848550", Offset="0x1848550", VA="0x1848550", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1848178", Offset="0x1848178", VA="0x1848178", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}