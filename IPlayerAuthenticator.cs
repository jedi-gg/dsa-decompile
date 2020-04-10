using System;

public interface IPlayerAuthenticator
{
	string AuthToken
	{
		get;
	}

	void AutoAuthenticate(Action<bool> completed);

	void Shutdown();

	void TickUpdate();
}