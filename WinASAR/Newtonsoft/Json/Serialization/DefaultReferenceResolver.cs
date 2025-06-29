using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000F2 RID: 242
	[NullableContext(1)]
	[Nullable(0)]
	internal class DefaultReferenceResolver : GInterface1
	{
		// Token: 0x0600096D RID: 2413 RVA: 0x00057510 File Offset: 0x00055710
		private BidirectionalDictionary<string, object> method_0(object object_0)
		{
			JsonSerializerInternalBase jsonSerializerInternalBase = object_0 as JsonSerializerInternalBase;
			if (jsonSerializerInternalBase == null)
			{
				JsonSerializerProxy jsonSerializerProxy = object_0 as JsonSerializerProxy;
				if (jsonSerializerProxy == null)
				{
					throw new JsonException(Class15.smethod_17(1270996812 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112));
				}
				jsonSerializerInternalBase = jsonSerializerProxy.GetInternalSerializer();
			}
			return jsonSerializerInternalBase.DefaultReferenceMappings;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0005755C File Offset: 0x0005575C
		public object ResolveReference(object context, string reference)
		{
			object obj;
			for (;;)
			{
				this.method_0(context).TryGetByFirst(reference, out obj);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
					break;
				}
				break;
			}
			return obj;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000575A0 File Offset: 0x000557A0
		public string GetReference(object context, object value)
		{
			string text;
			for (;;)
			{
				IL_00A1:
				BidirectionalDictionary<string, object> bidirectionalDictionary = this.method_0(context);
				for (;;)
				{
					if (!bidirectionalDictionary.TryGetBySecond(value, out text))
					{
						goto IL_006E;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
					{
						return text;
					}
					IL_0024:
					switch (num)
					{
					case 2:
						IL_006E:
						this.int_0++;
						goto IL_0048;
					case 3:
						goto IL_0048;
					case 4:
						continue;
					case 5:
						goto IL_00A1;
					case 6:
						goto IL_0006;
					}
					return text;
					IL_0006:
					bidirectionalDictionary.Set(text, value);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
					{
						goto IL_0024;
					}
					return text;
					IL_0048:
					text = this.int_0.ToString(CultureInfo.InvariantCulture);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
					{
						goto IL_0006;
					}
					goto IL_0024;
				}
			}
			return text;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00057660 File Offset: 0x00055860
		public void AddReference(object context, string reference, object value)
		{
			for (;;)
			{
				this.method_0(context).Set(reference, value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
					break;
				}
				break;
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000576A0 File Offset: 0x000558A0
		public bool IsReferenced(object context, object value)
		{
			string text;
			return this.method_0(context).TryGetBySecond(value, out text);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00057004 File Offset: 0x00055204
		public DefaultReferenceResolver()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x040004E4 RID: 1252
		private int int_0;
	}
}
