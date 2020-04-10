using System;

public interface IHapticController
{
	void Initialize();

	bool IsSupported();

	void SetEnabled(bool enabled);

	void Shutdown();

	void Vibrate();
}