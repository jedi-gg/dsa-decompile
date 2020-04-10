using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;

public class GamedataService : ADataCacheService, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x0")]
	private const string GAMEDATA_URL_FORMAT = "{0}/gamedata/{1}/gamedata-static.bin";

	[FieldOffset(Offset="0x0")]
	private const string CACHE_DIR = "gamedata";

	[FieldOffset(Offset="0x0")]
	private const string CACHE_FILE_NAME = "gamedata.bin";

	[Attribute(Name="InjectAttribute", RVA="0x10586F0", Offset="0x10586F0")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	public override LogCategory LogCategory
	{
		[Address(RVA="0x14EA37C", Offset="0x14EA37C", VA="0x14EA37C", Slot="5")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x14EA904", Offset="0x14EA904", VA="0x14EA904")]
	public GamedataService()
	{
	}

	[Address(RVA="0x14E9BCC", Offset="0x14E9BCC", VA="0x14E9BCC")]
	public void GetGamedata(string contentUrl, string version, Action<StaticGamedata> finished, Action error)
	{
	}

	[Address(RVA="0x14EA89C", Offset="0x14EA89C", VA="0x14EA89C")]
	private StaticGamedata TranslateData(byte[] data)
	{
		return new StaticGamedata();
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BFDC", Offset="0x104BFDC")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public GamedataService <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action<StaticGamedata> finished;

		[FieldOffset(Offset="0x20")]
		public ADataCacheService.DCacheInfo cacheInfo;

		[FieldOffset(Offset="0x38")]
		public Action error;

		[Address(RVA="0x14EA384", Offset="0x14EA384", VA="0x14EA384")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x14EA914", Offset="0x14EA914", VA="0x14EA914")]
		internal void <GetGamedata>b__0(byte[] data)
		{
		}

		[Address(RVA="0x14EABA0", Offset="0x14EABA0", VA="0x14EABA0")]
		internal void <GetGamedata>b__1(long errorCode, byte[] data)
		{
		}
	}
}