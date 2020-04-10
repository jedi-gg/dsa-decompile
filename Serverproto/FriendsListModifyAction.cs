using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum FriendsListModifyAction
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062CFC", Offset="0x1062CFC")]
		[FieldOffset(Offset="0x0")]
		FriendsListActionInvalid,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062D34", Offset="0x1062D34")]
		[FieldOffset(Offset="0x0")]
		FriendsListAdd,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062D6C", Offset="0x1062D6C")]
		[FieldOffset(Offset="0x0")]
		FriendsListAddByToken,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062DA4", Offset="0x1062DA4")]
		[FieldOffset(Offset="0x0")]
		FriendsListDelete,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062DDC", Offset="0x1062DDC")]
		[FieldOffset(Offset="0x0")]
		FriendsListAcceptFriendRequest,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062E14", Offset="0x1062E14")]
		[FieldOffset(Offset="0x0")]
		FriendsListRejectFriendRequest,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062E4C", Offset="0x1062E4C")]
		[FieldOffset(Offset="0x0")]
		FriendsListCancelFriendRequest
	}
}