using Il2CppDummyDll;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Cinemachine.Utility
{
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104ACAC", Offset="0x104ACAC")]
	public static class ReflectionHelpers
	{
		[Address(RVA="0x16A7E04", Offset="0x16A7E04", VA="0x16A7E04")]
		public static T AccessInternalField<T>(Type type, object obj, string memberName)
		{
			return null;
		}

		[Address(RVA="0x145C7A4", Offset="0x145C7A4", VA="0x145C7A4")]
		public static void CopyFields(object src, object dst, BindingFlags bindingAttr = 52)
		{
		}

		[Address(RVA="0x1999A98", Offset="0x1999A98", VA="0x1999A98")]
		public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr)
		{
			return null;
		}

		[Address(RVA="0x1462650", Offset="0x1462650", VA="0x1462650")]
		public static object GetParentObject(string path, object obj)
		{
			return null;
		}
	}
}