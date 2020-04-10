using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Zenject
{
	public static class IProviderExtensions
	{
		[Address(RVA="0x1838B7C", Offset="0x1838B7C", VA="0x1838B7C")]
		public static List<object> GetAllInstances(IProvider creator, InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x1838BF8", Offset="0x1838BF8", VA="0x1838BF8")]
		public static List<object> GetAllInstances(IProvider creator, InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x1838A90", Offset="0x1838A90", VA="0x1838A90")]
		public static IEnumerator<List<object>> GetAllInstancesWithInjectSplit(IProvider creator, InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x183900C", Offset="0x183900C", VA="0x183900C")]
		public static object GetInstance(IProvider creator, InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x1839088", Offset="0x1839088", VA="0x1839088")]
		public static object GetInstance(IProvider creator, InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x1838E78", Offset="0x1838E78", VA="0x1838E78")]
		public static object TryGetInstance(IProvider creator, InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x1838EF4", Offset="0x1838EF4", VA="0x1838EF4")]
		public static object TryGetInstance(IProvider creator, InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}
	}
}