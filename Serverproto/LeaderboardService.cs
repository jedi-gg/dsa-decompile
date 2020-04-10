using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public class LeaderboardService : ALeaderboardService
	{
		[Attribute(Name="InjectAttribute", RVA="0x1063B5C", Offset="0x1063B5C")]
		[FieldOffset(Offset="0x50")]
		private IPlayerAuthenticator _playerAuthenticator;

		[Attribute(Name="InjectAttribute", RVA="0x1063B6C", Offset="0x1063B6C")]
		[FieldOffset(Offset="0x58")]
		private GamedataManager _gamedataManager;

		[Address(RVA="0x1A17FA8", Offset="0x1A17FA8", VA="0x1A17FA8")]
		public LeaderboardService()
		{
		}
	}
}