using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ModestTree
{
	public static class TypeExtensions
	{
		[Address(RVA="0x1356368", Offset="0x1356368", VA="0x1356368")]
		public static IEnumerable<T> AllAttributes<T>(MemberInfo provider)
		where T : Attribute
		{
			return null;
		}

		[Address(RVA="0x12F72E0", Offset="0x12F72E0", VA="0x12F72E0")]
		public static IEnumerable<Attribute> AllAttributes(MemberInfo provider, params Type[] attributeTypes)
		{
			return null;
		}

		[Address(RVA="0x135647C", Offset="0x135647C", VA="0x135647C")]
		public static IEnumerable<T> AllAttributes<T>(ParameterInfo provider)
		where T : Attribute
		{
			return null;
		}

		[Address(RVA="0x12F746C", Offset="0x12F746C", VA="0x12F746C")]
		public static IEnumerable<Attribute> AllAttributes(ParameterInfo provider, params Type[] attributeTypes)
		{
			return null;
		}

		[Address(RVA="0x12F6744", Offset="0x12F6744", VA="0x12F6744")]
		public static Type BaseType(Type type)
		{
			return null;
		}

		[Address(RVA="0x12F68F8", Offset="0x12F68F8", VA="0x12F68F8")]
		public static ConstructorInfo[] Constructors(Type type)
		{
			return null;
		}

		[Address(RVA="0x12F670C", Offset="0x12F670C", VA="0x12F670C")]
		public static FieldInfo[] DeclaredInstanceFields(Type type)
		{
			return null;
		}

		[Address(RVA="0x12F669C", Offset="0x12F669C", VA="0x12F669C")]
		public static MethodInfo[] DeclaredInstanceMethods(Type type)
		{
			return null;
		}

		[Address(RVA="0x12F66D4", Offset="0x12F66D4", VA="0x12F66D4")]
		public static PropertyInfo[] DeclaredInstanceProperties(Type type)
		{
			return null;
		}

		[Address(RVA="0x1F6520C", Offset="0x1F6520C", VA="0x1F6520C")]
		public static bool DerivesFrom<T>(Type a)
		{
			return new bool();
		}

		[Address(RVA="0x12F485C", Offset="0x12F485C", VA="0x12F485C")]
		public static bool DerivesFrom(Type a, Type b)
		{
			return new bool();
		}

		[Address(RVA="0x1F65298", Offset="0x1F65298", VA="0x1F65298")]
		public static bool DerivesFromOrEqual<T>(Type a)
		{
			return new bool();
		}

		[Address(RVA="0x12F4AB0", Offset="0x12F4AB0", VA="0x12F4AB0")]
		public static bool DerivesFromOrEqual(Type a, Type b)
		{
			return new bool();
		}

		[Address(RVA="0x12F6890", Offset="0x12F6890", VA="0x12F6890")]
		public static Type[] GenericArguments(Type type)
		{
			return null;
		}

		[Address(RVA="0x12F6C68", Offset="0x12F6C68", VA="0x12F6C68")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1071B7C", Offset="0x1071B7C")]
		public static IEnumerable<FieldInfo> GetAllInstanceFields(Type type)
		{
			return null;
		}

		[Address(RVA="0x12F6DE0", Offset="0x12F6DE0", VA="0x12F6DE0")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1071C64", Offset="0x1071C64")]
		public static IEnumerable<MethodInfo> GetAllInstanceMethods(Type type)
		{
			return null;
		}

		[Address(RVA="0x12F6D24", Offset="0x12F6D24", VA="0x12F6D24")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1071BF0", Offset="0x1071BF0")]
		public static IEnumerable<PropertyInfo> GetAllInstanceProperties(Type type)
		{
			return null;
		}

		[Address(RVA="0x16ABCC0", Offset="0x16ABCC0", VA="0x16ABCC0")]
		public static T GetAttribute<T>(MemberInfo provider)
		where T : Attribute
		{
			return null;
		}

		[Address(RVA="0x12F700C", Offset="0x12F700C", VA="0x12F700C")]
		private static string GetCSharpTypeName(string typeName)
		{
			return null;
		}

		[Address(RVA="0x12F6930", Offset="0x12F6930", VA="0x12F6930")]
		public static object GetDefaultValue(Type type)
		{
			return null;
		}

		[Address(RVA="0x12F6A34", Offset="0x12F6A34", VA="0x12F6A34")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1071AE8", Offset="0x1071AE8")]
		public static IEnumerable<Type> GetParentTypes(Type type)
		{
			return null;
		}

		[Address(RVA="0x12F697C", Offset="0x12F697C", VA="0x12F697C")]
		public static string GetSimpleName(Type type)
		{
			return null;
		}

		[Address(RVA="0x12F727C", Offset="0x12F727C", VA="0x12F727C")]
		public static bool HasAttribute(MemberInfo provider, params Type[] attributeTypes)
		{
			return new bool();
		}

		[Address(RVA="0x1F65324", Offset="0x1F65324", VA="0x1F65324")]
		public static bool HasAttribute<T>(MemberInfo provider)
		where T : Attribute
		{
			return new bool();
		}

		[Address(RVA="0x12F7408", Offset="0x12F7408", VA="0x12F7408")]
		public static bool HasAttribute(ParameterInfo provider, params Type[] attributeTypes)
		{
			return new bool();
		}

		[Address(RVA="0x1F65438", Offset="0x1F65438", VA="0x1F65438")]
		public static bool HasAttribute<T>(ParameterInfo provider)
		where T : Attribute
		{
			return new bool();
		}

		[Address(RVA="0x12F68C4", Offset="0x12F68C4", VA="0x12F68C4")]
		public static Type[] Interfaces(Type type)
		{
			return null;
		}

		[Address(RVA="0x12F6838", Offset="0x12F6838", VA="0x12F6838")]
		public static bool IsAbstract(Type type)
		{
			return new bool();
		}

		[Address(RVA="0x12F6434", Offset="0x12F6434", VA="0x12F6434")]
		public static bool IsAssignableToGenericType(Type givenType, Type genericType)
		{
			return new bool();
		}

		[Address(RVA="0x12F6AF0", Offset="0x12F6AF0", VA="0x12F6AF0")]
		public static bool IsClosedGenericType(Type type)
		{
			return new bool();
		}

		[Address(RVA="0x12F663C", Offset="0x12F663C", VA="0x12F663C")]
		public static bool IsEnum(Type type)
		{
			return new bool();
		}

		[Address(RVA="0x12F6778", Offset="0x12F6778", VA="0x12F6778")]
		public static bool IsGenericType(Type type)
		{
			return new bool();
		}

		[Address(RVA="0x12F67AC", Offset="0x12F67AC", VA="0x12F67AC")]
		public static bool IsGenericTypeDefinition(Type type)
		{
			return new bool();
		}

		[Address(RVA="0x12F680C", Offset="0x12F680C", VA="0x12F680C")]
		public static bool IsInterface(Type type)
		{
			return new bool();
		}

		[Address(RVA="0x12F6BAC", Offset="0x12F6BAC", VA="0x12F6BAC")]
		public static bool IsOpenGenericType(Type type)
		{
			return new bool();
		}

		[Address(RVA="0x12F67E0", Offset="0x12F67E0", VA="0x12F67E0")]
		public static bool IsPrimitive(Type type)
		{
			return new bool();
		}

		[Address(RVA="0x12F6670", Offset="0x12F6670", VA="0x12F6670")]
		public static bool IsValueType(Type type)
		{
			return new bool();
		}

		[Address(RVA="0x12F6864", Offset="0x12F6864", VA="0x12F6864")]
		public static MethodInfo Method(Delegate del)
		{
			return null;
		}

		[Address(RVA="0x12F6E9C", Offset="0x12F6E9C", VA="0x12F6E9C")]
		public static string Name(Type type)
		{
			return null;
		}

		[Address(RVA="0x16ABCF8", Offset="0x16ABCF8", VA="0x16ABCF8")]
		public static T TryGetAttribute<T>(MemberInfo provider)
		where T : Attribute
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D378", Offset="0x104D378")]
		private sealed class <>c__DisplayClass35_0
		{
			[FieldOffset(Offset="0x10")]
			public Type[] attributeTypes;

			[Address(RVA="0x12F7400", Offset="0x12F7400", VA="0x12F7400")]
			public <>c__DisplayClass35_0()
			{
			}

			[Address(RVA="0x12F7594", Offset="0x12F7594", VA="0x12F7594")]
			internal bool <AllAttributes>b__0(Attribute a)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D388", Offset="0x104D388")]
		private sealed class <>c__DisplayClass35_1
		{
			[FieldOffset(Offset="0x10")]
			public Attribute a;

			[Address(RVA="0x12F7658", Offset="0x12F7658", VA="0x12F7658")]
			public <>c__DisplayClass35_1()
			{
			}

			[Address(RVA="0x12F7660", Offset="0x12F7660", VA="0x12F7660")]
			internal bool <AllAttributes>b__1(Type x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D398", Offset="0x104D398")]
		private sealed class <>c__DisplayClass39_0
		{
			[FieldOffset(Offset="0x10")]
			public Type[] attributeTypes;

			[Address(RVA="0x12F758C", Offset="0x12F758C", VA="0x12F758C")]
			public <>c__DisplayClass39_0()
			{
			}

			[Address(RVA="0x12F769C", Offset="0x12F769C", VA="0x12F769C")]
			internal bool <AllAttributes>b__0(Attribute a)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D3A8", Offset="0x104D3A8")]
		private sealed class <>c__DisplayClass39_1
		{
			[FieldOffset(Offset="0x10")]
			public Attribute a;

			[Address(RVA="0x12F7760", Offset="0x12F7760", VA="0x12F7760")]
			public <>c__DisplayClass39_1()
			{
			}

			[Address(RVA="0x12F7768", Offset="0x12F7768", VA="0x12F7768")]
			internal bool <AllAttributes>b__1(Type x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D348", Offset="0x104D348")]
		private sealed class <GetAllInstanceFields>d__25 : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private FieldInfo <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			private Type type;

			[FieldOffset(Offset="0x30")]
			public Type <>3__type;

			[FieldOffset(Offset="0x38")]
			private FieldInfo[] <>7__wrap1;

			[FieldOffset(Offset="0x40")]
			private int <>7__wrap2;

			[FieldOffset(Offset="0x48")]
			private IEnumerator<FieldInfo> <>7__wrap3;

			private FieldInfo System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo>.Current
			{
				[Address(RVA="0x12F7CE0", Offset="0x12F7CE0", VA="0x12F7CE0", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x12F7D50", Offset="0x12F7D50", VA="0x12F7D50", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x12F6CEC", Offset="0x12F6CEC", VA="0x12F6CEC")]
			[DebuggerHidden]
			public <GetAllInstanceFields>d__25(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x12F77C0", Offset="0x12F77C0", VA="0x12F77C0")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x12F7880", Offset="0x12F7880", VA="0x12F7880", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x12F7D58", Offset="0x12F7D58", VA="0x12F7D58", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<FieldInfo> System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12F7E08", Offset="0x12F7E08", VA="0x12F7E08", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12F7CE8", Offset="0x12F7CE8", VA="0x12F7CE8", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x12F77A4", Offset="0x12F77A4", VA="0x12F77A4", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D368", Offset="0x104D368")]
		private sealed class <GetAllInstanceMethods>d__27 : IEnumerable<MethodInfo>, IEnumerable, IEnumerator<MethodInfo>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private MethodInfo <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			private Type type;

			[FieldOffset(Offset="0x30")]
			public Type <>3__type;

			[FieldOffset(Offset="0x38")]
			private MethodInfo[] <>7__wrap1;

			[FieldOffset(Offset="0x40")]
			private int <>7__wrap2;

			[FieldOffset(Offset="0x48")]
			private IEnumerator<MethodInfo> <>7__wrap3;

			private MethodInfo System.Collections.Generic.IEnumerator<System.Reflection.MethodInfo>.Current
			{
				[Address(RVA="0x12F8348", Offset="0x12F8348", VA="0x12F8348", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x12F83B8", Offset="0x12F83B8", VA="0x12F83B8", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x12F6E64", Offset="0x12F6E64", VA="0x12F6E64")]
			[DebuggerHidden]
			public <GetAllInstanceMethods>d__27(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x12F7E28", Offset="0x12F7E28", VA="0x12F7E28")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x12F7EE8", Offset="0x12F7EE8", VA="0x12F7EE8", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x12F83C0", Offset="0x12F83C0", VA="0x12F83C0", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<MethodInfo> System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12F8470", Offset="0x12F8470", VA="0x12F8470", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12F8350", Offset="0x12F8350", VA="0x12F8350", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x12F7E0C", Offset="0x12F7E0C", VA="0x12F7E0C", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D358", Offset="0x104D358")]
		private sealed class <GetAllInstanceProperties>d__26 : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private PropertyInfo <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			private Type type;

			[FieldOffset(Offset="0x30")]
			public Type <>3__type;

			[FieldOffset(Offset="0x38")]
			private PropertyInfo[] <>7__wrap1;

			[FieldOffset(Offset="0x40")]
			private int <>7__wrap2;

			[FieldOffset(Offset="0x48")]
			private IEnumerator<PropertyInfo> <>7__wrap3;

			private PropertyInfo System.Collections.Generic.IEnumerator<System.Reflection.PropertyInfo>.Current
			{
				[Address(RVA="0x12F89B0", Offset="0x12F89B0", VA="0x12F89B0", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x12F8A20", Offset="0x12F8A20", VA="0x12F8A20", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x12F6DA8", Offset="0x12F6DA8", VA="0x12F6DA8")]
			[DebuggerHidden]
			public <GetAllInstanceProperties>d__26(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x12F8490", Offset="0x12F8490", VA="0x12F8490")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x12F8550", Offset="0x12F8550", VA="0x12F8550", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x12F8A28", Offset="0x12F8A28", VA="0x12F8A28", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<PropertyInfo> System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12F8AD8", Offset="0x12F8AD8", VA="0x12F8AD8", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12F89B8", Offset="0x12F89B8", VA="0x12F89B8", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x12F8474", Offset="0x12F8474", VA="0x12F8474", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D338", Offset="0x104D338")]
		private sealed class <GetParentTypes>d__22 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private Type <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			private Type type;

			[FieldOffset(Offset="0x30")]
			public Type <>3__type;

			[FieldOffset(Offset="0x38")]
			private IEnumerator<Type> <>7__wrap1;

			private Type System.Collections.Generic.IEnumerator<System.Type>.Current
			{
				[Address(RVA="0x12F8FFC", Offset="0x12F8FFC", VA="0x12F8FFC", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x12F906C", Offset="0x12F906C", VA="0x12F906C", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x12F6AB8", Offset="0x12F6AB8", VA="0x12F6AB8")]
			[DebuggerHidden]
			public <GetParentTypes>d__22(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x12F8AF8", Offset="0x12F8AF8", VA="0x12F8AF8")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x12F8BB8", Offset="0x12F8BB8", VA="0x12F8BB8", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x12F9074", Offset="0x12F9074", VA="0x12F9074", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12F9124", Offset="0x12F9124", VA="0x12F9124", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12F9004", Offset="0x12F9004", VA="0x12F9004", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x12F8ADC", Offset="0x12F8ADC", VA="0x12F8ADC", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}