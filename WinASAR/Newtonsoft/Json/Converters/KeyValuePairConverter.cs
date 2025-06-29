using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200019B RID: 411
	[Nullable(0)]
	[NullableContext(1)]
	public class KeyValuePairConverter : JsonConverter
	{
		// Token: 0x0600120E RID: 4622 RVA: 0x0008FD08 File Offset: 0x0008DF08
		private static ReflectionObject smethod_0(Type type_0)
		{
			Type type;
			Type type2;
			for (;;)
			{
				Type[] genericArguments = type_0.GetGenericArguments();
				type = ((IList<Type>)genericArguments)[0];
				type2 = ((IList<Type>)genericArguments)[1];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
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
			return ReflectionObject.Create(type_0, type_0.GetConstructor(new Type[] { type, type2 }), new string[]
			{
				Class15.smethod_17(1042091281 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad),
				Class15.smethod_17(974447947 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f)
			});
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0008FDA4 File Offset: 0x0008DFA4
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			ReflectionObject reflectionObject;
			for (;;)
			{
				if (value == null)
				{
					goto IL_0105;
				}
				reflectionObject = KeyValuePairConverter.threadSafeStore_0.Get(value.GetType());
				goto IL_015C;
				IL_0127:
				int num;
				switch (num)
				{
				case 0:
					goto IL_011F;
				case 1:
					goto IL_018B;
				case 2:
					break;
				case 3:
					goto IL_015C;
				case 4:
					return;
				case 5:
					IL_0105:
					writer.WriteNull();
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
					{
						goto IL_015C;
					}
					goto IL_0127;
				case 6:
					continue;
				case 7:
					goto IL_00B1;
				case 8:
					return;
				case 9:
					goto IL_001D;
				case 10:
					goto IL_01CB;
				default:
					goto IL_011F;
				}
				IL_005D:
				DefaultContractResolver defaultContractResolver;
				writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName(Class15.smethod_17(1387465858 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923)) : Class15.smethod_17(1678096696 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a));
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
				{
					break;
				}
				goto IL_0127;
				IL_001D:
				serializer.Serialize(writer, reflectionObject.GetValue(value, Class15.smethod_17(1678096646 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a)), reflectionObject.GetType(Class15.smethod_17(926377445 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296)));
				goto IL_005D;
				IL_00B1:
				writer.WritePropertyName((defaultContractResolver == null) ? Class15.smethod_17(1243250852 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95) : defaultContractResolver.GetResolvedPropertyName(Class15.smethod_17(2071396918 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808)));
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
				{
					goto IL_001D;
				}
				goto IL_0127;
				IL_011F:
				writer.WriteStartObject();
				goto IL_00B1;
				IL_015C:
				defaultContractResolver = serializer.ContractResolver as DefaultContractResolver;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					goto IL_011F;
				}
				goto IL_0127;
			}
			IL_018B:
			serializer.Serialize(writer, reflectionObject.GetValue(value, Class15.smethod_17(1743168870 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8)), reflectionObject.GetType(Class15.smethod_17(197587337 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81)));
			IL_01CB:
			writer.WriteEndObject();
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0008FF84 File Offset: 0x0008E184
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			while (reader.TokenType != JsonToken.Null)
			{
				object obj = null;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
				{
					goto IL_0183;
				}
				IL_01B4:
				Type type;
				ReflectionObject reflectionObject;
				object obj2;
				JsonContract jsonContract;
				switch (num)
				{
				case 0:
					goto IL_00BB;
				case 1:
					goto IL_0154;
				case 2:
					goto IL_018C;
				case 3:
					IL_010A:
					reflectionObject = KeyValuePairConverter.threadSafeStore_0.Get(type);
					goto IL_0118;
				case 4:
					goto IL_01A9;
				case 5:
				case 17:
					goto IL_0023;
				case 6:
					goto IL_0234;
				case 7:
					continue;
				case 8:
					IL_023C:
					return null;
				case 9:
				case 19:
				case 25:
					goto IL_00D4;
				case 10:
					goto IL_009D;
				case 11:
					goto IL_0186;
				case 12:
					IL_0183:
					obj2 = null;
					goto IL_0186;
				case 13:
					goto IL_00CE;
				case 14:
					goto IL_0118;
				case 15:
					goto IL_025A;
				case 16:
					goto IL_007E;
				case 18:
					IL_023E:
					throw JsonSerializationException.Create(reader, Class15.smethod_17(2021146724 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8));
				case 20:
					goto IL_003F;
				case 21:
					goto IL_00F2;
				case 22:
					break;
				case 23:
					goto IL_0032;
				case 24:
					obj = serializer.Deserialize(reader, jsonContract.UnderlyingType);
					goto IL_00D4;
				default:
					goto IL_00BB;
				}
				IL_005E:
				reader.ReadForTypeAndAssert(jsonContract, false);
				num = 24;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
				{
					goto IL_00BB;
				}
				goto IL_01B4;
				IL_003F:
				string text;
				if (string.Equals(text, Class15.smethod_17(1802340805 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4), StringComparison.OrdinalIgnoreCase))
				{
					goto IL_005E;
				}
				goto IL_007E;
				IL_0032:
				text = reader.Value.ToString();
				goto IL_003F;
				IL_0023:
				if (reader.TokenType != JsonToken.PropertyName)
				{
					goto IL_025A;
				}
				goto IL_0032;
				IL_0154:
				JsonContract jsonContract2 = serializer.ContractResolver.ResolveContract(reflectionObject.GetType(Class15.smethod_17(314772537 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927)));
				goto IL_0023;
				IL_00D4:
				reader.ReadAndAssert();
				goto IL_0023;
				IL_00CE:
				reader.Skip();
				goto IL_00D4;
				IL_007E:
				if (string.Equals(text, Class15.smethod_17(486530898 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c), StringComparison.OrdinalIgnoreCase))
				{
					goto IL_009D;
				}
				goto IL_00CE;
				IL_00BB:
				obj2 = serializer.Deserialize(reader, jsonContract2.UnderlyingType);
				goto IL_00D4;
				IL_009D:
				reader.ReadForTypeAndAssert(jsonContract2, false);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
				{
					goto IL_00BB;
				}
				goto IL_01B4;
				IL_00F3:
				Type type2;
				type = type2;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
				{
					goto IL_010A;
				}
				goto IL_01B4;
				IL_01A9:
				type2 = Nullable.GetUnderlyingType(objectType);
				goto IL_00F3;
				IL_00F2:
				type2 = objectType;
				goto IL_00F3;
				IL_018C:
				if (!ReflectionUtils.IsNullableType(objectType))
				{
					goto IL_00F2;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
				{
					goto IL_01A9;
				}
				goto IL_01B4;
				IL_0186:
				reader.ReadAndAssert();
				goto IL_018C;
				IL_0118:
				jsonContract = serializer.ContractResolver.ResolveContract(reflectionObject.GetType(Class15.smethod_17(538805273 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa)));
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
				{
					goto IL_0154;
				}
				goto IL_01B4;
				IL_025A:
				return reflectionObject.Creator(new object[] { obj, obj2 });
			}
			IL_0234:
			if (ReflectionUtils.IsNullableType(objectType))
			{
				goto IL_023C;
			}
			goto IL_023E;
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x00090208 File Offset: 0x0008E408
		public override bool CanConvert(Type objectType)
		{
			Type type;
			for (;;)
			{
				if (ReflectionUtils.IsNullableType(objectType))
				{
					goto IL_004F;
				}
				goto IL_006B;
				IL_0055:
				Type type2;
				type = type2;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
				{
					goto IL_0023;
				}
				IL_002F:
				switch (num)
				{
				case 0:
					goto IL_0023;
				case 1:
					goto IL_007A;
				case 2:
					IL_006B:
					type2 = objectType;
					goto IL_0055;
				case 3:
					break;
				case 4:
					IL_004F:
					type2 = Nullable.GetUnderlyingType(objectType);
					goto IL_0055;
				case 5:
					continue;
				default:
					goto IL_0023;
				}
				IL_0003:
				if (!type.IsGenericType())
				{
					return false;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
				{
					break;
				}
				goto IL_002F;
				IL_0023:
				if (type.IsValueType())
				{
					goto IL_0003;
				}
				return false;
			}
			IL_007A:
			return type.GetGenericTypeDefinition() == typeof(KeyValuePair<, >);
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x000902A8 File Offset: 0x0008E4A8
		public KeyValuePairConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x000902DC File Offset: 0x0008E4DC
		static KeyValuePairConverter()
		{
			for (;;)
			{
				IL_0058:
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
						{
							continue;
						}
						break;
					case 3:
						goto IL_0058;
					}
					do
					{
						KeyValuePairConverter.threadSafeStore_0 = new ThreadSafeStore<Type, ReflectionObject>(new Func<Type, ReflectionObject>(KeyValuePairConverter.smethod_0));
						num = 1;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0);
				}
			}
		}

		// Token: 0x0400080C RID: 2060
		private static readonly ThreadSafeStore<Type, ReflectionObject> threadSafeStore_0;
	}
}
