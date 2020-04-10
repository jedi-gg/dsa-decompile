using Il2CppDummyDll;
using System;

namespace Glunies
{
	public struct DBundleDownloadStatus
	{
		[FieldOffset(Offset="0x0")]
		public readonly string BundleName;

		[FieldOffset(Offset="0x8")]
		public readonly DBundleDownloadStatus.Status DownloadStatus;

		[FieldOffset(Offset="0x10")]
		public readonly ulong BytesDownloaded;

		[FieldOffset(Offset="0x18")]
		public readonly ulong TotalBytes;

		[Address(RVA="0xF009C8", Offset="0xF009C8", VA="0xF009C8")]
		public DBundleDownloadStatus(string bundleName, DBundleDownloadStatus.Status status, ulong bytesDownloaded, ulong totalBytes)
		{
		}

		public enum Status
		{
			[FieldOffset(Offset="0x0")]
			Downloading,
			[FieldOffset(Offset="0x0")]
			Finished
		}
	}
}