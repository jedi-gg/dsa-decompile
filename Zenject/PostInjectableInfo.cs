using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Zenject
{
	public class PostInjectableInfo
	{
		[FieldOffset(Offset="0x10")]
		private readonly System.Reflection.MethodInfo _methodInfo;

		[FieldOffset(Offset="0x18")]
		private readonly List<Zenject.InjectableInfo> _injectableInfo;

		public IEnumerable<Zenject.InjectableInfo> InjectableInfo
		{
			[Address(RVA="0x183E298", Offset="0x183E298", VA="0x183E298")]
			get
			{
				return null;
			}
		}

		public System.Reflection.MethodInfo MethodInfo
		{
			[Address(RVA="0x183E290", Offset="0x183E290", VA="0x183E290")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x183E258", Offset="0x183E258", VA="0x183E258")]
		public PostInjectableInfo(System.Reflection.MethodInfo methodInfo, List<Zenject.InjectableInfo> injectableInfo)
		{
		}
	}
}