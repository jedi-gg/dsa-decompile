using System;

namespace Glu.Plugins.GluAnalytics.Implementation
{
	public interface ISerializableJson
	{
		void Write(JsonStringer json, string key);
	}
}