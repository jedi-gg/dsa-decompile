using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class InjectableInfo
	{
		[FieldOffset(Offset="0x10")]
		public readonly bool Optional;

		[FieldOffset(Offset="0x18")]
		public readonly object Identifier;

		[FieldOffset(Offset="0x20")]
		public readonly InjectSources SourceType;

		[FieldOffset(Offset="0x28")]
		public readonly string MemberName;

		[FieldOffset(Offset="0x30")]
		public readonly Type MemberType;

		[FieldOffset(Offset="0x38")]
		public readonly Type ObjectType;

		[FieldOffset(Offset="0x40")]
		public readonly Action<object, object> Setter;

		[FieldOffset(Offset="0x48")]
		public readonly object DefaultValue;

		[Address(RVA="0x183B7D8", Offset="0x183B7D8", VA="0x183B7D8")]
		public InjectableInfo(bool optional, object identifier, string memberName, Type memberType, Type objectType, Action<object, object> setter, object defaultValue, InjectSources sourceType)
		{
		}

		[Address(RVA="0x183B858", Offset="0x183B858", VA="0x183B858")]
		public InjectContext CreateInjectContext(DiContainer container, InjectContext currentContext, object targetInstance, object concreteIdentifier)
		{
			return null;
		}
	}
}