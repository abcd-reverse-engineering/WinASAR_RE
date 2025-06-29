using System;
using Newtonsoft.Json;

namespace WinASAR.Common.Helpers
{
	// Token: 0x02000026 RID: 38
	public static class JsonHelper
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x000028BA File Offset: 0x00000ABA
		public static string SerializeObject(object data)
		{
			return JsonConvert.SerializeObject(data, JsonHelper.jsonConverter_0);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000028C7 File Offset: 0x00000AC7
		public static object DeserializeObject(string json, Type targetType)
		{
			return JsonConvert.DeserializeObject(json, targetType);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000028D0 File Offset: 0x00000AD0
		public static T DeserializeAnonymousType<T>(string json, T anonymousTypeObject)
		{
			return JsonConvert.DeserializeAnonymousType<T>(json, anonymousTypeObject);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000251B4 File Offset: 0x000233B4
		public static T DeserializeObject<T>(string json)
		{
			if (string.IsNullOrWhiteSpace(json))
			{
				return default(T);
			}
			return JsonConvert.DeserializeObject<T>(json);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000251DC File Offset: 0x000233DC
		static JsonHelper()
		{
			for (;;)
			{
				IL_0052:
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_0016;
					case 2:
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
						{
							goto IL_0016;
						}
						continue;
					case 3:
						goto IL_0052;
					}
					return;
					IL_0016:
					JsonHelper.jsonConverter_0 = new JsonConverter[]
					{
						new DateTimeConverter()
					};
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
					{
						return;
					}
				}
			}
		}

		// Token: 0x04000126 RID: 294
		private static readonly JsonConverter[] jsonConverter_0;
	}
}
