using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200018F RID: 399
	[Nullable(0)]
	[NullableContext(1)]
	public class DataSetConverter : JsonConverter
	{
		// Token: 0x060011BA RID: 4538 RVA: 0x0008CCD8 File Offset: 0x0008AED8
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			DefaultContractResolver defaultContractResolver;
			DataTableConverter dataTableConverter;
			IEnumerator enumerator;
			for (;;)
			{
				IL_0091:
				int num;
				if (value == null)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
					{
						break;
					}
				}
				else
				{
					DataSet dataSet = (DataSet)value;
					defaultContractResolver = serializer.ContractResolver as DefaultContractResolver;
					dataTableConverter = new DataTableConverter();
					writer.WriteStartObject();
					enumerator = dataSet.Tables.GetEnumerator();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
					{
						break;
					}
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						writer.WriteNull();
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0091;
					case 3:
						return;
					case 4:
						goto IL_019C;
					case 5:
						return;
					}
					goto Block_2;
				}
			}
			Block_2:
			try
			{
				for (;;)
				{
					if (enumerator.MoveNext())
					{
						goto IL_0113;
					}
					int num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
					{
						break;
					}
					IL_00E7:
					DataTable dataTable;
					switch (num2)
					{
					case 0:
						continue;
					case 1:
						goto IL_0147;
					case 2:
						goto IL_00CB;
					case 3:
						IL_0113:
						dataTable = (DataTable)enumerator.Current;
						break;
					case 4:
						break;
					default:
						continue;
					}
					writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName(dataTable.TableName) : dataTable.TableName);
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
					{
						goto IL_00E7;
					}
					IL_00CB:
					dataTableConverter.WriteJson(writer, dataTable, serializer);
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						goto IL_00E7;
					}
				}
				IL_0147:
				goto IL_019C;
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				while (disposable != null)
				{
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
					{
						goto IL_0166;
					}
					IL_017E:
					switch (num3)
					{
					case 1:
						goto IL_019A;
					case 2:
						continue;
					}
					IL_0166:
					disposable.Dispose();
					num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
					{
						goto IL_017E;
					}
					break;
				}
				IL_019A:;
			}
			return;
			IL_019C:
			writer.WriteEndObject();
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0008CE98 File Offset: 0x0008B098
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			DataSet dataSet;
			for (;;)
			{
				IL_01A6:
				int num;
				if (reader.TokenType == JsonToken.Null)
				{
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
					{
						break;
					}
				}
				else
				{
					if (!(objectType == typeof(DataSet)))
					{
						goto IL_0032;
					}
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
					{
						goto IL_00F2;
					}
				}
				DataTable dataTable;
				DataTableConverter dataTableConverter;
				for (;;)
				{
					IL_0153:
					switch (num)
					{
					case 1:
						for (;;)
						{
							bool flag = dataTable != null;
							dataTable = (DataTable)dataTableConverter.ReadJson(reader, typeof(DataTable), dataTable, serializer);
							if (flag)
							{
								goto IL_0059;
							}
							num = 10;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
							{
								goto IL_0153;
							}
						}
						break;
					case 2:
					case 4:
						goto IL_00AA;
					case 3:
						goto IL_0032;
					case 5:
						goto IL_01BA;
					case 6:
						goto IL_01A6;
					case 7:
						goto IL_00F2;
					case 8:
						goto IL_0061;
					case 9:
						return dataSet;
					case 10:
						dataSet.Tables.Add(dataTable);
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
						{
							goto Block_6;
						}
						continue;
					case 11:
						goto IL_0059;
					case 12:
						goto IL_0149;
					}
					goto Block_9;
				}
				IL_0149:
				DataSet dataSet2 = new DataSet();
				goto IL_003D;
				IL_0059:
				reader.ReadAndAssert();
				goto IL_00AA;
				Block_6:
				goto IL_0059;
				Block_9:
				goto IL_008F;
				IL_003D:
				dataSet = dataSet2;
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
				{
					break;
				}
				goto IL_0153;
				IL_0032:
				dataSet2 = (DataSet)Activator.CreateInstance(objectType);
				goto IL_003D;
				IL_0061:
				dataTable = dataSet.Tables[(string)reader.Value];
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
				{
					goto IL_008F;
				}
				goto IL_0153;
				IL_00AA:
				if (reader.TokenType == JsonToken.PropertyName)
				{
					goto IL_0061;
				}
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
				{
					goto Block_5;
				}
				goto IL_0153;
				IL_008F:
				reader.ReadAndAssert();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
				{
					goto IL_00AA;
				}
				goto IL_0153;
				IL_00F2:
				dataTableConverter = new DataTableConverter();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
				{
					goto IL_008F;
				}
				goto IL_0153;
			}
			goto IL_01BA;
			Block_5:
			return dataSet;
			IL_01BA:
			return null;
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00006A27 File Offset: 0x00004C27
		public override bool CanConvert(Type valueType)
		{
			return typeof(DataSet).IsAssignableFrom(valueType);
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x0008D064 File Offset: 0x0008B264
		public DataSetConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
