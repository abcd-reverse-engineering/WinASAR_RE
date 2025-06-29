using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000192 RID: 402
	[Nullable(0)]
	[NullableContext(1)]
	public class DiscriminatedUnionConverter : JsonConverter
	{
		// Token: 0x060011CF RID: 4559 RVA: 0x0008DC5C File Offset: 0x0008BE5C
		private static Type smethod_0(Type type_0)
		{
			object obj2;
			for (;;)
			{
				MethodCall<object, object> getUnionCases = FSharpUtils.Instance.GetUnionCases;
				object obj = null;
				object[] array = new object[2];
				array[0] = type_0;
				obj2 = ((object[])getUnionCases(obj, array)).First<object>();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
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
			return (Type)FSharpUtils.Instance.GetUnionCaseInfoDeclaringType(obj2);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0008DCC8 File Offset: 0x0008BEC8
		private static DiscriminatedUnionConverter.Union smethod_1(Type type_0)
		{
			DiscriminatedUnionConverter.Union union;
			for (;;)
			{
				IL_015B:
				MethodCall<object, object> preComputeUnionTagReader = FSharpUtils.Instance.PreComputeUnionTagReader;
				object obj = null;
				object[] array = new object[2];
				array[0] = type_0;
				union = new DiscriminatedUnionConverter.Union((FSharpFunction)preComputeUnionTagReader(obj, array), new List<DiscriminatedUnionConverter.UnionCase>());
				for (;;)
				{
					MethodCall<object, object> getUnionCases = FSharpUtils.Instance.GetUnionCases;
					object obj2 = null;
					object[] array2 = new object[2];
					array2[0] = type_0;
					object[] array3 = (object[])getUnionCases(obj2, array2);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
					{
						goto IL_00D2;
					}
					IL_00EF:
					DiscriminatedUnionConverter.UnionCase unionCase;
					switch (num)
					{
					case 0:
						goto IL_00D2;
					case 1:
						union.Cases.Add(unionCase);
						break;
					case 2:
					case 3:
						goto IL_00C6;
					case 4:
						break;
					case 5:
						continue;
					case 6:
						goto IL_015B;
					case 7:
						return union;
					case 8:
					case 9:
						goto IL_00A9;
					case 10:
						goto IL_0006;
					default:
						goto IL_00D2;
					}
					int num2;
					num2++;
					goto IL_00A9;
					IL_0006:
					object obj3;
					int num3 = (int)FSharpUtils.Instance.GetUnionCaseInfoTag(obj3);
					string text = (string)FSharpUtils.Instance.GetUnionCaseInfoName(obj3);
					PropertyInfo[] array4 = (PropertyInfo[])FSharpUtils.Instance.GetUnionCaseInfoFields(obj3, new object[0]);
					MethodCall<object, object> preComputeUnionReader = FSharpUtils.Instance.PreComputeUnionReader;
					object obj4 = null;
					object[] array5 = new object[2];
					array5[0] = obj3;
					FSharpFunction fsharpFunction = (FSharpFunction)preComputeUnionReader(obj4, array5);
					MethodCall<object, object> preComputeUnionConstructor = FSharpUtils.Instance.PreComputeUnionConstructor;
					object obj5 = null;
					object[] array6 = new object[2];
					array6[0] = obj3;
					unionCase = new DiscriminatedUnionConverter.UnionCase(num3, text, array4, fsharpFunction, (FSharpFunction)preComputeUnionConstructor(obj5, array6));
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
					{
						goto IL_00D2;
					}
					goto IL_00EF;
					IL_00C6:
					obj3 = array3[num2];
					goto IL_0006;
					IL_00A9:
					if (num2 >= array3.Length)
					{
						return union;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
					{
						goto IL_00C6;
					}
					goto IL_00EF;
					IL_00D2:
					num2 = 0;
					goto IL_00A9;
				}
			}
			return union;
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0008DE60 File Offset: 0x0008C060
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			for (;;)
			{
				IL_02AD:
				DiscriminatedUnionConverter.<>c__DisplayClass8_0 CS$<>8__locals1 = new DiscriminatedUnionConverter.<>c__DisplayClass8_0();
				IL_02A4:
				while (value != null)
				{
					DefaultContractResolver defaultContractResolver = serializer.ContractResolver as DefaultContractResolver;
					for (;;)
					{
						IL_0290:
						Type type = DiscriminatedUnionConverter.threadSafeStore_1.Get(value.GetType());
						for (;;)
						{
							IL_0280:
							DiscriminatedUnionConverter.Union union = DiscriminatedUnionConverter.threadSafeStore_0.Get(type);
							for (;;)
							{
								IL_025C:
								CS$<>8__locals1.int_0 = (int)union.TagReader.Invoke(new object[] { value });
								for (;;)
								{
									IL_023F:
									DiscriminatedUnionConverter.UnionCase unionCase = union.Cases.Single(new Func<DiscriminatedUnionConverter.UnionCase, bool>(CS$<>8__locals1.method_0));
									for (;;)
									{
										IL_0234:
										writer.WriteStartObject();
										for (;;)
										{
											IL_0018:
											writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName(Class15.smethod_17(2008601997 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb)) : Class15.smethod_17(1807937282 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3));
											for (;;)
											{
												IL_01EC:
												writer.WriteValue(unionCase.Name);
												int num = 20;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
												{
													goto IL_00A2;
												}
												do
												{
													IL_017D:
													int num2;
													switch (num)
													{
													case 1:
														return;
													case 2:
														goto IL_003F;
													case 4:
														goto IL_023F;
													case 5:
														num2 = 0;
														num = 6;
														if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
														{
															goto IL_006A;
														}
														continue;
													case 7:
														goto IL_0280;
													case 8:
														goto IL_0234;
													case 9:
														goto IL_00CB;
													case 10:
													case 22:
														goto IL_006A;
													case 11:
														goto IL_0087;
													case 12:
														return;
													case 13:
														goto IL_0018;
													case 14:
														goto IL_005B;
													case 15:
														goto IL_00EC;
													case 16:
														goto IL_0290;
													case 17:
														goto IL_02A4;
													case 18:
														goto IL_02AD;
													case 19:
														goto IL_0064;
													case 20:
														if (unionCase.Fields != null)
														{
															goto IL_00CB;
														}
														break;
													case 21:
														goto IL_025C;
													case 23:
														goto IL_01EC;
													case 24:
														goto IL_02B8;
													}
													break;
													IL_003F:
													object[] array;
													object obj = array[num2];
													num = 14;
													if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
													{
														goto IL_005B;
													}
													continue;
													IL_006A:
													if (num2 < array.Length)
													{
														goto IL_003F;
													}
													num = 5;
													if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
													{
														goto IL_0087;
													}
													continue;
													IL_0064:
													num2++;
													goto IL_006A;
													IL_005B:
													serializer.Serialize(writer, obj);
													goto IL_0064;
													IL_0087:
													writer.WriteEndArray();
													num = 6;
													if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
													{
														break;
													}
													continue;
													IL_00CB:
													if (unionCase.Fields.Length == 0)
													{
														num = 0;
														if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
														{
															break;
														}
														continue;
													}
													IL_00EC:
													object[] array2 = (object[])unionCase.FieldReader.Invoke(new object[] { value });
													writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName(Class15.smethod_17(1471407693 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e)) : Class15.smethod_17(1793904422 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a));
													writer.WriteStartArray();
													array = array2;
													num = 5;
												}
												while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0);
												IL_00A2:
												writer.WriteEndObject();
												num = 0;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
												{
													goto Block_3;
												}
												goto IL_017D;
											}
										}
									}
								}
							}
						}
					}
				}
				goto Block_11;
			}
			Block_3:
			return;
			Block_11:
			IL_02B8:
			writer.WriteNull();
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0008E12C File Offset: 0x0008C32C
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			DiscriminatedUnionConverter.<>c__DisplayClass9_0 CS$<>8__locals1;
			DiscriminatedUnionConverter.UnionCase unionCase;
			string text;
			object[] array;
			for (;;)
			{
				IL_034B:
				CS$<>8__locals1 = new DiscriminatedUnionConverter.<>c__DisplayClass9_0();
				for (;;)
				{
					IL_033B:
					int num;
					if (reader.TokenType == JsonToken.Null)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
						{
							goto Block_17;
						}
					}
					else
					{
						unionCase = null;
						num = 18;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
						{
							goto IL_0166;
						}
					}
					int num2;
					JToken jtoken;
					for (;;)
					{
						IL_0285:
						switch (num)
						{
						case 1:
							goto IL_035B;
						case 2:
							goto IL_033B;
						case 3:
							goto IL_034B;
						case 4:
							goto IL_0278;
						case 5:
							goto IL_009C;
						case 6:
						case 32:
							goto IL_007C;
						case 7:
						case 25:
							goto IL_03EE;
						case 8:
							goto IL_016E;
						case 9:
							goto IL_0023;
						case 10:
							goto IL_0171;
						case 12:
						{
							DiscriminatedUnionConverter.Union union = DiscriminatedUnionConverter.threadSafeStore_0.Get(objectType);
							CS$<>8__locals1.string_0 = reader.Value.ToString();
							IEnumerable<DiscriminatedUnionConverter.UnionCase> cases = union.Cases;
							Func<DiscriminatedUnionConverter.UnionCase, bool> func;
							if ((func = CS$<>8__locals1.func_0) == null)
							{
								func = (CS$<>8__locals1.func_0 = new Func<DiscriminatedUnionConverter.UnionCase, bool>(CS$<>8__locals1.method_0));
							}
							unionCase = cases.SingleOrDefault(func);
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
							{
								goto Block_14;
							}
							continue;
						}
						case 13:
							goto IL_01CC;
						case 14:
							if (!string.Equals(text, Class15.smethod_17(89016022 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454), StringComparison.OrdinalIgnoreCase))
							{
								goto Block_12;
							}
							goto IL_0149;
						case 15:
							goto IL_0102;
						case 16:
							goto IL_013E;
						case 17:
						{
							PropertyInfo propertyInfo;
							array[num2] = jtoken.ToObject(propertyInfo.PropertyType, serializer);
							goto IL_01CC;
						}
						case 18:
							goto IL_0385;
						case 19:
						case 28:
							goto IL_035D;
						case 20:
							goto IL_03C0;
						case 21:
						{
							PropertyInfo propertyInfo = unionCase.Fields[num2];
							num = 17;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
							{
								goto Block_10;
							}
							continue;
						}
						case 22:
							goto IL_00D1;
						case 23:
							goto IL_0085;
						case 24:
							goto IL_0166;
						case 26:
							goto IL_00A6;
						case 27:
							goto IL_0045;
						case 29:
							goto IL_0149;
						case 30:
							goto IL_00B4;
						case 31:
							goto IL_0122;
						case 33:
							goto IL_0400;
						case 34:
							goto IL_041C;
						case 35:
							goto IL_0457;
						case 36:
							goto IL_0484;
						}
						goto Block_16;
						IL_0149:
						reader.ReadAndAssert();
						num = 31;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
						{
							goto Block_8;
						}
						continue;
						IL_01CC:
						num2++;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
						{
							goto Block_11;
						}
					}
					IL_013E:
					reader.ReadAndAssert();
					goto IL_007C;
					IL_0278:
					if (unionCase == null)
					{
						goto Block_15;
					}
					goto IL_013E;
					IL_0122:
					if (reader.TokenType != JsonToken.StartArray)
					{
						goto Block_7;
					}
					JArray jarray = (JArray)JToken.ReadFrom(reader);
					goto IL_013E;
					Block_8:
					goto IL_0122;
					Block_16:
					Block_11:
					goto IL_00F1;
					IL_0023:
					text = reader.Value.ToString();
					num = 24;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
					{
						goto IL_0045;
					}
					goto IL_0285;
					IL_007C:
					if (reader.TokenType != JsonToken.PropertyName)
					{
						goto IL_0085;
					}
					goto IL_0023;
					IL_0045:
					if (string.Equals(text, Class15.smethod_17(613132015 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6), StringComparison.OrdinalIgnoreCase))
					{
						goto IL_0102;
					}
					num = 14;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
					{
						goto IL_007C;
					}
					goto IL_0285;
					IL_00D1:
					jtoken = jarray[num2];
					num = 21;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
					{
						goto IL_0285;
					}
					IL_00F1:
					if (num2 >= jarray.Count)
					{
						goto Block_5;
					}
					goto IL_00D1;
					IL_00B4:
					if (unionCase.Fields.Length != jarray.Count)
					{
						goto Block_4;
					}
					num2 = 0;
					goto IL_00F1;
					IL_00AD:
					if (jarray != null)
					{
						goto IL_00B4;
					}
					goto IL_03EE;
					IL_00A6:
					if (jarray != null)
					{
						goto IL_00AD;
					}
					goto IL_0385;
					IL_009C:
					if (unionCase.Fields.Length != 0)
					{
						goto IL_00A6;
					}
					goto IL_00AD;
					IL_0085:
					if (unionCase != null)
					{
						array = new object[unionCase.Fields.Length];
						goto IL_009C;
					}
					goto IL_041C;
					IL_0102:
					reader.ReadAndAssert();
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
					{
						goto Block_6;
					}
					goto IL_0285;
					IL_0171:
					reader.ReadAndAssert();
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
					{
						goto IL_007C;
					}
					goto IL_0285;
					IL_016E:
					jarray = null;
					goto IL_0171;
					IL_0166:
					CS$<>8__locals1.string_0 = null;
					goto IL_016E;
				}
			}
			Block_4:
			goto IL_03C0;
			Block_5:
			Block_6:
			goto IL_03EE;
			Block_7:
			goto IL_0400;
			Block_10:
			goto IL_035B;
			Block_12:
			goto IL_035D;
			Block_14:
			goto IL_035B;
			Block_15:
			goto IL_0457;
			Block_17:
			IL_035B:
			return null;
			IL_035D:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1471404517 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e).FormatWith(CultureInfo.InvariantCulture, text));
			IL_0385:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(486488666 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c).FormatWith(CultureInfo.InvariantCulture, Class15.smethod_17(41465683 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d)));
			IL_03C0:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(2021147680 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8).FormatWith(CultureInfo.InvariantCulture, CS$<>8__locals1.string_0));
			IL_03EE:
			object[] array2 = new object[] { array };
			goto IL_0484;
			IL_0400:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(594389220 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b));
			IL_041C:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(2008607471 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb).FormatWith(CultureInfo.InvariantCulture, Class15.smethod_17(41465647 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d)));
			IL_0457:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(82250016 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909).FormatWith(CultureInfo.InvariantCulture, CS$<>8__locals1.string_0));
			IL_0484:
			return unionCase.Constructor.Invoke(array2);
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0008E5CC File Offset: 0x0008C7CC
		public override bool CanConvert(Type objectType)
		{
			bool flag;
			for (;;)
			{
				IL_011C:
				object[] array;
				if (!typeof(IEnumerable).IsAssignableFrom(objectType))
				{
					object[] customAttributes = objectType.GetCustomAttributes(true);
					flag = false;
					array = customAttributes;
					goto IL_0103;
				}
				int num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
				{
					break;
				}
				int num2;
				for (;;)
				{
					IL_00B1:
					Type type;
					switch (num)
					{
					case 1:
					case 4:
						goto IL_013A;
					case 2:
						goto IL_0103;
					case 3:
						goto IL_009A;
					case 5:
						return false;
					case 6:
						return false;
					case 7:
						goto IL_011C;
					case 8:
					case 12:
						type = array[num2].GetType();
						num = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
						{
							goto Block_3;
						}
						continue;
					case 10:
						if (!(type.FullName == Class15.smethod_17(594389746 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b)))
						{
							goto IL_009A;
						}
						goto IL_002E;
					case 11:
						goto IL_003A;
					case 13:
						goto IL_002E;
					}
					break;
					IL_003A:
					flag = true;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
					{
						break;
					}
					continue;
					IL_002E:
					FSharpUtils.EnsureInitialized(type.Assembly());
					goto IL_003A;
				}
				goto IL_00F5;
				IL_009A:
				num2++;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
				{
					goto IL_00B1;
				}
				IL_00F5:
				if (num2 >= array.Length)
				{
					break;
				}
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
				{
					goto IL_009A;
				}
				goto IL_00B1;
				IL_0103:
				num2 = 0;
				goto IL_00F5;
			}
			Block_3:
			IL_013A:
			if (flag)
			{
				MethodCall<object, object> isUnion = FSharpUtils.Instance.IsUnion;
				object obj = null;
				object[] array2 = new object[2];
				array2[0] = objectType;
				return (bool)isUnion(obj, array2);
			}
			return false;
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0008E738 File Offset: 0x0008C938
		public DiscriminatedUnionConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0008E76C File Offset: 0x0008C96C
		static DiscriminatedUnionConverter()
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
				{
					goto IL_0006;
				}
				goto IL_006B;
				do
				{
					IL_0041:
					DiscriminatedUnionConverter.threadSafeStore_1 = new ThreadSafeStore<Type, Type>(new Func<Type, Type>(DiscriminatedUnionConverter.smethod_0));
					num = 1;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0);
				IL_006B:
				switch (num)
				{
				case 0:
					goto IL_0041;
				case 1:
					return;
				case 2:
					break;
				case 3:
					IL_0006:
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
					{
						goto IL_006B;
					}
					break;
				case 4:
					continue;
				default:
					goto IL_0041;
				}
				DiscriminatedUnionConverter.threadSafeStore_0 = new ThreadSafeStore<Type, DiscriminatedUnionConverter.Union>(new Func<Type, DiscriminatedUnionConverter.Union>(DiscriminatedUnionConverter.smethod_1));
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
				{
					goto IL_0041;
				}
				goto IL_006B;
			}
		}

		// Token: 0x040007F4 RID: 2036
		private static readonly ThreadSafeStore<Type, DiscriminatedUnionConverter.Union> threadSafeStore_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly ThreadSafeStore<Type, Type> threadSafeStore_1;

		// Token: 0x02000193 RID: 403
		[Nullable(0)]
		internal class Union
		{
			// Token: 0x060011D8 RID: 4568 RVA: 0x00006A4B File Offset: 0x00004C4B
			public Union(FSharpFunction tagReader, List<DiscriminatedUnionConverter.UnionCase> cases)
			{
				this.TagReader = tagReader;
				this.Cases = cases;
			}

			// Token: 0x040007F7 RID: 2039
			public readonly FSharpFunction TagReader;

			// Token: 0x040007F8 RID: 2040
			public readonly List<DiscriminatedUnionConverter.UnionCase> Cases;
		}

		// Token: 0x02000194 RID: 404
		[Nullable(0)]
		internal class UnionCase
		{
			// Token: 0x060011DA RID: 4570 RVA: 0x0008E818 File Offset: 0x0008CA18
			public UnionCase(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor)
			{
				for (;;)
				{
					IL_0071:
					this.Tag = tag;
					for (;;)
					{
						IL_0068:
						this.Name = name;
						for (;;)
						{
							IL_005F:
							this.Fields = fields;
							for (;;)
							{
								this.FieldReader = fieldReader;
								int num = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
								{
									goto IL_000A;
								}
								IL_0023:
								switch (num)
								{
								case 1:
									IL_000A:
									this.Constructor = constructor;
									num = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
									{
										goto IL_0023;
									}
									break;
								case 2:
									goto IL_0071;
								case 3:
									goto IL_0068;
								case 4:
									goto IL_005F;
								case 5:
									continue;
								}
								return;
							}
						}
					}
				}
			}

			// Token: 0x040007F9 RID: 2041
			public readonly int Tag;

			// Token: 0x040007FA RID: 2042
			public readonly string Name;

			// Token: 0x040007FB RID: 2043
			public readonly PropertyInfo[] Fields;

			// Token: 0x040007FC RID: 2044
			public readonly FSharpFunction FieldReader;

			// Token: 0x040007FD RID: 2045
			public readonly FSharpFunction Constructor;
		}
	}
}
