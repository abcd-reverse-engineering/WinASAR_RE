using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000114 RID: 276
	[NullableContext(1)]
	[Nullable(0)]
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase
	{
		// Token: 0x06000ACB RID: 2763 RVA: 0x0005BDAC File Offset: 0x00059FAC
		public JsonSerializerInternalReader(JsonSerializer serializer)
			: base(serializer)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0005BDE0 File Offset: 0x00059FE0
		public void Populate(JsonReader reader, object target)
		{
			string text2;
			JsonContract jsonContract;
			Type type;
			for (;;)
			{
				IL_01F2:
				ValidationUtils.ArgumentNotNull(target, Class15.smethod_17(676700724 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b));
				int num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
				{
					goto IL_0164;
				}
				for (;;)
				{
					IL_0183:
					string text;
					switch (num)
					{
					case 1:
						goto IL_0227;
					case 2:
						goto IL_031A;
					case 3:
						goto IL_00CF;
					case 4:
						goto IL_0164;
					case 5:
						goto IL_01F2;
					case 6:
						goto IL_0076;
					case 7:
						goto IL_0146;
					case 8:
					{
						object value = reader.Value;
						if (value != null)
						{
							text = value.ToString();
							goto IL_014E;
						}
						num = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
						{
							goto IL_0146;
						}
						continue;
					}
					case 9:
						goto IL_0102;
					case 10:
						IL_010D:
						reader.ReadAndAssert();
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
						{
							goto Block_7;
						}
						continue;
					case 11:
						goto IL_00C6;
					case 12:
						goto IL_00BB;
					case 13:
						goto IL_00A7;
					case 14:
						goto IL_0291;
					case 15:
						return;
					case 16:
						goto IL_0084;
					case 17:
						goto IL_02BC;
					case 18:
						return;
					case 19:
						goto IL_0073;
					case 20:
						goto IL_02C5;
					case 21:
						goto IL_0053;
					case 22:
						goto IL_02F0;
					case 23:
						return;
					case 24:
						goto IL_0043;
					}
					goto Block_11;
					IL_014E:
					text2 = text;
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
					{
						goto IL_010D;
					}
					continue;
					IL_0146:
					text = null;
					goto IL_014E;
				}
				Block_7:
				goto IL_0043;
				Block_11:
				goto IL_001B;
				IL_0043:
				if (jsonContract.ContractType != JsonContractType.Dictionary)
				{
					goto IL_0310;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					goto IL_0183;
				}
				IL_001B:
				if (!string.Equals(reader.Value.ToString(), Class15.smethod_17(676720514 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b), StringComparison.Ordinal))
				{
					goto IL_0043;
				}
				IL_0053:
				reader.ReadAndAssert();
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
				{
					break;
				}
				goto IL_0183;
				IL_00CF:
				if (jsonContract.ContractType != JsonContractType.Array)
				{
					goto IL_0238;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
				{
					goto Block_6;
				}
				goto IL_0183;
				IL_00C6:
				if (reader.TokenType == JsonToken.StartArray)
				{
					goto IL_00CF;
				}
				if (reader.TokenType == JsonToken.StartObject)
				{
					goto IL_0102;
				}
				goto IL_0260;
				IL_00BB:
				if (reader.MoveToContent())
				{
					goto IL_00C6;
				}
				goto IL_02F0;
				IL_00A7:
				jsonContract = this.Serializer._contractResolver.ResolveContract(type);
				goto IL_00BB;
				IL_0164:
				type = target.GetType();
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
				{
					goto IL_00A7;
				}
				goto IL_0183;
				IL_0076:
				if (this.Serializer.MetadataPropertyHandling != MetadataPropertyHandling.Ignore)
				{
					goto IL_0084;
				}
				goto IL_0043;
				IL_0073:
				text2 = null;
				goto IL_0076;
				IL_0102:
				reader.ReadAndAssert();
				goto IL_0073;
				IL_0084:
				if (reader.TokenType != JsonToken.PropertyName)
				{
					goto IL_0043;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
				{
					goto IL_001B;
				}
				goto IL_0183;
			}
			goto IL_031A;
			Block_6:
			goto IL_02BC;
			IL_0227:
			JsonDictionaryContract jsonDictionaryContract = (JsonDictionaryContract)jsonContract;
			goto IL_0291;
			IL_0238:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(124819234 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719).FormatWith(CultureInfo.InvariantCulture, type));
			IL_0260:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(314804307 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927).FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			IL_0291:
			IDictionary dictionary2;
			if (jsonDictionaryContract.ShouldCreateWrapper)
			{
				IDictionary dictionary = jsonDictionaryContract.CreateWrapper(target);
				dictionary2 = dictionary;
			}
			else
			{
				dictionary2 = (IDictionary)target;
			}
			this.method_23(dictionary2, reader, jsonDictionaryContract, null, text2);
			return;
			IL_02BC:
			JsonArrayContract jsonArrayContract = (JsonArrayContract)jsonContract;
			IL_02C5:
			IList list2;
			if (jsonArrayContract.ShouldCreateWrapper)
			{
				IList list = jsonArrayContract.CreateWrapper(target);
				list2 = list;
			}
			else
			{
				list2 = (IList)target;
			}
			this.method_26(list2, reader, jsonArrayContract, null, null);
			return;
			IL_02F0:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1802367617 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4));
			IL_0310:
			if (jsonContract.ContractType != JsonContractType.Object)
			{
				throw JsonSerializationException.Create(reader, Class15.smethod_17(1829629257 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae).FormatWith(CultureInfo.InvariantCulture, type));
			}
			IL_031A:
			this.method_32(target, reader, (JsonObjectContract)jsonContract, null, text2);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0005C144 File Offset: 0x0005A344
		[NullableContext(2)]
		private JsonContract method_1(Type type_0)
		{
			while (!(type_0 == null))
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_003D;
					}
				}
				return this.method_2(type_0);
			}
			IL_003D:
			return null;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00004FAF File Offset: 0x000031AF
		private JsonContract method_2(Type type_0)
		{
			return this.Serializer._contractResolver.ResolveContract(type_0);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0005C190 File Offset: 0x0005A390
		[NullableContext(2)]
		public object Deserialize([Nullable(1)] JsonReader reader, Type objectType, bool checkAdditionalContent)
		{
			object obj;
			for (;;)
			{
				int num;
				if (reader == null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
					{
						break;
					}
				}
				else
				{
					JsonContract jsonContract = this.method_1(objectType);
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
					{
						goto IL_006B;
					}
				}
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_006C;
				case 3:
					return obj;
				}
				break;
			}
			throw new ArgumentNullException(Class15.smethod_17(299949347 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e));
			IL_006B:
			IL_006C:
			try
			{
				JsonContract jsonContract;
				JsonConverter jsonConverter = this.method_7(jsonContract, null, null, null);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
				{
					goto IL_013A;
				}
				goto IL_0183;
				IL_0094:
				if (reader.TokenType != JsonToken.Comment)
				{
					goto IL_01D7;
				}
				IL_00A3:
				if (reader.Read())
				{
					goto IL_0094;
				}
				num2 = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
				{
					goto IL_0183;
				}
				IL_00C0:
				if (jsonContract == null)
				{
					goto IL_00D0;
				}
				IL_00C4:
				if (!jsonContract.IsNullable)
				{
					num2 = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
					{
						goto IL_01FA;
					}
					goto IL_0183;
				}
				IL_00D0:
				obj = null;
				num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
				{
					goto IL_013A;
				}
				goto IL_0183;
				IL_00EA:
				if (jsonConverter == null)
				{
					goto IL_0128;
				}
				num2 = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
				{
					goto IL_013A;
				}
				goto IL_0183;
				IL_0105:
				if (reader.ReadForType(jsonContract, jsonConverter != null))
				{
					goto IL_00EA;
				}
				num2 = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
				{
					goto IL_00C0;
				}
				goto IL_0183;
				IL_0128:
				object obj2 = this.method_6(reader, objectType, jsonContract, null, null, null, null);
				goto IL_0145;
				IL_013A:
				if (reader.TokenType == JsonToken.None)
				{
					goto IL_0105;
				}
				goto IL_00EA;
				IL_0145:
				if (checkAdditionalContent)
				{
					goto IL_00A3;
				}
				goto IL_01F3;
				IL_0183:
				switch (num2)
				{
				case 0:
					goto IL_013A;
				case 1:
					return obj;
				case 2:
				case 13:
					goto IL_0145;
				case 3:
					goto IL_01D7;
				case 4:
					if (!jsonConverter.CanRead)
					{
						goto IL_0128;
					}
					break;
				case 5:
					goto IL_0128;
				case 6:
					goto IL_00C0;
				case 7:
					break;
				case 8:
					goto IL_0227;
				case 9:
					goto IL_00EA;
				case 10:
					goto IL_01F3;
				case 11:
					goto IL_00C4;
				case 12:
					goto IL_0105;
				case 14:
					goto IL_01FA;
				case 15:
					goto IL_00A3;
				case 16:
					goto IL_0094;
				default:
					goto IL_013A;
				}
				obj2 = this.method_30(jsonConverter, reader, objectType, null);
				goto IL_0145;
				IL_01D7:
				throw JsonSerializationException.Create(reader, Class15.smethod_17(1802348725 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4));
				IL_01F3:
				obj = obj2;
				goto IL_0227;
				IL_01FA:
				throw JsonSerializationException.Create(reader, Class15.smethod_17(543292892 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89).FormatWith(CultureInfo.InvariantCulture, jsonContract.UnderlyingType));
				IL_0227:;
			}
			catch (Exception ex)
			{
				int num3 = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
				{
					goto IL_027A;
				}
				goto IL_02A8;
				IL_0242:
				base.ClearErrorContext();
				num3 = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
				{
					goto IL_02A8;
				}
				IL_025A:
				this.method_38(reader, false, 0);
				IL_0263:
				obj = null;
				num3 = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
				{
					goto IL_02CF;
				}
				goto IL_02A8;
				IL_027A:
				JsonContract jsonContract;
				if (base.IsErrorHandled(null, jsonContract, null, reader as IJsonLineInfo, reader.Path, ex))
				{
					goto IL_025A;
				}
				num3 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
				{
					goto IL_0242;
				}
				IL_02A8:
				switch (num3)
				{
				case 0:
					goto IL_025A;
				case 1:
				case 6:
					goto IL_0242;
				case 2:
					break;
				case 3:
					goto IL_027A;
				case 4:
					goto IL_0263;
				case 5:
					throw;
				default:
					goto IL_025A;
				}
				IL_02CF:;
			}
			return obj;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0005C48C File Offset: 0x0005A68C
		private JsonSerializerProxy method_3()
		{
			while (this.InternalSerializer == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					goto IL_0015;
				}
				IL_0032:
				switch (num)
				{
				case 0:
					goto IL_0052;
				case 1:
					IL_0015:
					this.InternalSerializer = new JsonSerializerProxy(this);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
					{
						goto IL_0032;
					}
					goto IL_0052;
				case 2:
					break;
				default:
					goto IL_0052;
				}
			}
			IL_0052:
			return this.InternalSerializer;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0005C4F4 File Offset: 0x0005A6F4
		[NullableContext(2)]
		private JToken method_4([Nullable(1)] JsonReader reader, JsonContract jsonContract_0)
		{
			JToken token;
			for (;;)
			{
				IL_01C7:
				ValidationUtils.ArgumentNotNull(reader, Class15.smethod_17(1603798320 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c));
				for (;;)
				{
					if (jsonContract_0 == null)
					{
						goto IL_0189;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
					{
						goto IL_007C;
					}
					IL_0127:
					JTokenWriter jtokenWriter;
					switch (num)
					{
					case 0:
						goto IL_0028;
					case 1:
						IL_009C:
						try
						{
							jtokenWriter.WriteToken(reader);
							int num2 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
							{
								goto IL_00D1;
							}
							IL_00B7:
							token = jtokenWriter.Token;
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
							{
								goto IL_00E2;
							}
							IL_00D1:
							switch (num2)
							{
							case 1:
								goto IL_00B7;
							}
							IL_00E2:
							goto IL_005C;
						}
						finally
						{
							if (jtokenWriter != null)
							{
								int num3 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
								{
									goto IL_0115;
								}
								IL_00FD:
								((IDisposable)jtokenWriter).Dispose();
								num3 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
								{
									goto IL_0126;
								}
								IL_0115:
								switch (num3)
								{
								case 0:
									goto IL_00FD;
								case 1:
									break;
								default:
									goto IL_00FD;
								}
							}
							IL_0126:;
						}
						goto IL_0127;
					case 2:
						IL_007C:
						if (jsonContract_0.UnderlyingType == typeof(JRaw))
						{
							goto IL_01E4;
						}
						break;
					case 3:
						goto IL_01E4;
					case 4:
					case 12:
						return token;
					case 5:
						goto IL_005C;
					case 6:
						continue;
					case 7:
						goto IL_01C7;
					case 8:
						goto IL_0206;
					case 9:
						goto IL_0246;
					case 10:
						break;
					case 11:
						goto IL_01F2;
					case 13:
						goto IL_01EE;
					case 14:
						goto IL_016F;
					default:
						goto IL_0028;
					}
					if (reader.TokenType != JsonToken.Null)
					{
						goto IL_0189;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
					{
						goto IL_0127;
					}
					IL_0028:
					if (jsonContract_0.UnderlyingType == typeof(JValue))
					{
						goto IL_0189;
					}
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
					{
						goto IL_016F;
					}
					goto IL_0127;
					IL_005C:
					if (jsonContract_0 != null)
					{
						goto IL_01EE;
					}
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
					{
						goto Block_5;
					}
					goto IL_0127;
					IL_0189:
					jtokenWriter = new JTokenWriter();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
					{
						goto IL_009C;
					}
					goto IL_0127;
					IL_016F:
					if (jsonContract_0.UnderlyingType == typeof(JToken))
					{
						goto IL_0189;
					}
					goto IL_0246;
				}
			}
			Block_5:
			return token;
			IL_01E4:
			return JRaw.Create(reader);
			IL_01EE:
			if (token == null)
			{
				return token;
			}
			IL_01F2:
			if (jsonContract_0.UnderlyingType.IsAssignableFrom(token.GetType()))
			{
				return token;
			}
			IL_0206:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(698970262 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a).FormatWith(CultureInfo.InvariantCulture, token.GetType().FullName, jsonContract_0.UnderlyingType.FullName));
			IL_0246:
			return null;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0005C758 File Offset: 0x0005A958
		private JToken method_5(JsonReader jsonReader_0)
		{
			JTokenWriter jtokenWriter;
			JToken token;
			for (;;)
			{
				IL_0033:
				ValidationUtils.ArgumentNotNull(jsonReader_0, Class15.smethod_17(564901314 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610));
				for (;;)
				{
					jtokenWriter = new JTokenWriter();
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
					{
						switch (num)
						{
						case 1:
							return token;
						case 2:
							continue;
						case 3:
							goto IL_0033;
						}
						goto Block_2;
					}
					goto IL_0050;
				}
			}
			Block_2:
			IL_0050:
			try
			{
				jtokenWriter.WriteStartObject();
				for (;;)
				{
					if (jsonReader_0.TokenType != JsonToken.PropertyName)
					{
						goto IL_0124;
					}
					int num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
					{
						goto IL_00E2;
					}
					IL_009E:
					string text;
					switch (num2)
					{
					case 0:
						goto IL_0102;
					case 1:
						IL_00E2:
						text = (string)jsonReader_0.Value;
						goto IL_00EF;
					case 2:
						goto IL_00EF;
					case 3:
					case 4:
					case 8:
						goto IL_0116;
					case 5:
					case 13:
						goto IL_0159;
					case 6:
						IL_0124:
						if (jsonReader_0.TokenType != JsonToken.Comment)
						{
							goto IL_0095;
						}
						goto IL_0116;
					case 7:
						goto IL_0095;
					case 9:
						goto IL_0175;
					case 10:
						break;
					case 11:
						goto IL_010B;
					case 12:
						continue;
					case 14:
						goto IL_00F7;
					default:
						goto IL_0102;
					}
					IL_0075:
					token = jtokenWriter.Token;
					num2 = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
					{
						break;
					}
					goto IL_009E;
					IL_0095:
					jtokenWriter.WriteEndObject();
					goto IL_0075;
					IL_0116:
					if (jsonReader_0.Read())
					{
						continue;
					}
					num2 = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
					{
						goto IL_009E;
					}
					IL_010B:
					jtokenWriter.WriteToken(jsonReader_0, true, true, false);
					goto IL_0116;
					IL_00F7:
					if (!this.method_34(jsonReader_0, text))
					{
						goto IL_0102;
					}
					goto IL_0116;
					IL_00EF:
					if (jsonReader_0.ReadAndMoveToContent())
					{
						goto IL_00F7;
					}
					goto IL_0159;
					IL_0102:
					jtokenWriter.WritePropertyName(text);
					goto IL_010B;
				}
				goto IL_0175;
				IL_0159:
				throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(649924686 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff));
				IL_0175:;
			}
			finally
			{
				if (jtokenWriter != null)
				{
					int num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
					{
						goto IL_01A5;
					}
					IL_018D:
					((IDisposable)jtokenWriter).Dispose();
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
					{
						goto IL_01B6;
					}
					IL_01A5:
					switch (num3)
					{
					case 1:
						goto IL_018D;
					}
				}
				IL_01B6:;
			}
			return token;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0005C93C File Offset: 0x0005AB3C
		[NullableContext(2)]
		private object method_6([Nullable(1)] JsonReader reader, Type type_0, JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, object object_0)
		{
			string text;
			for (;;)
			{
				IL_0130:
				if (jsonContract_0 != null)
				{
					goto IL_011A;
				}
				for (;;)
				{
					IL_0126:
					JsonToken tokenType = reader.TokenType;
					for (;;)
					{
						int num;
						switch (tokenType)
						{
						case JsonToken.StartObject:
							goto IL_0192;
						case JsonToken.StartArray:
							goto IL_0136;
						case JsonToken.StartConstructor:
							goto IL_0145;
						case JsonToken.Comment:
							if (!reader.Read())
							{
								goto IL_01A4;
							}
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
							{
								goto Block_5;
							}
							goto IL_0049;
						case JsonToken.Raw:
							goto IL_0154;
						case JsonToken.Integer:
						case JsonToken.Float:
						case JsonToken.Boolean:
						case JsonToken.Date:
						case JsonToken.Bytes:
							goto IL_022B;
						case JsonToken.String:
							text = (string)reader.Value;
							goto IL_0089;
						case JsonToken.Null:
						case JsonToken.Undefined:
							goto IL_01C8;
						}
						goto Block_6;
						IL_0049:
						switch (num)
						{
						case 1:
							goto IL_01C0;
						case 2:
							goto IL_0126;
						case 3:
							goto IL_01DA;
						case 4:
							goto IL_0176;
						case 5:
							continue;
						case 6:
							goto IL_011A;
						case 7:
							goto IL_0130;
						case 8:
							goto IL_0187;
						case 9:
							IL_0089:
							if (type_0 == typeof(byte[]))
							{
								goto IL_01C0;
							}
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
							{
								goto IL_0049;
							}
							break;
						case 10:
							goto IL_0190;
						case 11:
							goto IL_01F5;
						case 12:
							goto IL_0192;
						case 13:
							goto IL_01A4;
						}
						if (!JsonSerializerInternalReader.muXyNlttNP(type_0, jsonContract_0, text))
						{
							goto IL_0165;
						}
						num = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
						{
							goto IL_0049;
						}
						goto IL_0119;
					}
					Block_5:;
				}
				IL_0119:
				IL_011A:
				if (jsonContract_0.ContractType == JsonContractType.Linq)
				{
					goto Block_7;
				}
				goto IL_0126;
			}
			Block_6:
			goto IL_01F5;
			Block_7:
			goto IL_0187;
			IL_0136:
			return this.method_13(reader, type_0, jsonContract_0, jsonProperty_0, object_0, null);
			IL_0145:
			string text2 = reader.Value.ToString();
			goto IL_0176;
			IL_0154:
			return new JRaw((string)reader.Value);
			IL_0165:
			return this.method_14(reader, text, CultureInfo.InvariantCulture, jsonContract_0, type_0);
			IL_0176:
			return this.method_14(reader, text2, CultureInfo.InvariantCulture, jsonContract_0, type_0);
			IL_0187:
			return this.method_4(reader, jsonContract_0);
			IL_0190:
			return null;
			IL_0192:
			return this.method_8(reader, type_0, jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1, object_0);
			IL_01A4:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1793888542 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a));
			IL_01C0:
			return Convert.FromBase64String(text);
			IL_01C8:
			if (!(type_0 == typeof(DBNull)))
			{
				return this.method_14(reader, reader.Value, CultureInfo.InvariantCulture, jsonContract_0, type_0);
			}
			IL_01DA:
			return DBNull.Value;
			IL_01F5:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1243219690 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95) + reader.TokenType.ToString());
			IL_022B:
			return this.method_14(reader, reader.Value, CultureInfo.InvariantCulture, jsonContract_0, type_0);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0005CB88 File Offset: 0x0005AD88
		[NullableContext(2)]
		private static bool muXyNlttNP(Type type_0, object object_0, [Nullable(1)] string s)
		{
			IL_0077:
			while (StringUtils.IsNullOrEmpty(s))
			{
				for (;;)
				{
					if (type_0 != null)
					{
						goto IL_0041;
					}
					int num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
					{
						break;
					}
					IL_0014:
					switch (num)
					{
					default:
						IL_0041:
						if (type_0 != typeof(string))
						{
							goto IL_0085;
						}
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
						{
							goto IL_0014;
						}
						goto IL_0082;
					case 1:
						break;
					case 2:
						goto IL_0097;
					case 3:
						goto IL_009A;
					case 4:
						goto IL_0085;
					case 5:
					case 7:
					case 8:
					case 9:
						return false;
					case 6:
						goto IL_0077;
					}
				}
				continue;
				IL_0082:
				break;
				IL_0085:
				if (!(type_0 != typeof(object)))
				{
					break;
				}
				IL_0097:
				if (object_0 == null)
				{
					break;
				}
				IL_009A:
				return object_0.IsNullable;
			}
			return false;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0005CC38 File Offset: 0x0005AE38
		internal string GetExpectedDescription(JsonContract contract)
		{
			for (;;)
			{
				JsonContractType contractType = contract.ContractType;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					goto IL_0003;
				}
				IL_0039:
				switch (num)
				{
				case 1:
					IL_0003:
					switch (contractType)
					{
					case JsonContractType.Object:
					case JsonContractType.Dictionary:
					case JsonContractType.Dynamic:
					case JsonContractType.Serializable:
						goto IL_00B6;
					case JsonContractType.Array:
						goto IL_0074;
					case JsonContractType.Primitive:
						goto IL_008A;
					case JsonContractType.String:
						goto IL_00A0;
					default:
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
						{
							goto IL_0039;
						}
						break;
					}
					break;
				case 2:
					continue;
				case 3:
					goto IL_00B6;
				}
				break;
			}
			throw new ArgumentOutOfRangeException();
			IL_0074:
			return Class15.smethod_17(1802309411 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4);
			IL_008A:
			return Class15.smethod_17(1116199853 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54);
			IL_00A0:
			return Class15.smethod_17(1176487170 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af);
			IL_00B6:
			return Class15.smethod_17(635778001 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0005CD10 File Offset: 0x0005AF10
		[NullableContext(2)]
		private JsonConverter method_7(JsonContract jsonContract_0, JsonConverter jsonConverter_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_0)
		{
			JsonConverter jsonConverter;
			JsonConverter matchingConverter;
			for (;;)
			{
				IL_0198:
				jsonConverter = null;
				IL_018F:
				while (jsonConverter_0 == null)
				{
					int num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
					{
						goto IL_001B;
					}
					for (;;)
					{
						IL_0120:
						switch (num)
						{
						case 1:
							if (jsonContract_0.Converter == null)
							{
								goto IL_00E4;
							}
							num = 10;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_00C5;
						case 3:
							goto IL_0042;
						case 4:
						case 16:
							goto IL_00A8;
						case 5:
							goto IL_001F;
						case 6:
							goto IL_00F7;
						case 7:
							goto IL_0045;
						case 8:
						case 9:
						case 12:
						case 13:
						case 17:
						case 19:
							return jsonConverter;
						case 10:
							goto IL_019D;
						case 11:
						case 22:
							goto IL_001B;
						case 14:
							goto IL_0050;
						case 15:
							goto IL_00E4;
						case 18:
							goto IL_0072;
						case 20:
							goto IL_018F;
						case 21:
							goto IL_0198;
						case 23:
							goto IL_01AD;
						case 24:
							goto IL_01B3;
						}
						break;
					}
					goto IL_008D;
					IL_00F7:
					if (matchingConverter == null)
					{
						goto IL_00A8;
					}
					goto IL_01AD;
					IL_00E4:
					matchingConverter = this.Serializer.GetMatchingConverter(jsonContract_0.UnderlyingType);
					goto IL_00F7;
					IL_0029:
					bool flag;
					if (!flag)
					{
						goto IL_0042;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
					{
						goto IL_008D;
					}
					goto IL_0120;
					IL_001F:
					flag = null != null;
					goto IL_0029;
					IL_001B:
					if (jsonProperty_0 == null)
					{
						goto IL_001F;
					}
					flag = jsonProperty_0.ItemConverter != null;
					goto IL_0029;
					IL_0050:
					jsonConverter = jsonContainerContract_0.ItemConverter;
					num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
					{
						goto Block_3;
					}
					goto IL_0120;
					IL_004E:
					bool flag2;
					if (flag2)
					{
						goto IL_0050;
					}
					goto IL_0072;
					IL_0042:
					if (jsonContainerContract_0 != null)
					{
						flag2 = jsonContainerContract_0.ItemConverter != null;
						goto IL_004E;
					}
					IL_0045:
					flag2 = null != null;
					goto IL_004E;
					IL_0072:
					if (jsonContract_0 == null)
					{
						return jsonConverter;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
					{
						goto IL_0120;
					}
					IL_008D:
					jsonConverter = jsonProperty_0.ItemConverter;
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
					{
						goto IL_0120;
					}
					IL_00A8:
					if (jsonContract_0.InternalConverter == null)
					{
						return jsonConverter;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
					{
						goto IL_0120;
					}
					IL_00C5:
					jsonConverter = jsonContract_0.InternalConverter;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
					{
						goto Block_6;
					}
					goto IL_0120;
				}
				goto IL_01B3;
			}
			Block_3:
			Block_6:
			return jsonConverter;
			IL_019D:
			return jsonContract_0.Converter;
			IL_01AD:
			return matchingConverter;
			IL_01B3:
			jsonConverter = jsonConverter_0;
			return jsonConverter;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0005CED8 File Offset: 0x0005B0D8
		[NullableContext(2)]
		private object method_8([Nullable(1)] JsonReader reader, Type type_0, JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, object object_0)
		{
			Type type;
			object obj;
			object obj3;
			JsonDictionaryContract jsonDictionaryContract;
			IDictionary dictionary;
			string text;
			Interface1 @interface;
			bool flag2;
			JsonDynamicContract jsonDynamicContract;
			JsonObjectContract jsonObjectContract;
			string text2;
			for (;;)
			{
				IL_05A1:
				type = type_0;
				for (;;)
				{
					IL_058D:
					if (this.Serializer.MetadataPropertyHandling == MetadataPropertyHandling.Ignore)
					{
						goto IL_039A;
					}
					goto IL_0579;
					int num;
					JTokenReader jtokenReader;
					object obj2;
					object obj4;
					for (;;)
					{
						IL_03E8:
						bool flag;
						switch (num)
						{
						case 1:
							goto IL_0082;
						case 2:
							goto IL_0648;
						case 3:
							goto IL_0248;
						case 4:
							goto IL_014B;
						case 5:
							goto IL_06A5;
						case 6:
							jtokenReader.SupportMultipleContent = reader.SupportMultipleContent;
							goto IL_01EE;
						case 7:
							goto IL_06D1;
						case 8:
							goto IL_03B7;
						case 9:
						case 13:
						case 16:
							goto IL_052E;
						case 10:
							goto IL_010F;
						case 11:
							return obj;
						case 12:
							goto IL_0164;
						case 14:
							return obj2;
						case 15:
							goto IL_05BE;
						case 17:
							goto IL_0511;
						case 18:
							goto IL_05A6;
						case 19:
							goto IL_05E3;
						case 20:
						case 28:
							goto IL_0291;
						case 21:
							goto IL_00E0;
						case 22:
							goto IL_039A;
						case 23:
							goto IL_037B;
						case 24:
							goto IL_008E;
						case 25:
							goto IL_0655;
						case 26:
							goto IL_011C;
						case 27:
							goto IL_076C;
						case 29:
						case 48:
							goto IL_0688;
						case 30:
							goto IL_0325;
						case 31:
							goto IL_002F;
						case 32:
							goto IL_00ED;
						case 33:
							goto IL_0579;
						case 34:
						case 65:
							return obj3;
						case 35:
							goto IL_02E6;
						case 36:
							goto IL_01F5;
						case 37:
							goto IL_0225;
						case 38:
							goto IL_058D;
						case 39:
							goto IL_05A1;
						case 40:
							goto IL_0540;
						case 41:
							goto IL_05C9;
						case 42:
							goto IL_06FD;
						case 43:
							dictionary = this.method_20(reader, jsonDictionaryContract, out flag);
							goto IL_002B;
						case 44:
							goto IL_00AE;
						case 45:
							goto IL_00A5;
						case 46:
							goto IL_065F;
						case 47:
							goto IL_0759;
						case 49:
							goto IL_050B;
						case 50:
							goto IL_01EE;
						case 51:
						case 66:
							goto IL_0675;
						case 52:
							goto IL_0761;
						case 53:
							goto IL_017B;
						case 54:
							goto IL_009E;
						case 55:
							goto IL_066F;
						case 56:
							goto IL_0729;
						case 57:
							goto IL_068C;
						case 58:
							goto IL_0784;
						case 59:
							goto IL_01CC;
						case 60:
							goto IL_0129;
						case 61:
							return obj4;
						case 62:
							goto IL_05DA;
						case 63:
							goto IL_0631;
						case 64:
							goto IL_004B;
						case 67:
							goto IL_0651;
						case 68:
							goto IL_00D3;
						case 69:
							goto IL_002B;
						}
						break;
						IL_002F:
						if (text != null)
						{
							goto IL_0729;
						}
						num = 39;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
						{
							goto IL_004B;
						}
						continue;
						IL_002B:
						if (flag)
						{
							goto IL_002F;
						}
						goto IL_008E;
						IL_004B:
						if (jsonContract_0.OnSerializingCallbacks.Count > 0)
						{
							goto IL_06FD;
						}
						if (jsonContract_0.OnErrorCallbacks.Count > 0)
						{
							goto IL_06D1;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
						{
							goto IL_0082;
						}
						continue;
						IL_00AE:
						if (@interface != null)
						{
							goto IL_0759;
						}
						obj3 = dictionary;
						num = 24;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
						{
							goto Block_6;
						}
						continue;
						IL_00A5:
						@interface = dictionary as Interface1;
						goto IL_00AE;
						IL_009E:
						if (!flag)
						{
							goto IL_00A5;
						}
						goto IL_0761;
						IL_008E:
						this.method_23(dictionary, reader, jsonDictionaryContract, jsonProperty_0, text);
						goto IL_009E;
						IL_0082:
						if (jsonDictionaryContract.HasParameterizedCreatorInternal)
						{
							goto IL_008E;
						}
						goto IL_06A5;
						IL_01F5:
						reader = jtokenReader;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
						{
							goto Block_13;
						}
						continue;
						IL_01EE:
						jtokenReader.ReadAndAssert();
						goto IL_01F5;
					}
					goto IL_0266;
					Block_13:
					goto IL_0511;
					IL_050B:
					text = null;
					goto IL_052E;
					IL_00ED:
					jtokenReader.DateFormatString = reader.DateFormatString;
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
					{
						goto IL_010F;
					}
					goto IL_03E8;
					IL_00E0:
					jtokenReader.Culture = reader.Culture;
					goto IL_00ED;
					IL_0164:
					jtokenReader = (JTokenReader)JToken.ReadFrom(reader).CreateReader();
					goto IL_00E0;
					IL_00D3:
					if (jtokenReader == null)
					{
						goto IL_0164;
					}
					goto IL_0511;
					IL_0129:
					jtokenReader.FloatParseHandling = reader.FloatParseHandling;
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						goto IL_014B;
					}
					goto IL_03E8;
					IL_011C:
					jtokenReader.DateTimeZoneHandling = reader.DateTimeZoneHandling;
					goto IL_0129;
					IL_010F:
					jtokenReader.DateParseHandling = reader.DateParseHandling;
					goto IL_011C;
					IL_014B:
					if (object_0 != null)
					{
						goto IL_017B;
					}
					num = 43;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
					{
						goto IL_0164;
					}
					goto IL_03E8;
					IL_02E6:
					JsonContractType contractType;
					switch (contractType)
					{
					case JsonContractType.Object:
						IL_0325:
						flag2 = false;
						goto IL_01CC;
					case JsonContractType.Array:
					case JsonContractType.String:
						goto IL_0291;
					case JsonContractType.Primitive:
					{
						JsonPrimitiveContract jsonPrimitiveContract = (JsonPrimitiveContract)jsonContract_0;
						num = 17;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
						{
							goto IL_0225;
						}
						goto IL_03E8;
					}
					case JsonContractType.Dictionary:
						jsonDictionaryContract = (JsonDictionaryContract)jsonContract_0;
						goto IL_014B;
					case JsonContractType.Dynamic:
						jsonDynamicContract = (JsonDynamicContract)jsonContract_0;
						num = 18;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
						{
							goto IL_0266;
						}
						goto IL_03E8;
					case JsonContractType.Serializable:
						goto IL_05B4;
					default:
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
						{
							goto IL_0291;
						}
						goto IL_03E8;
					}
					IL_017B:
					IDictionary dictionary2;
					if (!jsonDictionaryContract.ShouldCreateWrapper && object_0 is IDictionary)
					{
						dictionary2 = (IDictionary)object_0;
					}
					else
					{
						IDictionary dictionary3 = jsonDictionaryContract.CreateWrapper(object_0);
						dictionary2 = dictionary3;
					}
					obj3 = this.method_23(dictionary2, reader, jsonDictionaryContract, jsonProperty_0, text);
					num = 65;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
					{
						goto Block_11;
					}
					goto IL_03E8;
					IL_01CC:
					jsonObjectContract = (JsonObjectContract)jsonContract_0;
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						goto Block_12;
					}
					goto IL_03E8;
					IL_0225:
					if (this.Serializer.MetadataPropertyHandling == MetadataPropertyHandling.Ignore)
					{
						goto IL_0291;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
					{
						goto IL_03E8;
					}
					IL_0248:
					if (reader.TokenType == JsonToken.PropertyName)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
						{
							goto IL_0266;
						}
						goto IL_03E8;
					}
					IL_0291:
					text2 = Class15.smethod_17(1802308335 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4) + Environment.NewLine + Class15.smethod_17(1788786845 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c) + Environment.NewLine;
					num = 58;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
					{
						goto Block_16;
					}
					goto IL_03E8;
					IL_0266:
					if (!string.Equals(reader.Value.ToString(), Class15.smethod_17(1760301497 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039), StringComparison.Ordinal))
					{
						goto IL_0291;
					}
					goto IL_05BE;
					IL_037B:
					contractType = jsonContract_0.ContractType;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
					{
						goto IL_02E6;
					}
					goto IL_03E8;
					IL_039A:
					reader.ReadAndAssert();
					num = 49;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
					{
						goto IL_00E0;
					}
					goto IL_03E8;
					IL_03B7:
					jtokenReader = reader as JTokenReader;
					num = 51;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
					{
						goto IL_00D3;
					}
					goto IL_03E8;
					IL_052E:
					if (this.voKyBvryj8(jsonContract_0))
					{
						goto IL_0784;
					}
					num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
					{
						goto IL_037B;
					}
					goto IL_03E8;
					IL_0540:
					if (!this.method_10(reader, ref type, ref jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1, object_0, out obj4, out text))
					{
						goto IL_052E;
					}
					return obj4;
					IL_0579:
					if (this.Serializer.MetadataPropertyHandling != MetadataPropertyHandling.ReadAhead)
					{
						reader.ReadAndAssert();
						goto IL_0540;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
					{
						goto IL_03B7;
					}
					goto IL_03E8;
					IL_0511:
					if (!this.method_9(jtokenReader, ref type, ref jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1, object_0, out obj2, out text))
					{
						goto IL_052E;
					}
					return obj2;
				}
			}
			Block_6:
			return obj3;
			Block_11:
			goto IL_06D1;
			Block_12:
			goto IL_0651;
			Block_16:
			goto IL_0631;
			IL_05A6:
			return this.method_28(reader, jsonDynamicContract, jsonProperty_0, text);
			IL_05B4:
			JsonISerializableContract jsonISerializableContract = (JsonISerializableContract)jsonContract_0;
			goto IL_05C9;
			IL_05BE:
			reader.ReadAndAssert();
			goto IL_05DA;
			IL_05C9:
			return this.method_27(reader, jsonISerializableContract, jsonProperty_0, text);
			IL_05DA:
			if (reader.TokenType != JsonToken.StartObject)
			{
				JsonPrimitiveContract jsonPrimitiveContract;
				object obj5 = this.method_6(reader, type, jsonPrimitiveContract, jsonProperty_0, null, null, object_0);
				reader.ReadAndAssert();
				return obj5;
			}
			IL_05E3:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(538772429 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa) + reader.TokenType.ToString());
			IL_0631:
			text2 = text2.FormatWith(CultureInfo.InvariantCulture, type, this.GetExpectedDescription(jsonContract_0));
			IL_0648:
			throw JsonSerializationException.Create(reader, text2);
			IL_0651:
			if (object_0 == null)
			{
				goto IL_0675;
			}
			IL_0655:
			if (type == type_0)
			{
				goto IL_066F;
			}
			IL_065F:
			if (!type.IsAssignableFrom(object_0.GetType()))
			{
				goto IL_0675;
			}
			IL_066F:
			obj = object_0;
			goto IL_0688;
			IL_0675:
			obj = this.CreateNewObject(reader, jsonObjectContract, jsonProperty_0, jsonProperty_1, text, out flag2);
			IL_0688:
			if (flag2)
			{
				return obj;
			}
			IL_068C:
			return this.method_32(obj, reader, jsonObjectContract, jsonProperty_0, text);
			IL_06A5:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(594398838 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b).FormatWith(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
			IL_06D1:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(974415003 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f).FormatWith(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
			IL_06FD:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1424608386 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf).FormatWith(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
			IL_0729:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(2071429648 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808).FormatWith(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
			IL_0759:
			return @interface.UnderlyingDictionary;
			IL_0761:
			ObjectConstructor<object> objectConstructor;
			if ((objectConstructor = jsonDictionaryContract.OverrideCreator) != null)
			{
				goto IL_0773;
			}
			IL_076C:
			objectConstructor = jsonDictionaryContract.ParameterizedCreator;
			IL_0773:
			return objectConstructor(new object[] { dictionary });
			IL_0784:
			return this.method_5(reader);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0005D674 File Offset: 0x0005B874
		[NullableContext(2)]
		private bool method_9([Nullable(1)] JTokenReader reader, ref Type type_0, ref JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, object object_0, out object object_1, out string string_0)
		{
			JToken value;
			JToken jtoken;
			JToken jtoken5;
			for (;;)
			{
				IL_04A1:
				string_0 = null;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
				{
					goto IL_035F;
				}
				JObject jobject;
				JToken jtoken2;
				string text2;
				for (;;)
				{
					IL_03DA:
					string text;
					switch (num)
					{
					case 0:
						goto IL_029B;
					case 1:
						goto IL_00CE;
					case 2:
					case 45:
						goto IL_00EF;
					case 3:
						goto IL_0111;
					case 4:
						goto IL_0503;
					case 5:
						goto IL_0304;
					case 6:
						goto IL_0560;
					case 7:
						goto IL_0245;
					case 8:
						goto IL_057C;
					case 9:
						goto IL_0199;
					case 10:
					case 12:
						goto IL_0175;
					case 11:
						goto IL_00A0;
					case 13:
					case 31:
						goto IL_0029;
					case 14:
						return false;
					case 15:
						goto IL_0324;
					case 16:
						if (value.Type != JTokenType.String)
						{
							goto IL_02CE;
						}
						goto IL_02DF;
					case 17:
						if (reader.TokenType != JsonToken.StartObject)
						{
							goto IL_0155;
						}
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
						{
							goto IL_0215;
						}
						continue;
					case 18:
						IL_032D:
						if (jtoken != null)
						{
							goto IL_0503;
						}
						num = 30;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
						{
							goto Block_12;
						}
						continue;
					case 19:
						goto IL_0222;
					case 20:
						goto IL_0190;
					case 21:
						return false;
					case 22:
						goto IL_0241;
					case 23:
						goto IL_04BF;
					case 24:
						goto IL_0049;
					case 25:
						goto IL_0559;
					case 26:
						IL_02E8:
						if (text == null)
						{
							goto IL_0268;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
						{
							goto IL_0304;
						}
						continue;
					case 27:
						goto IL_014E;
					case 28:
						goto IL_02C0;
					case 29:
						goto IL_01F5;
					case 30:
						object_1 = this.Serializer.GetReferenceResolver().ResolveReference(this, text);
						num = 34;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
						{
							goto IL_034E;
						}
						continue;
					case 32:
						goto IL_035F;
					case 33:
						goto IL_04A1;
					case 34:
					case 38:
						goto IL_0130;
					case 35:
						return true;
					case 36:
						goto IL_034E;
					case 37:
						goto IL_02A2;
					case 39:
						goto IL_02CE;
					case 40:
						goto IL_0550;
					case 41:
						goto IL_00A7;
					case 42:
						return true;
					case 43:
						goto IL_0215;
					case 44:
						goto IL_010D;
					case 46:
						break;
					default:
						goto IL_029B;
					}
					IL_0006:
					if (this.TraceWriter.LevelFilter >= TraceLevel.Info)
					{
						goto IL_0049;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
					{
						goto IL_0029;
					}
					continue;
					IL_034E:
					if (this.TraceWriter != null)
					{
						goto IL_0006;
					}
					IL_0029:
					reader.Skip();
					num = 30;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
					{
						goto Block_2;
					}
					continue;
					IL_0049:
					this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(reader, reader.Path, Class15.smethod_17(698973590 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a).FormatWith(CultureInfo.InvariantCulture, text, object_1.GetType())), null);
					num = 31;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
					{
						goto IL_00A0;
					}
					continue;
					IL_0245:
					JProperty jproperty;
					value = jproperty.Value;
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						goto Block_7;
					}
					continue;
					IL_0241:
					if (jproperty != null)
					{
						goto IL_0245;
					}
					goto IL_0268;
					IL_0222:
					jproperty = jobject.Property(Class15.smethod_17(197557931 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81), StringComparison.Ordinal);
					goto IL_0241;
					IL_0215:
					jobject = (JObject)reader.CurrentToken;
					goto IL_0222;
					IL_0268:
					jtoken2 = jobject[Class15.smethod_17(1116173919 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54)];
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
					{
						goto IL_029B;
					}
					continue;
					IL_02DF:
					text = (string)jproperty;
					goto IL_02E8;
					IL_02CE:
					if (value.Type != JTokenType.Null)
					{
						goto Block_8;
					}
					goto IL_02DF;
					IL_02A2:
					text2 = (string)jtoken2;
					num = 21;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
					{
						break;
					}
					continue;
					IL_029B:
					if (jtoken2 != null)
					{
						goto IL_02A2;
					}
					goto IL_00EF;
					IL_0304:
					JToken jtoken3;
					if ((jtoken3 = jproperty.Next) == null)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
						{
							goto IL_0324;
						}
						continue;
					}
					IL_032B:
					jtoken = jtoken3;
					goto IL_032D;
					IL_0324:
					jtoken3 = jproperty.Previous;
					goto IL_032B;
				}
				IL_02C0:
				JsonReader jsonReader = jtoken2.CreateReader();
				goto IL_00A0;
				Block_12:
				goto IL_02C0;
				IL_00A7:
				this.method_11(jsonReader, ref type_0, ref jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1, text2);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
				{
					goto IL_00CE;
				}
				goto IL_03DA;
				IL_00A0:
				jsonReader.ReadAndAssert();
				goto IL_00A7;
				IL_0111:
				JToken jtoken4;
				string_0 = (string)jtoken4;
				num = 38;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
				{
					goto IL_0130;
				}
				goto IL_03DA;
				IL_010D:
				if (jtoken4 != null)
				{
					goto IL_0111;
				}
				goto IL_0130;
				IL_00EF:
				jtoken4 = jobject[Class15.smethod_17(1760313533 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039)];
				goto IL_010D;
				IL_00CE:
				if (jobject[Class15.smethod_17(89044988 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454)] == null)
				{
					goto IL_00EF;
				}
				goto IL_0175;
				IL_0155:
				reader.ReadAndAssert();
				num = 21;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
				{
					goto Block_3;
				}
				goto IL_03DA;
				IL_014E:
				if (jtoken5 == null)
				{
					goto IL_0155;
				}
				goto IL_0550;
				IL_0130:
				jtoken5 = jobject[Class15.smethod_17(2008581771 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb)];
				goto IL_014E;
				IL_0175:
				reader.ReadAndAssert();
				num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
				{
					goto IL_0190;
				}
				goto IL_03DA;
				IL_0199:
				if (!((string)reader.Value == Class15.smethod_17(1176463430 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af)))
				{
					goto IL_01DA;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
				{
					goto Block_5;
				}
				goto IL_03DA;
				IL_0190:
				if (reader.TokenType == JsonToken.PropertyName)
				{
					goto IL_0199;
				}
				IL_01DA:
				reader.ReadAndAssert();
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
				{
					goto IL_03DA;
				}
				IL_01F5:
				reader.Skip();
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
				{
					goto Block_6;
				}
				goto IL_03DA;
				IL_035F:
				object_1 = null;
				num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
				{
					goto IL_00A0;
				}
				goto IL_03DA;
			}
			Block_2:
			return true;
			Block_3:
			return false;
			Block_5:
			return false;
			Block_6:
			Block_7:
			goto IL_057C;
			Block_8:
			IL_04BF:
			throw JsonSerializationException.Create(value, value.Path, Class15.smethod_17(1243221932 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95).FormatWith(CultureInfo.InvariantCulture, Class15.smethod_17(2048572063 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18)), null);
			IL_0503:
			throw JsonSerializationException.Create(jtoken, jtoken.Path, Class15.smethod_17(2060641904 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177).FormatWith(CultureInfo.InvariantCulture, Class15.smethod_17(314802971 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927)), null);
			IL_0550:
			JsonReader jsonReader2 = jtoken5.CreateReader();
			IL_0559:
			jsonReader2.ReadAndAssert();
			IL_0560:
			object_1 = this.method_13(jsonReader2, type_0, jsonContract_0, jsonProperty_0, object_0, string_0);
			IL_057C:
			reader.Skip();
			return true;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0005DC04 File Offset: 0x0005BE04
		[NullableContext(2)]
		private bool method_10([Nullable(1)] JsonReader reader, ref Type type_0, ref JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, object object_0, out object object_1, out string string_0)
		{
			string text4;
			for (;;)
			{
				IL_0457:
				string_0 = null;
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
				{
					goto IL_0375;
				}
				string text;
				string text2;
				object value;
				for (;;)
				{
					IL_0388:
					switch (num)
					{
					case 1:
					case 29:
					case 37:
						return true;
					case 2:
						goto IL_04FC;
					case 3:
						if (reader.TokenType != JsonToken.String)
						{
							goto IL_0328;
						}
						goto IL_0338;
					case 4:
					case 13:
					case 20:
					case 34:
						goto IL_0251;
					case 5:
						goto IL_013B;
					case 6:
						goto IL_0375;
					case 7:
						goto IL_0457;
					case 8:
						goto IL_01DB;
					case 9:
						goto IL_0363;
					case 10:
					case 27:
						goto IL_00A8;
					case 11:
						goto IL_004F;
					case 12:
						goto IL_02D7;
					case 14:
						goto IL_0159;
					case 15:
						goto IL_002C;
					case 16:
						return true;
					case 17:
						goto IL_04BE;
					case 18:
						goto IL_0175;
					case 19:
						goto IL_005E;
					case 21:
						goto IL_00CA;
					case 22:
						goto IL_01F5;
					case 23:
						goto IL_011B;
					case 24:
						goto IL_0121;
					case 25:
						goto IL_01BA;
					case 26:
						goto IL_0107;
					case 28:
						goto IL_0153;
					case 30:
						goto IL_0292;
					case 31:
						goto IL_01C0;
					case 32:
						goto IL_006B;
					case 33:
						goto IL_01FB;
					case 35:
						goto IL_0032;
					case 36:
						goto IL_022A;
					case 38:
						goto IL_0328;
					case 39:
						if (text[0] != '$')
						{
							return false;
						}
						num = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
						{
							goto Block_17;
						}
						continue;
					case 40:
						goto IL_01D5;
					case 41:
						goto IL_0272;
					case 42:
						goto IL_02CC;
					case 43:
					case 47:
						return false;
					case 44:
						goto IL_0477;
					case 45:
						goto IL_00EC;
					case 46:
						goto IL_021D;
					case 48:
						this.method_11(reader, ref type_0, ref jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1, text2);
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
						{
							goto IL_002C;
						}
						continue;
					}
					goto Block_23;
					IL_0338:
					value = reader.Value;
					if (value != null)
					{
						goto IL_0359;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
					{
						goto Block_20;
					}
					continue;
					IL_0328:
					if (reader.TokenType != JsonToken.Null)
					{
						goto Block_18;
					}
					goto IL_0338;
				}
				IL_002C:
				reader.ReadAndAssert();
				goto IL_0032;
				IL_0359:
				string text3 = value.ToString();
				goto IL_013C;
				Block_20:
				goto IL_013B;
				Block_23:
				goto IL_018D;
				Block_17:
				goto IL_005E;
				IL_0032:
				bool flag = true;
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
				{
					goto IL_0251;
				}
				goto IL_0388;
				IL_00EC:
				reader.ReadAndAssert();
				num = 15;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
				{
					goto IL_0107;
				}
				goto IL_0388;
				IL_00CA:
				if (string.Equals(text, Class15.smethod_17(1788664594 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1), StringComparison.Ordinal))
				{
					goto IL_00EC;
				}
				flag = false;
				goto IL_0251;
				IL_00A8:
				if (!string.Equals(text, Class15.smethod_17(2128238876 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9), StringComparison.Ordinal))
				{
					goto IL_00CA;
				}
				goto IL_01BA;
				IL_0121:
				object obj;
				object_1 = obj;
				num = 16;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
				{
					goto IL_013B;
				}
				goto IL_0388;
				IL_011B:
				reader.ReadAndAssert();
				goto IL_0121;
				IL_0107:
				obj = this.method_13(reader, type_0, jsonContract_0, jsonProperty_0, object_0, string_0);
				goto IL_011B;
				IL_013C:
				text4 = text3;
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
				{
					goto IL_0153;
				}
				goto IL_0388;
				IL_013B:
				text3 = null;
				goto IL_013C;
				IL_0159:
				if (text4 != null)
				{
					goto IL_0292;
				}
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
				{
					goto IL_0175;
				}
				goto IL_0388;
				IL_0153:
				reader.ReadAndAssert();
				goto IL_0159;
				IL_0175:
				flag = true;
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
				{
					goto IL_0388;
				}
				IL_018D:
				if (string.Equals(text, Class15.smethod_17(1760301461 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039), StringComparison.Ordinal))
				{
					goto IL_01F5;
				}
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
				{
					goto IL_00A8;
				}
				goto IL_0388;
				IL_006B:
				if (string.Equals(text, Class15.smethod_17(197557931 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81), StringComparison.Ordinal))
				{
					goto IL_0272;
				}
				goto IL_018D;
				IL_005E:
				text = reader.Value.ToString();
				goto IL_006B;
				IL_004F:
				if (reader.TokenType != JsonToken.PropertyName)
				{
					break;
				}
				goto IL_005E;
				IL_0251:
				if (flag)
				{
					goto IL_004F;
				}
				num = 47;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
				{
					goto Block_11;
				}
				goto IL_0388;
				IL_01DB:
				flag = true;
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					goto IL_0251;
				}
				goto IL_0388;
				IL_01D5:
				reader.ReadAndAssert();
				goto IL_01DB;
				IL_01C0:
				object value2 = reader.Value;
				string_0 = ((value2 == null) ? null : value2.ToString());
				goto IL_01D5;
				IL_01BA:
				reader.ReadAndAssert();
				goto IL_01C0;
				IL_01FB:
				text2 = reader.Value.ToString();
				num = 48;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
				{
					goto IL_021D;
				}
				goto IL_0388;
				IL_01F5:
				reader.ReadAndAssert();
				goto IL_01FB;
				IL_022A:
				if (text.Length <= 0)
				{
					break;
				}
				num = 39;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
				{
					goto IL_0032;
				}
				goto IL_0388;
				IL_021D:
				text = reader.Value.ToString();
				goto IL_022A;
				IL_0363:
				if (reader.TokenType == JsonToken.PropertyName)
				{
					goto IL_021D;
				}
				break;
				IL_0375:
				object_1 = null;
				goto IL_0363;
				IL_0272:
				reader.ReadAndAssert();
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
				{
					goto Block_12;
				}
				goto IL_0388;
				IL_0292:
				if (reader.TokenType == JsonToken.PropertyName)
				{
					goto Block_13;
				}
				object_1 = this.Serializer.GetReferenceResolver().ResolveReference(this, text4);
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
				{
					goto IL_02CC;
				}
				goto IL_0388;
				IL_02D7:
				if (this.TraceWriter.LevelFilter >= TraceLevel.Info)
				{
					goto IL_04FC;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
				{
					goto Block_15;
				}
				goto IL_0388;
				IL_02CC:
				if (this.TraceWriter != null)
				{
					goto IL_02D7;
				}
				return true;
			}
			return false;
			Block_11:
			Block_12:
			return true;
			Block_13:
			goto IL_04BE;
			Block_15:
			return true;
			Block_18:
			IL_0477:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(486494308 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c).FormatWith(CultureInfo.InvariantCulture, Class15.smethod_17(277673934 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98)));
			IL_04BE:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1743137490 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8).FormatWith(CultureInfo.InvariantCulture, Class15.smethod_17(2071432490 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808)));
			IL_04FC:
			this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(reader as IJsonLineInfo, reader.Path, Class15.smethod_17(41477375 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d).FormatWith(CultureInfo.InvariantCulture, text4, object_1.GetType())), null);
			return true;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0005E158 File Offset: 0x0005C358
		[NullableContext(2)]
		private void method_11([Nullable(1)] JsonReader reader, ref Type type_0, ref JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, [Nullable(1)] string qualifiedTypeName)
		{
			Type type;
			for (;;)
			{
				IL_038C:
				if (jsonProperty_0 == null)
				{
					goto IL_036B;
				}
				TypeNameHandling? typeNameHandling = jsonProperty_0.TypeNameHandling;
				IL_0375:
				TypeNameHandling? typeNameHandling2 = typeNameHandling;
				int num = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
				{
					continue;
				}
				TypeNameHandling? typeNameHandling5;
				for (;;)
				{
					TypeNameHandling? typeNameHandling4;
					TypeNameHandling? typeNameHandling3;
					bool flag;
					switch (num)
					{
					case 0:
						goto IL_0212;
					case 1:
					case 26:
						goto IL_0189;
					case 2:
						goto IL_0150;
					case 3:
						goto IL_0024;
					case 4:
						goto IL_0052;
					case 5:
						goto IL_0373;
					case 6:
						typeNameHandling3 = typeNameHandling4;
						goto IL_02AC;
					case 7:
						goto IL_036B;
					case 8:
						goto IL_038C;
					case 9:
						goto IL_002D;
					case 10:
						goto IL_0166;
					case 11:
					case 18:
						goto IL_0146;
					case 12:
						goto IL_00F9;
					case 13:
						if (typeNameHandling2 == null)
						{
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
							{
								goto IL_0282;
							}
							continue;
						}
						else
						{
							flag = typeNameHandling2.GetValueOrDefault() != TypeNameHandling.None;
						}
						break;
					case 14:
						IL_001B:
						if (typeNameHandling4 != null)
						{
							goto IL_0024;
						}
						goto IL_002D;
					case 15:
						goto IL_0286;
					case 16:
						return;
					case 17:
						goto IL_0282;
					case 19:
						goto IL_0138;
					case 20:
						goto IL_0248;
					case 21:
						goto IL_0266;
					case 22:
						goto IL_01A2;
					case 23:
						goto IL_0070;
					case 24:
						goto IL_03A2;
					case 25:
						goto IL_0396;
					case 27:
						IL_0225:
						if (typeNameHandling5 == null)
						{
							goto IL_0248;
						}
						num = 28;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
						{
							goto IL_0189;
						}
						continue;
					case 28:
						flag = typeNameHandling5.GetValueOrDefault() != TypeNameHandling.None;
						break;
					case 29:
						goto IL_03D6;
					case 30:
						goto IL_011B;
					case 31:
						goto IL_0012;
					default:
						goto IL_0212;
					}
					IL_0038:
					if (!flag)
					{
						return;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
					{
						goto IL_0052;
					}
					continue;
					IL_0024:
					flag = typeNameHandling4.GetValueOrDefault() != TypeNameHandling.None;
					goto IL_0038;
					IL_0019:
					TypeNameHandling? typeNameHandling6;
					typeNameHandling4 = typeNameHandling6;
					goto IL_001B;
					IL_0012:
					typeNameHandling6 = jsonProperty_1.ItemTypeNameHandling;
					goto IL_0019;
					IL_0052:
					StructMultiKey<string, string> structMultiKey = ReflectionUtils.SplitFullyQualifiedTypeName(qualifiedTypeName);
					num = 20;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
					{
						goto IL_0070;
					}
					continue;
					IL_00F9:
					if (type == null)
					{
						goto IL_03D6;
					}
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
					{
						goto IL_011B;
					}
					continue;
					IL_0070:
					try
					{
						type = this.Serializer._serializationBinder.BindToType(structMultiKey.Value1, structMultiKey.Value2);
						int num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
						{
							switch (num2)
							{
							}
						}
					}
					catch (Exception ex)
					{
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
						{
							switch (num3)
							{
							}
						}
						throw JsonSerializationException.Create(reader, Class15.smethod_17(2060640558 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177).FormatWith(CultureInfo.InvariantCulture, qualifiedTypeName), ex);
					}
					goto IL_00F9;
					IL_011B:
					if (this.TraceWriter == null)
					{
						goto IL_0146;
					}
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
					{
						goto IL_0138;
					}
					continue;
					IL_0166:
					if (!type_0.IsAssignableFrom(type))
					{
						goto IL_03A2;
					}
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
					{
						goto IL_0189;
					}
					continue;
					IL_0150:
					if (type_0 != typeof(IDynamicMetaObjectProvider))
					{
						goto IL_0166;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
					{
						goto IL_0212;
					}
					continue;
					IL_0146:
					if (type_0 != null)
					{
						goto IL_0150;
					}
					goto IL_0189;
					IL_0138:
					if (this.TraceWriter.LevelFilter < TraceLevel.Verbose)
					{
						goto IL_0146;
					}
					goto IL_01A2;
					IL_0189:
					type_0 = type;
					num = 25;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
					{
						continue;
					}
					IL_01A2:
					this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(reader as IJsonLineInfo, reader.Path, Class15.smethod_17(1116198163 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54).FormatWith(CultureInfo.InvariantCulture, qualifiedTypeName, type)), null);
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
					{
						goto IL_0052;
					}
					continue;
					IL_02AC:
					typeNameHandling5 = typeNameHandling3;
					goto IL_0225;
					IL_0282:
					if (jsonContainerContract_0 == null)
					{
						goto IL_0286;
					}
					typeNameHandling3 = jsonContainerContract_0.ItemTypeNameHandling;
					goto IL_02AC;
					IL_0248:
					if (jsonProperty_1 != null)
					{
						num = 24;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
						{
							goto IL_0012;
						}
						continue;
					}
					IL_0266:
					TypeNameHandling? typeNameHandling7 = null;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						goto IL_0212;
					}
					continue;
					IL_0286:
					typeNameHandling4 = null;
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
					{
						goto IL_0150;
					}
					continue;
					IL_002D:
					flag = this.Serializer._typeNameHandling != TypeNameHandling.None;
					goto IL_0038;
					IL_0212:
					typeNameHandling6 = typeNameHandling7;
					goto IL_0019;
				}
				IL_0373:
				typeNameHandling = typeNameHandling5;
				goto IL_0375;
				IL_036B:
				typeNameHandling5 = null;
				goto IL_0373;
			}
			IL_0396:
			jsonContract_0 = this.method_2(type);
			return;
			IL_03A2:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1829576573 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae).FormatWith(CultureInfo.InvariantCulture, type.AssemblyQualifiedName, type_0.AssemblyQualifiedName));
			IL_03D6:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(299917889 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e).FormatWith(CultureInfo.InvariantCulture, qualifiedTypeName));
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0005E574 File Offset: 0x0005C774
		private JsonArrayContract method_12(JsonReader jsonReader_0, Type type_0, JsonContract jsonContract_0)
		{
			while (jsonContract_0 != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
				{
					switch (num)
					{
					case 0:
						goto IL_0095;
					case 1:
						break;
					case 2:
						continue;
					default:
						goto IL_0095;
					}
				}
				JsonArrayContract jsonArrayContract = jsonContract_0 as JsonArrayContract;
				if (jsonArrayContract == null)
				{
					string text = Class15.smethod_17(676667082 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b) + Environment.NewLine + Class15.smethod_17(124806916 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719) + Environment.NewLine;
					text = text.FormatWith(CultureInfo.InvariantCulture, type_0, this.GetExpectedDescription(jsonContract_0));
					throw JsonSerializationException.Create(jsonReader_0, text);
				}
				return jsonArrayContract;
			}
			IL_0095:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(314803747 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927).FormatWith(CultureInfo.InvariantCulture, type_0));
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0005E640 File Offset: 0x0005C840
		[NullableContext(2)]
		private object method_13([Nullable(1)] JsonReader reader, Type type_0, JsonContract jsonContract_0, JsonProperty jsonProperty_0, object object_0, string string_0)
		{
			IL_029C:
			while (!this.voKyBvryj8(jsonContract_0))
			{
				JsonArrayContract jsonArrayContract;
				IList list;
				object obj;
				Interface0 @interface;
				ObjectConstructor<object> objectConstructor;
				for (;;)
				{
					IL_028F:
					jsonArrayContract = this.method_12(reader, type_0, jsonContract_0);
					IL_0287:
					while (object_0 == null)
					{
						for (;;)
						{
							IL_0278:
							bool flag;
							list = this.method_19(reader, jsonArrayContract, out flag);
							for (;;)
							{
								IL_026D:
								if (flag)
								{
									goto IL_015B;
								}
								goto IL_025D;
								int num;
								Array array;
								for (;;)
								{
									IL_018E:
									switch (num)
									{
									case 1:
									case 25:
										goto IL_00BB;
									case 2:
									case 13:
									case 17:
										goto IL_0021;
									case 3:
										goto IL_0050;
									case 4:
										goto IL_006D;
									case 5:
									case 19:
										goto IL_02D7;
									case 6:
										goto IL_028F;
									case 7:
										goto IL_029C;
									case 8:
										goto IL_0233;
									case 9:
										goto IL_00BF;
									case 10:
										goto IL_026D;
									case 11:
										goto IL_0061;
									case 12:
										goto IL_00E9;
									case 14:
										goto IL_0179;
									case 15:
										goto IL_0278;
									case 16:
										goto IL_00CB;
									case 18:
										goto IL_015B;
									case 20:
										goto IL_02E3;
									case 21:
										goto IL_03EE;
									case 22:
									case 27:
										return obj;
									case 23:
										goto IL_009F;
									case 24:
										list.CopyTo(array, 0);
										num = 33;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
										{
											goto Block_9;
										}
										continue;
									case 26:
										goto IL_0396;
									case 28:
										goto IL_02EC;
									case 29:
										goto IL_0115;
									case 30:
										goto IL_03C2;
									case 31:
										goto IL_0287;
									case 32:
										goto IL_0096;
									case 33:
										goto IL_0090;
									case 34:
										goto IL_0329;
									case 35:
										goto IL_0355;
									case 36:
										goto IL_038E;
									case 37:
										goto IL_003F;
									case 38:
										goto IL_0006;
									}
									goto Block_12;
								}
								IL_0050:
								if (jsonContract_0.OnErrorCallbacks.Count <= 0)
								{
									goto IL_0061;
								}
								goto IL_0396;
								IL_003F:
								if (jsonContract_0.OnSerializingCallbacks.Count <= 0)
								{
									goto IL_0050;
								}
								goto IL_03C2;
								IL_0090:
								list = array;
								IL_0021:
								obj = list;
								num = 27;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
								{
									continue;
								}
								goto IL_018E;
								IL_0006:
								list = CollectionUtils.ToMultidimensionalArray(list, jsonArrayContract.CollectionItemType, jsonContract_0.CreatedType.GetArrayRank());
								goto IL_0021;
								IL_00BF:
								if (!jsonArrayContract.IsMultidimensionalArray)
								{
									goto IL_00CB;
								}
								goto IL_0006;
								IL_00BB:
								if (flag)
								{
									goto IL_00BF;
								}
								goto IL_0096;
								IL_009F:
								if (@interface != null)
								{
									goto IL_038E;
								}
								num = 13;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
								{
									goto IL_00BB;
								}
								goto IL_018E;
								IL_0096:
								@interface = list as Interface0;
								goto IL_009F;
								IL_006D:
								if (jsonArrayContract.IsArray)
								{
									goto IL_025D;
								}
								num = 34;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
								{
									goto IL_0021;
								}
								goto IL_018E;
								IL_0061:
								if (!jsonArrayContract.HasParameterizedCreatorInternal)
								{
									goto IL_006D;
								}
								goto IL_025D;
								IL_0179:
								this.method_26(list, reader, jsonArrayContract, jsonProperty_0, string_0);
								goto IL_00BB;
								IL_025D:
								if (!jsonArrayContract.IsMultidimensionalArray)
								{
									goto IL_0179;
								}
								goto IL_0233;
								IL_00CB:
								if (!jsonArrayContract.IsArray)
								{
									goto IL_0115;
								}
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
								{
									goto IL_018E;
								}
								IL_00E9:
								array = Array.CreateInstance(jsonArrayContract.CollectionItemType, list.Count);
								num = 24;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
								{
									goto IL_0061;
								}
								goto IL_018E;
								IL_0115:
								if ((objectConstructor = jsonArrayContract.OverrideCreator) != null)
								{
									goto IL_0318;
								}
								num = 20;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
								{
									goto IL_0233;
								}
								goto IL_018E;
								IL_015B:
								if (string_0 != null)
								{
									goto IL_02AB;
								}
								num = 37;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
								{
									goto Block_11;
								}
								goto IL_018E;
								IL_0233:
								this.method_24(list, reader, jsonArrayContract, jsonProperty_0, string_0);
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
								{
									goto IL_00BB;
								}
								goto IL_018E;
							}
							Block_9:;
						}
						Block_11:
						goto IL_028F;
					}
					goto Block_16;
				}
				Block_12:
				goto IL_02AB;
				Block_16:
				goto IL_02D7;
				IL_02AB:
				throw JsonSerializationException.Create(reader, Class15.smethod_17(649921436 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff).FormatWith(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
				IL_02D7:
				if (jsonArrayContract.CanDeserialize)
				{
					goto IL_0355;
				}
				goto IL_02EC;
				IL_02E3:
				objectConstructor = jsonArrayContract.ParameterizedCreator;
				goto IL_0318;
				IL_02EC:
				throw JsonSerializationException.Create(reader, Class15.smethod_17(197550263 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81).FormatWith(CultureInfo.InvariantCulture, jsonContract_0.CreatedType));
				IL_0318:
				return objectConstructor(new object[] { list });
				IL_0329:
				throw JsonSerializationException.Create(reader, Class15.smethod_17(1571019753 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406).FormatWith(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
				IL_0355:
				IList list3;
				if (!jsonArrayContract.ShouldCreateWrapper)
				{
					IList list2 = object_0 as IList;
					if (list2 != null)
					{
						list3 = list2;
						goto IL_037D;
					}
				}
				IList list4 = jsonArrayContract.CreateWrapper(object_0);
				list3 = list4;
				IL_037D:
				obj = this.method_26(list3, reader, jsonArrayContract, jsonProperty_0, string_0);
				return obj;
				IL_038E:
				return @interface.UnderlyingCollection;
				IL_0396:
				throw JsonSerializationException.Create(reader, Class15.smethod_17(594402064 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b).FormatWith(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
				IL_03C2:
				throw JsonSerializationException.Create(reader, Class15.smethod_17(649921202 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff).FormatWith(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
			}
			IL_03EE:
			return this.method_4(reader, jsonContract_0);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0005EA44 File Offset: 0x0005CC44
		[NullableContext(2)]
		private bool voKyBvryj8(JsonContract jsonContract_0)
		{
			while (jsonContract_0 != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
				{
					goto IL_0034;
				}
				IL_005C:
				switch (num)
				{
				case 0:
					return true;
				case 1:
					IL_0034:
					if (jsonContract_0.UnderlyingType == typeof(object))
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
						{
							goto IL_005C;
						}
						return true;
					}
					break;
				case 2:
					continue;
				case 3:
					goto IL_0082;
				case 4:
					break;
				default:
					return true;
				}
				if (jsonContract_0.ContractType == JsonContractType.Linq)
				{
					break;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
				{
					goto IL_005C;
				}
				IL_0082:
				return jsonContract_0.UnderlyingType == typeof(IDynamicMetaObjectProvider);
			}
			return true;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0005EAEC File Offset: 0x0005CCEC
		[NullableContext(2)]
		private object method_14([Nullable(1)] JsonReader reader, object object_0, [Nullable(1)] CultureInfo culture, JsonContract jsonContract_0, Type type_0)
		{
			while (!(type_0 == null))
			{
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
				{
					goto IL_0078;
				}
				IL_0066:
				while (!(ReflectionUtils.GetObjectType(object_0) != type_0))
				{
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
					{
						goto IL_0078;
					}
				}
				goto IL_003D;
				IL_0078:
				switch (num)
				{
				case 0:
				case 1:
				case 4:
					goto IL_00C5;
				case 2:
					goto IL_0066;
				case 3:
					continue;
				case 5:
				case 8:
					return object_0;
				case 6:
					goto IL_003D;
				case 7:
					return object_0;
				case 9:
					break;
				case 10:
					goto IL_0341;
				default:
					goto IL_00C5;
				}
				IL_001A:
				if (jsonContract_0.IsNullable)
				{
					goto IL_0341;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
				{
					goto IL_00C5;
				}
				goto IL_0078;
				IL_003D:
				if (object_0 == null)
				{
					goto IL_001A;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
				{
					goto IL_0078;
				}
				IL_00C5:
				object obj;
				try
				{
					if (jsonContract_0.IsConvertable)
					{
						goto IL_026A;
					}
					int num2 = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
					{
						goto IL_02DB;
					}
					goto IL_01EE;
					IL_00EC:
					obj = Convert.ChangeType(object_0, jsonContract_0.NonNullableUnderlyingType, culture);
					num2 = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
					{
						goto IL_02DE;
					}
					goto IL_01EE;
					IL_0116:
					string text;
					obj = EnumUtils.ParseEnum(jsonContract_0.NonNullableUnderlyingType, null, text, false);
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
					{
						goto IL_02AC;
					}
					goto IL_01EE;
					IL_0142:
					JsonPrimitiveContract jsonPrimitiveContract;
					if (ConvertUtils.IsInteger(jsonPrimitiveContract.TypeCode))
					{
						goto IL_02DE;
					}
					IL_0158:
					if (!(object_0 is BigInteger))
					{
						goto IL_00EC;
					}
					goto IL_02B1;
					IL_0166:
					if (!(jsonContract_0.NonNullableUnderlyingType == typeof(DateTime)))
					{
						goto IL_0158;
					}
					num2 = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
					{
						goto IL_01EE;
					}
					IL_0190:
					string text2 = object_0 as string;
					IL_0198:
					if (text2 == null)
					{
						goto IL_0158;
					}
					IL_019C:
					DateTime dateTime;
					if (DateTimeUtils.TryParseDateTime(text2, reader.DateTimeZoneHandling, reader.DateFormatString, reader.Culture, out dateTime))
					{
						goto IL_0292;
					}
					goto IL_0158;
					IL_01BF:
					if (!jsonContract_0.IsEnum)
					{
						goto IL_0166;
					}
					IL_01C8:
					text = object_0 as string;
					IL_01D0:
					if (text != null)
					{
						goto IL_0116;
					}
					num2 = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
					{
						goto IL_0142;
					}
					IL_01EE:
					switch (num2)
					{
					case 0:
						goto IL_02AC;
					case 1:
						IL_026A:
						jsonPrimitiveContract = (JsonPrimitiveContract)jsonContract_0;
						num2 = 18;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
						{
							goto IL_01BF;
						}
						goto IL_01EE;
					case 2:
						goto IL_0198;
					case 3:
						goto IL_01C8;
					case 4:
						goto IL_02DB;
					case 5:
						goto IL_02DE;
					case 6:
					case 22:
						goto IL_0166;
					case 7:
					case 9:
					case 16:
						goto IL_0158;
					case 8:
						return obj;
					case 10:
						goto IL_01D0;
					case 11:
					case 27:
						obj = ConvertUtils.ConvertOrCast(object_0, culture, jsonContract_0.NonNullableUnderlyingType);
						goto IL_02DB;
					case 12:
						goto IL_0190;
					case 13:
						goto IL_019C;
					case 14:
						goto IL_02ED;
					case 15:
					case 28:
						goto IL_00EC;
					case 17:
					case 23:
						goto IL_0142;
					case 18:
						break;
					case 19:
						goto IL_02C9;
					case 20:
						goto IL_02A6;
					case 21:
						goto IL_01BF;
					case 24:
						goto IL_02B9;
					case 25:
						goto IL_0116;
					case 26:
						goto IL_02B1;
					default:
						goto IL_02AC;
					}
					IL_0292:
					obj = DateTimeUtils.EnsureDateTime(dateTime, reader.DateTimeZoneHandling);
					IL_02A6:
					IL_02AC:
					return obj;
					IL_02B1:
					BigInteger bigInteger = (BigInteger)object_0;
					IL_02B9:
					obj = ConvertUtils.FromBigInteger(bigInteger, jsonContract_0.NonNullableUnderlyingType);
					IL_02C9:
					IL_02DB:
					return obj;
					IL_02DE:
					obj = Enum.ToObject(jsonContract_0.NonNullableUnderlyingType, object_0);
					IL_02ED:;
				}
				catch (Exception ex)
				{
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
					{
						switch (num3)
						{
						}
					}
					throw JsonSerializationException.Create(reader, Class15.smethod_17(1953645745 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f).FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(object_0), type_0), ex);
				}
				return obj;
				IL_0341:
				return null;
			}
			return object_0;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0005EE5C File Offset: 0x0005D05C
		private bool method_15(JsonProperty jsonProperty_0, [Nullable(2)] JsonConverter propertyConverter, [Nullable(2)] JsonContainerContract containerContract, [Nullable(2)] JsonProperty containerProperty, JsonReader jsonReader_0, object object_0)
		{
			bool flag;
			object value;
			JsonContract jsonContract;
			bool flag2;
			bool flag3;
			while (!this.method_16(jsonProperty_0, ref propertyConverter, containerContract, containerProperty, jsonReader_0, object_0, out flag, out value, out jsonContract, out flag2, out flag3))
			{
				if (propertyConverter == null)
				{
					goto IL_0023;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
				{
					goto IL_012B;
				}
				IL_00B1:
				switch (num)
				{
				case 0:
					goto IL_0092;
				case 1:
					return true;
				case 2:
				case 11:
				case 22:
					goto IL_0204;
				case 3:
					IL_012B:
					if (propertyConverter.CanRead)
					{
						goto IL_0136;
					}
					goto IL_0023;
				case 4:
					goto IL_013A;
				case 5:
					goto IL_0023;
				case 6:
					goto IL_01AB;
				case 7:
				case 8:
					goto IL_0164;
				case 9:
					goto IL_01A3;
				case 10:
					break;
				case 12:
					goto IL_0151;
				case 13:
					goto IL_011C;
				case 14:
					goto IL_0136;
				case 15:
				case 23:
					goto IL_005D;
				case 16:
					IL_019A:
					if (flag3)
					{
						return true;
					}
					break;
				case 17:
					continue;
				case 18:
					goto IL_0142;
				case 19:
					goto IL_0071;
				case 20:
					goto IL_01B9;
				case 21:
					return true;
				default:
					goto IL_0092;
				}
				return false;
				IL_0071:
				object obj;
				jsonProperty_0.ValueProvider.SetValue(object_0, obj);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
				{
					goto IL_0092;
				}
				goto IL_00B1;
				IL_005D:
				if (this.paSyLmeWi4(jsonProperty_0, containerContract as JsonObjectContract, obj))
				{
					goto IL_0071;
				}
				return flag;
				IL_0164:
				if (!flag)
				{
					goto IL_005D;
				}
				goto IL_011C;
				IL_0151:
				obj = this.method_30(propertyConverter, jsonReader_0, jsonProperty_0.PropertyType, value);
				goto IL_0164;
				IL_0136:
				if (!flag2)
				{
					goto IL_013A;
				}
				goto IL_0151;
				IL_0023:
				obj = this.method_6(jsonReader_0, jsonProperty_0.PropertyType, jsonContract, jsonProperty_0, containerContract, containerProperty, flag ? value : null);
				goto IL_0164;
				IL_0092:
				if (jsonProperty_0.SetIsSpecified == null)
				{
					return true;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					goto IL_00B1;
				}
				goto IL_01A3;
				IL_011C:
				if (obj == value)
				{
					return flag;
				}
				num = 23;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
				{
					return true;
				}
				goto IL_00B1;
				IL_013A:
				if (!jsonProperty_0.Readable)
				{
					goto IL_0151;
				}
				IL_0142:
				value = jsonProperty_0.ValueProvider.GetValue(object_0);
				goto IL_0151;
				IL_01A3:
				if (this.TraceWriter == null)
				{
					goto IL_0204;
				}
				IL_01AB:
				if (this.TraceWriter.LevelFilter < TraceLevel.Verbose)
				{
					goto IL_0204;
				}
				IL_01B9:
				this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, Class15.smethod_17(594402686 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b).FormatWith(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName, jsonProperty_0.DeclaringType)), null);
				IL_0204:
				jsonProperty_0.SetIsSpecified(object_0, true);
				return true;
			}
			goto IL_019A;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0005F084 File Offset: 0x0005D284
		[NullableContext(2)]
		private bool method_16([Nullable(1)] JsonProperty property, ref JsonConverter jsonConverter_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_0, [Nullable(1)] JsonReader reader, [Nullable(1)] object target, out bool bool_0, out object object_0, out JsonContract jsonContract_0, out bool bool_1, out bool bool_2)
		{
			for (;;)
			{
				IL_0439:
				object_0 = null;
				for (;;)
				{
					IL_0433:
					bool_0 = false;
					for (;;)
					{
						IL_0415:
						jsonContract_0 = null;
						int num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
						{
							goto IL_0347;
						}
						for (;;)
						{
							IL_034D:
							switch (num)
							{
							case 1:
								goto IL_046F;
							case 2:
								goto IL_0165;
							case 3:
								goto IL_00D7;
							case 4:
								goto IL_003D;
							case 5:
								goto IL_0415;
							case 6:
								goto IL_0347;
							case 7:
								bool_2 = true;
								num = 3;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
								{
									goto Block_18;
								}
								continue;
							case 8:
							case 45:
								return false;
							case 9:
								goto IL_0036;
							case 10:
								goto IL_0459;
							case 11:
								goto IL_02C0;
							case 12:
								return true;
							case 13:
								goto IL_01DB;
							case 14:
								goto IL_002C;
							case 15:
								goto IL_006E;
							case 16:
								goto IL_0326;
							case 17:
								goto IL_0310;
							case 18:
								goto IL_02EC;
							case 19:
							case 30:
								return true;
							case 20:
								goto IL_0072;
							case 21:
								goto IL_01AB;
							case 22:
								goto IL_0201;
							case 23:
								goto IL_02E4;
							case 24:
								goto IL_0266;
							case 25:
								goto IL_030A;
							case 26:
								goto IL_0433;
							case 27:
								goto IL_0439;
							case 28:
								goto IL_009D;
							case 29:
								goto IL_0442;
							case 31:
							case 41:
								goto IL_0006;
							case 32:
								goto IL_019F;
							case 33:
								goto IL_0077;
							case 34:
							case 44:
								goto IL_01C2;
							case 35:
								return true;
							case 36:
								goto IL_005E;
							case 37:
								goto IL_0031;
							case 38:
								goto IL_00F4;
							case 39:
								goto IL_0117;
							case 40:
								goto IL_0048;
							case 42:
								goto IL_02B8;
							case 43:
								goto IL_01D0;
							case 46:
								return true;
							}
							break;
						}
						goto IL_0111;
						IL_030A:
						bool flag = true;
						goto IL_005C;
						IL_01AB:
						if (!MiscellaneousUtils.ValueEquals(reader.Value, property.GetResolvedDefaultValue()))
						{
							goto IL_01C2;
						}
						num = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
						{
							continue;
						}
						goto IL_034D;
						IL_019F:
						JsonToken tokenType;
						if (JsonTokenUtils.IsPrimitiveToken(tokenType))
						{
							goto IL_01AB;
						}
						num = 34;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
						{
							goto Block_15;
						}
						goto IL_034D;
						IL_0165:
						if (!this.method_18(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), DefaultValueHandling.Populate))
						{
							goto IL_019F;
						}
						num = 22;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
						{
							goto IL_01C2;
						}
						goto IL_034D;
						IL_012D:
						if (!this.method_18(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), DefaultValueHandling.Ignore))
						{
							goto IL_01C2;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
						{
							goto IL_0165;
						}
						goto IL_034D;
						IL_0111:
						if (tokenType == JsonToken.Null)
						{
							goto IL_0117;
						}
						goto IL_012D;
						IL_0048:
						JsonContract propertyContract = property.PropertyContract;
						if (propertyContract != null)
						{
							flag = propertyContract.ContractType != JsonContractType.Linq;
							goto IL_005C;
						}
						num = 25;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
						{
							goto IL_0111;
						}
						goto IL_034D;
						IL_003D:
						if (property.Readable)
						{
							goto IL_0048;
						}
						goto IL_00D7;
						IL_002C:
						if (tokenType != JsonToken.StartArray)
						{
							goto IL_0031;
						}
						goto IL_003D;
						IL_0006:
						jsonContract_0 = this.method_2(object_0.GetType());
						num = 29;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
						{
							goto IL_002C;
						}
						goto IL_034D;
						IL_01C2:
						if (object_0 != null)
						{
							goto IL_0006;
						}
						goto IL_046F;
						IL_0077:
						jsonContract_0 = this.method_2(object_0.GetType());
						num = 16;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
						{
							goto IL_009D;
						}
						goto IL_034D;
						IL_0072:
						if (object_0 != null)
						{
							goto IL_0077;
						}
						goto IL_00D7;
						IL_006E:
						bool_1 = true;
						goto IL_0072;
						IL_005E:
						object_0 = property.ValueProvider.GetValue(target);
						goto IL_006E;
						IL_005C:
						if (flag)
						{
							goto IL_005E;
						}
						goto IL_00D7;
						IL_0117:
						if (base.ResolvedNullValueHandling(jsonContainerContract_0 as JsonObjectContract, property) == NullValueHandling.Ignore)
						{
							goto IL_0266;
						}
						goto IL_012D;
						IL_00D7:
						if (property.Writable)
						{
							goto IL_0111;
						}
						num = 18;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
						{
							goto IL_00F4;
						}
						goto IL_034D;
						IL_009D:
						bool_0 = !jsonContract_0.IsReadOnlyOrFixedSize && !jsonContract_0.UnderlyingType.IsValueType();
						goto IL_00D7;
						IL_00F4:
						if (!bool_0)
						{
							goto IL_01D0;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
						{
							goto IL_0111;
						}
						goto IL_034D;
						IL_0031:
						if (tokenType == JsonToken.StartObject)
						{
							goto IL_003D;
						}
						IL_0036:
						if (jsonConverter_0 != null)
						{
							goto IL_003D;
						}
						goto IL_00D7;
						IL_01DB:
						if (this.TraceWriter.LevelFilter < TraceLevel.Info)
						{
							return true;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
						{
							goto IL_0201;
						}
						goto IL_034D;
						IL_01D0:
						if (this.TraceWriter != null)
						{
							goto IL_01DB;
						}
						return true;
						IL_0201:
						this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(reader as IJsonLineInfo, reader.Path, Class15.smethod_17(1471393683 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e).FormatWith(CultureInfo.InvariantCulture, property.PropertyName, property.DeclaringType)), null);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
						{
							goto Block_12;
						}
						goto IL_034D;
						IL_0266:
						bool_2 = true;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
						{
							goto Block_13;
						}
						goto IL_034D;
						IL_02C0:
						property.PropertyContract = this.method_1(property.PropertyType);
						num = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
						{
							goto IL_02E4;
						}
						goto IL_034D;
						IL_02B8:
						if (property.PropertyContract == null)
						{
							goto IL_02C0;
						}
						goto IL_02E4;
						IL_0310:
						if (!property.Ignored)
						{
							tokenType = reader.TokenType;
							goto IL_02B8;
						}
						return true;
						IL_0326:
						bool_2 = false;
						goto IL_0310;
						IL_0347:
						bool_1 = false;
						goto IL_0326;
						IL_02EC:
						ObjectCreationHandling? objectCreationHandling;
						if (objectCreationHandling.GetValueOrDefault(this.Serializer._objectCreationHandling) != ObjectCreationHandling.Replace)
						{
							goto IL_002C;
						}
						goto IL_00D7;
						IL_02E4:
						objectCreationHandling = property.ObjectCreationHandling;
						goto IL_02EC;
					}
				}
			}
			Block_12:
			return true;
			Block_13:
			return true;
			Block_15:
			goto IL_0459;
			Block_18:
			return true;
			IL_0442:
			if (jsonContract_0 != property.PropertyContract)
			{
				goto IL_0459;
			}
			return false;
			IL_0459:
			jsonConverter_0 = this.method_7(jsonContract_0, property.Converter, jsonContainerContract_0, jsonProperty_0);
			return false;
			IL_046F:
			jsonContract_0 = property.PropertyContract;
			return false;
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0005F50C File Offset: 0x0005D70C
		private void method_17(JsonReader jsonReader_0, string string_0, object object_0)
		{
			try
			{
				if (this.TraceWriter != null)
				{
					goto IL_00BC;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
				{
					goto IL_0078;
				}
				for (;;)
				{
					IL_0095:
					this.Serializer.GetReferenceResolver().AddReference(this, string_0, object_0);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
					{
						goto IL_0078;
					}
				}
				IL_0020:
				this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, Class15.smethod_17(552146792 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f).FormatWith(CultureInfo.InvariantCulture, string_0, object_0.GetType())), null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
				{
					goto IL_0095;
				}
				IL_0078:
				switch (num)
				{
				default:
					goto IL_0095;
				case 1:
					IL_00BC:
					if (this.TraceWriter.LevelFilter < TraceLevel.Verbose)
					{
						goto IL_0095;
					}
					goto IL_0020;
				case 3:
					break;
				case 5:
					goto IL_0020;
				}
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
				{
					switch (num2)
					{
					}
				}
				throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1953646361 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f).FormatWith(CultureInfo.InvariantCulture, string_0), ex);
			}
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00004FC2 File Offset: 0x000031C2
		private bool method_18(DefaultValueHandling defaultValueHandling_0, DefaultValueHandling defaultValueHandling_1)
		{
			return (defaultValueHandling_0 & defaultValueHandling_1) == defaultValueHandling_1;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0005F644 File Offset: 0x0005D844
		[NullableContext(2)]
		private bool paSyLmeWi4([Nullable(1)] JsonProperty property, JsonObjectContract jsonObjectContract_0, object object_0)
		{
			for (;;)
			{
				if (object_0 == null)
				{
					goto IL_0031;
				}
				goto IL_00CF;
				IL_0050:
				int num;
				switch (num)
				{
				case 1:
					goto IL_00A6;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					IL_0031:
					if (base.ResolvedNullValueHandling(jsonObjectContract_0, property) != NullValueHandling.Ignore)
					{
						goto IL_00CF;
					}
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
					{
						goto IL_0050;
					}
					goto IL_0006;
				case 5:
					continue;
				case 6:
				case 8:
					goto IL_0097;
				case 7:
					goto IL_0006;
				case 9:
					return false;
				}
				break;
				IL_0006:
				if (MiscellaneousUtils.ValueEquals(object_0, property.GetResolvedDefaultValue()))
				{
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						goto IL_00A6;
					}
					goto IL_0050;
				}
				IL_0097:
				if (!property.Writable)
				{
					return false;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
				{
					break;
				}
				goto IL_0050;
				IL_00A6:
				if (this.method_18(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), DefaultValueHandling.Populate))
				{
					goto IL_0097;
				}
				goto IL_0006;
				IL_00CF:
				if (!this.method_18(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), DefaultValueHandling.Ignore))
				{
					goto IL_0097;
				}
				goto IL_00A6;
			}
			return true;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0005F758 File Offset: 0x0005D958
		private IList method_19(JsonReader jsonReader_0, JsonArrayContract jsonArrayContract_0, out bool bool_0)
		{
			while (jsonArrayContract_0.CanDeserialize)
			{
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
				{
					goto IL_008D;
				}
				goto IL_0194;
				IL_00C1:
				while (jsonArrayContract_0.HasParameterizedCreator)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
					{
						goto IL_0194;
					}
				}
				object obj = jsonArrayContract_0.OverrideCreator(new object[0]);
				goto IL_00DC;
				IL_0194:
				IList list;
				switch (num)
				{
				case 0:
					goto IL_00C1;
				case 1:
					goto IL_0252;
				case 2:
					goto IL_013B;
				case 3:
					goto IL_027E;
				case 4:
					goto IL_0113;
				case 5:
					goto IL_00DC;
				case 6:
					goto IL_02AA;
				case 7:
					goto IL_0255;
				case 8:
				case 9:
					bool_0 = false;
					goto IL_025C;
				case 10:
					goto IL_026C;
				case 11:
					goto IL_0047;
				case 12:
					goto IL_0069;
				case 13:
					return list;
				case 14:
					goto IL_0178;
				case 15:
					goto IL_026F;
				case 16:
					goto IL_0163;
				case 17:
				case 29:
					goto IL_001D;
				case 18:
					goto IL_00E7;
				case 19:
					goto IL_0305;
				case 20:
					if (!jsonArrayContract_0.ShouldCreateWrapper)
					{
						return list;
					}
					break;
				case 21:
					goto IL_011E;
				case 22:
					IL_008D:
					if (jsonArrayContract_0.OverrideCreator != null)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
						{
							goto IL_00C1;
						}
						goto IL_0194;
					}
					else
					{
						if (jsonArrayContract_0.IsReadOnlyOrFixedSize)
						{
							goto IL_0163;
						}
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
						{
							goto IL_0113;
						}
						goto IL_0194;
					}
					break;
				case 23:
					continue;
				case 24:
					break;
				case 25:
					goto IL_003A;
				case 26:
					goto IL_025C;
				case 27:
					goto IL_02D9;
				case 28:
					goto IL_0264;
				default:
					goto IL_00C1;
				}
				list = jsonArrayContract_0.CreateWrapper(list);
				return list;
				IL_025C:
				object obj2;
				return (IList)obj2;
				IL_001D:
				bool_0 = false;
				num = 19;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
				{
					goto IL_0305;
				}
				goto IL_0194;
				IL_00DC:
				if (jsonArrayContract_0.ShouldCreateWrapper)
				{
					goto IL_00E7;
				}
				goto IL_001D;
				IL_0047:
				if (jsonArrayContract_0.ShouldCreateWrapper)
				{
					goto IL_0069;
				}
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					goto IL_0252;
				}
				goto IL_0194;
				IL_003A:
				obj2 = jsonArrayContract_0.DefaultCreator();
				goto IL_0047;
				IL_011E:
				if (!jsonArrayContract_0.DefaultCreatorNonPublic)
				{
					goto IL_003A;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
				{
					goto IL_013B;
				}
				goto IL_0194;
				IL_0113:
				if (jsonArrayContract_0.DefaultCreator != null)
				{
					goto IL_011E;
				}
				goto IL_0264;
				IL_0069:
				obj2 = jsonArrayContract_0.CreateWrapper(obj2);
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
				{
					goto IL_0252;
				}
				goto IL_0194;
				IL_013B:
				if (this.Serializer._constructorHandling != ConstructorHandling.AllowNonPublicDefaultConstructor)
				{
					goto IL_0264;
				}
				num = 25;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
				{
					goto IL_0305;
				}
				goto IL_0194;
				IL_0163:
				bool_0 = true;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
				{
					goto IL_0194;
				}
				IL_0178:
				list = jsonArrayContract_0.CreateTemporaryCollection();
				num = 20;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
				{
					goto IL_0194;
				}
				goto IL_02AA;
				IL_00E7:
				obj = jsonArrayContract_0.CreateWrapper(obj);
				goto IL_001D;
				IL_0252:
				bool_0 = true;
				IL_0255:
				return jsonArrayContract_0.CreateTemporaryCollection();
				IL_0264:
				if (!jsonArrayContract_0.HasParameterizedCreatorInternal)
				{
					if (jsonArrayContract_0.IsInstantiable)
					{
						goto IL_027E;
					}
					goto IL_02AA;
				}
				IL_026C:
				bool_0 = true;
				IL_026F:
				return jsonArrayContract_0.CreateTemporaryCollection();
				IL_027E:
				throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1571018549 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406).FormatWith(CultureInfo.InvariantCulture, jsonArrayContract_0.UnderlyingType));
				IL_02AA:
				throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1788782427 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c).FormatWith(CultureInfo.InvariantCulture, jsonArrayContract_0.UnderlyingType));
				IL_0305:
				return (IList)obj;
			}
			IL_02D9:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(197550829 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81).FormatWith(CultureInfo.InvariantCulture, jsonArrayContract_0.CreatedType));
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0005FA74 File Offset: 0x0005DC74
		private IDictionary method_20(JsonReader jsonReader_0, JsonDictionaryContract jsonDictionaryContract_0, out bool bool_0)
		{
			for (;;)
			{
				IL_0122:
				int num;
				if (jsonDictionaryContract_0.OverrideCreator != null)
				{
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
					{
						goto IL_0091;
					}
				}
				else if (jsonDictionaryContract_0.IsReadOnlyOrFixedSize)
				{
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
					{
						goto IL_004F;
					}
				}
				else
				{
					if (jsonDictionaryContract_0.DefaultCreator != null)
					{
						goto IL_0044;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
					{
						break;
					}
				}
				for (;;)
				{
					IL_00B3:
					switch (num)
					{
					case 1:
						goto IL_0044;
					case 2:
						goto IL_004F;
					case 3:
					case 12:
						goto IL_01D7;
					case 4:
						goto IL_0170;
					case 5:
						goto IL_0165;
					case 6:
						goto IL_009C;
					case 7:
						goto IL_0091;
					case 8:
						goto IL_0122;
					case 9:
						goto IL_01F6;
					case 10:
						goto IL_01AB;
					case 11:
						goto IL_01E4;
					case 13:
						goto IL_01F9;
					case 14:
						goto IL_013F;
					case 15:
						goto IL_0156;
					case 16:
						goto IL_01EC;
					case 17:
						goto IL_017F;
					case 18:
						bool_0 = true;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
						{
							continue;
						}
						break;
					case 19:
						goto IL_016D;
					}
					goto Block_8;
				}
				IL_004F:
				if (this.Serializer._constructorHandling != ConstructorHandling.AllowNonPublicDefaultConstructor)
				{
					break;
				}
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
				{
					goto Block_6;
				}
				goto IL_00B3;
				IL_0044:
				if (jsonDictionaryContract_0.DefaultCreatorNonPublic)
				{
					goto IL_004F;
				}
				goto IL_01D7;
				IL_009C:
				bool_0 = true;
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
				{
					goto IL_00B3;
				}
				goto IL_0139;
				IL_0091:
				if (jsonDictionaryContract_0.HasParameterizedCreator)
				{
					goto IL_009C;
				}
				goto IL_013C;
			}
			goto IL_0165;
			Block_6:
			goto IL_01D7;
			Block_8:
			goto IL_015E;
			IL_0139:
			goto IL_0156;
			IL_013C:
			bool_0 = false;
			IL_013F:
			return (IDictionary)jsonDictionaryContract_0.OverrideCreator(new object[0]);
			IL_0156:
			return jsonDictionaryContract_0.CreateTemporaryDictionary();
			IL_015E:
			return jsonDictionaryContract_0.CreateTemporaryDictionary();
			IL_0165:
			if (!jsonDictionaryContract_0.HasParameterizedCreatorInternal)
			{
				if (jsonDictionaryContract_0.IsInstantiable)
				{
					goto IL_017F;
				}
				goto IL_01AB;
			}
			IL_016D:
			bool_0 = true;
			IL_0170:
			return jsonDictionaryContract_0.CreateTemporaryDictionary();
			IL_017F:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(564862804 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610).FormatWith(CultureInfo.InvariantCulture, jsonDictionaryContract_0.UnderlyingType));
			IL_01AB:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1116196617 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54).FormatWith(CultureInfo.InvariantCulture, jsonDictionaryContract_0.UnderlyingType));
			IL_01D7:
			object obj = jsonDictionaryContract_0.DefaultCreator();
			IL_01E4:
			if (!jsonDictionaryContract_0.ShouldCreateWrapper)
			{
				goto IL_01F6;
			}
			IL_01EC:
			obj = jsonDictionaryContract_0.CreateWrapper(obj);
			IL_01F6:
			bool_0 = false;
			IL_01F9:
			return (IDictionary)obj;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0005FC84 File Offset: 0x0005DE84
		private void method_21(JsonReader jsonReader_0, JsonContract jsonContract_0, object object_0)
		{
			for (;;)
			{
				if (this.TraceWriter != null)
				{
					goto IL_00A4;
				}
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
				{
					goto IL_007E;
				}
				IL_005D:
				switch (num)
				{
				default:
					goto IL_007E;
				case 1:
					return;
				case 2:
					break;
				case 4:
					continue;
				case 5:
					IL_00A4:
					if (this.TraceWriter.LevelFilter < TraceLevel.Info)
					{
						goto IL_007E;
					}
					break;
				}
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, Class15.smethod_17(649922814 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff).FormatWith(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType)), null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
				{
					goto IL_005D;
				}
				IL_007E:
				jsonContract_0.InvokeOnDeserializing(object_0, this.Serializer._context);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
				{
					break;
				}
				goto IL_005D;
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0005FD6C File Offset: 0x0005DF6C
		private void method_22(JsonReader jsonReader_0, JsonContract jsonContract_0, object object_0)
		{
			for (;;)
			{
				if (this.TraceWriter != null)
				{
					goto IL_007E;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
				{
					break;
				}
				IL_005A:
				switch (num)
				{
				case 1:
				case 2:
				case 4:
					goto IL_00B5;
				case 3:
					IL_007E:
					if (this.TraceWriter.LevelFilter < TraceLevel.Info)
					{
						goto Block_2;
					}
					break;
				case 5:
					continue;
				case 6:
					return;
				}
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, Class15.smethod_17(768748422 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7).FormatWith(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType)), null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					goto IL_005A;
				}
				break;
			}
			Block_2:
			IL_00B5:
			jsonContract_0.InvokeOnDeserialized(object_0, this.Serializer._context);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0005FE40 File Offset: 0x0005E040
		private object method_23(IDictionary idictionary_0, JsonReader jsonReader_0, JsonDictionaryContract jsonDictionaryContract_0, [Nullable(2)] JsonProperty containerProperty, [Nullable(2)] string id)
		{
			object obj;
			for (;;)
			{
				IL_0001:
				Interface1 @interface = idictionary_0 as Interface1;
				int num = 34;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
				{
					goto IL_001E;
				}
				JsonToken tokenType;
				for (;;)
				{
					IL_0287:
					JsonConverter jsonConverter;
					object obj2;
					switch (num)
					{
					case 1:
						goto IL_0656;
					case 2:
					case 25:
						goto IL_06A0;
					case 3:
						goto IL_0143;
					case 4:
					case 20:
						goto IL_0162;
					case 5:
						goto IL_032A;
					case 6:
						goto IL_00B8;
					case 7:
						goto IL_01A3;
					case 8:
						goto IL_0279;
					case 9:
						goto IL_002C;
					case 10:
						if (tokenType == JsonToken.EndObject)
						{
							goto IL_0656;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
						{
							goto Block_16;
						}
						continue;
					case 11:
						goto IL_00F7;
					case 12:
					case 31:
						goto IL_0059;
					case 13:
						goto IL_007E;
					case 14:
					case 21:
						goto IL_0695;
					case 15:
						if (id == null)
						{
							goto IL_01F4;
						}
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
						{
							goto IL_0215;
						}
						continue;
					case 16:
						goto IL_0128;
					case 17:
						goto IL_001E;
					case 18:
						return obj;
					case 19:
					{
						int depth = jsonReader_0.Depth;
						goto IL_011D;
					}
					case 22:
						goto IL_0215;
					case 23:
						goto IL_01F4;
					case 24:
						goto IL_01B6;
					case 26:
						goto IL_01D5;
					case 27:
						goto IL_01CD;
					case 28:
						goto IL_019B;
					case 29:
						goto IL_0097;
					case 30:
						jsonConverter = this.method_7(jsonDictionaryContract_0.ItemContract, null, jsonDictionaryContract_0, containerProperty);
						goto IL_0062;
					case 33:
						goto IL_011D;
					case 34:
						if (@interface == null)
						{
							goto IL_00F7;
						}
						obj2 = @interface.UnderlyingDictionary;
						goto IL_0101;
					case 35:
						goto IL_0001;
					case 36:
						goto IL_00C7;
					case 37:
						goto IL_0051;
					}
					goto Block_17;
					IL_0059:
					if ((jsonConverter = jsonDictionaryContract_0.ItemConverter) != null)
					{
						goto IL_0062;
					}
					num = 30;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
					{
						goto IL_00B8;
					}
					continue;
					IL_0051:
					if (jsonDictionaryContract_0.ItemContract != null)
					{
						goto IL_0059;
					}
					goto IL_00C7;
					IL_011D:
					if (jsonDictionaryContract_0.KeyContract == null)
					{
						goto IL_0128;
					}
					goto IL_0051;
					IL_007E:
					JsonPrimitiveContract jsonPrimitiveContract;
					PrimitiveTypeCode primitiveTypeCode;
					if (jsonPrimitiveContract != null)
					{
						primitiveTypeCode = jsonPrimitiveContract.TypeCode;
						goto IL_00A1;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
					{
						goto IL_0097;
					}
					continue;
					IL_00B8:
					jsonPrimitiveContract = jsonDictionaryContract_0.KeyContract as JsonPrimitiveContract;
					goto IL_007E;
					IL_0062:
					JsonConverter jsonConverter2 = jsonConverter;
					goto IL_00B8;
					IL_00A1:
					PrimitiveTypeCode primitiveTypeCode2 = primitiveTypeCode;
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
					{
						goto IL_00B8;
					}
					continue;
					IL_0097:
					primitiveTypeCode = PrimitiveTypeCode.Empty;
					goto IL_00A1;
					IL_00C7:
					jsonDictionaryContract_0.ItemContract = this.method_1(jsonDictionaryContract_0.DictionaryValueType);
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
					{
						break;
					}
					continue;
					IL_0101:
					obj = obj2;
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
					{
						goto IL_007E;
					}
					continue;
					IL_00F7:
					obj2 = idictionary_0;
					goto IL_0101;
					IL_01F4:
					this.method_21(jsonReader_0, jsonDictionaryContract_0, obj);
					num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
					{
						goto Block_11;
					}
					continue;
					IL_0215:
					this.method_17(jsonReader_0, id, obj);
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						goto IL_01F4;
					}
					continue;
					IL_0128:
					jsonDictionaryContract_0.KeyContract = this.method_1(jsonDictionaryContract_0.DictionaryKeyType);
					goto IL_0051;
				}
				goto IL_002C;
				Block_17:
				Block_11:
				goto IL_013F;
				IL_032A:
				object obj3;
				try
				{
					try
					{
						PrimitiveTypeCode primitiveTypeCode2;
						if (primitiveTypeCode2 - PrimitiveTypeCode.DateTime <= 1)
						{
							DateTime dateTime;
							object obj4;
							while (DateTimeUtils.TryParseDateTime(obj3.ToString(), jsonReader_0.DateTimeZoneHandling, jsonReader_0.DateFormatString, jsonReader_0.Culture, out dateTime))
							{
								int num2 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
								{
									switch (num2)
									{
									case 1:
										continue;
									case 2:
										goto IL_03E3;
									case 3:
									case 14:
										goto IL_040D;
									case 4:
									case 6:
									case 13:
										goto IL_049C;
									case 5:
										goto IL_0422;
									case 7:
										goto IL_03BF;
									case 8:
										goto IL_0458;
									case 9:
									case 12:
										goto IL_03C7;
									case 10:
										goto IL_0415;
									case 11:
										goto IL_0480;
									}
								}
								obj4 = dateTime;
								IL_049A:
								obj3 = obj4;
								goto IL_049C;
							}
							IL_0480:
							obj4 = this.method_14(jsonReader_0, obj3, CultureInfo.InvariantCulture, jsonDictionaryContract_0.KeyContract, jsonDictionaryContract_0.DictionaryKeyType);
							goto IL_049A;
						}
						IL_03BF:
						if (primitiveTypeCode2 - PrimitiveTypeCode.DateTimeOffset > 1)
						{
							goto IL_040D;
						}
						IL_03C7:
						DateTimeOffset dateTimeOffset;
						object obj5;
						if (DateTimeUtils.TryParseDateTimeOffset(obj3.ToString(), jsonReader_0.DateFormatString, jsonReader_0.Culture, out dateTimeOffset))
						{
							obj5 = dateTimeOffset;
							goto IL_0406;
						}
						IL_03E3:
						obj5 = this.method_14(jsonReader_0, obj3, CultureInfo.InvariantCulture, jsonDictionaryContract_0.KeyContract, jsonDictionaryContract_0.DictionaryKeyType);
						IL_0406:
						obj3 = obj5;
						goto IL_049C;
						IL_040D:
						if (jsonDictionaryContract_0.KeyContract == null)
						{
							goto IL_0458;
						}
						IL_0415:
						if (!jsonDictionaryContract_0.KeyContract.IsEnum)
						{
							goto IL_0458;
						}
						IL_0422:
						Type nonNullableUnderlyingType = jsonDictionaryContract_0.KeyContract.NonNullableUnderlyingType;
						DefaultContractResolver defaultContractResolver = this.Serializer._contractResolver as DefaultContractResolver;
						object obj6 = EnumUtils.ParseEnum(nonNullableUnderlyingType, (defaultContractResolver == null) ? null : defaultContractResolver.NamingStrategy, obj3.ToString(), false);
						goto IL_0472;
						IL_0458:
						obj6 = this.method_14(jsonReader_0, obj3, CultureInfo.InvariantCulture, jsonDictionaryContract_0.KeyContract, jsonDictionaryContract_0.DictionaryKeyType);
						IL_0472:
						obj3 = obj6;
						IL_049C:
						goto IL_0570;
					}
					catch (Exception ex)
					{
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
						{
							switch (num3)
							{
							}
						}
						throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(698968128 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a).FormatWith(CultureInfo.InvariantCulture, jsonReader_0.Value, jsonDictionaryContract_0.DictionaryKeyType), ex);
					}
					IL_04F4:
					JsonConverter jsonConverter2;
					if (jsonConverter2 != null)
					{
						goto IL_0550;
					}
					goto IL_05A9;
					IL_04FE:
					object obj7 = this.method_30(jsonConverter2, jsonReader_0, jsonDictionaryContract_0.DictionaryValueType, null);
					int num4 = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
					{
						goto IL_05C3;
					}
					IL_0524:
					switch (num4)
					{
					case 0:
					case 6:
						goto IL_05A9;
					case 1:
						break;
					case 2:
						IL_0570:
						if (jsonReader_0.ReadForType(jsonDictionaryContract_0.ItemContract, jsonConverter2 != null))
						{
							goto IL_04F4;
						}
						num4 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
						{
							goto IL_0524;
						}
						break;
					case 3:
						goto IL_05CD;
					case 4:
					case 5:
						goto IL_05C3;
					case 7:
						IL_0550:
						if (!jsonConverter2.CanRead)
						{
							goto IL_05A9;
						}
						goto IL_04FE;
					case 8:
						goto IL_04FE;
					default:
						goto IL_05A9;
					}
					throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(564856434 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610));
					IL_05A9:
					obj7 = this.method_6(jsonReader_0, jsonDictionaryContract_0.DictionaryValueType, jsonDictionaryContract_0.ItemContract, null, jsonDictionaryContract_0, containerProperty, null);
					IL_05C3:
					idictionary_0[obj3] = obj7;
					IL_05CD:
					goto IL_0695;
				}
				catch (Exception ex2)
				{
					int num5 = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
					{
						goto IL_0606;
					}
					goto IL_0632;
					IL_05E8:
					int depth;
					this.method_38(jsonReader_0, true, depth);
					num5 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
					{
						goto IL_0652;
					}
					goto IL_0632;
					IL_0606:
					if (base.IsErrorHandled(obj, jsonDictionaryContract_0, obj3, jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, ex2))
					{
						goto IL_05E8;
					}
					num5 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
					{
						goto IL_0652;
					}
					IL_0632:
					switch (num5)
					{
					case 1:
						goto IL_0695;
					case 2:
						goto IL_0606;
					case 4:
						goto IL_05E8;
					}
					IL_0652:
					throw;
				}
				IL_0656:
				bool flag = true;
				goto IL_0695;
				IL_0279:
				flag = false;
				goto IL_01CD;
				IL_001E:
				if (tokenType == JsonToken.Comment)
				{
					goto IL_0695;
				}
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
				{
					goto IL_01A3;
				}
				goto IL_0287;
				IL_002C:
				if (jsonReader_0.Read())
				{
					goto IL_01CD;
				}
				num = 27;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
				{
					goto IL_013F;
				}
				goto IL_0287;
				IL_0695:
				if (!flag)
				{
					goto IL_002C;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
				{
					goto IL_013F;
				}
				goto IL_0287;
				IL_01A3:
				if (!this.method_34(jsonReader_0, obj3.ToString()))
				{
					goto IL_01B6;
				}
				goto IL_0695;
				IL_019B:
				obj3 = jsonReader_0.Value;
				goto IL_01A3;
				IL_01D5:
				if (tokenType == JsonToken.PropertyName)
				{
					goto IL_019B;
				}
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
				{
					goto IL_001E;
				}
				goto IL_0287;
				IL_01CD:
				tokenType = jsonReader_0.TokenType;
				goto IL_01D5;
				IL_0162:
				this.method_22(jsonReader_0, jsonDictionaryContract_0, obj);
				num = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
				{
					break;
				}
				goto IL_0287;
				IL_0143:
				this.method_25(jsonReader_0, jsonDictionaryContract_0, obj, Class15.smethod_17(1571016377 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406));
				goto IL_0162;
				IL_013F:
				if (!flag)
				{
					goto IL_0143;
				}
				goto IL_0162;
				IL_01B6:
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
				{
					goto IL_0162;
				}
				goto IL_0287;
			}
			return obj;
			Block_16:
			IL_06A0:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1471390535 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e) + jsonReader_0.TokenType.ToString());
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0006055C File Offset: 0x0005E75C
		private object method_24(IList ilist_0, JsonReader jsonReader_0, JsonArrayContract jsonArrayContract_0, [Nullable(2)] JsonProperty containerProperty, [Nullable(2)] string id)
		{
			for (;;)
			{
				IL_0001:
				int arrayRank = jsonArrayContract_0.UnderlyingType.GetArrayRank();
				for (;;)
				{
					IL_000E:
					if (id != null)
					{
						goto IL_0015;
					}
					for (;;)
					{
						IL_0526:
						this.method_21(jsonReader_0, jsonArrayContract_0, ilist_0);
						for (;;)
						{
							IL_0024:
							JsonContract jsonContract = this.method_1(jsonArrayContract_0.CollectionItemType);
							for (;;)
							{
								IL_0032:
								JsonConverter jsonConverter = this.method_7(jsonContract, null, jsonArrayContract_0, containerProperty);
								for (;;)
								{
									IL_0040:
									int? num = null;
									for (;;)
									{
										IL_0048:
										Stack<IList> stack = new Stack<IList>();
										int num2 = 2;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
										{
											goto IL_0064;
										}
										JsonToken jsonToken;
										bool flag;
										IList list;
										IList list2;
										for (;;)
										{
											IL_046F:
											switch (num2)
											{
											case 1:
											case 20:
											case 21:
												goto IL_0534;
											case 2:
											case 33:
												goto IL_009E;
											case 3:
												if (jsonToken != JsonToken.StartArray)
												{
													goto IL_045C;
												}
												goto IL_0441;
											case 4:
												goto IL_0032;
											case 5:
											case 9:
												goto IL_0541;
											case 6:
												goto IL_045C;
											case 7:
												goto IL_0441;
											case 8:
												goto IL_03DD;
											case 10:
												goto IL_0040;
											case 11:
												goto IL_0048;
											case 12:
												goto IL_000E;
											case 13:
												goto IL_0001;
											case 14:
												goto IL_0064;
											case 15:
												goto IL_0435;
											case 16:
												goto IL_0429;
											case 17:
												return ilist_0;
											case 18:
												goto IL_0116;
											case 19:
												goto IL_006C;
											case 22:
												goto IL_03D2;
											case 23:
												goto IL_041C;
											case 24:
												goto IL_006F;
											case 25:
												goto IL_03FC;
											case 26:
												goto IL_00F3;
											case 27:
												goto IL_0526;
											case 28:
												goto IL_00EA;
											case 29:
											case 37:
												goto IL_0598;
											case 30:
												goto IL_00BB;
											case 32:
											case 34:
												goto IL_0072;
											case 35:
												goto IL_0094;
											case 36:
												goto IL_0015;
											case 38:
												goto IL_0024;
											case 39:
												goto IL_057A;
											}
											goto Block_12;
											IL_009E:
											flag = true;
											num2 = 1;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
											{
												break;
											}
											continue;
											IL_0094:
											if (stack.Count <= 0)
											{
												goto IL_009E;
											}
											goto IL_00BB;
											IL_041C:
											stack.Pop();
											goto IL_0094;
											IL_0429:
											if (jsonToken != JsonToken.EndArray)
											{
												goto Block_8;
											}
											goto IL_041C;
											IL_045C:
											if (jsonToken != JsonToken.Comment)
											{
												goto IL_0429;
											}
											break;
											IL_03FC:
											stack.Push(list);
											num2 = 28;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
											{
												goto Block_7;
											}
											continue;
											IL_0435:
											list2.Add(list);
											goto IL_03FC;
											IL_0441:
											list = new List<object>();
											num2 = 5;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
											{
												goto IL_0435;
											}
										}
										goto IL_0534;
										Block_7:
										goto IL_006F;
										Block_12:
										goto IL_00C9;
										IL_00BB:
										list2 = stack.Peek();
										goto IL_0534;
										IL_00EA:
										list2 = list;
										goto IL_0534;
										IL_0072:
										int depth = jsonReader_0.Depth;
										num2 = 4;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
										{
											goto IL_00F3;
										}
										goto IL_046F;
										IL_0534:
										if (!flag)
										{
											goto IL_0072;
										}
										goto IL_00C9;
										IL_006F:
										flag = false;
										goto IL_0072;
										IL_006C:
										list2 = ilist_0;
										goto IL_006F;
										IL_0064:
										stack.Push(ilist_0);
										goto IL_006C;
										IL_00C9:
										if (!flag)
										{
											goto IL_057A;
										}
										num2 = 8;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
										{
											goto Block_3;
										}
										goto IL_046F;
										IL_03D2:
										if (jsonReader_0.Read())
										{
											goto IL_03DD;
										}
										goto IL_00C9;
										IL_00F3:
										if (stack.Count != arrayRank)
										{
											goto IL_03D2;
										}
										num2 = 18;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
										{
											goto IL_0116;
										}
										goto IL_046F;
										IL_03DD:
										jsonToken = jsonReader_0.TokenType;
										num2 = 3;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
										{
											goto IL_0534;
										}
										goto IL_046F;
										IL_0116:
										try
										{
											if (jsonReader_0.ReadForType(jsonContract, jsonConverter != null))
											{
												int num3 = 1;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
												{
													goto IL_01DA;
												}
												for (;;)
												{
													IL_022F:
													switch (num3)
													{
													case 1:
														goto IL_01DA;
													case 2:
														if (jsonConverter.CanRead)
														{
															goto IL_01F8;
														}
														num3 = 16;
														if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
														{
															goto Block_25;
														}
														continue;
													case 3:
													case 7:
													case 15:
														goto IL_0290;
													case 4:
														goto IL_01B7;
													case 5:
														goto IL_01F8;
													case 6:
													case 16:
														goto IL_0143;
													case 8:
														goto IL_0295;
													case 9:
														goto IL_01D1;
													case 10:
													case 13:
														goto IL_0159;
													case 11:
														goto IL_019F;
													case 12:
														goto IL_0285;
													case 14:
														goto IL_017D;
													}
													goto Block_26;
												}
												IL_01F8:
												object obj = this.method_30(jsonConverter, jsonReader_0, jsonArrayContract_0.CollectionItemType, null);
												goto IL_0159;
												Block_25:
												goto IL_0143;
												Block_26:
												goto IL_027C;
												IL_0143:
												obj = this.method_6(jsonReader_0, jsonArrayContract_0.CollectionItemType, jsonContract, null, jsonArrayContract_0, containerProperty, null);
												IL_0159:
												list2.Add(obj);
												num3 = 3;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
												{
													goto IL_0290;
												}
												goto IL_022F;
												IL_017D:
												stack.Pop();
												num3 = 0;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
												{
													goto IL_027C;
												}
												goto IL_022F;
												IL_019F:
												if (jsonConverter == null)
												{
													goto IL_0143;
												}
												num3 = 2;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
												{
													goto IL_01DA;
												}
												goto IL_022F;
												IL_01B7:
												if (jsonToken == JsonToken.Comment)
												{
													goto IL_0290;
												}
												num3 = 4;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
												{
													goto IL_022F;
												}
												IL_01D1:
												if (jsonToken != JsonToken.EndArray)
												{
													goto IL_019F;
												}
												num3 = 14;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
												{
													goto IL_017D;
												}
												goto IL_022F;
												IL_01DA:
												jsonToken = jsonReader_0.TokenType;
												goto IL_01B7;
												IL_027C:
												list2 = stack.Peek();
												IL_0285:
												num = null;
												IL_0290:
												goto IL_0534;
											}
											IL_0295:
											goto IL_00C9;
										}
										catch (Exception ex)
										{
											JsonPosition position;
											for (;;)
											{
												position = jsonReader_0.GetPosition(depth);
												int num4 = 0;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
												{
													goto IL_0309;
												}
												IL_033E:
												switch (num4)
												{
												case 0:
													goto IL_0309;
												case 1:
													goto IL_02FB;
												case 2:
												case 8:
													goto IL_039C;
												case 3:
													goto IL_02CC;
												case 4:
													goto IL_03A1;
												case 5:
													goto IL_03CD;
												case 6:
													continue;
												case 7:
													break;
												case 9:
												case 11:
													goto IL_03BF;
												case 10:
													goto IL_02C3;
												case 12:
													goto IL_02A1;
												default:
													goto IL_0309;
												}
												IL_02AD:
												int? num5 = num;
												num4 = 9;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
												{
													goto IL_02C3;
												}
												goto IL_033E;
												IL_02A1:
												if (num != null)
												{
													goto IL_02AD;
												}
												break;
												IL_02FB:
												this.method_38(jsonReader_0, true, depth + 1);
												goto IL_02A1;
												IL_0309:
												if (base.IsErrorHandled(ilist_0, jsonArrayContract_0, position.Position, jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, ex))
												{
													goto IL_02FB;
												}
												num4 = 2;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
												{
													goto IL_033E;
												}
												goto IL_039B;
												IL_02CC:
												int position2;
												if ((num5.GetValueOrDefault() == position2) & (num5 != null))
												{
													goto IL_03A1;
												}
												num4 = 11;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
												{
													break;
												}
												goto IL_033E;
												IL_02C3:
												position2 = position.Position;
												goto IL_02CC;
											}
											goto IL_03BF;
											IL_039B:
											IL_039C:
											throw;
											IL_03A1:
											throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(2128264668 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9), ex);
											IL_03BF:
											num = new int?(position.Position);
											IL_03CD:
											goto IL_0534;
										}
										goto IL_03D2;
									}
								}
							}
						}
					}
					IL_0015:
					this.method_17(jsonReader_0, id, ilist_0);
					goto IL_0526;
				}
			}
			Block_3:
			goto IL_0598;
			Block_8:
			IL_0541:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(432090013 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2) + jsonReader_0.TokenType.ToString());
			IL_057A:
			this.method_25(jsonReader_0, jsonArrayContract_0, ilist_0, Class15.smethod_17(649923150 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff));
			IL_0598:
			this.method_22(jsonReader_0, jsonArrayContract_0, ilist_0);
			return ilist_0;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00060B28 File Offset: 0x0005ED28
		private void method_25(JsonReader jsonReader_0, JsonContract jsonContract_0, [Nullable(2)] object currentObject, string string_0)
		{
			try
			{
				throw JsonSerializationException.Create(jsonReader_0, string_0);
			}
			catch (Exception ex)
			{
				IL_0044:
				while (base.IsErrorHandled(currentObject, jsonContract_0, null, jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, ex))
				{
					for (;;)
					{
						this.method_38(jsonReader_0, false, 0);
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
						{
							switch (num)
							{
							case 1:
							case 3:
								goto IL_005D;
							case 2:
								goto IL_0044;
							case 4:
								continue;
							}
							break;
						}
						break;
					}
					return;
				}
				IL_005D:
				throw;
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00060BA8 File Offset: 0x0005EDA8
		private object method_26(IList ilist_0, JsonReader jsonReader_0, JsonArrayContract jsonArrayContract_0, [Nullable(2)] JsonProperty containerProperty, [Nullable(2)] string id)
		{
			object obj;
			for (;;)
			{
				IL_0161:
				Interface0 @interface = ilist_0 as Interface0;
				for (;;)
				{
					IL_015A:
					if (@interface != null)
					{
						goto IL_014C;
					}
					goto IL_0157;
					IL_0153:
					object obj2;
					obj = obj2;
					for (;;)
					{
						if (id == null)
						{
							goto IL_011D;
						}
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
						{
							goto IL_0112;
						}
						IL_004E:
						switch (num)
						{
						case 1:
							IL_0112:
							this.method_17(jsonReader_0, id, obj);
							goto IL_011D;
						case 2:
							goto IL_0032;
						case 3:
							return obj;
						case 4:
							goto IL_03B8;
						case 5:
							goto IL_016C;
						case 6:
						case 11:
						case 23:
							goto IL_03B2;
						case 7:
							goto IL_00E9;
						case 8:
							goto IL_011D;
						case 9:
							goto IL_03BC;
						case 10:
							goto IL_0015;
						case 12:
						case 24:
							goto IL_03DB;
						case 13:
							continue;
						case 14:
							goto IL_0108;
						case 15:
							goto IL_0157;
						case 16:
							goto IL_014C;
						case 17:
						case 18:
							goto IL_00BD;
						case 19:
							goto IL_015A;
						case 20:
							goto IL_0161;
						case 21:
							goto IL_00FD;
						case 22:
							goto IL_03AE;
						}
						goto Block_2;
						IL_0015:
						jsonReader_0.Skip();
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
						{
							goto Block_1;
						}
						goto IL_004E;
						IL_0032:
						int? num2 = null;
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
						{
							goto IL_004E;
						}
						goto IL_016B;
						IL_00BD:
						JsonConverter jsonConverter = this.method_7(jsonArrayContract_0.ItemContract, null, jsonArrayContract_0, containerProperty);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
						{
							goto IL_0032;
						}
						goto IL_004E;
						IL_00FD:
						if (jsonArrayContract_0.ItemContract != null)
						{
							goto IL_00BD;
						}
						goto IL_00E9;
						IL_0108:
						int depth = jsonReader_0.Depth;
						goto IL_00FD;
						IL_011D:
						if (ilist_0.IsFixedSize)
						{
							goto IL_0015;
						}
						this.method_21(jsonReader_0, jsonArrayContract_0, obj);
						goto IL_0108;
						IL_00E9:
						jsonArrayContract_0.ItemContract = this.method_1(jsonArrayContract_0.CollectionItemType);
						goto IL_00BD;
					}
					IL_0157:
					obj2 = ilist_0;
					goto IL_0153;
					IL_014C:
					obj2 = @interface.UnderlyingCollection;
					goto IL_0153;
				}
			}
			Block_1:
			Block_2:
			return obj;
			IL_016B:
			IL_016C:
			bool flag = false;
			goto IL_03B2;
			IL_03AE:
			if (flag)
			{
				goto IL_03B8;
			}
			IL_03B2:
			try
			{
				JsonConverter jsonConverter;
				if (jsonReader_0.ReadForType(jsonArrayContract_0.ItemContract, jsonConverter != null))
				{
					goto IL_027C;
				}
				int num3 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					goto IL_0289;
				}
				goto IL_0201;
				IL_01A5:
				if (jsonConverter.CanRead)
				{
					goto IL_01D1;
				}
				goto IL_01E5;
				IL_01B1:
				object obj3;
				ilist_0.Add(obj3);
				num3 = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
				{
					goto IL_0291;
				}
				goto IL_0201;
				IL_01D1:
				obj3 = this.method_30(jsonConverter, jsonReader_0, jsonArrayContract_0.CollectionItemType, null);
				goto IL_01B1;
				IL_01E5:
				obj3 = this.method_6(jsonReader_0, jsonArrayContract_0.CollectionItemType, jsonArrayContract_0.ItemContract, null, jsonArrayContract_0, containerProperty, null);
				goto IL_01B1;
				IL_0201:
				JsonToken tokenType;
				switch (num3)
				{
				case 1:
				case 9:
					IL_0289:
					goto IL_03B8;
				case 2:
					IL_027C:
					tokenType = jsonReader_0.TokenType;
					goto IL_0274;
				case 3:
				case 12:
				case 13:
					goto IL_01E5;
				case 4:
					goto IL_0274;
				case 5:
					goto IL_01D1;
				case 6:
				case 14:
				case 15:
					goto IL_0291;
				case 7:
					goto IL_01A5;
				case 8:
				case 10:
					goto IL_01B1;
				case 11:
					goto IL_026B;
				case 16:
					goto IL_028E;
				}
				IL_0261:
				if (jsonConverter != null)
				{
					goto IL_01A5;
				}
				num3 = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
				{
					goto IL_01E5;
				}
				goto IL_0201;
				IL_026B:
				if (tokenType == JsonToken.EndArray)
				{
					goto IL_028E;
				}
				goto IL_0261;
				IL_0274:
				if (tokenType != JsonToken.Comment)
				{
					goto IL_026B;
				}
				goto IL_0291;
				IL_028E:
				flag = true;
				IL_0291:;
			}
			catch (Exception ex)
			{
				int num4 = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
				{
					goto IL_0317;
				}
				int depth;
				JsonPosition position;
				for (;;)
				{
					IL_0325:
					switch (num4)
					{
					case 1:
						goto IL_035E;
					case 2:
						goto IL_0367;
					case 3:
						goto IL_03AC;
					case 4:
					case 11:
						goto IL_03AA;
					case 5:
						goto IL_0317;
					case 6:
						goto IL_039A;
					case 7:
						goto IL_037C;
					case 8:
						goto IL_02B8;
					case 9:
						position = jsonReader_0.GetPosition(depth);
						num4 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
						{
							continue;
						}
						break;
					case 10:
						goto IL_02AC;
					}
					break;
				}
				IL_02EF:
				if (base.IsErrorHandled(obj, jsonArrayContract_0, position.Position, jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, ex))
				{
					goto IL_0317;
				}
				goto IL_03AA;
				goto IL_02EF;
				IL_03AA:
				throw;
				IL_02AC:
				int? num2;
				if (num2 == null)
				{
					goto IL_039A;
				}
				IL_02B8:
				int? num5 = num2;
				num4 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
				{
					goto IL_035E;
				}
				goto IL_0325;
				IL_0317:
				this.method_38(jsonReader_0, true, depth + 1);
				goto IL_02AC;
				IL_035E:
				int position2 = position.Position;
				IL_0367:
				if (!((num5.GetValueOrDefault() == position2) & (num5 != null)))
				{
					goto IL_039A;
				}
				IL_037C:
				throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(486490206 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c), ex);
				IL_039A:
				num2 = new int?(position.Position);
				IL_03AC:;
			}
			goto IL_03AE;
			IL_03B8:
			if (flag)
			{
				goto IL_03DB;
			}
			IL_03BC:
			this.method_25(jsonReader_0, jsonArrayContract_0, obj, Class15.smethod_17(2128264458 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9));
			IL_03DB:
			this.method_22(jsonReader_0, jsonArrayContract_0, obj);
			return obj;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00060FB8 File Offset: 0x0005F1B8
		private object method_27(JsonReader jsonReader_0, JsonISerializableContract jsonISerializableContract_0, [Nullable(2)] JsonProperty member, [Nullable(2)] string id)
		{
			Type underlyingType;
			object obj;
			string text;
			for (;;)
			{
				IL_02E4:
				underlyingType = jsonISerializableContract_0.UnderlyingType;
				IL_02D7:
				while (JsonTypeReflector.FullyTrusted)
				{
					if (this.TraceWriter == null)
					{
						goto IL_02A8;
					}
					goto IL_02C3;
					int num;
					JsonToken tokenType;
					bool flag;
					for (;;)
					{
						IL_006E:
						switch (num)
						{
						case 1:
							goto IL_01B5;
						case 2:
							return obj;
						case 3:
							goto IL_0115;
						case 4:
							if (tokenType == JsonToken.PropertyName)
							{
								goto IL_0249;
							}
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
							{
								goto IL_026D;
							}
							continue;
						case 5:
							goto IL_026D;
						case 6:
							goto IL_0140;
						case 7:
							goto IL_02C3;
						case 8:
							goto IL_0371;
						case 10:
							goto IL_0017;
						case 11:
						case 36:
							goto IL_037B;
						case 12:
							goto IL_0175;
						case 13:
							goto IL_020A;
						case 14:
							goto IL_0249;
						case 15:
						case 37:
							goto IL_0111;
						case 16:
							goto IL_023B;
						case 17:
							goto IL_01BC;
						case 18:
							goto IL_03B9;
						case 19:
							goto IL_02EE;
						case 20:
							goto IL_0227;
						case 21:
							goto IL_0391;
						case 22:
							goto IL_015F;
						case 23:
							goto IL_03E6;
						case 24:
							goto IL_0385;
						case 25:
						case 27:
							goto IL_011D;
						case 26:
						case 28:
						case 29:
							goto IL_02A8;
						case 30:
							if (tokenType == JsonToken.EndObject)
							{
								goto IL_01E1;
							}
							break;
						case 31:
							goto IL_02D7;
						case 32:
							goto IL_02E4;
						case 33:
							goto IL_013C;
						case 34:
							goto IL_01E1;
						case 35:
							goto IL_0361;
						}
						goto Block_2;
						IL_01E1:
						flag = true;
						num = 37;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
						{
							goto Block_6;
						}
						continue;
						IL_0249:
						text = jsonReader_0.Value.ToString();
						num = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
						{
							goto Block_10;
						}
						continue;
						IL_026D:
						if (tokenType == JsonToken.Comment)
						{
							break;
						}
						num = 30;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
						{
							goto Block_12;
						}
					}
					IL_0111:
					if (!flag)
					{
						goto IL_0115;
					}
					goto IL_013C;
					IL_0227:
					SerializationInfo serializationInfo;
					serializationInfo.AddValue(text, JToken.ReadFrom(jsonReader_0));
					goto IL_0111;
					IL_023B:
					if (jsonReader_0.Read())
					{
						goto IL_0227;
					}
					goto IL_03E6;
					Block_10:
					goto IL_023B;
					Block_12:
					goto IL_02A8;
					Block_6:
					goto IL_02C3;
					IL_0017:
					this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, Class15.smethod_17(649933202 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff).FormatWith(CultureInfo.InvariantCulture, jsonISerializableContract_0.UnderlyingType)), null);
					num = 28;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
					{
						goto IL_006E;
					}
					goto IL_03E5;
					IL_011D:
					tokenType = jsonReader_0.TokenType;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
					{
						goto IL_006E;
					}
					IL_0115:
					if (jsonReader_0.Read())
					{
						goto IL_011D;
					}
					goto IL_013C;
					IL_0175:
					obj = jsonISerializableContract_0.ObjectConstructor_0(new object[]
					{
						serializationInfo,
						this.Serializer._context
					});
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
					{
						goto IL_01B5;
					}
					goto IL_006E;
					IL_015F:
					if (!jsonISerializableContract_0.IsInstantiable)
					{
						goto IL_03B9;
					}
					if (jsonISerializableContract_0.ObjectConstructor_0 != null)
					{
						goto IL_0175;
					}
					goto IL_0391;
					IL_0140:
					this.method_25(jsonReader_0, jsonISerializableContract_0, serializationInfo, Class15.smethod_17(552140854 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f));
					goto IL_015F;
					IL_013C:
					if (!flag)
					{
						goto IL_0140;
					}
					goto IL_015F;
					IL_01BC:
					this.method_17(jsonReader_0, id, obj);
					num = 14;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
					{
						goto Block_5;
					}
					goto IL_006E;
					IL_01B5:
					if (id != null)
					{
						goto IL_01BC;
					}
					goto IL_037B;
					IL_020A:
					flag = false;
					num = 22;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						goto IL_011D;
					}
					goto IL_006E;
					IL_02A8:
					serializationInfo = new SerializationInfo(jsonISerializableContract_0.UnderlyingType, new JsonFormatterConverter(this, jsonISerializableContract_0, member));
					goto IL_020A;
					IL_02C3:
					if (this.TraceWriter.LevelFilter < TraceLevel.Info)
					{
						goto IL_02A8;
					}
					goto IL_0017;
				}
				goto Block_16;
			}
			Block_2:
			goto IL_032B;
			Block_5:
			goto IL_037B;
			goto IL_032B;
			Block_16:
			IL_02EE:
			string text2 = Class15.smethod_17(1176492792 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af) + Environment.NewLine + Class15.smethod_17(1788783897 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c) + Environment.NewLine;
			goto IL_0361;
			IL_032B:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(88998876 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454) + jsonReader_0.TokenType.ToString());
			IL_0361:
			text2 = text2.FormatWith(CultureInfo.InvariantCulture, underlyingType);
			IL_0371:
			throw JsonSerializationException.Create(jsonReader_0, text2);
			IL_037B:
			this.method_21(jsonReader_0, jsonISerializableContract_0, obj);
			IL_0385:
			this.method_22(jsonReader_0, jsonISerializableContract_0, obj);
			return obj;
			IL_0391:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(299913139 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e).FormatWith(CultureInfo.InvariantCulture, underlyingType));
			IL_03B9:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1042128541 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad).FormatWith(CultureInfo.InvariantCulture, jsonISerializableContract_0.UnderlyingType));
			IL_03E5:
			IL_03E6:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(299913191 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e).FormatWith(CultureInfo.InvariantCulture, text));
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x000613D8 File Offset: 0x0005F5D8
		[return: Nullable(2)]
		internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, [Nullable(2)] JsonProperty member)
		{
			JsonContract jsonContract;
			JsonConverter jsonConverter;
			JsonReader jsonReader;
			object obj;
			for (;;)
			{
				IL_00C7:
				jsonContract = this.method_1(type);
				for (;;)
				{
					IL_00B7:
					jsonConverter = this.method_7(jsonContract, null, contract, member);
					for (;;)
					{
						IL_00AD:
						jsonReader = token.CreateReader();
						for (;;)
						{
							jsonReader.MaxDepth = this.Serializer.MaxDepth;
							int num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
							{
								goto IL_0029;
							}
							IL_004C:
							switch (num)
							{
							case 0:
								goto IL_0042;
							case 1:
								IL_0029:
								jsonReader.ReadAndAssert();
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
								{
									goto IL_0042;
								}
								goto IL_004C;
							case 2:
								goto IL_00E7;
							case 3:
							case 5:
								goto IL_00D3;
							case 4:
								goto IL_00AD;
							case 6:
								continue;
							case 7:
								break;
							case 8:
							case 9:
								return obj;
							case 10:
								goto IL_00B7;
							case 11:
								goto IL_00C7;
							default:
								goto IL_0042;
							}
							IL_0006:
							if (jsonConverter.CanRead)
							{
								goto IL_00E7;
							}
							num = 5;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
							{
								goto Block_2;
							}
							goto IL_004C;
							IL_0042:
							if (jsonConverter != null)
							{
								goto IL_0006;
							}
							goto IL_00D3;
						}
					}
				}
			}
			Block_2:
			IL_00D3:
			return this.method_6(jsonReader, type, jsonContract, null, contract, member, null);
			IL_00E7:
			obj = this.method_30(jsonConverter, jsonReader, type, null);
			return obj;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000614DC File Offset: 0x0005F6DC
		private object method_28(JsonReader jsonReader_0, JsonDynamicContract jsonDynamicContract_0, [Nullable(2)] JsonProperty member, [Nullable(2)] string id)
		{
			IL_0001:
			while (jsonDynamicContract_0.IsInstantiable)
			{
				if (jsonDynamicContract_0.DefaultCreator != null)
				{
					goto IL_002E;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
				{
					goto IL_04F8;
				}
				IDynamicMetaObjectProvider dynamicMetaObjectProvider;
				bool flag;
				for (;;)
				{
					IL_0472:
					switch (num)
					{
					case 1:
						goto IL_0396;
					case 2:
					{
						int depth = jsonReader_0.Depth;
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
						{
							goto IL_044E;
						}
						continue;
					}
					case 4:
						goto IL_0566;
					case 5:
						goto IL_0001;
					case 6:
						goto IL_0094;
					case 7:
						goto IL_044E;
					case 8:
					case 11:
						goto IL_03D1;
					case 9:
						goto IL_005E;
					case 10:
						goto IL_0080;
					case 12:
						return dynamicMetaObjectProvider;
					case 13:
					case 24:
						goto IL_0524;
					case 14:
						goto IL_040A;
					case 15:
						goto IL_039D;
					case 16:
						goto IL_002E;
					case 17:
					case 27:
						goto IL_055A;
					case 18:
						goto IL_0053;
					case 19:
						goto IL_043A;
					case 20:
						goto IL_0417;
					case 21:
						goto IL_0066;
					case 22:
						goto IL_008C;
					case 23:
						goto IL_03F2;
					case 25:
						goto IL_00A1;
					case 26:
						goto IL_04EA;
					}
					goto Block_13;
					IL_0066:
					JsonToken tokenType;
					if (tokenType == JsonToken.PropertyName)
					{
						goto IL_0094;
					}
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
					{
						goto IL_0080;
					}
					continue;
					IL_005E:
					tokenType = jsonReader_0.TokenType;
					goto IL_0066;
					IL_0053:
					if (jsonReader_0.Read())
					{
						goto IL_005E;
					}
					goto IL_0381;
					IL_04EA:
					if (!flag)
					{
						goto IL_0053;
					}
					goto IL_0396;
					IL_008C:
					flag = true;
					goto IL_04EA;
					IL_0080:
					if (tokenType != JsonToken.EndObject)
					{
						break;
					}
					goto IL_008C;
					IL_0381:
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
					{
						goto IL_0396;
					}
					continue;
					IL_044E:
					flag = false;
					goto IL_005E;
					IL_00A1:
					string text;
					try
					{
						int num2;
						JsonProperty closestMatchProperty;
						if (!jsonReader_0.Read())
						{
							num2 = 9;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
							{
								goto IL_02D6;
							}
							goto IL_0240;
						}
						else
						{
							closestMatchProperty = jsonDynamicContract_0.Properties.GetClosestMatchProperty(text);
							num2 = 14;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
							{
								goto IL_0233;
							}
							goto IL_0240;
						}
						IL_00ED:
						closestMatchProperty.PropertyContract = this.method_1(closestMatchProperty.PropertyType);
						IL_0101:
						JsonConverter jsonConverter = this.method_7(closestMatchProperty.PropertyContract, closestMatchProperty.Converter, null, null);
						IL_0119:
						if (!this.method_15(closestMatchProperty, jsonConverter, null, member, jsonReader_0, dynamicMetaObjectProvider))
						{
							goto IL_02CE;
						}
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
						{
							goto IL_02FE;
						}
						goto IL_0240;
						IL_0147:
						if (!closestMatchProperty.Writable)
						{
							goto IL_0165;
						}
						IL_0150:
						if (closestMatchProperty.Ignored)
						{
							goto IL_0165;
						}
						IL_0159:
						if (closestMatchProperty.PropertyContract != null)
						{
							goto IL_0101;
						}
						goto IL_00ED;
						IL_0165:
						Type type;
						if (JsonTokenUtils.IsPrimitiveToken(jsonReader_0.TokenType))
						{
							type = jsonReader_0.ValueType;
							goto IL_0199;
						}
						num2 = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
						{
							goto IL_0240;
						}
						IL_0187:
						type = typeof(IDynamicMetaObjectProvider);
						IL_0199:
						Type type2 = type;
						num2 = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
						{
							goto IL_0240;
						}
						IL_01B0:
						JsonContract jsonContract = this.method_1(type2);
						num2 = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
						{
							goto IL_0240;
						}
						IL_01CC:
						JsonConverter jsonConverter2 = this.method_7(jsonContract, null, null, member);
						IL_01D9:
						if (jsonConverter2 == null)
						{
							goto IL_020B;
						}
						IL_01DD:
						if (!jsonConverter2.CanRead)
						{
							goto IL_020B;
						}
						IL_01E6:
						object obj = this.method_30(jsonConverter2, jsonReader_0, type2, null);
						num2 = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
						{
							goto IL_02BC;
						}
						goto IL_0240;
						IL_020B:
						obj = this.method_6(jsonReader_0, type2, jsonContract, null, null, member, null);
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
						{
							goto IL_02BC;
						}
						goto IL_0240;
						IL_0233:
						if (closestMatchProperty == null)
						{
							goto IL_0165;
						}
						goto IL_0147;
						IL_0240:
						switch (num2)
						{
						case 0:
						case 8:
						case 17:
							goto IL_02FE;
						case 1:
						case 6:
							break;
						case 2:
							goto IL_02CE;
						case 3:
							goto IL_01B0;
						case 4:
						case 11:
						case 16:
							goto IL_020B;
						case 5:
							goto IL_01DD;
						case 7:
						case 20:
							goto IL_0101;
						case 9:
							goto IL_0187;
						case 10:
							goto IL_0150;
						case 12:
						case 19:
						case 21:
						case 22:
							goto IL_0165;
						case 13:
							goto IL_0119;
						case 14:
							goto IL_0159;
						case 15:
							goto IL_01CC;
						case 18:
							goto IL_01E6;
						case 23:
							goto IL_01D9;
						case 24:
							goto IL_0233;
						case 25:
							goto IL_0147;
						case 26:
							goto IL_00ED;
						case 27:
							IL_02D6:
							throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(486505468 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c).FormatWith(CultureInfo.InvariantCulture, text));
						default:
							goto IL_02FE;
						}
						IL_02BC:
						jsonDynamicContract_0.TrySetMember(dynamicMetaObjectProvider, text, obj);
						goto IL_02FE;
						IL_02CE:
						jsonReader_0.Skip();
						IL_02FE:
						goto IL_04EA;
					}
					catch (Exception ex)
					{
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
						{
							goto IL_035F;
						}
						IL_0317:
						if (!base.IsErrorHandled(dynamicMetaObjectProvider, jsonDynamicContract_0, text, jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, ex))
						{
							goto IL_037A;
						}
						num3 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
						{
							goto IL_035F;
						}
						IL_0344:
						int depth;
						this.method_38(jsonReader_0, true, depth);
						num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
						{
							goto IL_037C;
						}
						IL_035F:
						switch (num3)
						{
						case 1:
							goto IL_0344;
						case 2:
							goto IL_037C;
						case 3:
							goto IL_0317;
						}
						IL_037A:
						throw;
						IL_037C:
						goto IL_04EA;
					}
					goto IL_0381;
					IL_0094:
					text = jsonReader_0.Value.ToString();
					goto IL_00A1;
				}
				goto IL_0524;
				Block_13:
				goto IL_04F8;
				IL_0524:
				throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(768747726 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7) + jsonReader_0.TokenType.ToString());
				IL_002E:
				if (!jsonDynamicContract_0.DefaultCreatorNonPublic)
				{
					goto IL_043A;
				}
				num = 15;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
				{
					goto IL_0417;
				}
				goto IL_0472;
				IL_039D:
				this.method_25(jsonReader_0, jsonDynamicContract_0, dynamicMetaObjectProvider, Class15.smethod_17(1396525158 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7));
				num = 27;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
				{
					goto IL_03D1;
				}
				goto IL_0472;
				IL_0396:
				if (!flag)
				{
					goto IL_039D;
				}
				goto IL_055A;
				IL_03D1:
				this.method_21(jsonReader_0, jsonDynamicContract_0, dynamicMetaObjectProvider);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
				{
					goto IL_0396;
				}
				goto IL_0472;
				IL_040A:
				this.method_17(jsonReader_0, id, dynamicMetaObjectProvider);
				goto IL_03D1;
				IL_03F2:
				if (id != null)
				{
					goto IL_040A;
				}
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
				{
					goto IL_03D1;
				}
				goto IL_0472;
				IL_043A:
				dynamicMetaObjectProvider = (IDynamicMetaObjectProvider)jsonDynamicContract_0.DefaultCreator();
				goto IL_03F2;
				IL_0417:
				if (this.Serializer._constructorHandling == ConstructorHandling.AllowNonPublicDefaultConstructor)
				{
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
					{
						goto IL_043A;
					}
					goto IL_0472;
				}
				IL_04F8:
				throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(543286776 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89).FormatWith(CultureInfo.InvariantCulture, jsonDynamicContract_0.UnderlyingType));
				IL_055A:
				this.method_22(jsonReader_0, jsonDynamicContract_0, dynamicMetaObjectProvider);
				return dynamicMetaObjectProvider;
			}
			IL_0566:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(432088969 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2).FormatWith(CultureInfo.InvariantCulture, jsonDynamicContract_0.UnderlyingType));
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00061A9C File Offset: 0x0005FC9C
		private object method_29(JsonReader jsonReader_0, JsonObjectContract jsonObjectContract_0, [Nullable(2)] JsonProperty containerProperty, ObjectConstructor<object> objectConstructor_0, [Nullable(2)] string id)
		{
			ValidationUtils.ArgumentNotNull(objectConstructor_0, Class15.smethod_17(1570972031 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406));
			bool flag = jsonObjectContract_0.HasRequiredOrDefaultValueProperties || this.method_18(this.Serializer._defaultValueHandling, DefaultValueHandling.Populate);
			Type underlyingType = jsonObjectContract_0.UnderlyingType;
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Info)
			{
				string text = string.Join(Class15.smethod_17(2008566723 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb), jsonObjectContract_0.CreatorParameters.Select(new Func<JsonProperty, string>(JsonSerializerInternalReader.<>c.<>c_0.method_0)));
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, Class15.smethod_17(89013070 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454).FormatWith(CultureInfo.InvariantCulture, jsonObjectContract_0.UnderlyingType, text)), null);
			}
			List<JsonSerializerInternalReader.CreatorPropertyContext> list = this.method_31(jsonObjectContract_0, containerProperty, jsonReader_0, underlyingType);
			if (flag)
			{
				using (IEnumerator<JsonProperty> enumerator = jsonObjectContract_0.Properties.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						JsonSerializerInternalReader.<>c__DisplayClass38_0 CS$<>8__locals1 = new JsonSerializerInternalReader.<>c__DisplayClass38_0();
						CS$<>8__locals1.jsonProperty_0 = enumerator.Current;
						if (!CS$<>8__locals1.jsonProperty_0.Ignored && list.All(new Func<JsonSerializerInternalReader.CreatorPropertyContext, bool>(CS$<>8__locals1.method_0)))
						{
							list.Add(new JsonSerializerInternalReader.CreatorPropertyContext(CS$<>8__locals1.jsonProperty_0.PropertyName)
							{
								Property = CS$<>8__locals1.jsonProperty_0,
								Presence = new JsonSerializerInternalReader.PropertyPresence?(JsonSerializerInternalReader.PropertyPresence.None)
							});
						}
					}
				}
			}
			object[] array = new object[jsonObjectContract_0.CreatorParameters.Count];
			foreach (JsonSerializerInternalReader.CreatorPropertyContext creatorPropertyContext in list)
			{
				if (flag && creatorPropertyContext.Property != null && creatorPropertyContext.Presence == null)
				{
					object value = creatorPropertyContext.Value;
					JsonSerializerInternalReader.PropertyPresence propertyPresence;
					if (value == null)
					{
						propertyPresence = JsonSerializerInternalReader.PropertyPresence.Null;
					}
					else
					{
						string text2 = value as string;
						if (text2 != null)
						{
							propertyPresence = (JsonSerializerInternalReader.muXyNlttNP(creatorPropertyContext.Property.PropertyType, creatorPropertyContext.Property.PropertyContract, text2) ? JsonSerializerInternalReader.PropertyPresence.Null : JsonSerializerInternalReader.PropertyPresence.Value);
						}
						else
						{
							propertyPresence = JsonSerializerInternalReader.PropertyPresence.Value;
						}
					}
					creatorPropertyContext.Presence = new JsonSerializerInternalReader.PropertyPresence?(propertyPresence);
				}
				JsonProperty jsonProperty = creatorPropertyContext.ConstructorProperty;
				if (jsonProperty == null && creatorPropertyContext.Property != null)
				{
					jsonProperty = jsonObjectContract_0.CreatorParameters.ForgivingCaseSensitiveFind(new Func<JsonProperty, string>(JsonSerializerInternalReader.<>c.<>c_0.method_1), creatorPropertyContext.Property.UnderlyingName);
				}
				if (jsonProperty != null && !jsonProperty.Ignored)
				{
					if (flag)
					{
						JsonSerializerInternalReader.PropertyPresence? propertyPresence2 = creatorPropertyContext.Presence;
						if (!((propertyPresence2.GetValueOrDefault() == JsonSerializerInternalReader.PropertyPresence.None) & (propertyPresence2 != null)))
						{
							propertyPresence2 = creatorPropertyContext.Presence;
							if (!((propertyPresence2.GetValueOrDefault() == JsonSerializerInternalReader.PropertyPresence.Null) & (propertyPresence2 != null)))
							{
								goto IL_032D;
							}
						}
						if (jsonProperty.PropertyContract == null)
						{
							jsonProperty.PropertyContract = this.method_1(jsonProperty.PropertyType);
						}
						if (this.method_18(jsonProperty.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), DefaultValueHandling.Populate))
						{
							creatorPropertyContext.Value = this.method_14(jsonReader_0, jsonProperty.GetResolvedDefaultValue(), CultureInfo.InvariantCulture, jsonProperty.PropertyContract, jsonProperty.PropertyType);
						}
					}
					IL_032D:
					int num = jsonObjectContract_0.CreatorParameters.IndexOf(jsonProperty);
					array[num] = creatorPropertyContext.Value;
					creatorPropertyContext.Used = true;
				}
			}
			object obj = objectConstructor_0(array);
			if (id != null)
			{
				this.method_17(jsonReader_0, id, obj);
			}
			this.method_21(jsonReader_0, jsonObjectContract_0, obj);
			foreach (JsonSerializerInternalReader.CreatorPropertyContext creatorPropertyContext2 in list)
			{
				if (!creatorPropertyContext2.Used && creatorPropertyContext2.Property != null && !creatorPropertyContext2.Property.Ignored)
				{
					JsonSerializerInternalReader.PropertyPresence? propertyPresence2 = creatorPropertyContext2.Presence;
					if (!((propertyPresence2.GetValueOrDefault() == JsonSerializerInternalReader.PropertyPresence.None) & (propertyPresence2 != null)))
					{
						JsonProperty property = creatorPropertyContext2.Property;
						object value2 = creatorPropertyContext2.Value;
						if (this.paSyLmeWi4(property, jsonObjectContract_0, value2))
						{
							property.ValueProvider.SetValue(obj, value2);
							creatorPropertyContext2.Used = true;
						}
						else if (!property.Writable && value2 != null)
						{
							JsonContract jsonContract = this.Serializer._contractResolver.ResolveContract(property.PropertyType);
							if (jsonContract.ContractType != JsonContractType.Array)
							{
								goto IL_0536;
							}
							JsonArrayContract jsonArrayContract = (JsonArrayContract)jsonContract;
							if (jsonArrayContract.CanDeserialize && !jsonArrayContract.IsReadOnlyOrFixedSize)
							{
								object value3 = property.ValueProvider.GetValue(obj);
								if (value3 != null)
								{
									jsonArrayContract = (JsonArrayContract)this.method_2(value3.GetType());
									IList list2;
									if (!jsonArrayContract.ShouldCreateWrapper)
									{
										list2 = (IList)value3;
									}
									else
									{
										IList list3 = jsonArrayContract.CreateWrapper(value3);
										list2 = list3;
									}
									IList list4 = list2;
									if (!list4.IsFixedSize)
									{
										IEnumerable enumerable;
										if (!jsonArrayContract.ShouldCreateWrapper)
										{
											enumerable = (IList)value2;
										}
										else
										{
											IList list3 = jsonArrayContract.CreateWrapper(value2);
											enumerable = list3;
										}
										using (IEnumerator enumerator3 = enumerable.GetEnumerator())
										{
											while (enumerator3.MoveNext())
											{
												object obj2 = enumerator3.Current;
												list4.Add(obj2);
											}
											goto IL_05F5;
										}
										goto IL_0536;
									}
								}
							}
							IL_05F5:
							creatorPropertyContext2.Used = true;
							continue;
							IL_0536:
							if (jsonContract.ContractType != JsonContractType.Dictionary)
							{
								goto IL_05F5;
							}
							JsonDictionaryContract jsonDictionaryContract = (JsonDictionaryContract)jsonContract;
							if (jsonDictionaryContract.IsReadOnlyOrFixedSize)
							{
								goto IL_05F5;
							}
							object value4 = property.ValueProvider.GetValue(obj);
							if (value4 != null)
							{
								IDictionary dictionary;
								if (!jsonDictionaryContract.ShouldCreateWrapper)
								{
									dictionary = (IDictionary)value4;
								}
								else
								{
									IDictionary dictionary2 = jsonDictionaryContract.CreateWrapper(value4);
									dictionary = dictionary2;
								}
								IDictionary dictionary3 = dictionary;
								IDictionary dictionary4;
								if (!jsonDictionaryContract.ShouldCreateWrapper)
								{
									dictionary4 = (IDictionary)value2;
								}
								else
								{
									IDictionary dictionary2 = jsonDictionaryContract.CreateWrapper(value2);
									dictionary4 = dictionary2;
								}
								using (IDictionaryEnumerator enumerator4 = dictionary4.GetEnumerator())
								{
									while (enumerator4.MoveNext())
									{
										DictionaryEntry entry = enumerator4.Entry;
										dictionary3[entry.Key] = entry.Value;
									}
								}
								goto IL_05F5;
							}
							goto IL_05F5;
						}
					}
				}
			}
			if (jsonObjectContract_0.ExtensionDataSetter != null)
			{
				foreach (JsonSerializerInternalReader.CreatorPropertyContext creatorPropertyContext3 in list)
				{
					if (!creatorPropertyContext3.Used)
					{
						JsonSerializerInternalReader.PropertyPresence? propertyPresence2 = creatorPropertyContext3.Presence;
						if (!((propertyPresence2.GetValueOrDefault() == JsonSerializerInternalReader.PropertyPresence.None) & (propertyPresence2 != null)))
						{
							jsonObjectContract_0.ExtensionDataSetter(obj, creatorPropertyContext3.Name, creatorPropertyContext3.Value);
						}
					}
				}
			}
			if (flag)
			{
				foreach (JsonSerializerInternalReader.CreatorPropertyContext creatorPropertyContext4 in list)
				{
					if (creatorPropertyContext4.Property != null)
					{
						this.method_36(obj, jsonReader_0, jsonObjectContract_0, jsonReader_0.Depth, creatorPropertyContext4.Property, creatorPropertyContext4.Presence.GetValueOrDefault(), !creatorPropertyContext4.Used);
					}
				}
			}
			this.method_22(jsonReader_0, jsonObjectContract_0, obj);
			return obj;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00062250 File Offset: 0x00060450
		[return: Nullable(2)]
		private object method_30(JsonConverter jsonConverter_0, JsonReader jsonReader_0, Type type_0, [Nullable(2)] object existingValue)
		{
			IL_008F:
			while (this.TraceWriter != null)
			{
				IL_007B:
				while (this.TraceWriter.LevelFilter >= TraceLevel.Info)
				{
					for (;;)
					{
						this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, Class15.smethod_17(1953657639 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f).FormatWith(CultureInfo.InvariantCulture, type_0, jsonConverter_0.GetType())), null);
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
						{
							switch (num)
							{
							case 1:
								goto IL_007B;
							case 4:
								goto IL_008F;
							case 5:
								continue;
							}
							break;
						}
						break;
					}
					break;
				}
				IL_009B:
				object obj = jsonConverter_0.ReadJson(jsonReader_0, type_0, existingValue, this.method_3());
				if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Info)
				{
					this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, Class15.smethod_17(564864166 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610).FormatWith(CultureInfo.InvariantCulture, type_0, jsonConverter_0.GetType())), null);
				}
				return obj;
			}
			goto IL_009B;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00062364 File Offset: 0x00060564
		private List<JsonSerializerInternalReader.CreatorPropertyContext> method_31(JsonObjectContract jsonObjectContract_0, [Nullable(2)] JsonProperty containerProperty, JsonReader jsonReader_0, Type type_0)
		{
			List<JsonSerializerInternalReader.CreatorPropertyContext> list = new List<JsonSerializerInternalReader.CreatorPropertyContext>();
			bool flag = false;
			string text;
			for (;;)
			{
				JsonToken tokenType = jsonReader_0.TokenType;
				if (tokenType != JsonToken.PropertyName)
				{
					if (tokenType != JsonToken.Comment)
					{
						if (tokenType != JsonToken.EndObject)
						{
							goto Block_18;
						}
						flag = true;
					}
				}
				else
				{
					text = jsonReader_0.Value.ToString();
					JsonSerializerInternalReader.CreatorPropertyContext creatorPropertyContext = new JsonSerializerInternalReader.CreatorPropertyContext(text)
					{
						ConstructorProperty = jsonObjectContract_0.CreatorParameters.GetClosestMatchProperty(text),
						Property = jsonObjectContract_0.Properties.GetClosestMatchProperty(text)
					};
					list.Add(creatorPropertyContext);
					JsonProperty jsonProperty = creatorPropertyContext.ConstructorProperty ?? creatorPropertyContext.Property;
					if (jsonProperty != null)
					{
						if (!jsonProperty.Ignored)
						{
							if (jsonProperty.PropertyContract == null)
							{
								jsonProperty.PropertyContract = this.method_1(jsonProperty.PropertyType);
							}
							JsonConverter jsonConverter = this.method_7(jsonProperty.PropertyContract, jsonProperty.Converter, jsonObjectContract_0, containerProperty);
							if (!jsonReader_0.ReadForType(jsonProperty.PropertyContract, jsonConverter != null))
							{
								goto IL_023C;
							}
							if (jsonConverter != null && jsonConverter.CanRead)
							{
								creatorPropertyContext.Value = this.method_30(jsonConverter, jsonReader_0, jsonProperty.PropertyType, null);
								goto IL_01CD;
							}
							creatorPropertyContext.Value = this.method_6(jsonReader_0, jsonProperty.PropertyType, jsonProperty.PropertyContract, jsonProperty, jsonObjectContract_0, containerProperty, null);
							goto IL_01CD;
						}
						else if (!jsonReader_0.Read())
						{
							break;
						}
					}
					else
					{
						if (!jsonReader_0.Read())
						{
							goto IL_02DB;
						}
						if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
						{
							this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, Class15.smethod_17(768741768 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7).FormatWith(CultureInfo.InvariantCulture, text, jsonObjectContract_0.UnderlyingType)), null);
						}
						if ((jsonObjectContract_0.MissingMemberHandling ?? this.Serializer._missingMemberHandling) == MissingMemberHandling.Error)
						{
							goto Block_13;
						}
					}
					if (jsonObjectContract_0.ExtensionDataSetter != null)
					{
						creatorPropertyContext.Value = this.MwWygFtAqe(jsonObjectContract_0, containerProperty, jsonReader_0);
					}
					else
					{
						jsonReader_0.Skip();
					}
				}
				IL_01CD:
				if (flag)
				{
					goto IL_02B8;
				}
				if (!jsonReader_0.Read())
				{
					goto Block_16;
				}
			}
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1270941770 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112).FormatWith(CultureInfo.InvariantCulture, text));
			Block_13:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1743127190 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8).FormatWith(CultureInfo.InvariantCulture, text, type_0.Name));
			Block_16:
			goto IL_02B8;
			Block_18:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(642167374 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba) + jsonReader_0.TokenType.ToString());
			IL_023C:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(543284650 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89).FormatWith(CultureInfo.InvariantCulture, text));
			IL_02B8:
			if (!flag)
			{
				this.method_25(jsonReader_0, jsonObjectContract_0, null, Class15.smethod_17(1788784947 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c));
			}
			return list;
			IL_02DB:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(2008591037 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb).FormatWith(CultureInfo.InvariantCulture, text));
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00062674 File Offset: 0x00060874
		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, [Nullable(2)] JsonProperty containerMember, [Nullable(2)] JsonProperty containerProperty, [Nullable(2)] string id, out bool createdFromNonDefaultCreator)
		{
			object obj;
			for (;;)
			{
				IL_015D:
				obj = null;
				for (;;)
				{
					IL_014F:
					if (objectContract.OverrideCreator != null)
					{
						goto IL_004C;
					}
					goto IL_0144;
					int num;
					for (;;)
					{
						IL_0099:
						switch (num)
						{
						case 1:
							goto IL_0166;
						case 2:
							goto IL_01B9;
						case 3:
							goto IL_0006;
						case 4:
							goto IL_011C;
						case 5:
							goto IL_014F;
						case 6:
							goto IL_015D;
						case 7:
							return obj;
						case 8:
							goto IL_0034;
						case 9:
							goto IL_0144;
						case 10:
							if (objectContract.ParameterizedCreator == null)
							{
								goto IL_01A2;
							}
							num = 14;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
							{
								continue;
							}
							break;
						case 11:
							goto IL_0190;
						case 12:
						case 20:
						case 24:
							goto IL_01AF;
						case 13:
						case 15:
							goto IL_01A2;
						case 16:
							goto IL_004C;
						case 17:
							goto IL_01B3;
						case 18:
							goto IL_017A;
						case 19:
							goto IL_01ED;
						case 22:
							goto IL_018C;
						case 23:
							goto IL_01C1;
						}
						break;
					}
					goto IL_0029;
					IL_0006:
					if (this.Serializer._constructorHandling == ConstructorHandling.AllowNonPublicDefaultConstructor)
					{
						goto IL_01A2;
					}
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
					{
						goto IL_0029;
					}
					goto IL_0099;
					IL_0034:
					createdFromNonDefaultCreator = true;
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
					{
						goto IL_0006;
					}
					goto IL_0099;
					IL_0029:
					if (objectContract.ParameterizedCreator != null)
					{
						goto IL_0034;
					}
					goto IL_01AF;
					IL_004C:
					if (objectContract.CreatorParameters.Count > 0)
					{
						goto IL_018C;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
					{
						goto Block_4;
					}
					goto IL_0099;
					IL_0144:
					if (objectContract.DefaultCreator == null)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
						{
							goto IL_0029;
						}
						goto IL_0099;
					}
					IL_011C:
					if (objectContract.DefaultCreatorNonPublic)
					{
						goto IL_0006;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
					{
						goto Block_8;
					}
					goto IL_0099;
				}
			}
			Block_4:
			goto IL_0166;
			Block_8:
			goto IL_01A2;
			IL_0166:
			obj = objectContract.OverrideCreator(CollectionUtils.ArrayEmpty<object>());
			goto IL_01AF;
			IL_017A:
			return this.method_29(reader, objectContract, containerMember, objectContract.ParameterizedCreator, id);
			IL_018C:
			createdFromNonDefaultCreator = true;
			IL_0190:
			return this.method_29(reader, objectContract, containerMember, objectContract.OverrideCreator, id);
			IL_01A2:
			obj = objectContract.DefaultCreator();
			IL_01AF:
			if (obj == null)
			{
				goto IL_01B9;
			}
			IL_01B3:
			createdFromNonDefaultCreator = false;
			return obj;
			IL_01B9:
			if (!objectContract.IsInstantiable)
			{
				goto IL_01ED;
			}
			IL_01C1:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1743127932 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8).FormatWith(CultureInfo.InvariantCulture, objectContract.UnderlyingType));
			IL_01ED:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1387503408 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923).FormatWith(CultureInfo.InvariantCulture, objectContract.UnderlyingType));
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0006289C File Offset: 0x00060A9C
		private object method_32(object object_0, JsonReader jsonReader_0, JsonObjectContract jsonObjectContract_0, [Nullable(2)] JsonProperty member, [Nullable(2)] string id)
		{
			Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> dictionary;
			int depth;
			for (;;)
			{
				IL_0001:
				this.method_21(jsonReader_0, jsonObjectContract_0, object_0);
				for (;;)
				{
					IL_000A:
					if (jsonObjectContract_0.HasRequiredOrDefaultValueProperties)
					{
						goto IL_0015;
					}
					goto IL_05B4;
					IL_004A:
					Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> dictionary2;
					dictionary = dictionary2;
					for (;;)
					{
						IL_004C:
						if (id == null)
						{
							goto IL_058A;
						}
						int num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
						{
							goto IL_013D;
						}
						for (;;)
						{
							IL_006A:
							switch (num)
							{
							case 1:
							case 8:
								goto IL_0637;
							case 2:
								goto IL_011B;
							case 3:
								goto IL_000A;
							case 4:
								goto IL_0001;
							case 5:
								goto IL_004C;
							case 6:
								goto IL_013D;
							case 7:
								return object_0;
							case 9:
								goto IL_05B4;
							case 10:
								goto IL_0647;
							case 11:
								goto IL_05A8;
							case 12:
							case 32:
								goto IL_00F9;
							case 13:
							case 16:
								goto IL_06FA;
							case 14:
								goto IL_05A3;
							case 15:
								goto IL_05CB;
							case 17:
							case 26:
								goto IL_0015;
							case 18:
								goto IL_05ED;
							case 19:
								goto IL_016D;
							case 20:
								goto IL_0512;
							case 21:
								goto IL_0592;
							case 22:
								goto IL_059A;
							case 23:
								goto IL_0158;
							case 24:
								goto IL_014A;
							case 25:
							case 31:
								goto IL_05FA;
							case 27:
								goto IL_058A;
							case 28:
								if (!jsonReader_0.Read())
								{
									goto IL_0512;
								}
								num = 7;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
								{
									goto Block_13;
								}
								continue;
							case 29:
								goto IL_0101;
							case 30:
								goto IL_0530;
							}
							goto Block_3;
						}
						Block_13:
						goto IL_00F9;
						IL_05A3:
						bool flag = true;
						goto IL_05ED;
						IL_059A:
						JsonToken tokenType;
						if (tokenType != JsonToken.EndObject)
						{
							goto Block_14;
						}
						goto IL_05A3;
						IL_05A8:
						this.method_17(jsonReader_0, id, object_0);
						goto IL_058A;
						IL_0101:
						if (tokenType == JsonToken.PropertyName)
						{
							goto IL_013D;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
						{
							goto IL_011B;
						}
						goto IL_006A;
						IL_00F9:
						tokenType = jsonReader_0.TokenType;
						goto IL_0101;
						IL_0592:
						flag = false;
						goto IL_00F9;
						IL_058A:
						depth = jsonReader_0.Depth;
						goto IL_0592;
						IL_011B:
						if (tokenType == JsonToken.Comment)
						{
							goto IL_05ED;
						}
						num = 22;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
						{
							goto IL_0512;
						}
						goto IL_006A;
						IL_0158:
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
						{
							goto IL_016D;
						}
						goto IL_006A;
						IL_014A:
						string text;
						if (!this.method_34(jsonReader_0, text))
						{
							goto IL_0158;
						}
						goto IL_05ED;
						IL_013D:
						text = jsonReader_0.Value.ToString();
						goto IL_014A;
						IL_04F8:
						num = 28;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
						{
							goto Block_8;
						}
						goto IL_006A;
						IL_05ED:
						if (!flag)
						{
							goto IL_04F8;
						}
						goto IL_0512;
						IL_016D:
						try
						{
							JsonProperty closestMatchProperty = jsonObjectContract_0.Properties.GetClosestMatchProperty(text);
							JsonConverter jsonConverter;
							for (;;)
							{
								if (closestMatchProperty == null)
								{
									goto IL_0244;
								}
								goto IL_03D8;
								IL_0306:
								int num2;
								switch (num2)
								{
								case 0:
									goto IL_0271;
								case 1:
									goto IL_0433;
								case 2:
									break;
								case 3:
									goto IL_024C;
								case 4:
									goto IL_044F;
								case 5:
									goto IL_02C7;
								case 6:
								case 9:
									goto IL_02B6;
								case 7:
									goto IL_02BE;
								case 8:
								case 15:
								case 28:
									goto IL_0486;
								case 10:
								case 20:
									IL_021D:
									this.method_35(jsonObjectContract_0, member, jsonReader_0, text, object_0);
									num2 = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
									{
										goto Block_21;
									}
									goto IL_0306;
								case 11:
									goto IL_03FA;
								case 12:
									IL_03D8:
									if (!closestMatchProperty.Ignored)
									{
										goto IL_01D7;
									}
									goto IL_03CD;
								case 13:
									IL_0244:
									if (this.TraceWriter != null)
									{
										goto IL_024C;
									}
									goto IL_02B6;
								case 14:
									goto IL_043E;
								case 16:
									goto IL_01E6;
								case 17:
									goto IL_0204;
								case 18:
									goto IL_0385;
								case 19:
									goto IL_042D;
								case 21:
									continue;
								case 22:
									goto IL_03CD;
								case 23:
									goto IL_03A9;
								case 24:
									goto IL_01D7;
								case 25:
									goto IL_045E;
								case 26:
									goto IL_0438;
								case 27:
									goto IL_0182;
								default:
									goto IL_0271;
								}
								IL_019B:
								if (!jsonReader_0.ReadForType(closestMatchProperty.PropertyContract, jsonConverter != null))
								{
									goto IL_045E;
								}
								this.method_37(jsonReader_0, closestMatchProperty, dictionary);
								num2 = 2;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
								{
									break;
								}
								goto IL_0306;
								IL_0182:
								jsonConverter = this.method_7(closestMatchProperty.PropertyContract, closestMatchProperty.Converter, jsonObjectContract_0, member);
								goto IL_019B;
								IL_01E6:
								if (closestMatchProperty.PropertyContract != null)
								{
									goto IL_0182;
								}
								num2 = 16;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
								{
									goto IL_0204;
								}
								goto IL_0306;
								IL_01D7:
								if (this.method_33(jsonReader_0, closestMatchProperty, object_0))
								{
									goto IL_01E6;
								}
								goto IL_03CD;
								IL_024C:
								if (this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
								{
									goto IL_0271;
								}
								num2 = 6;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
								{
									goto IL_02C7;
								}
								goto IL_0306;
								IL_02DB:
								int num3;
								if (num3 == 1)
								{
									goto Block_24;
								}
								if (!jsonReader_0.Read())
								{
									goto IL_0438;
								}
								num2 = 8;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
								{
									goto IL_021D;
								}
								goto IL_0306;
								IL_02BE:
								MissingMemberHandling? missingMemberHandling;
								if (missingMemberHandling == null)
								{
									goto IL_02C7;
								}
								num3 = (int)missingMemberHandling.GetValueOrDefault();
								goto IL_02DB;
								IL_02B6:
								missingMemberHandling = jsonObjectContract_0.MissingMemberHandling;
								goto IL_02BE;
								IL_0271:
								this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, Class15.smethod_17(1387506968 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923).FormatWith(CultureInfo.InvariantCulture, text, jsonObjectContract_0.UnderlyingType)), null);
								goto IL_02B6;
								IL_02C7:
								num3 = (int)this.Serializer._missingMemberHandling;
								goto IL_02DB;
								IL_0385:
								this.method_35(jsonObjectContract_0, member, jsonReader_0, text, object_0);
								num2 = 27;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
								{
									goto Block_28;
								}
								goto IL_0306;
								IL_03A9:
								this.method_37(jsonReader_0, closestMatchProperty, dictionary);
								goto IL_0385;
								IL_03CD:
								if (jsonReader_0.Read())
								{
									goto IL_03A9;
								}
								num2 = 4;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
								{
									goto Block_29;
								}
								goto IL_0306;
								IL_0204:
								closestMatchProperty.PropertyContract = this.method_1(closestMatchProperty.PropertyType);
								goto IL_0182;
							}
							goto IL_043E;
							Block_21:
							goto IL_0433;
							Block_24:
							goto IL_03FA;
							Block_28:
							Block_29:
							goto IL_042D;
							IL_03FA:
							throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(594406170 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b).FormatWith(CultureInfo.InvariantCulture, text, jsonObjectContract_0.UnderlyingType.Name));
							IL_042D:
							IL_0433:
							IL_0438:
							goto IL_05ED;
							IL_043E:
							if (this.method_15(closestMatchProperty, jsonConverter, jsonObjectContract_0, member, jsonReader_0, object_0))
							{
								goto IL_0486;
							}
							IL_044F:
							this.method_35(jsonObjectContract_0, member, jsonReader_0, text, object_0);
							goto IL_0486;
							IL_045E:
							throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1788776519 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c).FormatWith(CultureInfo.InvariantCulture, text));
							IL_0486:
							goto IL_05ED;
						}
						catch (Exception ex)
						{
							int num4 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
							{
								for (;;)
								{
									switch (num4)
									{
									case 1:
										if (!base.IsErrorHandled(object_0, jsonObjectContract_0, text, jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, ex))
										{
											goto IL_04F1;
										}
										num4 = 0;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
										{
											continue;
										}
										break;
									case 2:
										goto IL_04F3;
									case 3:
										goto IL_04F1;
									}
									break;
								}
								goto IL_04E5;
								IL_04F1:
								throw;
							}
							IL_04E5:
							this.method_38(jsonReader_0, true, depth);
							IL_04F3:
							goto IL_05ED;
						}
						goto IL_04F8;
						IL_0512:
						if (flag)
						{
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
							{
								goto IL_006A;
							}
							goto IL_0633;
						}
						IL_0530:
						this.method_25(jsonReader_0, jsonObjectContract_0, object_0, Class15.smethod_17(543292638 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89));
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
						{
							goto Block_11;
						}
						goto IL_006A;
					}
					IL_0015:
					IEnumerable<JsonProperty> properties = jsonObjectContract_0.Properties;
					Func<JsonProperty, JsonProperty> func;
					if ((func = JsonSerializerInternalReader.<>c.func_2) == null)
					{
						func = (JsonSerializerInternalReader.<>c.func_2 = new Func<JsonProperty, JsonProperty>(JsonSerializerInternalReader.<>c.<>c_0.method_2));
					}
					dictionary2 = properties.ToDictionary(func, new Func<JsonProperty, JsonSerializerInternalReader.PropertyPresence>(JsonSerializerInternalReader.<>c.<>c_0.method_3));
					goto IL_004A;
					IL_05CB:
					dictionary2 = null;
					goto IL_004A;
					IL_05B4:
					if (!this.method_18(this.Serializer._defaultValueHandling, DefaultValueHandling.Populate))
					{
						goto IL_05CB;
					}
					goto IL_0015;
				}
			}
			Block_3:
			goto IL_063E;
			Block_8:
			Block_11:
			goto IL_0637;
			Block_14:
			IL_05FA:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(2021146472 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8) + jsonReader_0.TokenType.ToString());
			IL_0633:
			IL_0637:
			if (dictionary == null)
			{
				goto IL_06FA;
			}
			IL_063E:
			Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence>.Enumerator enumerator = dictionary.GetEnumerator();
			IL_0647:
			try
			{
				for (;;)
				{
					if (enumerator.MoveNext())
					{
						goto IL_0685;
					}
					int num5 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
					{
						break;
					}
					IL_0665:
					KeyValuePair<JsonProperty, JsonSerializerInternalReader.PropertyPresence> keyValuePair;
					switch (num5)
					{
					case 1:
						goto IL_0691;
					case 2:
						goto IL_069A;
					case 3:
						continue;
					case 4:
						IL_0685:
						keyValuePair = enumerator.Current;
						goto IL_064B;
					case 5:
						goto IL_064B;
					}
					break;
					IL_064B:
					JsonProperty key = keyValuePair.Key;
					num5 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						goto IL_0665;
					}
					goto IL_0691;
					IL_069A:
					JsonSerializerInternalReader.PropertyPresence value;
					this.method_36(object_0, jsonReader_0, jsonObjectContract_0, depth, key, value, true);
					continue;
					IL_0691:
					value = keyValuePair.Value;
					goto IL_069A;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num6 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
				{
					switch (num6)
					{
					}
				}
			}
			IL_06FA:
			this.method_22(jsonReader_0, jsonObjectContract_0, object_0);
			return object_0;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00062FE4 File Offset: 0x000611E4
		private bool method_33(JsonReader jsonReader_0, JsonProperty jsonProperty_0, object object_0)
		{
			while (jsonProperty_0.ShouldDeserialize != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					goto IL_00A5;
				}
				IL_00E4:
				bool flag;
				switch (num)
				{
				case 0:
					goto IL_0046;
				case 1:
					goto IL_00C5;
				case 2:
					IL_00A5:
					flag = jsonProperty_0.ShouldDeserialize(object_0);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
					{
						goto IL_00C5;
					}
					goto IL_00E4;
				case 3:
					continue;
				case 4:
					break;
				case 5:
					return true;
				case 6:
					return flag;
				default:
					goto IL_0046;
				}
				IL_0020:
				if (this.TraceWriter.LevelFilter < TraceLevel.Verbose)
				{
					return flag;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
				{
					goto IL_00E4;
				}
				IL_0046:
				this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(null, jsonReader_0.Path, Class15.smethod_17(538781189 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa).FormatWith(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName, jsonProperty_0.DeclaringType, flag)), null);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
				{
					return flag;
				}
				goto IL_00E4;
				IL_00C5:
				if (this.TraceWriter != null)
				{
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
					{
						goto IL_0020;
					}
					goto IL_00E4;
				}
				return flag;
			}
			return true;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00063110 File Offset: 0x00061310
		private bool method_34(JsonReader jsonReader_0, string string_0)
		{
			while (this.Serializer.MetadataPropertyHandling == MetadataPropertyHandling.ReadAhead)
			{
				int num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
				{
					goto IL_0015;
				}
				IL_0046:
				switch (num)
				{
				case 0:
					goto IL_00BE;
				case 1:
					break;
				case 2:
				case 7:
				case 8:
					goto IL_00DB;
				case 3:
					goto IL_00A1;
				case 4:
					IL_0015:
					if (string_0 == Class15.smethod_17(1760313533 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039))
					{
						goto IL_00DB;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
					{
						goto IL_0046;
					}
					break;
				case 5:
					continue;
				case 6:
					return true;
				default:
					goto IL_00BE;
				}
				if (string_0 == Class15.smethod_17(926411513 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296))
				{
					goto IL_00DB;
				}
				IL_00A1:
				if (string_0 == Class15.smethod_17(1424582490 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf))
				{
					goto IL_00DB;
				}
				IL_00BE:
				if (!(string_0 == Class15.smethod_17(314803361 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927)))
				{
					break;
				}
				IL_00DB:
				jsonReader_0.Skip();
				return true;
			}
			return false;
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00063204 File Offset: 0x00061404
		private void method_35(JsonObjectContract jsonObjectContract_0, [Nullable(2)] JsonProperty member, JsonReader jsonReader_0, string string_0, object object_0)
		{
			for (;;)
			{
				if (jsonObjectContract_0.ExtensionDataSetter == null)
				{
					goto IL_0003;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
				{
					break;
				}
				IL_001D:
				switch (num)
				{
				case 1:
					goto IL_005D;
				case 2:
					continue;
				case 3:
					IL_0003:
					jsonReader_0.Skip();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
					{
						goto IL_001D;
					}
					break;
				}
				break;
			}
			return;
			IL_005D:
			try
			{
				object obj = this.MwWygFtAqe(jsonObjectContract_0, member, jsonReader_0);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
				{
					goto IL_00A0;
				}
				do
				{
					IL_007B:
					jsonObjectContract_0.ExtensionDataSetter(object_0, string_0, obj);
					num2 = 1;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0);
				IL_00A0:
				switch (num2)
				{
				case 0:
					goto IL_007B;
				case 1:
					break;
				default:
					goto IL_007B;
				}
			}
			catch (Exception ex)
			{
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
				{
					switch (num3)
					{
					}
				}
				throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1571023167 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406).FormatWith(CultureInfo.InvariantCulture, jsonObjectContract_0.UnderlyingType), ex);
			}
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00063324 File Offset: 0x00061524
		[return: Nullable(2)]
		private object MwWygFtAqe(JsonObjectContract jsonObjectContract_0, [Nullable(2)] JsonProperty member, JsonReader jsonReader_0)
		{
			while (jsonObjectContract_0.ExtensionDataIsJToken)
			{
				int num = 0;
				object obj;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
				{
					switch (num)
					{
					case 0:
						goto IL_0046;
					case 1:
						break;
					case 2:
						continue;
					case 3:
					case 4:
						return obj;
					default:
						goto IL_0046;
					}
				}
				obj = JToken.ReadFrom(jsonReader_0);
				return obj;
			}
			IL_0046:
			return this.method_6(jsonReader_0, null, null, null, jsonObjectContract_0, member, null);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00063388 File Offset: 0x00061588
		private void method_36(object object_0, JsonReader jsonReader_0, JsonObjectContract jsonObjectContract_0, int int_0, JsonProperty jsonProperty_0, JsonSerializerInternalReader.PropertyPresence propertyPresence_0, bool bool_0)
		{
			for (;;)
			{
				if (propertyPresence_0 != JsonSerializerInternalReader.PropertyPresence.None)
				{
					goto IL_0003;
				}
				goto IL_0038;
				IL_001C:
				int num;
				switch (num)
				{
				case 1:
					IL_0038:
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
					{
						goto IL_001C;
					}
					break;
				case 2:
					IL_0003:
					if (propertyPresence_0 != JsonSerializerInternalReader.PropertyPresence.Null)
					{
						return;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
					{
						goto IL_001C;
					}
					break;
				case 3:
					continue;
				case 4:
					return;
				}
				break;
			}
			try
			{
				Required required;
				if (jsonProperty_0.Ignored)
				{
					required = Required.Default;
					goto IL_02E1;
				}
				int num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
				{
					goto IL_020A;
				}
				goto IL_0240;
				IL_0081:
				if (propertyPresence_0 != JsonSerializerInternalReader.PropertyPresence.Null)
				{
					num2 = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
					{
						goto IL_0240;
					}
					goto IL_038A;
				}
				IL_008C:
				Required required2;
				if (required2 == Required.Always)
				{
					num2 = 21;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
					{
						goto IL_038A;
					}
					goto IL_0240;
				}
				else
				{
					if (required2 != Required.DisallowNull)
					{
						goto IL_038A;
					}
					num2 = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						goto IL_038A;
					}
					goto IL_0240;
				}
				IL_00B9:
				if (required2 == Required.AllowNull)
				{
					goto IL_035D;
				}
				IL_00C1:
				if (required2 == Required.Always)
				{
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
					{
						goto IL_035D;
					}
					goto IL_0240;
				}
				else if (!bool_0)
				{
					num2 = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
					{
						goto IL_038A;
					}
					goto IL_0240;
				}
				IL_00FE:
				if (jsonProperty_0.Ignored)
				{
					goto IL_038A;
				}
				IL_010A:
				if (jsonProperty_0.PropertyContract != null)
				{
					goto IL_013C;
				}
				IL_0113:
				jsonProperty_0.PropertyContract = this.method_1(jsonProperty_0.PropertyType);
				num2 = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
				{
					goto IL_0240;
				}
				IL_013C:
				if (!this.method_18(jsonProperty_0.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), DefaultValueHandling.Populate))
				{
					num2 = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
					{
						goto IL_038A;
					}
					goto IL_0240;
				}
				IL_017A:
				if (!jsonProperty_0.Writable)
				{
					goto IL_038A;
				}
				IL_0186:
				jsonProperty_0.ValueProvider.SetValue(object_0, this.method_14(jsonReader_0, jsonProperty_0.GetResolvedDefaultValue(), CultureInfo.InvariantCulture, jsonProperty_0.PropertyContract, jsonProperty_0.PropertyType));
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
				{
					goto IL_038A;
				}
				goto IL_0240;
				IL_01CB:
				Required? required3;
				if (required3 != null)
				{
					num2 = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
					{
						goto IL_00FE;
					}
					goto IL_0240;
				}
				IL_01EB:
				Required? itemRequired = jsonObjectContract_0.ItemRequired;
				num2 = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
				{
					goto IL_02DA;
				}
				goto IL_0240;
				IL_020A:
				required3 = jsonProperty_0._required;
				goto IL_01CB;
				IL_0240:
				switch (num2)
				{
				case 0:
				case 11:
				case 18:
				case 20:
					goto IL_038A;
				case 1:
					goto IL_020A;
				case 2:
					goto IL_035D;
				case 3:
					throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(613146361 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6).FormatWith(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName));
				case 4:
				case 24:
					goto IL_00B9;
				case 5:
					goto IL_00FE;
				case 6:
					goto IL_0081;
				case 7:
					goto IL_00C1;
				case 8:
					required = required3.GetValueOrDefault();
					goto IL_02E1;
				case 9:
				case 17:
					goto IL_013C;
				case 10:
					break;
				case 12:
					IL_02C6:
					if (propertyPresence_0 != JsonSerializerInternalReader.PropertyPresence.None)
					{
						goto IL_0081;
					}
					num2 = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
					{
						goto IL_00B9;
					}
					goto IL_0240;
				case 13:
					goto IL_0186;
				case 14:
					goto IL_01EB;
				case 15:
					goto IL_0113;
				case 16:
					goto IL_010A;
				case 19:
					goto IL_008C;
				case 21:
					throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1176494484 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af).FormatWith(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName));
				case 22:
					goto IL_017A;
				case 23:
					goto IL_01CB;
				default:
					goto IL_038A;
				}
				IL_02DA:
				required = itemRequired.GetValueOrDefault();
				IL_02E1:
				required2 = required;
				goto IL_02C6;
				IL_035D:
				throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1829581917 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae).FormatWith(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName));
				IL_038A:;
			}
			catch (Exception ex)
			{
				int num3 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
				{
					goto IL_03D0;
				}
				IL_03A0:
				if (!base.IsErrorHandled(object_0, jsonObjectContract_0, jsonProperty_0.PropertyName, jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, ex))
				{
					goto IL_03F5;
				}
				num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					goto IL_03E9;
				}
				IL_03D0:
				switch (num3)
				{
				case 1:
					goto IL_03A0;
				case 2:
					goto IL_03F5;
				case 3:
					goto IL_03F7;
				}
				IL_03E9:
				this.method_38(jsonReader_0, true, int_0);
				goto IL_03F7;
				IL_03F5:
				throw;
				IL_03F7:;
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x000637AC File Offset: 0x000619AC
		private void method_37(JsonReader jsonReader_0, JsonProperty jsonProperty_0, [Nullable(new byte[] { 2, 1 })] Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties)
		{
			if (jsonProperty_0 != null && requiredProperties != null)
			{
				JsonToken tokenType = jsonReader_0.TokenType;
				JsonSerializerInternalReader.PropertyPresence propertyPresence;
				if (tokenType != JsonToken.String)
				{
					if (tokenType - JsonToken.Null > 1)
					{
						propertyPresence = JsonSerializerInternalReader.PropertyPresence.Value;
					}
					else
					{
						propertyPresence = JsonSerializerInternalReader.PropertyPresence.Null;
					}
				}
				else
				{
					propertyPresence = (JsonSerializerInternalReader.muXyNlttNP(jsonProperty_0.PropertyType, jsonProperty_0.PropertyContract, (string)jsonReader_0.Value) ? JsonSerializerInternalReader.PropertyPresence.Null : JsonSerializerInternalReader.PropertyPresence.Value);
				}
				requiredProperties[jsonProperty_0] = propertyPresence;
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00063808 File Offset: 0x00061A08
		private void method_38(JsonReader jsonReader_0, bool bool_0, int int_0)
		{
			for (;;)
			{
				base.ClearErrorContext();
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					goto IL_0036;
				}
				IL_004A:
				switch (num)
				{
				case 2:
					IL_0036:
					if (bool_0)
					{
						goto IL_002E;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
					{
						goto IL_004A;
					}
					break;
				case 3:
					continue;
				case 4:
					goto IL_002E;
				case 6:
				case 9:
					goto IL_0003;
				case 7:
				case 8:
					goto IL_000B;
				}
				break;
				IL_0003:
				if (!jsonReader_0.Read())
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
					{
						break;
					}
					goto IL_004A;
				}
				IL_000B:
				if (jsonReader_0.Depth > int_0)
				{
					goto IL_0003;
				}
				break;
				IL_002E:
				jsonReader_0.Skip();
				goto IL_000B;
			}
		}

		// Token: 0x02000115 RID: 277
		[NullableContext(0)]
		internal enum PropertyPresence
		{
			// Token: 0x0400058F RID: 1423
			None,
			// Token: 0x04000590 RID: 1424
			Null,
			// Token: 0x04000591 RID: 1425
			Value
		}

		// Token: 0x02000116 RID: 278
		[Nullable(0)]
		[NullableContext(2)]
		internal class CreatorPropertyContext
		{
			// Token: 0x06000AFE RID: 2814 RVA: 0x000638B0 File Offset: 0x00061AB0
			[NullableContext(1)]
			public CreatorPropertyContext(string name)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
				{
					goto IL_0032;
				}
				IL_001A:
				this.Name = name;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
				{
					return;
				}
				IL_0032:
				switch (num)
				{
				case 0:
					goto IL_001A;
				case 1:
					break;
				default:
					goto IL_001A;
				}
			}

			// Token: 0x04000592 RID: 1426
			[Nullable(1)]
			public readonly string Name;

			// Token: 0x04000593 RID: 1427
			public JsonProperty Property;

			// Token: 0x04000594 RID: 1428
			public JsonProperty ConstructorProperty;

			// Token: 0x04000595 RID: 1429
			public JsonSerializerInternalReader.PropertyPresence? Presence;

			// Token: 0x04000596 RID: 1430
			public object Value;

			// Token: 0x04000597 RID: 1431
			public bool Used;
		}
	}
}
