using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200019F RID: 415
	[Nullable(0)]
	[NullableContext(1)]
	public class VersionConverter : JsonConverter
	{
		// Token: 0x0600123E RID: 4670 RVA: 0x00091844 File Offset: 0x0008FA44
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			while (value != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					goto IL_0037;
				}
				IL_0053:
				switch (num)
				{
				case 0:
					goto IL_0096;
				case 1:
					IL_0037:
					if (!(value is Version))
					{
						throw new JsonSerializationException(Class15.smethod_17(314827449 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927));
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
					{
						goto IL_0053;
					}
					break;
				case 2:
					continue;
				case 3:
					return;
				case 4:
					return;
				case 5:
					break;
				default:
					goto IL_0096;
				}
				writer.WriteValue(value.ToString());
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					goto IL_0053;
				}
				return;
			}
			IL_0096:
			writer.WriteNull();
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x000918F0 File Offset: 0x0008FAF0
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			while (reader.TokenType != JsonToken.Null)
			{
				if (reader.TokenType == JsonToken.String)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
					{
						switch (num)
						{
						case 1:
							goto IL_00C8;
						case 2:
							goto IL_0043;
						case 3:
							continue;
						}
					}
					try
					{
						object obj = new Version((string)reader.Value);
						int num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
						{
							switch (num2)
							{
							}
						}
						return obj;
					}
					catch (Exception ex)
					{
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
						{
							switch (num3)
							{
							}
						}
						throw JsonSerializationException.Create(reader, Class15.smethod_17(41452151 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d).FormatWith(CultureInfo.InvariantCulture, reader.Value), ex);
					}
				}
				IL_00C8:
				throw JsonSerializationException.Create(reader, Class15.smethod_17(1743145578 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8).FormatWith(CultureInfo.InvariantCulture, reader.TokenType, reader.Value));
			}
			IL_0043:
			return null;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00006AF1 File Offset: 0x00004CF1
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(Version);
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00091A10 File Offset: 0x0008FC10
		public VersionConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
