using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace Zenject
{
	public static class TypeAnalyzer
	{
		[FieldOffset(Offset="0x0")]
		private static Dictionary<Type, ZenjectTypeInfo> _typeInfo;

		[Address(RVA="0x233E464", Offset="0x233E464", VA="0x233E464")]
		static TypeAnalyzer()
		{
		}

		[Address(RVA="0x233DF94", Offset="0x233DF94", VA="0x233DF94")]
		private static InjectableInfo CreateForMember(MemberInfo memInfo, Type parentType)
		{
			return null;
		}

		[Address(RVA="0x233D840", Offset="0x233D840", VA="0x233D840")]
		private static InjectableInfo CreateInjectableInfoForParam(Type parentType, ParameterInfo paramInfo)
		{
			return null;
		}

		[Address(RVA="0x233CB94", Offset="0x233CB94", VA="0x233CB94")]
		private static ZenjectTypeInfo CreateTypeInfo(Type type)
		{
			return null;
		}

		[Address(RVA="0x233DAA8", Offset="0x233DAA8", VA="0x233DAA8")]
		private static IEnumerable<FieldInfo> GetAllFields(Type t, BindingFlags flags)
		{
			return null;
		}

		[Address(RVA="0x233D6A0", Offset="0x233D6A0", VA="0x233D6A0")]
		private static IEnumerable<InjectableInfo> GetConstructorInjectables(Type parentType, ConstructorInfo constructorInfo)
		{
			return null;
		}

		[Address(RVA="0x233D598", Offset="0x233D598", VA="0x233D598")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10740E0", Offset="0x10740E0")]
		private static IEnumerable<InjectableInfo> GetFieldInjectables(Type type)
		{
			return null;
		}

		[Address(RVA="0x2AFEF9C", Offset="0x2AFEF9C", VA="0x2AFEF9C")]
		public static ZenjectTypeInfo GetInfo<T>()
		{
			return null;
		}

		[Address(RVA="0x23364A4", Offset="0x23364A4", VA="0x23364A4")]
		public static ZenjectTypeInfo GetInfo(Type type)
		{
			return null;
		}

		[Address(RVA="0x233CC9C", Offset="0x233CC9C", VA="0x233CC9C")]
		private static ConstructorInfo GetInjectConstructor(Type parentType)
		{
			return null;
		}

		[Address(RVA="0x233DBE4", Offset="0x233DBE4", VA="0x233DBE4")]
		private static Action<object, object> GetOnlyPropertySetter(Type parentType, string propertyName)
		{
			return null;
		}

		[Address(RVA="0x233CF34", Offset="0x233CF34", VA="0x233CF34")]
		private static List<PostInjectableInfo> GetPostInjectMethods(Type type)
		{
			return null;
		}

		[Address(RVA="0x233D61C", Offset="0x233D61C", VA="0x233D61C")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x107407C", Offset="0x107407C")]
		private static IEnumerable<InjectableInfo> GetPropertyInjectables(Type type)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E1E8", Offset="0x104E1E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TypeAnalyzer.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<MethodInfo, bool> <>9__6_0;

			[FieldOffset(Offset="0x10")]
			public static Func<PropertyInfo, bool> <>9__7_0;

			[FieldOffset(Offset="0x18")]
			public static Func<FieldInfo, bool> <>9__8_0;

			[FieldOffset(Offset="0x20")]
			public static Func<FieldInfo, string> <>9__10_1;

			[FieldOffset(Offset="0x28")]
			public static Func<ConstructorInfo, bool> <>9__12_0;

			[FieldOffset(Offset="0x30")]
			public static Func<ConstructorInfo, bool> <>9__12_1;

			[Address(RVA="0x233E4D8", Offset="0x233E4D8", VA="0x233E4D8")]
			static <>c()
			{
			}

			[Address(RVA="0x233E53C", Offset="0x233E53C", VA="0x233E53C")]
			public <>c()
			{
			}

			[Address(RVA="0x233E6F4", Offset="0x233E6F4", VA="0x233E6F4")]
			internal bool <GetFieldInjectables>b__8_0(FieldInfo x)
			{
				return new bool();
			}

			[Address(RVA="0x233E82C", Offset="0x233E82C", VA="0x233E82C")]
			internal bool <GetInjectConstructor>b__12_0(ConstructorInfo c)
			{
				return new bool();
			}

			[Address(RVA="0x233E87C", Offset="0x233E87C", VA="0x233E87C")]
			internal bool <GetInjectConstructor>b__12_1(ConstructorInfo x)
			{
				return new bool();
			}

			[Address(RVA="0x233E7F8", Offset="0x233E7F8", VA="0x233E7F8")]
			internal string <GetOnlyPropertySetter>b__10_1(FieldInfo f)
			{
				return null;
			}

			[Address(RVA="0x233E544", Offset="0x233E544", VA="0x233E544")]
			internal bool <GetPostInjectMethods>b__6_0(MethodInfo x)
			{
				return new bool();
			}

			[Address(RVA="0x233E5F0", Offset="0x233E5F0", VA="0x233E5F0")]
			internal bool <GetPropertyInjectables>b__7_0(PropertyInfo x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E218", Offset="0x104E218")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset="0x10")]
			public string propertyName;

			[FieldOffset(Offset="0x18")]
			public List<FieldInfo> writeableFields;

			[Address(RVA="0x233DF14", Offset="0x233DF14", VA="0x233DF14")]
			public <>c__DisplayClass10_0()
			{
			}

			[Address(RVA="0x233E8B8", Offset="0x233E8B8", VA="0x233E8B8")]
			internal bool <GetOnlyPropertySetter>b__0(FieldInfo f)
			{
				return new bool();
			}

			[Address(RVA="0x233E94C", Offset="0x233E94C", VA="0x233E94C")]
			internal void <GetOnlyPropertySetter>b__2(object injectable, object value)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E228", Offset="0x104E228")]
		private sealed class <>c__DisplayClass10_1
		{
			[FieldOffset(Offset="0x10")]
			public object injectable;

			[FieldOffset(Offset="0x18")]
			public object @value;

			[Address(RVA="0x233EA38", Offset="0x233EA38", VA="0x233EA38")]
			public <>c__DisplayClass10_1()
			{
			}

			[Address(RVA="0x233EA40", Offset="0x233EA40", VA="0x233EA40")]
			internal void <GetOnlyPropertySetter>b__3(FieldInfo f)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E238", Offset="0x104E238")]
		private sealed class <>c__DisplayClass11_0
		{
			[FieldOffset(Offset="0x10")]
			public FieldInfo fieldInfo;

			[Address(RVA="0x233E454", Offset="0x233E454", VA="0x233E454")]
			public <>c__DisplayClass11_0()
			{
			}

			[Address(RVA="0x233EA84", Offset="0x233EA84", VA="0x233EA84")]
			internal void <CreateForMember>b__0(object injectable, object value)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E248", Offset="0x104E248")]
		private sealed class <>c__DisplayClass11_1
		{
			[FieldOffset(Offset="0x10")]
			public PropertyInfo propInfo;

			[Address(RVA="0x233E45C", Offset="0x233E45C", VA="0x233E45C")]
			public <>c__DisplayClass11_1()
			{
			}

			[Address(RVA="0x233EACC", Offset="0x233EACC", VA="0x233EACC")]
			internal void <CreateForMember>b__1(object injectable, object value)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E1C8", Offset="0x104E1C8")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x10")]
			public Type parentType;

			[Address(RVA="0x233D838", Offset="0x233D838", VA="0x233D838")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x233EB20", Offset="0x233EB20", VA="0x233EB20")]
			internal InjectableInfo <GetConstructorInjectables>b__0(ParameterInfo paramInfo)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E1D8", Offset="0x104E1D8")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public List<Type> heirarchyList;

			[FieldOffset(Offset="0x18")]
			public Type type;

			[FieldOffset(Offset="0x20")]
			public Func<ParameterInfo, InjectableInfo> <>9__2;

			[Address(RVA="0x233DA30", Offset="0x233DA30", VA="0x233DA30")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x233EB98", Offset="0x233EB98", VA="0x233EB98")]
			internal int <GetPostInjectMethods>b__1(MethodInfo x)
			{
				return new int();
			}

			[Address(RVA="0x233EC28", Offset="0x233EC28", VA="0x233EC28")]
			internal InjectableInfo <GetPostInjectMethods>b__2(ParameterInfo paramInfo)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E208", Offset="0x104E208")]
		private sealed class <GetFieldInjectables>d__8 : IEnumerable<InjectableInfo>, IEnumerable, IEnumerator<InjectableInfo>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private InjectableInfo <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			private Type type;

			[FieldOffset(Offset="0x30")]
			public Type <>3__type;

			[FieldOffset(Offset="0x38")]
			private IEnumerator<FieldInfo> <>7__wrap1;

			private InjectableInfo System.Collections.Generic.IEnumerator<Zenject.InjectableInfo>.Current
			{
				[Address(RVA="0x233F0EC", Offset="0x233F0EC", VA="0x233F0EC", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x233F15C", Offset="0x233F15C", VA="0x233F15C", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x233DA70", Offset="0x233DA70", VA="0x233DA70")]
			[DebuggerHidden]
			public <GetFieldInjectables>d__8(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x233ECBC", Offset="0x233ECBC", VA="0x233ECBC")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x233ED7C", Offset="0x233ED7C", VA="0x233ED7C", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x233F164", Offset="0x233F164", VA="0x233F164", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<InjectableInfo> System.Collections.Generic.IEnumerable<Zenject.InjectableInfo>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x233F214", Offset="0x233F214", VA="0x233F214", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x233F0F4", Offset="0x233F0F4", VA="0x233F0F4", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x233ECA0", Offset="0x233ECA0", VA="0x233ECA0", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E1F8", Offset="0x104E1F8")]
		private sealed class <GetPropertyInjectables>d__7 : IEnumerable<InjectableInfo>, IEnumerable, IEnumerator<InjectableInfo>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private InjectableInfo <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			private Type type;

			[FieldOffset(Offset="0x30")]
			public Type <>3__type;

			[FieldOffset(Offset="0x38")]
			private IEnumerator<PropertyInfo> <>7__wrap1;

			private InjectableInfo System.Collections.Generic.IEnumerator<Zenject.InjectableInfo>.Current
			{
				[Address(RVA="0x233F664", Offset="0x233F664", VA="0x233F664", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x233F6D4", Offset="0x233F6D4", VA="0x233F6D4", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x233DA38", Offset="0x233DA38", VA="0x233DA38")]
			[DebuggerHidden]
			public <GetPropertyInjectables>d__7(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x233F234", Offset="0x233F234", VA="0x233F234")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x233F2F4", Offset="0x233F2F4", VA="0x233F2F4", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x233F6DC", Offset="0x233F6DC", VA="0x233F6DC", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<InjectableInfo> System.Collections.Generic.IEnumerable<Zenject.InjectableInfo>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x233F78C", Offset="0x233F78C", VA="0x233F78C", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x233F66C", Offset="0x233F66C", VA="0x233F66C", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x233F218", Offset="0x233F218", VA="0x233F218", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}