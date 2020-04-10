using System;

namespace Glunies
{
	public interface IAssetDownloader
	{
		string DownloadedManifestVersion
		{
			get;
		}

		bool IsManifestLoaded
		{
			get;
		}

		ulong GetTutorialAssetsDownloadSizeBytes();

		void Initialize();

		void LoadManifest(string contentUrl, string version, Action<bool> finished);

		void LoadManifest(string assetUrl, Action<bool> finished);

		bool NeedsToDownloadTutorialAssets();

		void Shutdown();

		void StartBackgroundDownloads();

		void StartTutorialAssetsDownloads();

		void StopBackgroundDownloads();

		void TickUpdate();

		void TryShowLargeDownloadPrompt(Action finished);
	}
}