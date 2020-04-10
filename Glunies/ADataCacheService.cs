using Il2CppDummyDll;
using System;

namespace Glunies
{
	public abstract class ADataCacheService : ILoggable<LogCategory>
	{
		[Attribute(Name="InjectAttribute", RVA="0x10641CC", Offset="0x10641CC")]
		[FieldOffset(Offset="0x10")]
		private HttpService _httpService;

		public abstract LogCategory LogCategory
		{
			get;
		}

		[Address(RVA="0x14EA90C", Offset="0x14EA90C", VA="0x14EA90C")]
		protected ADataCacheService()
		{
		}

		[Address(RVA="0x14F48DC", Offset="0x14F48DC", VA="0x14F48DC")]
		private void CacheData(ADataCacheService.DCacheInfo cacheInfo, byte[] data)
		{
		}

		[Address(RVA="0x14EAB5C", Offset="0x14EAB5C", VA="0x14EAB5C")]
		protected void ClearCache(ADataCacheService.DCacheInfo cacheInfo)
		{
		}

		[Address(RVA="0x14EA5B8", Offset="0x14EA5B8", VA="0x14EA5B8")]
		protected void GetData(string dataUrl, ADataCacheService.DCacheInfo cacheInfo, Action<byte[]> success, HttpService.RequestFail failure)
		{
		}

		[Address(RVA="0x14F4794", Offset="0x14F4794", VA="0x14F4794")]
		private bool TryLoadFromCache(ADataCacheService.DCacheInfo cacheInfo, out byte[] data)
		{
			data = 0;
			return new bool();
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050F88", Offset="0x1050F88")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x10")]
			public ADataCacheService <>4__this;

			[FieldOffset(Offset="0x18")]
			public ADataCacheService.DCacheInfo cacheInfo;

			[FieldOffset(Offset="0x30")]
			public Action<byte[]> success;

			[FieldOffset(Offset="0x38")]
			public HttpService.RequestFail failure;

			[Address(RVA="0x14F478C", Offset="0x14F478C", VA="0x14F478C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x14F4990", Offset="0x14F4990", VA="0x14F4990")]
			internal void <GetData>b__0(byte[] data)
			{
			}
		}

		public struct DCacheInfo
		{
			[FieldOffset(Offset="0x0")]
			public readonly string Version;

			[FieldOffset(Offset="0x8")]
			public readonly string CacheDir;

			[FieldOffset(Offset="0x10")]
			public readonly string CachePath;

			[Address(RVA="0xF01A30", Offset="0xF01A30", VA="0xF01A30")]
			public DCacheInfo(string version, string cacheDir, string fileName)
			{
			}
		}
	}
}