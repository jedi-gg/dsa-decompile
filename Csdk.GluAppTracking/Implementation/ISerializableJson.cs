using System;

namespace Csdk.GluAppTracking.Implementation
{
	public interface ISerializableJson
	{
		void Write(JsonStringer json, string key);
	}
}