using System;

namespace Csdk.GluCentralServices.Implementation
{
	public interface ISerializableJson
	{
		void Write(JsonStringer json, string key);
	}
}