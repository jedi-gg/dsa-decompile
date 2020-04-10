using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class ArgNonLazyBinder : NonLazyBinder
	{
		[Address(RVA="0x15AB7A0", Offset="0x15AB7A0", VA="0x15AB7A0")]
		public ArgNonLazyBinder(Zenject.BindInfo bindInfo)
		{
		}

		[Address(RVA="0x2AF73EC", Offset="0x2AF73EC", VA="0x2AF73EC")]
		public ArgNonLazyBinder WithArguments<T>(T param)
		{
			return null;
		}

		[Address(RVA="0x2AF7368", Offset="0x2AF7368", VA="0x2AF7368")]
		public ArgNonLazyBinder WithArguments<TParam1, TParam2>(TParam1 param1, TParam2 param2)
		{
			return null;
		}

		[Address(RVA="0x2AF72D4", Offset="0x2AF72D4", VA="0x2AF72D4")]
		public ArgNonLazyBinder WithArguments<TParam1, TParam2, TParam3>(TParam1 param1, TParam2 param2, TParam3 param3)
		{
			return null;
		}

		[Address(RVA="0x2AF7238", Offset="0x2AF7238", VA="0x2AF7238")]
		public ArgNonLazyBinder WithArguments<TParam1, TParam2, TParam3, TParam4>(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
		{
			return null;
		}

		[Address(RVA="0x2AF718C", Offset="0x2AF718C", VA="0x2AF718C")]
		public ArgNonLazyBinder WithArguments<TParam1, TParam2, TParam3, TParam4, TParam5>(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5)
		{
			return null;
		}

		[Address(RVA="0x2AF70D8", Offset="0x2AF70D8", VA="0x2AF70D8")]
		public ArgNonLazyBinder WithArguments<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6)
		{
			return null;
		}

		[Address(RVA="0x15AB7A8", Offset="0x15AB7A8", VA="0x15AB7A8")]
		public ArgNonLazyBinder WithArguments(object[] args)
		{
			return null;
		}

		[Address(RVA="0x15AB800", Offset="0x15AB800", VA="0x15AB800")]
		public ArgNonLazyBinder WithArgumentsExplicit(IEnumerable<TypeValuePair> extraArgs)
		{
			return null;
		}
	}
}