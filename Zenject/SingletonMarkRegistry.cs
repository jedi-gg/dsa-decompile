using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SingletonMarkRegistry
	{
		[FieldOffset(Offset="0x10")]
		private readonly Dictionary<SingletonId, SingletonTypes> _singletonTypes;

		[Address(RVA="0x2333370", Offset="0x2333370", VA="0x2333370")]
		public SingletonMarkRegistry()
		{
		}

		[Address(RVA="0x2333158", Offset="0x2333158", VA="0x2333158")]
		public void MarkSingleton(Type type, object concreteIdentifier, SingletonTypes singletonType)
		{
		}

		[Address(RVA="0x23331E0", Offset="0x23331E0", VA="0x23331E0")]
		public void MarkSingleton(SingletonId id, SingletonTypes type)
		{
		}

		[Address(RVA="0x17E097C", Offset="0x17E097C", VA="0x17E097C")]
		public SingletonTypes? TryGetSingletonType<T>()
		{
			return null;
		}

		[Address(RVA="0x2333024", Offset="0x2333024", VA="0x2333024")]
		public SingletonTypes? TryGetSingletonType(Type type)
		{
			return null;
		}

		[Address(RVA="0x233302C", Offset="0x233302C", VA="0x233302C")]
		public SingletonTypes? TryGetSingletonType(Type type, object concreteIdentifier)
		{
			return null;
		}

		[Address(RVA="0x23330A4", Offset="0x23330A4", VA="0x23330A4")]
		public SingletonTypes? TryGetSingletonType(SingletonId id)
		{
			return null;
		}
	}
}