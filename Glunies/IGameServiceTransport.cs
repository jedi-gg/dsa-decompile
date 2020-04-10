using Serverproto;
using System;

namespace Glunies
{
	public interface IGameServiceTransport
	{
		string AuthToken
		{
			get;
		}

		Serverproto.AuthType AuthType
		{
			get;
		}

		void Call(RequestEnvelope requestProtoObject, Action<ResponseEnvelope> success, Action<long, ResponseEnvelope> failure, uint timeoutOverrideS = 0);

		void Initialize(Serverproto.AuthType authType, string authToken, string timezone, Action<bool> completed);

		void Reconnect();

		void Shutdown();

		void TickUpdate();
	}
}