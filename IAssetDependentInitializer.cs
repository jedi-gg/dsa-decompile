using System;

public interface IAssetDependentInitializer
{
	bool IsInitialized
	{
		get;
	}

	void LoadAssets(Action finished);

	void ReleaseAssets();

	void Shutdown();
}