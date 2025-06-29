using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WinASAR.Common.Helpers
{
	// Token: 0x02000027 RID: 39
	internal class DateTimeConverter : DateTimeConverterBase
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x000028D9 File Offset: 0x00000AD9
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return Convert.ToDateTime(reader.Value);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00025254 File Offset: 0x00023454
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			for (;;)
			{
				writer.WriteValue(((DateTime)value).ToString(Class15.smethod_17(552182646 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f)));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
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

		// Token: 0x060001B2 RID: 434 RVA: 0x000252B0 File Offset: 0x000234B0
		public DateTimeConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
