using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000190 RID: 400
	[Nullable(0)]
	[NullableContext(1)]
	public class DataTableConverter : JsonConverter
	{
		// Token: 0x060011C1 RID: 4545 RVA: 0x0008D098 File Offset: 0x0008B298
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			for (;;)
			{
				DefaultContractResolver defaultContractResolver;
				IEnumerator enumerator;
				if (value != null)
				{
					DataTable dataTable = (DataTable)value;
					defaultContractResolver = serializer.ContractResolver as DefaultContractResolver;
					writer.WriteStartArray();
					enumerator = dataTable.Rows.GetEnumerator();
					goto IL_0338;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
				{
					break;
				}
				IL_0318:
				switch (num)
				{
				case 1:
					goto IL_035F;
				case 2:
					continue;
				case 3:
					return;
				case 4:
					return;
				case 5:
					IL_0338:
					try
					{
						for (;;)
						{
							if (enumerator.MoveNext())
							{
								goto IL_0261;
							}
							int num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
							{
								break;
							}
							goto IL_020B;
							IL_0036:
							writer.WriteEndObject();
							num2 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
							{
								continue;
							}
							goto IL_020B;
							IL_0056:
							IEnumerator enumerator2;
							DataRow dataRow;
							try
							{
								for (;;)
								{
									IL_018F:
									if (enumerator2.MoveNext())
									{
										goto IL_0162;
									}
									int num3 = 4;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
									{
										break;
									}
									object obj;
									for (;;)
									{
										IL_0113:
										switch (num3)
										{
										case 1:
											goto IL_0162;
										case 2:
										case 9:
											goto IL_018F;
										case 3:
											goto IL_007B;
										case 4:
											goto IL_00BE;
										case 5:
											serializer.Serialize(writer, obj);
											num3 = 3;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
											{
												goto Block_16;
											}
											continue;
										case 6:
											goto IL_005D;
										case 7:
											goto IL_019C;
										case 8:
											goto IL_0143;
										}
										goto Block_21;
									}
									Block_16:
									continue;
									Block_21:
									goto IL_00F3;
									IL_005D:
									if (obj != null)
									{
										goto IL_007B;
									}
									num3 = 2;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
									{
										continue;
									}
									goto IL_0113;
									IL_00F3:
									if (serializer.NullValueHandling == NullValueHandling.Ignore)
									{
										num3 = 0;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
										{
											goto IL_005D;
										}
										goto IL_0113;
									}
									IL_00BE:
									DataColumn dataColumn;
									writer.WritePropertyName((defaultContractResolver == null) ? dataColumn.ColumnName : defaultContractResolver.GetResolvedPropertyName(dataColumn.ColumnName));
									num3 = 5;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
									{
										goto IL_00F3;
									}
									goto IL_0113;
									IL_007B:
									if (obj == DBNull.Value)
									{
										continue;
									}
									num3 = 4;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
									{
										continue;
									}
									goto IL_0113;
									IL_0143:
									obj = dataRow[dataColumn];
									num3 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
									{
										goto IL_00F3;
									}
									goto IL_0113;
									IL_0162:
									dataColumn = (DataColumn)enumerator2.Current;
									goto IL_0143;
								}
								IL_019C:
								goto IL_0036;
							}
							finally
							{
								IDisposable disposable = enumerator2 as IDisposable;
								int num4 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
								{
									goto IL_01D9;
								}
								goto IL_01F1;
								IL_01BE:
								disposable.Dispose();
								num4 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
								{
									goto IL_020A;
								}
								goto IL_01F1;
								IL_01D9:
								if (disposable != null)
								{
									goto IL_01BE;
								}
								num4 = 3;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
								{
									goto IL_01BE;
								}
								IL_01F1:
								switch (num4)
								{
								case 0:
									goto IL_01D9;
								case 1:
								case 3:
									break;
								case 2:
									goto IL_01BE;
								default:
									goto IL_01D9;
								}
								IL_020A:;
							}
							goto IL_020B;
							IL_022F:
							enumerator2 = dataRow.Table.Columns.GetEnumerator();
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
							{
								goto IL_0056;
							}
							goto IL_020B;
							IL_0259:
							writer.WriteStartObject();
							goto IL_022F;
							IL_0261:
							dataRow = (DataRow)enumerator.Current;
							goto IL_0259;
							IL_020B:
							switch (num2)
							{
							case 1:
								goto IL_0056;
							case 2:
								continue;
							case 3:
								goto IL_0036;
							case 4:
								goto IL_0259;
							case 5:
								goto IL_0261;
							case 6:
								goto IL_022F;
							}
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num5 = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
						{
							do
							{
								switch (num5)
								{
								case 2:
									goto IL_02CC;
								case 3:
									if (disposable != null)
									{
										goto IL_02CC;
									}
									num5 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
									{
										continue;
									}
									break;
								}
								break;
								IL_02CC:
								disposable.Dispose();
								num5 = 1;
							}
							while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0);
						}
					}
					break;
				}
				writer.WriteEndArray();
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
				{
					goto IL_0318;
				}
			}
			IL_035F:
			writer.WriteNull();
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0008D444 File Offset: 0x0008B644
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			for (;;)
			{
				DataTable dataTable;
				if (reader.TokenType != JsonToken.Null)
				{
					dataTable = existingValue as DataTable;
					goto IL_017C;
				}
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
				{
					break;
				}
				IL_00E3:
				switch (num)
				{
				case 0:
					goto IL_0096;
				case 1:
					goto IL_0159;
				case 2:
					goto IL_00B7;
				case 3:
				case 10:
					break;
				case 4:
					return dataTable;
				case 5:
					goto IL_0030;
				case 6:
					goto IL_01B6;
				case 7:
					continue;
				case 8:
					return dataTable;
				case 9:
					goto IL_007E;
				case 11:
					goto IL_0026;
				case 12:
					goto IL_016D;
				case 13:
					IL_017C:
					if (dataTable == null)
					{
						goto IL_0052;
					}
					goto IL_016D;
				case 14:
					goto IL_01B8;
				case 15:
					goto IL_0052;
				case 16:
					goto IL_0160;
				default:
					goto IL_0096;
				}
				IL_0019:
				if (reader.TokenType != JsonToken.EndArray)
				{
					goto IL_0026;
				}
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					break;
				}
				goto IL_00E3;
				IL_0146:
				if (reader.TokenType == JsonToken.StartArray)
				{
					reader.ReadAndAssert();
					goto IL_0019;
				}
				num = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
				{
					goto IL_0159;
				}
				goto IL_00E3;
				IL_0096:
				if (reader.TokenType != JsonToken.Null)
				{
					goto IL_0146;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
				{
					goto IL_0019;
				}
				goto IL_00E3;
				IL_0052:
				if (!(objectType == typeof(DataTable)))
				{
					goto IL_0160;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
				{
					goto IL_0159;
				}
				goto IL_00E3;
				IL_007E:
				reader.ReadAndAssert();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
				{
					goto IL_0096;
				}
				goto IL_00E3;
				IL_00B7:
				dataTable.TableName = (string)reader.Value;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
				{
					goto IL_007E;
				}
				goto IL_00E3;
				IL_0030:
				reader.ReadAndAssert();
				goto IL_0019;
				IL_0026:
				DataTableConverter.smethod_0(reader, dataTable, serializer);
				goto IL_0030;
				IL_016D:
				if (reader.TokenType == JsonToken.PropertyName)
				{
					goto IL_00B7;
				}
				goto IL_0146;
				IL_016B:
				DataTable dataTable2;
				dataTable = dataTable2;
				goto IL_016D;
				IL_0160:
				dataTable2 = (DataTable)Activator.CreateInstance(objectType);
				goto IL_016B;
				IL_0159:
				dataTable2 = new DataTable();
				goto IL_016B;
			}
			IL_01B6:
			return null;
			IL_01B8:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1603856836 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c).FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0008D63C File Offset: 0x0008B83C
		private static void smethod_0(JsonReader jsonReader_0, DataTable dataTable_0, JsonSerializer jsonSerializer_0)
		{
			DataRow dataRow;
			for (;;)
			{
				IL_03C5:
				dataRow = dataTable_0.NewRow();
				for (;;)
				{
					IL_03BD:
					jsonReader_0.ReadAndAssert();
					for (;;)
					{
						IL_03AE:
						if (jsonReader_0.TokenType != JsonToken.PropertyName)
						{
							goto IL_01ED;
						}
						goto IL_0360;
						int num;
						string text;
						DataColumn dataColumn;
						List<object> list;
						Array array;
						for (;;)
						{
							IL_02A9:
							switch (num)
							{
							case 1:
								goto IL_009A;
							case 2:
								goto IL_018D;
							case 3:
							case 37:
								goto IL_01BA;
							case 4:
							case 24:
							case 33:
								goto IL_03A8;
							case 5:
							case 21:
								goto IL_011B;
							case 6:
								dataColumn = dataTable_0.Columns[text];
								num = 39;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
								{
									goto IL_0006;
								}
								continue;
							case 7:
							case 19:
								goto IL_002A;
							case 8:
								goto IL_0115;
							case 9:
								goto IL_016B;
							case 10:
							case 12:
								goto IL_03AE;
							case 11:
								return;
							case 13:
								goto IL_007C;
							case 14:
								goto IL_0059;
							case 15:
								goto IL_001D;
							case 16:
								goto IL_03CF;
							case 17:
								goto IL_0278;
							case 18:
								goto IL_00E0;
							case 20:
								goto IL_00BA;
							case 22:
								goto IL_0257;
							case 23:
								goto IL_019F;
							case 25:
								jsonReader_0.ReadAndAssert();
								num = 6;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
								{
									goto Block_14;
								}
								continue;
							case 26:
								goto IL_0196;
							case 27:
								goto IL_00F9;
							case 28:
								goto IL_039D;
							case 29:
								goto IL_0218;
							case 30:
								goto IL_0012;
							case 31:
								goto IL_0387;
							case 32:
								goto IL_000A;
							case 34:
								((ICollection)list).CopyTo(array, 0);
								goto IL_0218;
							case 35:
								goto IL_01ED;
							case 36:
								if (jsonReader_0.TokenType != JsonToken.StartArray)
								{
									goto IL_018D;
								}
								num = 17;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
								{
									goto Block_11;
								}
								continue;
							case 38:
								goto IL_00C3;
							case 39:
								goto IL_03BD;
							case 40:
								goto IL_03C5;
							case 41:
								goto IL_0006;
							case 42:
								goto IL_0360;
							}
							goto Block_17;
							IL_002A:
							if (!(dataColumn.DataType == typeof(DataTable)))
							{
								goto IL_0059;
							}
							num = 36;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
							{
								break;
							}
							continue;
							IL_0006:
							if (dataColumn == null)
							{
								goto IL_000A;
							}
							goto IL_002A;
							IL_0059:
							if (!dataColumn.DataType.IsArray)
							{
								goto IL_00C3;
							}
							num = 22;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
							{
								break;
							}
							continue;
							IL_0218:
							dataRow[text] = array;
							num = 33;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
							{
								goto Block_13;
							}
							continue;
							IL_001D:
							dataTable_0.Columns.Add(dataColumn);
							goto IL_002A;
							IL_0012:
							Type type;
							dataColumn = new DataColumn(text, type);
							goto IL_001D;
							IL_000A:
							type = DataTableConverter.smethod_1(jsonReader_0);
							goto IL_0012;
						}
						goto IL_007C;
						IL_0387:
						object obj;
						dataRow[text] = obj;
						Block_11:
						goto IL_03A8;
						Block_17:
						goto IL_013A;
						IL_0278:
						jsonReader_0.ReadAndAssert();
						Block_14:
						goto IL_018D;
						Block_13:
						goto IL_039D;
						IL_009A:
						jsonReader_0.ReadAndAssert();
						num = 20;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
						{
							continue;
						}
						goto IL_02A9;
						IL_007C:
						if (jsonReader_0.TokenType != JsonToken.StartArray)
						{
							goto IL_00BA;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
						{
							goto IL_009A;
						}
						goto IL_02A9;
						IL_03A8:
						jsonReader_0.ReadAndAssert();
						continue;
						IL_0257:
						if (dataColumn.DataType != typeof(byte[]))
						{
							goto IL_007C;
						}
						IL_00C3:
						object obj2;
						if (jsonReader_0.Value == null)
						{
							num = 15;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
							{
								goto IL_00E0;
							}
							goto IL_02A9;
						}
						else if ((obj2 = jsonSerializer_0.Deserialize(jsonReader_0, dataColumn.DataType)) == null)
						{
							goto IL_00F9;
						}
						IL_00FE:
						obj = obj2;
						num = 31;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
						{
							goto IL_0115;
						}
						goto IL_02A9;
						IL_00F9:
						obj2 = DBNull.Value;
						goto IL_00FE;
						IL_00E0:
						obj2 = DBNull.Value;
						goto IL_00FE;
						IL_011B:
						if (jsonReader_0.TokenType != JsonToken.EndArray)
						{
							goto IL_016B;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
						{
							goto IL_013A;
						}
						goto IL_02A9;
						IL_0115:
						jsonReader_0.ReadAndAssert();
						goto IL_011B;
						IL_00BA:
						list = new List<object>();
						goto IL_011B;
						IL_013A:
						array = Array.CreateInstance(dataColumn.DataType.GetElementType(), list.Count);
						num = 34;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
						{
							goto IL_018D;
						}
						goto IL_02A9;
						IL_016B:
						list.Add(jsonReader_0.Value);
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
						{
							goto IL_018D;
						}
						goto IL_02A9;
						IL_019F:
						jsonReader_0.ReadAndAssert();
						num = 24;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
						{
							goto IL_01BA;
						}
						goto IL_02A9;
						IL_0196:
						DataTable dataTable;
						DataTableConverter.smethod_0(jsonReader_0, dataTable, jsonSerializer_0);
						goto IL_019F;
						IL_01BA:
						if (jsonReader_0.TokenType == JsonToken.EndArray)
						{
							goto IL_039D;
						}
						goto IL_0196;
						IL_018D:
						dataTable = new DataTable();
						goto IL_01BA;
						IL_01ED:
						dataRow.EndEdit();
						num = 16;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
						{
							goto IL_0115;
						}
						goto IL_02A9;
						IL_0360:
						text = (string)jsonReader_0.Value;
						num = 25;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
						{
							goto IL_0257;
						}
						goto IL_02A9;
						IL_039D:
						dataRow[text] = dataTable;
						goto IL_03A8;
					}
				}
			}
			IL_03CF:
			dataTable_0.Rows.Add(dataRow);
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0008DA28 File Offset: 0x0008BC28
		private static Type smethod_1(JsonReader jsonReader_0)
		{
			JsonToken tokenType;
			for (;;)
			{
				tokenType = jsonReader_0.TokenType;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
				{
					switch (num)
					{
					case 1:
						goto IL_003E;
					case 2:
						continue;
					case 3:
						goto IL_0099;
					case 4:
						goto IL_00BB;
					case 5:
						goto IL_0090;
					}
					break;
				}
				goto IL_003D;
			}
			goto IL_00E8;
			IL_003D:
			IL_003E:
			switch (tokenType)
			{
			case JsonToken.StartArray:
				jsonReader_0.ReadAndAssert();
				break;
			case JsonToken.StartConstructor:
			case JsonToken.PropertyName:
			case JsonToken.Comment:
			case JsonToken.Raw:
			case JsonToken.EndObject:
			case JsonToken.EndConstructor:
				goto IL_00BB;
			case JsonToken.Integer:
			case JsonToken.Float:
			case JsonToken.String:
			case JsonToken.Boolean:
			case JsonToken.Date:
			case JsonToken.Bytes:
				IL_00E8:
				return jsonReader_0.ValueType;
			case JsonToken.Null:
			case JsonToken.Undefined:
			case JsonToken.EndArray:
				return typeof(string);
			default:
				goto IL_00BB;
			}
			IL_0090:
			if (jsonReader_0.TokenType != JsonToken.StartObject)
			{
				return DataTableConverter.smethod_1(jsonReader_0).MakeArrayType();
			}
			IL_0099:
			return typeof(DataTable);
			IL_00BB:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(676679486 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b).FormatWith(CultureInfo.InvariantCulture, tokenType));
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00006A39 File Offset: 0x00004C39
		public override bool CanConvert(Type valueType)
		{
			return typeof(DataTable).IsAssignableFrom(valueType);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0008DB24 File Offset: 0x0008BD24
		public DataTableConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
