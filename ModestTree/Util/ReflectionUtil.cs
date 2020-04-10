using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ModestTree.Util
{
	public static class ReflectionUtil
	{
		[Address(RVA="0x12F9794", Offset="0x12F9794", VA="0x12F9794")]
		public static IDictionary CreateGenericDictionary(Type keyType, Type valueType, object[] keysAsObj, object[] valuesAsObj)
		{
			return null;
		}

		[Address(RVA="0x12F9318", Offset="0x12F9318", VA="0x12F9318")]
		public static IList CreateGenericList(Type elementType, object[] contentsAsObj)
		{
			return null;
		}

		[Address(RVA="0x17E0A18", Offset="0x17E0A18", VA="0x17E0A18")]
		public static object DowncastList<TFrom, TTo>(IEnumerable<TFrom> fromList)
		where TTo : class, TFrom
		{
			return null;
		}

		[Address(RVA="0x135563C", Offset="0x135563C", VA="0x135563C")]
		public static IEnumerable<ReflectionUtil.IMemberInfo> GetFieldsAndProperties<T>(BindingFlags flags)
		{
			return null;
		}

		[Address(RVA="0x12F9AB4", Offset="0x12F9AB4", VA="0x12F9AB4")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1071D88", Offset="0x1071D88")]
		public static IEnumerable<ReflectionUtil.IMemberInfo> GetFieldsAndProperties(Type type, BindingFlags flags)
		{
			return null;
		}

		[Address(RVA="0x12F9130", Offset="0x12F9130", VA="0x12F9130")]
		public static bool IsGenericList(Type type)
		{
			return new bool();
		}

		[Address(RVA="0x12F9278", Offset="0x12F9278", VA="0x12F9278")]
		public static bool IsGenericList(Type type, out Type contentsType)
		{
			contentsType = null;
			return new bool();
		}

		[Address(RVA="0x12F9B94", Offset="0x12F9B94", VA="0x12F9B94")]
		public static string ToDebugString(MethodInfo method)
		{
			return null;
		}

		[Address(RVA="0x12F9CE0", Offset="0x12F9CE0", VA="0x12F9CE0")]
		public static string ToDebugString(Action action)
		{
			return null;
		}

		[Address(RVA="0x199A310", Offset="0x199A310", VA="0x199A310")]
		public static string ToDebugString<TParam1>(Action<TParam1> action)
		{
			return null;
		}

		[Address(RVA="0x199A2A8", Offset="0x199A2A8", VA="0x199A2A8")]
		public static string ToDebugString<TParam1, TParam2>(Action<TParam1, TParam2> action)
		{
			return null;
		}

		[Address(RVA="0x199A240", Offset="0x199A240", VA="0x199A240")]
		public static string ToDebugString<TParam1, TParam2, TParam3>(Action<TParam1, TParam2, TParam3> action)
		{
			return null;
		}

		[Address(RVA="0x199A1D8", Offset="0x199A1D8", VA="0x199A1D8")]
		public static string ToDebugString<TParam1, TParam2, TParam3, TParam4>(Action<TParam1, TParam2, TParam3, TParam4> action)
		{
			return null;
		}

		[Address(RVA="0x199A1A4", Offset="0x199A1A4", VA="0x199A1A4")]
		public static string ToDebugString<TParam1, TParam2, TParam3, TParam4, TParam5>(ModestTree.Util.Action<TParam1, TParam2, TParam3, TParam4, TParam5> action)
		{
			return null;
		}

		[Address(RVA="0x199A170", Offset="0x199A170", VA="0x199A170")]
		public static string ToDebugString<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>(ModestTree.Util.Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6> action)
		{
			return null;
		}

		[Address(RVA="0x199A344", Offset="0x199A344", VA="0x199A344")]
		public static string ToDebugString<TParam1>(Func<TParam1> func)
		{
			return null;
		}

		[Address(RVA="0x199A2DC", Offset="0x199A2DC", VA="0x199A2DC")]
		public static string ToDebugString<TParam1, TParam2>(Func<TParam1, TParam2> func)
		{
			return null;
		}

		[Address(RVA="0x199A274", Offset="0x199A274", VA="0x199A274")]
		public static string ToDebugString<TParam1, TParam2, TParam3>(Func<TParam1, TParam2, TParam3> func)
		{
			return null;
		}

		[Address(RVA="0x199A20C", Offset="0x199A20C", VA="0x199A20C")]
		public static string ToDebugString<TParam1, TParam2, TParam3, TParam4>(Func<TParam1, TParam2, TParam3, TParam4> func)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D3B8", Offset="0x104D3B8")]
		private sealed class <GetFieldsAndProperties>d__6 : IEnumerable<ReflectionUtil.IMemberInfo>, IEnumerable, IEnumerator<ReflectionUtil.IMemberInfo>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private ReflectionUtil.IMemberInfo <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			private Type type;

			[FieldOffset(Offset="0x30")]
			public Type <>3__type;

			[FieldOffset(Offset="0x38")]
			private BindingFlags flags;

			[FieldOffset(Offset="0x3C")]
			public BindingFlags <>3__flags;

			[FieldOffset(Offset="0x40")]
			private PropertyInfo[] <>7__wrap1;

			[FieldOffset(Offset="0x48")]
			private int <>7__wrap2;

			[FieldOffset(Offset="0x50")]
			private FieldInfo[] <>7__wrap3;

			private ReflectionUtil.IMemberInfo System.Collections.Generic.IEnumerator<ModestTree.Util.ReflectionUtil.IMemberInfo>.Current
			{
				[Address(RVA="0x12F9FC8", Offset="0x12F9FC8", VA="0x12F9FC8", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x12FA038", Offset="0x12FA038", VA="0x12FA038", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x12F9B5C", Offset="0x12F9B5C", VA="0x12F9B5C")]
			[DebuggerHidden]
			public <GetFieldsAndProperties>d__6(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x12F9D14", Offset="0x12F9D14", VA="0x12F9D14", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x12FA040", Offset="0x12FA040", VA="0x12FA040", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<ReflectionUtil.IMemberInfo> System.Collections.Generic.IEnumerable<ModestTree.Util.ReflectionUtil.IMemberInfo>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12FA110", Offset="0x12FA110", VA="0x12FA110", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12F9FD0", Offset="0x12F9FD0", VA="0x12F9FD0", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x12F9D10", Offset="0x12F9D10", VA="0x12F9D10", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		public class FieldMemberInfo : ReflectionUtil.IMemberInfo
		{
			[FieldOffset(Offset="0x10")]
			private FieldInfo _fieldInfo;

			public string MemberName
			{
				[Address(RVA="0x12FA14C", Offset="0x12FA14C", VA="0x12FA14C", Slot="5")]
				get
				{
					return null;
				}
			}

			public Type MemberType
			{
				[Address(RVA="0x12FA114", Offset="0x12FA114", VA="0x12FA114", Slot="4")]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x12F9F9C", Offset="0x12F9F9C", VA="0x12F9F9C")]
			public FieldMemberInfo(FieldInfo fieldInfo)
			{
			}

			[Address(RVA="0x12FA180", Offset="0x12FA180", VA="0x12FA180", Slot="6")]
			public object GetValue(object instance)
			{
				return null;
			}

			[Address(RVA="0x12FA1C0", Offset="0x12FA1C0", VA="0x12FA1C0", Slot="7")]
			public void SetValue(object instance, object value)
			{
			}
		}

		public interface IMemberInfo
		{
			string MemberName
			{
				get;
			}

			Type MemberType
			{
				get;
			}

			object GetValue(object instance);

			void SetValue(object instance, object value);
		}

		public class PropertyMemberInfo : ReflectionUtil.IMemberInfo
		{
			[FieldOffset(Offset="0x10")]
			private PropertyInfo _propInfo;

			public string MemberName
			{
				[Address(RVA="0x12FA240", Offset="0x12FA240", VA="0x12FA240", Slot="5")]
				get
				{
					return null;
				}
			}

			public Type MemberType
			{
				[Address(RVA="0x12FA208", Offset="0x12FA208", VA="0x12FA208", Slot="4")]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x12F9F70", Offset="0x12F9F70", VA="0x12F9F70")]
			public PropertyMemberInfo(PropertyInfo propInfo)
			{
			}

			[Address(RVA="0x12FA274", Offset="0x12FA274", VA="0x12FA274", Slot="6")]
			public object GetValue(object instance)
			{
				return null;
			}

			[Address(RVA="0x12FA470", Offset="0x12FA470", VA="0x12FA470", Slot="7")]
			public void SetValue(object instance, object value)
			{
			}
		}
	}
}