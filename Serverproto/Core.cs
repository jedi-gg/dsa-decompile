using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public class Core : ACore
	{
		[Attribute(Name="InjectAttribute", RVA="0x1063B0C", Offset="0x1063B0C")]
		[FieldOffset(Offset="0x50")]
		private IPlayerAuthenticator _playerAuthenticator;

		[Attribute(Name="InjectAttribute", RVA="0x1063B1C", Offset="0x1063B1C")]
		[FieldOffset(Offset="0x58")]
		private GamedataManager _gamedataManager;

		[Attribute(Name="InjectAttribute", RVA="0x1063B2C", Offset="0x1063B2C")]
		[FieldOffset(Offset="0x60")]
		private GraphicsSettings _graphicsSettings;

		[Address(RVA="0x1EF2FD4", Offset="0x1EF2FD4", VA="0x1EF2FD4")]
		public Core()
		{
		}

		[Address(RVA="0x1EF2E9C", Offset="0x1EF2E9C", VA="0x1EF2E9C", Slot="5")]
		protected override void AuthServiceSuccess(AuthResponse response)
		{
		}

		[Address(RVA="0x1EF2F48", Offset="0x1EF2F48", VA="0x1EF2F48", Slot="6")]
		protected override void MetaServiceSuccess(MetadataResponse response)
		{
		}
	}
}