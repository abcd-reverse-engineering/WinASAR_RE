using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200018C RID: 396
	[NullableContext(1)]
	[Nullable(0)]
	public class BinaryConverter : JsonConverter
	{
		// Token: 0x060011A0 RID: 4512 RVA: 0x0008C468 File Offset: 0x0008A668
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			for (;;)
			{
				byte[] array;
				if (value != null)
				{
					array = this.method_0(value);
					goto IL_0041;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
				{
					goto IL_000E;
				}
				IL_0025:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				case 3:
					return;
				case 4:
					IL_0041:
					writer.WriteValue(array);
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
					{
						goto Block_2;
					}
					goto IL_0025;
				}
				IL_000E:
				writer.WriteNull();
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
				{
					goto IL_0025;
				}
				goto IL_007A;
			}
			Block_2:
			return;
			IL_007A:;
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0008C4F4 File Offset: 0x0008A6F4
		private byte[] method_0(object object_0)
		{
			for (;;)
			{
				if (object_0.GetType().FullName == Class15.smethod_17(89014960 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454))
				{
					goto IL_0043;
				}
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				default:
					IL_0043:
					BinaryConverter.smethod_0(object_0.GetType());
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
					{
						goto Block_2;
					}
					goto IL_0022;
				case 1:
					goto IL_00A4;
				case 2:
					IL_0003:
					if (object_0 is SqlBinary)
					{
						goto IL_00F5;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
					{
						goto IL_0022;
					}
					goto IL_00A3;
				case 3:
					break;
				case 4:
					goto IL_00FD;
				case 5:
					goto IL_00CA;
				case 6:
					goto IL_00F5;
				}
			}
			Block_2:
			IL_00A3:
			IL_00A4:
			return (byte[])BinaryConverter.reflectionObject_0.GetValue(object_0, Class15.smethod_17(314823631 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927));
			IL_00CA:
			throw new JsonSerializationException(Class15.smethod_17(277653292 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98).FormatWith(CultureInfo.InvariantCulture, object_0.GetType()));
			IL_00F5:
			SqlBinary sqlBinary = (SqlBinary)object_0;
			IL_00FD:
			return sqlBinary.Value;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0008C608 File Offset: 0x0008A808
		private static void smethod_0(Type type_0)
		{
			while (BinaryConverter.reflectionObject_0 != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0039;
					}
				}
				return;
			}
			IL_0039:
			BinaryConverter.reflectionObject_0 = ReflectionObject.Create(type_0, type_0.GetConstructor(new Type[] { typeof(byte[]) }), new string[] { Class15.smethod_17(635792049 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2) });
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0008C690 File Offset: 0x0008A890
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			byte[] array;
			for (;;)
			{
				IL_01C1:
				int num;
				if (reader.TokenType == JsonToken.Null)
				{
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
					{
						goto IL_006D;
					}
				}
				else
				{
					if (reader.TokenType != JsonToken.StartArray)
					{
						goto IL_0029;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
					{
						goto IL_014C;
					}
				}
				for (;;)
				{
					IL_015A:
					switch (num)
					{
					case 1:
						goto IL_021C;
					case 2:
						goto IL_006D;
					case 3:
						goto IL_01D1;
					case 4:
						goto IL_0141;
					case 5:
						goto IL_00BD;
					case 6:
						goto IL_0085;
					case 7:
						goto IL_012A;
					case 8:
						goto IL_0243;
					case 9:
						goto IL_0029;
					case 10:
						goto IL_00EA;
					case 11:
						goto IL_01EF;
					case 12:
						if (!ReflectionUtils.IsNullable(objectType))
						{
							goto IL_01EF;
						}
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
						{
							goto Block_11;
						}
						continue;
					case 13:
						goto IL_01C1;
					case 14:
					case 17:
						goto IL_0050;
					case 15:
						goto IL_0216;
					case 16:
						goto IL_0274;
					}
					break;
				}
				goto IL_014C;
				IL_0141:
				Type type = Nullable.GetUnderlyingType(objectType);
				goto IL_006E;
				IL_0029:
				if (reader.TokenType != JsonToken.String)
				{
					goto IL_0243;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
				{
					goto IL_012A;
				}
				goto IL_015A;
				IL_0050:
				if (!ReflectionUtils.IsNullableType(objectType))
				{
					goto IL_006D;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
				{
					goto IL_006D;
				}
				goto IL_015A;
				IL_014C:
				array = this.method_1(reader);
				goto IL_0050;
				IL_012A:
				array = Convert.FromBase64String(reader.Value.ToString());
				goto IL_0050;
				IL_006E:
				Type type2 = type;
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
				{
					goto IL_0085;
				}
				goto IL_015A;
				IL_006D:
				type = objectType;
				goto IL_006E;
				IL_0085:
				if (type2.FullName == Class15.smethod_17(564878380 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610))
				{
					goto IL_00EA;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
				{
					goto IL_015A;
				}
				IL_00BD:
				if (type2 == typeof(SqlBinary))
				{
					goto IL_0274;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
				{
					break;
				}
				goto IL_015A;
				IL_00EA:
				BinaryConverter.smethod_0(type2);
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
				{
					break;
				}
				goto IL_015A;
			}
			goto IL_021C;
			Block_11:
			goto IL_0216;
			IL_01D1:
			return BinaryConverter.reflectionObject_0.Creator(new object[] { array });
			IL_01EF:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1829588735 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae).FormatWith(CultureInfo.InvariantCulture, objectType));
			IL_0216:
			return null;
			IL_021C:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(432106753 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2).FormatWith(CultureInfo.InvariantCulture, objectType));
			IL_0243:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1424594192 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf).FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			IL_0274:
			return new SqlBinary(array);
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0008C920 File Offset: 0x0008AB20
		private byte[] method_1(JsonReader jsonReader_0)
		{
			List<byte> list = new List<byte>();
			while (jsonReader_0.Read())
			{
				JsonToken tokenType = jsonReader_0.TokenType;
				if (tokenType != JsonToken.Comment)
				{
					if (tokenType != JsonToken.Integer)
					{
						if (tokenType != JsonToken.EndArray)
						{
							throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1788643886 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1).FormatWith(CultureInfo.InvariantCulture, jsonReader_0.TokenType));
						}
						return list.ToArray();
					}
					else
					{
						list.Add(Convert.ToByte(jsonReader_0.Value, CultureInfo.InvariantCulture));
					}
				}
			}
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1116173047 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54));
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0008C9C4 File Offset: 0x0008ABC4
		public override bool CanConvert(Type objectType)
		{
			for (;;)
			{
				int num;
				if (objectType.FullName == Class15.smethod_17(41464629 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d))
				{
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						goto IL_002A;
					}
				}
				else
				{
					if (objectType == typeof(SqlBinary))
					{
						return true;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
					{
						goto IL_002A;
					}
				}
				IL_004D:
				switch (num)
				{
				case 1:
					IL_002A:
					if (objectType == typeof(SqlBinary?))
					{
						return true;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
					{
						goto IL_004D;
					}
					break;
				case 2:
					return true;
				case 3:
					return true;
				case 4:
					continue;
				}
				break;
			}
			return false;
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0008CA7C File Offset: 0x0008AC7C
		public BinaryConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x040007ED RID: 2029
		[Nullable(2)]
		private static ReflectionObject reflectionObject_0;
	}
}
