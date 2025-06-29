using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000119 RID: 281
	[Nullable(0)]
	[NullableContext(1)]
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase
	{
		// Token: 0x06000B0F RID: 2831 RVA: 0x000639C4 File Offset: 0x00061BC4
		public JsonSerializerInternalWriter(JsonSerializer serializer)
			: base(serializer)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00063A04 File Offset: 0x00061C04
		[NullableContext(2)]
		public void Serialize([Nullable(1)] JsonWriter jsonWriter, object value, Type objectType)
		{
			while (jsonWriter != null)
			{
				this.type_0 = objectType;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						goto IL_003E;
					case 3:
						continue;
					case 4:
						goto IL_0076;
					case 5:
						goto IL_006D;
					}
				}
				this.int_0 = this.list_0.Count + 1;
				IL_006D:
				JsonContract jsonContract = this.method_2(value);
				IL_0076:
				try
				{
					if (this.method_7(value, null, jsonContract, null, null))
					{
						goto IL_00D1;
					}
					int num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
					{
						goto IL_00B5;
					}
					IL_0097:
					this.method_5(jsonWriter, value, jsonContract, null, null, null);
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
					{
						goto IL_00EE;
					}
					IL_00B5:
					switch (num2)
					{
					case 2:
					case 4:
						goto IL_0097;
					case 3:
						IL_00D1:
						this.method_10(jsonWriter, value);
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
						{
							goto IL_00B5;
						}
						break;
					}
					IL_00EE:;
				}
				catch (Exception ex)
				{
					int num3 = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
					{
						goto IL_0147;
					}
					IL_0107:
					if (base.IsErrorHandled(null, jsonContract, null, null, jsonWriter.Path, ex))
					{
						num3 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
						{
							goto IL_0169;
						}
						goto IL_0147;
					}
					IL_0130:
					base.ClearErrorContext();
					num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
					{
						goto IL_0167;
					}
					IL_0147:
					switch (num3)
					{
					case 0:
						goto IL_0130;
					case 1:
						break;
					case 2:
						goto IL_0107;
					case 3:
						goto IL_0169;
					case 4:
						goto IL_0171;
					default:
						goto IL_0130;
					}
					IL_0167:
					throw;
					IL_0169:
					this.method_34(jsonWriter, 0);
					IL_0171:;
				}
				finally
				{
					this.type_0 = null;
					int num4 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						switch (num4)
						{
						}
					}
				}
				return;
			}
			IL_003E:
			throw new ArgumentNullException(Class15.smethod_17(2008561753 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb));
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00063BC8 File Offset: 0x00061DC8
		private JsonSerializerProxy method_1()
		{
			IL_0038:
			while (this.InternalSerializer == null)
			{
				for (;;)
				{
					this.InternalSerializer = new JsonSerializerProxy(this);
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
					{
						break;
					}
					switch (num)
					{
					case 1:
					case 2:
						goto IL_0044;
					case 3:
						goto IL_0038;
					}
				}
				IL_0044:
				return this.InternalSerializer;
			}
			goto IL_0044;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00063C20 File Offset: 0x00061E20
		[NullableContext(2)]
		private JsonContract method_2(object object_0)
		{
			while (object_0 == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return null;
			}
			return this.method_3(object_0);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00004FDD File Offset: 0x000031DD
		private JsonContract method_3(object object_0)
		{
			return this.Serializer._contractResolver.ResolveContract(object_0.GetType());
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00063C64 File Offset: 0x00061E64
		private void method_4(JsonWriter jsonWriter_0, object object_0, JsonPrimitiveContract jsonPrimitiveContract_0, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract containerContract, [Nullable(2)] JsonProperty containerProperty)
		{
			IL_00B3:
			while (jsonPrimitiveContract_0.TypeCode == PrimitiveTypeCode.Bytes)
			{
				for (;;)
				{
					if (this.method_31(TypeNameHandling.Objects, jsonPrimitiveContract_0, member, containerContract, containerProperty))
					{
						goto IL_0084;
					}
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
					{
						goto IL_00C0;
					}
					IL_0027:
					switch (num)
					{
					case 1:
						IL_0084:
						jsonWriter_0.WriteStartObject();
						goto IL_0075;
					case 2:
						goto IL_0075;
					case 3:
						continue;
					case 4:
						goto IL_00B3;
					case 5:
						goto IL_0057;
					case 6:
						goto IL_0006;
					case 7:
						return;
					case 8:
						return;
					case 9:
						goto IL_00CB;
					}
					break;
					IL_0006:
					JsonWriter.WriteValue(jsonWriter_0, jsonPrimitiveContract_0.TypeCode, object_0);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
					{
						goto IL_0027;
					}
					break;
					IL_0057:
					jsonWriter_0.WritePropertyName(Class15.smethod_17(1802347315 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4), false);
					goto IL_0006;
					IL_0075:
					this.method_19(jsonWriter_0, jsonPrimitiveContract_0.CreatedType);
					goto IL_0057;
				}
				goto IL_00C4;
				IL_00C0:
				break;
				IL_00C4:
				jsonWriter_0.WriteEndObject();
				return;
			}
			IL_00CB:
			JsonWriter.WriteValue(jsonWriter_0, jsonPrimitiveContract_0.TypeCode, object_0);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00063D4C File Offset: 0x00061F4C
		[NullableContext(2)]
		private void method_5([Nullable(1)] JsonWriter writer, object object_0, JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
		{
			JsonArrayContract jsonArrayContract;
			JsonConverter jsonConverter2;
			for (;;)
			{
				IL_034C:
				int num;
				if (object_0 == null)
				{
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
					{
						goto IL_0270;
					}
				}
				else
				{
					if (jsonProperty_0 == null)
					{
						goto IL_0024;
					}
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
					{
						goto IL_022F;
					}
				}
				for (;;)
				{
					IL_02A0:
					switch (num)
					{
					case 1:
						goto IL_01E6;
					case 2:
						goto IL_0024;
					case 3:
						return;
					case 4:
						goto IL_0270;
					case 5:
						return;
					case 6:
						goto IL_003B;
					case 7:
						writer.WriteNull();
						num = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
						{
							goto Block_16;
						}
						continue;
					case 8:
						goto IL_034C;
					case 9:
						goto IL_0026;
					case 10:
						goto IL_023F;
					case 11:
						goto IL_0210;
					case 12:
						goto IL_0282;
					case 13:
						return;
					case 14:
						goto IL_036E;
					case 15:
						goto IL_006E;
					case 16:
						goto IL_0356;
					case 17:
						goto IL_00AC;
					case 18:
						goto IL_022F;
					case 19:
						goto IL_03AD;
					case 20:
						return;
					case 21:
						return;
					case 22:
						return;
					case 23:
						goto IL_01C7;
					case 24:
						return;
					case 25:
						return;
					case 26:
						return;
					case 27:
						goto IL_0294;
					case 28:
						return;
					case 29:
						goto IL_002D;
					case 30:
						return;
					case 31:
						return;
					case 32:
						goto IL_006A;
					}
					break;
				}
				goto IL_008F;
				IL_023F:
				JsonConverter jsonConverter;
				if ((jsonConverter = this.Serializer.GetMatchingConverter(jsonContract_0.UnderlyingType)) == null)
				{
					goto IL_0210;
				}
				goto IL_0216;
				Block_16:
				goto IL_003B;
				IL_00AC:
				JsonContractType contractType;
				switch (contractType)
				{
				case JsonContractType.Object:
					this.method_14(writer, object_0, (JsonObjectContract)jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
					{
						goto Block_7;
					}
					goto IL_02A0;
				case JsonContractType.Array:
					jsonArrayContract = (JsonArrayContract)jsonContract_0;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
					{
						goto IL_0024;
					}
					goto IL_02A0;
				case JsonContractType.Primitive:
					goto IL_0381;
				case JsonContractType.String:
					goto IL_0396;
				case JsonContractType.Dictionary:
					goto IL_03A5;
				case JsonContractType.Dynamic:
					this.method_29(writer, (IDynamicMetaObjectProvider)object_0, (JsonDynamicContract)jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
					{
						goto Block_9;
					}
					goto IL_02A0;
				case JsonContractType.Serializable:
					this.method_28(writer, (ISerializable)object_0, (JsonISerializableContract)jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						goto Block_10;
					}
					goto IL_02A0;
				case JsonContractType.Linq:
					((JToken)object_0).WriteTo(writer, this.Serializer.Converters.ToArray<JsonConverter>());
					num = 28;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
					{
						continue;
					}
					goto IL_02A0;
				}
				break;
				IL_008F:
				contractType = jsonContract_0.ContractType;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
				{
					goto IL_00AC;
				}
				goto IL_02A0;
				IL_006A:
				if (jsonConverter2 != null)
				{
					goto IL_006E;
				}
				goto IL_008F;
				IL_0216:
				jsonConverter2 = jsonConverter;
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
				{
					goto IL_006A;
				}
				goto IL_02A0;
				IL_002D:
				if ((jsonConverter = jsonProperty_1.ItemConverter) == null)
				{
					goto IL_003A;
				}
				goto IL_0216;
				IL_0026:
				if (jsonProperty_1 != null)
				{
					goto IL_002D;
				}
				goto IL_0294;
				IL_0025:
				goto IL_0026;
				IL_0024:
				goto IL_0025;
				IL_004F:
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
				{
					goto IL_01C7;
				}
				goto IL_02A0;
				IL_0282:
				goto IL_004F;
				IL_003B:
				if (jsonContainerContract_0 == null)
				{
					goto IL_0282;
				}
				if ((jsonConverter = jsonContainerContract_0.ItemConverter) == null)
				{
					goto IL_004F;
				}
				goto IL_0216;
				IL_003A:
				goto IL_003B;
				IL_006E:
				if (jsonConverter2.CanWrite)
				{
					goto IL_036E;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
				{
					goto IL_008F;
				}
				goto IL_02A0;
				IL_01C7:
				if ((jsonConverter = jsonContract_0.Converter) != null)
				{
					goto IL_0216;
				}
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
				{
					goto IL_01E6;
				}
				goto IL_02A0;
				IL_0210:
				jsonConverter = jsonContract_0.InternalConverter;
				goto IL_0216;
				IL_022F:
				if ((jsonConverter = jsonProperty_0.Converter) == null)
				{
					goto IL_0025;
				}
				goto IL_0216;
				IL_01E6:
				this.method_24(writer, (IEnumerable)object_0, jsonArrayContract, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
				num = 24;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
				{
					goto IL_0210;
				}
				goto IL_02A0;
				IL_0270:
				if (jsonArrayContract.IsMultidimensionalArray)
				{
					goto Block_17;
				}
				goto IL_01E6;
				IL_0294:
				goto IL_003A;
			}
			return;
			Block_7:
			return;
			Block_9:
			return;
			Block_10:
			return;
			Block_17:
			IL_0356:
			this.method_25(writer, (Array)object_0, jsonArrayContract, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
			return;
			IL_036E:
			this.method_23(writer, jsonConverter2, object_0, jsonContract_0, jsonContainerContract_0, jsonProperty_1);
			return;
			IL_0381:
			this.method_4(writer, object_0, (JsonPrimitiveContract)jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
			return;
			IL_0396:
			this.liwyzGqbv3(writer, object_0, (JsonStringContract)jsonContract_0);
			return;
			IL_03A5:
			JsonDictionaryContract jsonDictionaryContract = (JsonDictionaryContract)jsonContract_0;
			IL_03AD:
			IDictionary dictionary = object_0 as IDictionary;
			IDictionary dictionary3;
			if (dictionary == null)
			{
				IDictionary dictionary2 = jsonDictionaryContract.CreateWrapper(object_0);
				dictionary3 = dictionary2;
			}
			else
			{
				dictionary3 = dictionary;
			}
			this.method_32(writer, dictionary3, jsonDictionaryContract, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00064138 File Offset: 0x00062338
		[NullableContext(2)]
		private bool? method_6([Nullable(1)] JsonContract contract, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
		{
			bool? flag = null;
			if (jsonProperty_0 != null)
			{
				flag = jsonProperty_0.IsReference;
			}
			if (flag == null && jsonProperty_1 != null)
			{
				flag = jsonProperty_1.ItemIsReference;
			}
			if (flag == null && jsonContainerContract_0 != null)
			{
				flag = jsonContainerContract_0.ItemIsReference;
			}
			if (flag == null)
			{
				flag = contract.IsReference;
			}
			return flag;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00064190 File Offset: 0x00062390
		[NullableContext(2)]
		private bool method_7(object object_0, JsonProperty jsonProperty_0, JsonContract jsonContract_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
		{
			while (object_0 != null)
			{
				if (jsonContract_0.ContractType != JsonContractType.Primitive)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
					{
						goto IL_0077;
					}
					IL_00A8:
					bool? flag;
					switch (num)
					{
					case 0:
					case 11:
						goto IL_0104;
					case 1:
						IL_0077:
						if (jsonContract_0.ContractType == JsonContractType.String)
						{
							return false;
						}
						flag = this.method_6(jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
						{
							goto IL_0068;
						}
						goto IL_00A8;
					case 2:
						return false;
					case 3:
						continue;
					case 4:
						goto IL_010D;
					case 5:
						goto IL_0068;
					case 6:
						return false;
					case 7:
						goto IL_00E8;
					case 8:
						goto IL_0059;
					case 9:
						break;
					case 10:
						return false;
					default:
						goto IL_0104;
					}
					IL_0029:
					flag = new bool?(this.method_21(this.Serializer._preserveReferencesHandling, PreserveReferencesHandling.Arrays));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						goto IL_0104;
					}
					goto IL_00A8;
					IL_0059:
					if (jsonContract_0.ContractType == JsonContractType.Array)
					{
						goto IL_0029;
					}
					goto IL_00E8;
					IL_0068:
					if (flag == null)
					{
						goto IL_0059;
					}
					goto IL_0104;
					IL_00E8:
					flag = new bool?(this.method_21(this.Serializer._preserveReferencesHandling, PreserveReferencesHandling.Objects));
					IL_0104:
					if (!flag.GetValueOrDefault())
					{
						return false;
					}
					IL_010D:
					return this.Serializer.GetReferenceResolver().IsReferenced(this, object_0);
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x000642C0 File Offset: 0x000624C0
		[NullableContext(2)]
		private bool method_8(object object_0, JsonObjectContract jsonObjectContract_0, [Nullable(1)] JsonProperty property)
		{
			for (;;)
			{
				if (object_0 != null)
				{
					goto IL_003E;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
				{
					break;
				}
				IL_0014:
				switch (num)
				{
				case 1:
					if (base.ResolvedNullValueHandling(jsonObjectContract_0, property) == NullValueHandling.Ignore)
					{
						goto Block_2;
					}
					goto IL_003E;
				case 2:
					continue;
				case 3:
					return false;
				case 4:
					return false;
				}
				break;
				IL_003E:
				if (!this.method_20(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), DefaultValueHandling.Ignore))
				{
					return true;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					goto IL_0014;
				}
				break;
			}
			goto IL_0084;
			Block_2:
			return false;
			IL_0084:
			if (!MiscellaneousUtils.ValueEquals(object_0, property.GetResolvedDefaultValue()))
			{
				return true;
			}
			return false;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00064364 File Offset: 0x00062564
		[NullableContext(2)]
		private bool method_9([Nullable(1)] JsonWriter writer, object object_0, JsonProperty jsonProperty_0, JsonContract jsonContract_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
		{
			IL_033F:
			while (object_0 != null)
			{
				int num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
				{
					goto IL_028C;
				}
				ReferenceLoopHandling? referenceLoopHandling;
				for (;;)
				{
					IL_02A3:
					switch (num)
					{
					case 1:
						goto IL_0222;
					case 2:
						goto IL_028C;
					case 3:
						goto IL_01FB;
					case 4:
					case 23:
						goto IL_01B3;
					case 5:
					case 10:
					case 33:
						goto IL_0134;
					case 6:
						goto IL_025D;
					case 7:
					case 13:
						goto IL_0294;
					case 8:
						goto IL_0275;
					case 9:
						goto IL_0182;
					case 11:
						goto IL_034C;
					case 12:
					case 30:
						goto IL_0219;
					case 14:
						return true;
					case 15:
						goto IL_0365;
					case 16:
						return true;
					case 17:
						if (jsonContract_0.ContractType != JsonContractType.Primitive)
						{
							goto IL_025D;
						}
						return true;
					case 18:
						goto IL_033F;
					case 19:
						goto IL_0249;
					case 20:
						goto IL_0185;
					case 21:
						goto IL_00D3;
					case 22:
						goto IL_016B;
					case 24:
						goto IL_0141;
					case 25:
						goto IL_0229;
					case 26:
						goto IL_0109;
					case 28:
						return true;
					case 29:
					case 32:
						return true;
					case 34:
						goto IL_0098;
					case 35:
						goto IL_006F;
					case 36:
						goto IL_0020;
					}
					goto Block_16;
					IL_0275:
					if (jsonProperty_0 != null)
					{
						goto IL_028C;
					}
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
					{
						break;
					}
					continue;
					IL_025D:
					if (jsonContract_0.ContractType == JsonContractType.String)
					{
						goto Block_12;
					}
					referenceLoopHandling = null;
					goto IL_0275;
				}
				goto IL_0294;
				Block_12:
				return true;
				Block_16:
				return false;
				IL_0020:
				string text;
				this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(null, writer.Path, text + Class15.smethod_17(552151402 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f)), null);
				num = 23;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
				{
					return false;
				}
				goto IL_02A3;
				IL_00D3:
				if (this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
				{
					goto IL_0020;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					return false;
				}
				goto IL_02A3;
				IL_0098:
				ReferenceLoopHandling valueOrDefault;
				switch (valueOrDefault)
				{
				case ReferenceLoopHandling.Error:
					IL_034C:
					throw JsonSerializationException.Create(null, writer.ContainerPath, text, null);
				case ReferenceLoopHandling.Ignore:
					if (this.TraceWriter != null)
					{
						goto IL_00D3;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
					{
						return false;
					}
					goto IL_02A3;
				case ReferenceLoopHandling.Serialize:
					if (this.TraceWriter != null)
					{
						goto IL_0109;
					}
					return true;
				default:
					return true;
				}
				IL_006F:
				valueOrDefault = referenceLoopHandling.GetValueOrDefault(this.Serializer._referenceLoopHandling);
				num = 33;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
				{
					goto IL_0098;
				}
				goto IL_02A3;
				IL_01B3:
				text += Class15.smethod_17(1802315171 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4).FormatWith(CultureInfo.InvariantCulture, object_0.GetType());
				goto IL_006F;
				IL_0185:
				text += Class15.smethod_17(197549567 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81).FormatWith(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName);
				goto IL_01B3;
				IL_0182:
				if (jsonProperty_0 != null)
				{
					goto IL_0185;
				}
				goto IL_01B3;
				IL_016B:
				text = Class15.smethod_17(2057019817 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48);
				goto IL_0182;
				IL_0166:
				bool flag;
				if (flag)
				{
					goto IL_016B;
				}
				return true;
				IL_0134:
				if (this.Serializer._equalityComparer == null)
				{
					goto IL_0141;
				}
				flag = this.list_0.Contains(object_0, this.Serializer._equalityComparer);
				goto IL_0166;
				IL_0222:
				if (jsonContainerContract_0 != null)
				{
					goto IL_0229;
				}
				goto IL_0134;
				IL_0219:
				if (referenceLoopHandling == null)
				{
					goto IL_0222;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
				{
					goto IL_01FB;
				}
				goto IL_02A3;
				IL_0249:
				if (jsonProperty_1 != null)
				{
					goto IL_01FB;
				}
				goto IL_0219;
				IL_0294:
				if (referenceLoopHandling != null)
				{
					goto IL_0219;
				}
				goto IL_0249;
				IL_0141:
				flag = this.list_0.Contains(object_0);
				goto IL_0166;
				IL_0109:
				if (this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
				{
					goto IL_0365;
				}
				num = 28;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
				{
					return true;
				}
				goto IL_02A3;
				IL_01FB:
				referenceLoopHandling = jsonProperty_1.ItemReferenceLoopHandling;
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto IL_0219;
				}
				goto IL_02A3;
				IL_0229:
				referenceLoopHandling = jsonContainerContract_0.ItemReferenceLoopHandling;
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					goto IL_0134;
				}
				goto IL_02A3;
				IL_028C:
				referenceLoopHandling = jsonProperty_0.ReferenceLoopHandling;
				goto IL_0294;
				IL_0365:
				this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(null, writer.Path, text + Class15.smethod_17(2008589111 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb)), null);
				return true;
			}
			return true;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00064714 File Offset: 0x00062914
		private void method_10(JsonWriter jsonWriter_0, object object_0)
		{
			for (;;)
			{
				IL_0106:
				string text = this.method_11(jsonWriter_0, object_0);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
				{
					goto IL_00C6;
				}
				for (;;)
				{
					IL_00D1:
					switch (num)
					{
					case 1:
						goto IL_00C6;
					case 2:
						goto IL_0106;
					case 3:
					case 4:
					case 8:
						goto IL_005D;
					case 5:
						goto IL_00B2;
					case 6:
						jsonWriter_0.WriteValue(text);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
						{
							continue;
						}
						break;
					case 7:
						goto IL_0063;
					case 9:
						goto IL_0006;
					case 10:
						return;
					}
					goto Block_6;
				}
				IL_0006:
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(null, jsonWriter_0.Path, Class15.smethod_17(314810705 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927).FormatWith(CultureInfo.InvariantCulture, text, object_0.GetType())), null);
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
				{
					continue;
				}
				goto IL_00D1;
				IL_00B2:
				if (this.TraceWriter.LevelFilter < TraceLevel.Info)
				{
					goto IL_005D;
				}
				goto IL_0006;
				IL_00C6:
				if (this.TraceWriter == null)
				{
					goto IL_005D;
				}
				goto IL_00B2;
				IL_0063:
				jsonWriter_0.WritePropertyName(Class15.smethod_17(314802971 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927), false);
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
				{
					break;
				}
				goto IL_00D1;
				IL_005D:
				jsonWriter_0.WriteStartObject();
				goto IL_0063;
			}
			Block_6:
			jsonWriter_0.WriteEndObject();
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00064850 File Offset: 0x00062A50
		private string method_11(JsonWriter jsonWriter_0, object object_0)
		{
			string reference;
			try
			{
				reference = this.Serializer.GetReferenceResolver().GetReference(this, object_0);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
				{
					switch (num)
					{
					}
				}
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
				{
					switch (num2)
					{
					}
				}
				throw JsonSerializationException.Create(null, jsonWriter_0.ContainerPath, Class15.smethod_17(314810807 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927).FormatWith(CultureInfo.InvariantCulture, object_0.GetType()), ex);
			}
			return reference;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x000648F8 File Offset: 0x00062AF8
		internal static bool TryConvertToString(object value, Type type, [NotNullWhen(true)] [Nullable(2)] out string s)
		{
			for (;;)
			{
				TypeConverter typeConverter;
				if (JsonTypeReflector.CanTypeDescriptorConvertString(type, out typeConverter))
				{
					goto IL_007B;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
				{
					goto IL_0006;
				}
				IL_0053:
				Type type2;
				switch (num)
				{
				case 0:
					goto IL_0039;
				case 1:
					return true;
				case 2:
					break;
				case 3:
					IL_0006:
					type2 = value as Type;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
					{
						goto IL_0053;
					}
					break;
				case 4:
					continue;
				case 5:
					return true;
				case 6:
					return false;
				case 7:
					IL_007B:
					s = typeConverter.ConvertToInvariantString(value);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
					{
						return true;
					}
					goto IL_0053;
				default:
					goto IL_0039;
				}
				if (type2 == null)
				{
					goto IL_00C3;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
				{
					goto IL_0053;
				}
				IL_0039:
				s = type2.AssemblyQualifiedName;
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
				{
					goto IL_0053;
				}
				break;
			}
			return true;
			IL_00C3:
			s = null;
			return false;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x000649D0 File Offset: 0x00062BD0
		private void liwyzGqbv3(JsonWriter jsonWriter_0, object object_0, JsonStringContract jsonStringContract_0)
		{
			for (;;)
			{
				this.method_12(jsonWriter_0, jsonStringContract_0, object_0);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
				{
					goto IL_0003;
				}
				IL_0058:
				string text;
				switch (num)
				{
				case 1:
					goto IL_003E;
				case 2:
					IL_0003:
					JsonSerializerInternalWriter.TryConvertToString(object_0, jsonStringContract_0.UnderlyingType, out text);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
					{
						goto IL_0058;
					}
					break;
				case 3:
					continue;
				case 4:
					return;
				}
				jsonWriter_0.WriteValue(text);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
				{
					goto IL_0058;
				}
				IL_003E:
				this.method_13(jsonWriter_0, jsonStringContract_0, object_0);
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
				{
					goto IL_0058;
				}
				break;
			}
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00064A74 File Offset: 0x00062C74
		private void method_12(JsonWriter jsonWriter_0, JsonContract jsonContract_0, object object_0)
		{
			while (this.TraceWriter == null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
				{
					switch (num)
					{
					case 0:
						goto IL_0040;
					case 1:
					case 4:
						break;
					case 2:
						continue;
					case 3:
						IL_004E:
						this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(null, jsonWriter_0.Path, Class15.smethod_17(1760335189 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039).FormatWith(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType)), null);
						break;
					case 5:
						return;
					default:
						goto IL_0040;
					}
					IL_008C:
					jsonContract_0.InvokeOnSerializing(object_0, this.Serializer._context);
					return;
				}
				break;
			}
			IL_0040:
			if (this.TraceWriter.LevelFilter >= TraceLevel.Info)
			{
				goto IL_004E;
			}
			goto IL_008C;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00064B20 File Offset: 0x00062D20
		private void method_13(JsonWriter jsonWriter_0, JsonContract jsonContract_0, object object_0)
		{
			while (this.TraceWriter != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
				{
					goto IL_006C;
				}
				IL_007D:
				switch (num)
				{
				case 0:
					goto IL_006C;
				case 1:
					continue;
				case 2:
				case 4:
					goto IL_00AC;
				case 3:
					return;
				case 5:
					break;
				default:
					goto IL_006C;
				}
				IL_001A:
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(null, jsonWriter_0.Path, Class15.smethod_17(432085549 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2).FormatWith(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType)), null);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
				{
					break;
				}
				goto IL_007D;
				IL_006C:
				if (this.TraceWriter.LevelFilter < TraceLevel.Info)
				{
					break;
				}
				goto IL_001A;
			}
			IL_00AC:
			jsonContract_0.InvokeOnSerialized(object_0, this.Serializer._context);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00064BEC File Offset: 0x00062DEC
		private void method_14(JsonWriter jsonWriter_0, object object_0, JsonObjectContract jsonObjectContract_0, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
			for (;;)
			{
				IL_0001:
				this.method_12(jsonWriter_0, jsonObjectContract_0, object_0);
				for (;;)
				{
					IL_000A:
					this.list_0.Add(object_0);
					for (;;)
					{
						IL_0016:
						this.method_16(jsonWriter_0, object_0, jsonObjectContract_0, member, collectionContract, containerProperty);
						for (;;)
						{
							IL_0025:
							int top = jsonWriter_0.Top;
							for (;;)
							{
								IL_002D:
								int num = 0;
								for (;;)
								{
									IL_0030:
									if (num >= jsonObjectContract_0.Properties.Count)
									{
										goto IL_02FA;
									}
									int num2 = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
									{
										goto IL_0057;
									}
									for (;;)
									{
										IL_0323:
										switch (num2)
										{
										case 1:
										case 19:
											goto IL_0057;
										case 2:
											goto IL_02FA;
										case 3:
											goto IL_0025;
										case 4:
										case 15:
											goto IL_0030;
										case 5:
											goto IL_02AB;
										case 6:
											goto IL_0083;
										case 7:
											goto IL_002D;
										case 8:
											return;
										case 9:
											goto IL_0016;
										case 10:
											goto IL_02A5;
										case 11:
											goto IL_008A;
										case 12:
											goto IL_000A;
										case 13:
											goto IL_0001;
										case 14:
											goto IL_0093;
										case 16:
											goto IL_040B;
										case 17:
											this.method_13(jsonWriter_0, jsonObjectContract_0, object_0);
											num2 = 6;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
											{
												continue;
											}
											return;
										case 18:
											goto IL_0080;
										}
										goto Block_7;
									}
									IL_0080:
									IEnumerable<KeyValuePair<object, object>> enumerable = null;
									goto IL_0081;
									Block_7:
									goto IL_0382;
									IL_040B:
									num++;
									continue;
									IL_0382:
									JsonProperty jsonProperty;
									try
									{
										JsonContract jsonContract;
										object obj;
										if (this.method_15(jsonWriter_0, object_0, jsonObjectContract_0, member, jsonProperty, out jsonContract, out obj))
										{
											for (;;)
											{
												jsonProperty.WritePropertyName(jsonWriter_0);
												int num3 = 0;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
												{
													switch (num3)
													{
													case 1:
														continue;
													case 2:
														goto IL_03D8;
													case 3:
														goto IL_03DA;
													}
													break;
												}
												break;
											}
											this.method_5(jsonWriter_0, obj, jsonContract, jsonProperty, jsonObjectContract_0, member);
											IL_03D8:;
										}
										IL_03DA:
										goto IL_040B;
									}
									catch (Exception ex)
									{
										if (!base.IsErrorHandled(object_0, jsonObjectContract_0, jsonProperty.PropertyName, null, jsonWriter_0.ContainerPath, ex))
										{
											throw;
										}
										this.method_34(jsonWriter_0, top);
										goto IL_040B;
									}
									goto IL_0405;
									IL_02FA:
									ExtensionDataGetter extensionDataGetter = jsonObjectContract_0.ExtensionDataGetter;
									if (extensionDataGetter != null)
									{
										enumerable = extensionDataGetter(object_0);
										goto IL_0081;
									}
									num2 = 18;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
									{
										goto IL_0323;
									}
									goto IL_040B;
									IL_0057:
									jsonProperty = jsonObjectContract_0.Properties[num];
									num2 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
									{
										goto IL_0382;
									}
									goto IL_0323;
									IL_02AB:
									this.list_0.RemoveAt(this.list_0.Count - 1);
									num2 = 17;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
									{
										goto Block_3;
									}
									goto IL_0323;
									IL_02A5:
									jsonWriter_0.WriteEndObject();
									goto IL_02AB;
									IL_0093:
									IEnumerator<KeyValuePair<object, object>> enumerator;
									try
									{
										for (;;)
										{
											IL_0261:
											if (enumerator.MoveNext())
											{
												goto IL_0227;
											}
											int num4 = 5;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
											{
												break;
											}
											KeyValuePair<object, object> keyValuePair;
											string text;
											for (;;)
											{
												IL_01D7:
												JsonContract jsonContract2;
												JsonContract jsonContract3;
												switch (num4)
												{
												case 0:
													goto IL_0140;
												case 1:
													goto IL_0227;
												case 2:
													goto IL_016B;
												case 3:
													goto IL_017A;
												case 4:
													goto IL_00F1;
												case 5:
													jsonContract2 = this.method_3(keyValuePair.Key);
													goto IL_0196;
												case 6:
												case 8:
												case 12:
													goto IL_0261;
												case 7:
													goto IL_0271;
												case 9:
													goto IL_00F9;
												case 10:
													if (jsonObjectContract_0.ExtensionDataNameResolver == null)
													{
														goto IL_0140;
													}
													num4 = 2;
													if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
													{
														goto Block_16;
													}
													continue;
												case 11:
													IL_0144:
													if (!this.method_7(keyValuePair.Value, null, jsonContract3, jsonObjectContract_0, member))
													{
														goto IL_017A;
													}
													num4 = 4;
													if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
													{
														goto IL_016B;
													}
													continue;
												case 13:
													goto IL_0196;
												case 14:
													goto IL_0121;
												case 15:
													this.method_5(jsonWriter_0, keyValuePair.Value, jsonContract3, null, jsonObjectContract_0, member);
													num4 = 8;
													if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
													{
														goto IL_00F1;
													}
													continue;
												case 16:
													break;
												default:
													goto IL_0140;
												}
												IL_009A:
												bool flag;
												text = this.method_33(jsonWriter_0, keyValuePair.Key, jsonContract2, out flag);
												num4 = 10;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
												{
													goto Block_10;
												}
												continue;
												IL_0196:
												jsonContract3 = this.method_2(keyValuePair.Value);
												goto IL_009A;
												IL_0121:
												jsonWriter_0.WritePropertyName(text);
												num4 = 15;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
												{
													goto IL_016B;
												}
												continue;
												IL_017A:
												if (!this.method_9(jsonWriter_0, keyValuePair.Value, null, jsonContract3, jsonObjectContract_0, member))
												{
													break;
												}
												goto IL_0121;
												IL_0142:
												string text2;
												text = text2;
												goto IL_0144;
												IL_016B:
												text2 = jsonObjectContract_0.ExtensionDataNameResolver(text);
												goto IL_0142;
												IL_0140:
												text2 = text;
												goto IL_0142;
											}
											continue;
											Block_16:
											goto IL_0227;
											IL_00F9:
											this.method_10(jsonWriter_0, keyValuePair.Value);
											num4 = 2;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
											{
												continue;
											}
											goto IL_01D7;
											IL_00F1:
											jsonWriter_0.WritePropertyName(text);
											goto IL_00F9;
											IL_0227:
											keyValuePair = enumerator.Current;
											num4 = 5;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
											{
												goto IL_00F1;
											}
											goto IL_01D7;
										}
										Block_10:
										IL_0271:;
									}
									finally
									{
										if (enumerator != null)
										{
											for (;;)
											{
												enumerator.Dispose();
												int num5 = 1;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
												{
													break;
												}
												switch (num5)
												{
												case 1:
												case 2:
													goto IL_02A4;
												}
											}
										}
										IL_02A4:;
									}
									goto IL_02A5;
									IL_008A:
									IEnumerable<KeyValuePair<object, object>> enumerable2;
									enumerator = enumerable2.GetEnumerator();
									goto IL_0093;
									IL_0083:
									if (enumerable2 != null)
									{
										goto IL_008A;
									}
									goto IL_02A5;
									IL_0081:
									enumerable2 = enumerable;
									goto IL_0083;
								}
							}
							IL_0405:
							Block_3:;
						}
					}
				}
			}
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00065044 File Offset: 0x00063244
		private bool method_15(JsonWriter jsonWriter_0, object object_0, JsonContainerContract jsonContainerContract_0, [Nullable(2)] JsonProperty member, JsonProperty jsonProperty_0, [Nullable(2)] [NotNullWhen(true)] out JsonContract memberContract, [Nullable(2)] out object memberValue)
		{
			IL_0261:
			while (!jsonProperty_0.Ignored)
			{
				IL_0251:
				while (jsonProperty_0.Readable)
				{
					for (;;)
					{
						IL_0242:
						if (this.ShouldSerialize(jsonWriter_0, jsonProperty_0, object_0))
						{
							goto IL_0213;
						}
						int num = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
						{
							goto IL_0021;
						}
						Required? required;
						JsonObjectContract jsonObjectContract;
						for (;;)
						{
							IL_019C:
							switch (num)
							{
							case 1:
								if (required != null)
								{
									goto Block_13;
								}
								goto IL_0150;
							case 2:
								goto IL_0251;
							case 3:
								goto IL_0261;
							case 4:
								goto IL_0021;
							case 5:
								goto IL_00A5;
							case 6:
								goto IL_00BB;
							case 7:
								goto IL_02F4;
							case 8:
								goto IL_00D1;
							case 9:
								goto IL_0184;
							case 10:
								goto IL_0213;
							case 11:
								return false;
							case 12:
								goto IL_0242;
							case 13:
								goto IL_00F8;
							case 14:
								goto IL_0072;
							case 15:
								goto IL_0177;
							case 16:
								goto IL_0150;
							case 17:
								goto IL_02F8;
							case 18:
								return false;
							case 19:
								goto IL_00F0;
							case 20:
								goto IL_0275;
							case 21:
								jsonProperty_0.PropertyContract = this.Serializer._contractResolver.ResolveContract(jsonProperty_0.PropertyType);
								num = 14;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
								{
									goto Block_10;
								}
								continue;
							case 22:
								return false;
							case 23:
								goto IL_027D;
							case 24:
								goto IL_0082;
							case 25:
								goto IL_0052;
							case 26:
								goto IL_001D;
							}
							goto Block_14;
							IL_0150:
							if (jsonObjectContract != null)
							{
								goto IL_016B;
							}
							num = 15;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
							{
								goto Block_12;
							}
						}
						IL_001F:
						Required? required3;
						Required? required2 = required3;
						goto IL_0021;
						IL_001D:
						required3 = required2;
						goto IL_001F;
						IL_0177:
						required2 = null;
						goto IL_001D;
						Block_10:
						goto IL_00A5;
						IL_0184:
						object obj = required.GetValueOrDefault();
						goto IL_0028;
						Block_13:
						goto IL_0184;
						IL_016B:
						required3 = jsonObjectContract.ItemRequired;
						goto IL_001F;
						IL_0028:
						object obj2 = obj;
						if (obj2 == 2)
						{
							goto Block_2;
						}
						if (obj2 != 3)
						{
							return true;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
						{
							goto Block_4;
						}
						goto IL_019C;
						IL_0021:
						obj = required2.GetValueOrDefault();
						goto IL_0028;
						IL_0052:
						if (jsonProperty_0.PropertyContract != null)
						{
							goto IL_0072;
						}
						num = 21;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
						{
							goto IL_00BB;
						}
						goto IL_019C;
						IL_00F8:
						required = jsonProperty_0._required;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
						{
							goto Block_9;
						}
						goto IL_019C;
						IL_00F0:
						jsonObjectContract = jsonContainerContract_0 as JsonObjectContract;
						goto IL_00F8;
						IL_00D1:
						if (!this.method_9(jsonWriter_0, memberValue, jsonProperty_0, memberContract, jsonContainerContract_0, member))
						{
							return false;
						}
						if (memberValue == null)
						{
							goto IL_00F0;
						}
						return true;
						IL_00BB:
						if (!this.method_7(memberValue, jsonProperty_0, memberContract, jsonContainerContract_0, member))
						{
							goto IL_00D1;
						}
						goto IL_0275;
						IL_00A5:
						if (this.method_8(memberValue, jsonContainerContract_0 as JsonObjectContract, jsonProperty_0))
						{
							goto IL_00BB;
						}
						goto IL_02F4;
						IL_0082:
						memberContract = (jsonProperty_0.PropertyContract.IsSealed ? jsonProperty_0.PropertyContract : this.method_2(memberValue));
						goto IL_00A5;
						IL_0072:
						memberValue = jsonProperty_0.ValueProvider.GetValue(object_0);
						goto IL_0082;
						IL_0213:
						if (!this.method_35(jsonWriter_0, jsonProperty_0, object_0))
						{
							goto IL_02F4;
						}
						num = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
						{
							goto IL_0052;
						}
						goto IL_019C;
					}
					Block_12:
					goto IL_0261;
					Block_2:
					throw JsonSerializationException.Create(null, jsonWriter_0.ContainerPath, Class15.smethod_17(543283014 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89).FormatWith(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName), null);
					Block_4:
					Block_9:
					Block_14:
					goto IL_02BE;
					IL_0275:
					jsonProperty_0.WritePropertyName(jsonWriter_0);
					IL_027D:
					this.method_10(jsonWriter_0, memberValue);
					return false;
					IL_02BE:
					throw JsonSerializationException.Create(null, jsonWriter_0.ContainerPath, Class15.smethod_17(613143471 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6).FormatWith(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName), null);
				}
				break;
				IL_02F8:
				memberValue = null;
				return false;
			}
			IL_02F4:
			memberContract = null;
			goto IL_02F8;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00065350 File Offset: 0x00063550
		private void method_16(JsonWriter jsonWriter_0, object object_0, JsonContract jsonContract_0, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
			for (;;)
			{
				IL_0129:
				jsonWriter_0.WriteStartObject();
				for (;;)
				{
					IL_0118:
					bool? flag = this.method_6(jsonContract_0, member, collectionContract, containerProperty);
					for (;;)
					{
						if (flag == null)
						{
							goto IL_00D6;
						}
						bool flag2 = flag.GetValueOrDefault();
						IL_0104:
						if (!flag2)
						{
							goto IL_00C3;
						}
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
						{
							goto IL_0032;
						}
						IL_0047:
						switch (num)
						{
						case 0:
							goto IL_0032;
						case 1:
						case 9:
							goto IL_00B5;
						case 2:
							return;
						case 3:
							break;
						case 4:
							goto IL_00C3;
						case 5:
							goto IL_007F;
						case 6:
							continue;
						case 7:
							goto IL_0118;
						case 8:
							goto IL_0129;
						case 10:
							IL_00D6:
							flag2 = this.method_21(this.Serializer._preserveReferencesHandling, PreserveReferencesHandling.Objects);
							goto IL_0104;
						case 11:
							if (this.method_17(collectionContract, member))
							{
								goto IL_00B5;
							}
							goto IL_00C3;
						default:
							goto IL_0032;
						}
						IL_0012:
						if (member.Writable)
						{
							goto IL_00B5;
						}
						num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
						{
							goto IL_00B5;
						}
						goto IL_0047;
						IL_0032:
						if (member != null)
						{
							goto IL_0012;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
						{
							goto IL_0047;
						}
						goto IL_00B5;
						IL_007F:
						this.method_19(jsonWriter_0, jsonContract_0.UnderlyingType);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
						{
							return;
						}
						goto IL_0047;
						IL_00C3:
						if (this.method_31(TypeNameHandling.Objects, jsonContract_0, member, collectionContract, containerProperty))
						{
							goto IL_007F;
						}
						return;
						IL_00B5:
						this.method_18(jsonWriter_0, jsonContract_0.UnderlyingType, object_0);
						goto IL_00C3;
					}
				}
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00065490 File Offset: 0x00063690
		private bool method_17([Nullable(2)] JsonContainerContract contract, JsonProperty jsonProperty_0)
		{
			JsonObjectContract jsonObjectContract;
			for (;;)
			{
				IL_0033:
				jsonObjectContract = contract as JsonObjectContract;
				while (jsonObjectContract != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
					{
						switch (num)
						{
						case 1:
							return false;
						case 2:
							continue;
						case 3:
							goto IL_0033;
						}
						goto Block_2;
					}
					goto IL_003D;
				}
				return false;
			}
			Block_2:
			IL_003D:
			return jsonObjectContract.CreatorParameters.Contains(jsonProperty_0.PropertyName);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x000654F0 File Offset: 0x000636F0
		private void method_18(JsonWriter jsonWriter_0, Type type_1, object object_0)
		{
			for (;;)
			{
				IL_00EC:
				string text = this.method_11(jsonWriter_0, object_0);
				for (;;)
				{
					IL_00DD:
					if (this.TraceWriter != null)
					{
						goto IL_0025;
					}
					goto IL_00AA;
					int num;
					for (;;)
					{
						IL_0044:
						switch (num)
						{
						case 1:
							return;
						case 2:
							goto IL_006F;
						case 3:
							goto IL_0025;
						case 4:
							goto IL_00DD;
						case 5:
							goto IL_00EC;
						case 7:
							jsonWriter_0.WriteValue(text);
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
							{
								return;
							}
							continue;
						}
						break;
					}
					goto IL_00AA;
					IL_0025:
					if (this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
					{
						goto IL_006F;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
					{
						goto IL_0044;
					}
					IL_00AA:
					jsonWriter_0.WritePropertyName(Class15.smethod_17(2128238876 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9), false);
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
					{
						break;
					}
					goto IL_0044;
					IL_006F:
					this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(null, jsonWriter_0.Path, Class15.smethod_17(1807915800 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3).FormatWith(CultureInfo.InvariantCulture, text, type_1)), null);
					goto IL_00AA;
				}
			}
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x000655F8 File Offset: 0x000637F8
		private void method_19(JsonWriter jsonWriter_0, Type type_1)
		{
			for (;;)
			{
				IL_00E2:
				string typeName = ReflectionUtils.GetTypeName(type_1, this.Serializer._typeNameAssemblyFormatHandling, this.Serializer._serializationBinder);
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
				{
					goto IL_0097;
				}
				goto IL_00BB;
				do
				{
					IL_0053:
					jsonWriter_0.WritePropertyName(Class15.smethod_17(1176463466 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af), false);
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0);
				for (;;)
				{
					IL_00BB:
					switch (num)
					{
					case 1:
						return;
					case 2:
						jsonWriter_0.WriteValue(typeName);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
						{
							continue;
						}
						return;
					case 3:
						goto IL_0097;
					case 4:
						goto IL_00E2;
					case 5:
						goto IL_0083;
					case 6:
						goto IL_0006;
					}
					break;
				}
				goto IL_0053;
				IL_0006:
				this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(null, jsonWriter_0.Path, Class15.smethod_17(642155386 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba).FormatWith(CultureInfo.InvariantCulture, typeName, type_1)), null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto IL_0053;
				}
				goto IL_00BB;
				IL_0083:
				if (this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
				{
					goto IL_0006;
				}
				goto IL_0053;
				IL_0097:
				if (this.TraceWriter != null)
				{
					goto IL_0083;
				}
				goto IL_0053;
			}
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00004FC2 File Offset: 0x000031C2
		private bool method_20(DefaultValueHandling defaultValueHandling_0, DefaultValueHandling defaultValueHandling_1)
		{
			return (defaultValueHandling_0 & defaultValueHandling_1) == defaultValueHandling_1;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00004FC2 File Offset: 0x000031C2
		private bool method_21(PreserveReferencesHandling preserveReferencesHandling_0, PreserveReferencesHandling preserveReferencesHandling_1)
		{
			return (preserveReferencesHandling_0 & preserveReferencesHandling_1) == preserveReferencesHandling_1;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00004FC2 File Offset: 0x000031C2
		private bool method_22(TypeNameHandling typeNameHandling_0, TypeNameHandling typeNameHandling_1)
		{
			return (typeNameHandling_0 & typeNameHandling_1) == typeNameHandling_1;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0006571C File Offset: 0x0006391C
		private void method_23(JsonWriter jsonWriter_0, JsonConverter jsonConverter_0, object object_0, JsonContract jsonContract_0, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
			IL_0106:
			while (!this.method_7(object_0, null, jsonContract_0, collectionContract, containerProperty))
			{
				if (this.method_9(jsonWriter_0, object_0, null, jsonContract_0, collectionContract, containerProperty))
				{
					this.list_0.Add(object_0);
					int num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
					{
						goto IL_003B;
					}
					do
					{
						IL_00C6:
						switch (num)
						{
						case 1:
							if (this.TraceWriter.LevelFilter >= TraceLevel.Info)
							{
								goto IL_005D;
							}
							break;
						case 2:
							goto IL_005D;
						case 3:
							goto IL_011F;
						case 4:
							goto IL_0106;
						case 5:
							goto IL_0143;
						case 6:
							goto IL_003B;
						case 7:
							goto IL_0151;
						case 8:
							return;
						case 9:
							return;
						case 10:
							return;
						case 12:
							goto IL_013B;
						case 13:
							goto IL_0195;
						}
						break;
						IL_005D:
						this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(null, jsonWriter_0.Path, Class15.smethod_17(89011500 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454).FormatWith(CultureInfo.InvariantCulture, object_0.GetType(), jsonConverter_0.GetType())), null);
						num = 0;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0);
					goto IL_012D;
					IL_011F:
					this.method_10(jsonWriter_0, object_0);
					return;
					IL_003B:
					if (this.TraceWriter != null)
					{
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
						{
							goto IL_00C6;
						}
					}
					IL_012D:
					jsonConverter_0.WriteJson(jsonWriter_0, object_0, this.method_1());
					IL_013B:
					if (this.TraceWriter == null)
					{
						goto IL_0195;
					}
					IL_0143:
					if (this.TraceWriter.LevelFilter < TraceLevel.Info)
					{
						goto IL_0195;
					}
					IL_0151:
					this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(null, jsonWriter_0.Path, Class15.smethod_17(2057020717 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48).FormatWith(CultureInfo.InvariantCulture, object_0.GetType(), jsonConverter_0.GetType())), null);
					IL_0195:
					this.list_0.RemoveAt(this.list_0.Count - 1);
					return;
				}
				return;
			}
			goto IL_011F;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x000658D8 File Offset: 0x00063AD8
		private void method_24(JsonWriter jsonWriter_0, IEnumerable ienumerable_0, JsonArrayContract jsonArrayContract_0, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
			for (;;)
			{
				Interface0 @interface = ienumerable_0 as Interface0;
				int num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
				{
					goto IL_0006;
				}
				goto IL_02CB;
				do
				{
					IL_027E:
					jsonWriter_0.WriteEndObject();
					num = 7;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0);
				IL_02CB:
				object obj;
				switch (num)
				{
				case 0:
					goto IL_027A;
				case 1:
					goto IL_0262;
				case 2:
					IL_0016:
					this.method_12(jsonWriter_0, jsonArrayContract_0, obj);
					goto IL_0020;
				case 3:
					return;
				case 4:
					break;
				case 5:
					goto IL_027E;
				case 6:
					goto IL_0013;
				case 7:
					goto IL_0298;
				case 8:
					goto IL_0020;
				case 9:
					goto IL_005A;
				case 10:
					goto IL_000A;
				case 11:
					goto IL_006D;
				case 12:
					goto IL_0062;
				case 13:
					goto IL_002D;
				case 14:
					goto IL_02B0;
				case 15:
					goto IL_0065;
				case 16:
					IL_0006:
					if (@interface != null)
					{
						goto IL_000A;
					}
					goto IL_0013;
				case 17:
					continue;
				default:
					goto IL_027A;
				}
				IL_003F:
				jsonWriter_0.WriteStartArray();
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
				{
					goto IL_005A;
				}
				goto IL_02CB;
				IL_002D:
				bool flag = this.method_27(jsonWriter_0, obj, jsonArrayContract_0, member, collectionContract, containerProperty);
				goto IL_003F;
				IL_0020:
				this.list_0.Add(obj);
				goto IL_002D;
				IL_0014:
				object obj2;
				obj = obj2;
				goto IL_0016;
				IL_000A:
				obj2 = @interface.UnderlyingCollection;
				goto IL_0014;
				IL_0262:
				jsonWriter_0.WriteEndArray();
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
				{
					goto IL_027A;
				}
				goto IL_02CB;
				IL_006D:
				IEnumerator enumerator;
				int top;
				int num5;
				try
				{
					for (;;)
					{
						if (!enumerator.MoveNext())
						{
							goto IL_01EA;
						}
						goto IL_0074;
						IL_008E:
						int num2;
						object obj3;
						switch (num2)
						{
						case 0:
							continue;
						case 1:
							break;
						case 2:
							goto IL_0213;
						case 3:
							IL_0074:
							obj3 = enumerator.Current;
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
							{
								goto IL_008E;
							}
							break;
						default:
							continue;
						}
						IL_00AA:
						try
						{
							JsonContract jsonContract;
							if ((jsonContract = jsonArrayContract_0.FinalItemContract) != null)
							{
								goto IL_0146;
							}
							int num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
							{
								goto IL_013E;
							}
							IL_00CC:
							JsonContract jsonContract2;
							switch (num3)
							{
							case 0:
								goto IL_013E;
							case 1:
								goto IL_0117;
							case 2:
							case 4:
							case 5:
								continue;
							case 3:
								break;
							case 6:
								goto IL_014D;
							case 7:
								IL_012B:
								if (!this.method_7(obj3, null, jsonContract2, jsonArrayContract_0, member))
								{
									goto IL_0117;
								}
								goto IL_014D;
							default:
								goto IL_013E;
							}
							IL_00F4:
							this.method_5(jsonWriter_0, obj3, jsonContract2, null, jsonArrayContract_0, member);
							num3 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
							{
								continue;
							}
							goto IL_00CC;
							IL_0117:
							if (this.method_9(jsonWriter_0, obj3, null, jsonContract2, jsonArrayContract_0, member))
							{
								goto IL_00F4;
							}
							continue;
							IL_013E:
							jsonContract = this.method_2(obj3);
							IL_0146:
							jsonContract2 = jsonContract;
							goto IL_012B;
							IL_014D:
							this.method_10(jsonWriter_0, obj3);
							continue;
						}
						catch (Exception ex)
						{
							int num4 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
							{
								goto IL_018E;
							}
							goto IL_01AC;
							IL_0171:
							this.method_34(jsonWriter_0, top);
							num4 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
							{
								continue;
							}
							goto IL_01AC;
							IL_018E:
							if (base.IsErrorHandled(obj, jsonArrayContract_0, num5, null, jsonWriter_0.ContainerPath, ex))
							{
								goto IL_0171;
							}
							goto IL_01C1;
							IL_01AC:
							switch (num4)
							{
							case 1:
								goto IL_018E;
							case 2:
								goto IL_0171;
							case 3:
								continue;
							}
							IL_01C1:
							throw;
							continue;
						}
						finally
						{
							num5++;
							int num6 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
							{
								switch (num6)
								{
								}
							}
						}
						IL_01EA:
						num2 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
						{
							goto IL_00AA;
						}
						goto IL_008E;
					}
					IL_0213:;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num7 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						goto IL_0245;
					}
					IL_0230:
					if (disposable == null)
					{
						goto IL_0261;
					}
					num7 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
					{
						goto IL_025A;
					}
					IL_0245:
					switch (num7)
					{
					case 1:
						goto IL_0230;
					case 2:
						goto IL_0261;
					}
					IL_025A:
					disposable.Dispose();
					IL_0261:;
				}
				goto IL_0262;
				IL_0065:
				enumerator = ienumerable_0.GetEnumerator();
				goto IL_006D;
				IL_0062:
				num5 = 0;
				goto IL_0065;
				IL_005A:
				top = jsonWriter_0.Top;
				goto IL_0062;
				IL_027A:
				if (flag)
				{
					goto IL_027E;
				}
				goto IL_0298;
				IL_02B0:
				this.method_13(jsonWriter_0, jsonArrayContract_0, obj);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
				{
					goto IL_02CB;
				}
				break;
				IL_0298:
				this.list_0.RemoveAt(this.list_0.Count - 1);
				goto IL_02B0;
				IL_0013:
				obj2 = ienumerable_0;
				goto IL_0014;
			}
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00065C70 File Offset: 0x00063E70
		private void method_25(JsonWriter jsonWriter_0, Array array_0, JsonArrayContract jsonArrayContract_0, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
			for (;;)
			{
				this.method_12(jsonWriter_0, jsonArrayContract_0, array_0);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
				{
					goto IL_007A;
				}
				IL_009D:
				switch (num)
				{
				case 0:
					goto IL_003F;
				case 1:
					return;
				case 2:
					goto IL_0045;
				case 3:
					goto IL_005D;
				case 4:
					IL_007A:
					this.list_0.Add(array_0);
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
					{
						goto IL_009D;
					}
					break;
				case 5:
					continue;
				case 6:
					break;
				default:
					goto IL_003F;
				}
				bool flag = this.method_27(jsonWriter_0, array_0, jsonArrayContract_0, member, collectionContract, containerProperty);
				this.method_26(jsonWriter_0, array_0, jsonArrayContract_0, member, jsonWriter_0.Top, CollectionUtils.ArrayEmpty<int>());
				if (!flag)
				{
					goto IL_0045;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
				{
					goto IL_003F;
				}
				goto IL_009D;
				IL_005D:
				this.method_13(jsonWriter_0, jsonArrayContract_0, array_0);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
				{
					break;
				}
				goto IL_009D;
				IL_0045:
				this.list_0.RemoveAt(this.list_0.Count - 1);
				goto IL_005D;
				IL_003F:
				jsonWriter_0.WriteEndObject();
				goto IL_0045;
			}
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00065D60 File Offset: 0x00063F60
		private void method_26(JsonWriter jsonWriter_0, Array array_0, JsonArrayContract jsonArrayContract_0, [Nullable(2)] JsonProperty member, int int_1, int[] int_2)
		{
			for (;;)
			{
				IL_0001:
				int num = int_2.Length;
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
				{
					goto IL_001C;
				}
				goto IL_0210;
				do
				{
					IL_0042:
					jsonWriter_0.WriteStartArray();
					num2 = 14;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0);
				int[] array;
				for (;;)
				{
					IL_0210:
					switch (num2)
					{
					case 1:
						goto IL_0001;
					case 2:
					case 13:
						goto IL_00B2;
					case 3:
						goto IL_0027;
					case 4:
					case 10:
						goto IL_002A;
					case 5:
						goto IL_00D2;
					case 6:
						goto IL_00A4;
					case 7:
						goto IL_003A;
					case 8:
						goto IL_0088;
					case 9:
						goto IL_0042;
					case 11:
						return;
					case 12:
						goto IL_0271;
					case 14:
						goto IL_0201;
					case 15:
						goto IL_00C8;
					case 16:
					case 17:
						goto IL_0062;
					case 18:
						goto IL_028F;
					case 19:
						goto IL_0030;
					}
					goto Block_4;
					IL_0062:
					int num3;
					if (num3 <= array_0.GetUpperBound(num))
					{
						goto IL_0088;
					}
					num2 = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
					{
						goto Block_2;
					}
					continue;
					IL_0201:
					num3 = array_0.GetLowerBound(num);
					goto IL_0062;
					IL_00D2:
					object value;
					try
					{
						JsonContract jsonContract;
						if ((jsonContract = jsonArrayContract_0.FinalItemContract) != null)
						{
							goto IL_0179;
						}
						IL_0171:
						jsonContract = this.method_2(value);
						IL_0179:
						JsonContract jsonContract2 = jsonContract;
						int num4 = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
						{
							goto IL_0171;
						}
						do
						{
							switch (num4)
							{
							case 1:
							case 6:
								goto IL_010B;
							case 3:
								goto IL_012F;
							case 4:
								goto IL_0171;
							case 5:
								if (this.method_7(value, null, jsonContract2, jsonArrayContract_0, member))
								{
									goto IL_012F;
								}
								goto IL_010B;
							case 7:
								goto IL_00E5;
							}
							break;
							IL_00E5:
							this.method_5(jsonWriter_0, value, jsonContract2, null, jsonArrayContract_0, member);
							num4 = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
							{
								break;
							}
							continue;
							IL_010B:
							if (this.method_9(jsonWriter_0, value, null, jsonContract2, jsonArrayContract_0, member))
							{
								goto IL_00E5;
							}
							break;
							IL_012F:
							this.method_10(jsonWriter_0, value);
							num4 = 0;
						}
						while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0);
						goto IL_0271;
					}
					catch (Exception ex)
					{
						int num5 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
						{
							goto IL_01D7;
						}
						IL_01AC:
						if (!base.IsErrorHandled(array_0, jsonArrayContract_0, num3, null, jsonWriter_0.ContainerPath, ex))
						{
							goto IL_01FD;
						}
						num5 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
						{
							goto IL_01F0;
						}
						IL_01D7:
						switch (num5)
						{
						case 0:
							goto IL_01AC;
						case 1:
							break;
						case 2:
							goto IL_01FF;
						case 3:
							goto IL_01FD;
						default:
							goto IL_01AC;
						}
						IL_01F0:
						this.method_34(jsonWriter_0, int_1 + 1);
						goto IL_01FF;
						IL_01FD:
						throw;
						IL_01FF:
						goto IL_0271;
					}
					goto IL_0201;
					IL_00C8:
					value = array_0.GetValue(array);
					goto IL_00D2;
					IL_00A4:
					if (array.Length != array_0.Rank)
					{
						goto IL_00B2;
					}
					goto IL_00C8;
					IL_0088:
					array[num] = num3;
					num2 = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						goto IL_00A4;
					}
					continue;
					IL_0271:
					num3++;
					num2 = 17;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
					{
						break;
					}
					continue;
					IL_00B2:
					this.method_26(jsonWriter_0, array_0, jsonArrayContract_0, member, int_1 + 1, array);
					goto IL_0271;
				}
				continue;
				Block_4:
				goto IL_001C;
				IL_002A:
				int num6;
				if (num6 < num)
				{
					goto IL_0030;
				}
				goto IL_0042;
				IL_003A:
				num6++;
				goto IL_002A;
				IL_0030:
				array[num6] = int_2[num6];
				goto IL_003A;
				IL_0027:
				num6 = 0;
				goto IL_002A;
				IL_001C:
				array = new int[num + 1];
				goto IL_0027;
			}
			Block_2:
			IL_028F:
			jsonWriter_0.WriteEndArray();
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00066014 File Offset: 0x00064214
		private bool method_27(JsonWriter jsonWriter_0, object object_0, JsonArrayContract jsonArrayContract_0, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract containerContract, [Nullable(2)] JsonProperty containerProperty)
		{
			bool flag2;
			bool flag4;
			for (;;)
			{
				IL_00EB:
				bool? flag = this.method_6(jsonArrayContract_0, member, containerContract, containerProperty);
				for (;;)
				{
					IL_00DF:
					if (flag != null)
					{
						goto IL_00C0;
					}
					goto IL_00CB;
					IL_00C7:
					bool flag3;
					flag2 = flag3;
					for (;;)
					{
						if (!flag2)
						{
							goto IL_0086;
						}
						goto IL_00B2;
						IL_004A:
						int num;
						bool flag5;
						switch (num)
						{
						case 0:
							goto IL_0006;
						case 1:
							IL_0026:
							flag4 = this.method_31(TypeNameHandling.Arrays, jsonArrayContract_0, member, containerContract, containerProperty);
							num = 7;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
							{
								goto IL_004A;
							}
							goto IL_00FC;
						case 2:
							continue;
						case 3:
							goto IL_00DF;
						case 4:
							goto IL_00EB;
						case 5:
							IL_0086:
							flag5 = false;
							break;
						case 6:
						case 8:
							goto IL_008C;
						case 7:
							goto IL_00FD;
						case 9:
							goto IL_00C0;
						case 10:
							goto IL_00A3;
						case 11:
							IL_00B2:
							if (member == null)
							{
								goto IL_008C;
							}
							goto IL_00A3;
						case 12:
							goto IL_00CB;
						default:
							goto IL_0006;
						}
						IL_0010:
						flag2 = flag5;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
						{
							goto IL_0026;
						}
						goto IL_004A;
						IL_0006:
						flag5 = this.method_17(containerContract, member);
						goto IL_0010;
						IL_008C:
						flag5 = true;
						goto IL_0010;
						IL_00A3:
						if (!member.Writable)
						{
							goto IL_0006;
						}
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
						{
							goto IL_008C;
						}
						goto IL_004A;
					}
					IL_00CB:
					flag3 = this.method_21(this.Serializer._preserveReferencesHandling, PreserveReferencesHandling.Arrays);
					goto IL_00C7;
					IL_00C0:
					flag3 = flag.GetValueOrDefault();
					goto IL_00C7;
				}
			}
			IL_00FC:
			IL_00FD:
			bool flag6 = flag2 || flag4;
			if (flag6)
			{
				jsonWriter_0.WriteStartObject();
				if (flag2)
				{
					this.method_18(jsonWriter_0, jsonArrayContract_0.UnderlyingType, object_0);
				}
				if (flag4)
				{
					this.method_19(jsonWriter_0, object_0.GetType());
				}
				jsonWriter_0.WritePropertyName(Class15.smethod_17(1176488470 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af), false);
			}
			if (jsonArrayContract_0.ItemContract == null)
			{
				jsonArrayContract_0.ItemContract = this.Serializer._contractResolver.ResolveContract(jsonArrayContract_0.CollectionItemType ?? typeof(object));
			}
			return flag6;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x000661A0 File Offset: 0x000643A0
		[SecuritySafeCritical]
		private void method_28(JsonWriter jsonWriter_0, ISerializable iserializable_0, JsonISerializableContract jsonISerializableContract_0, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
			string text;
			for (;;)
			{
				IL_02FE:
				if (!JsonTypeReflector.FullyTrusted)
				{
					goto IL_028F;
				}
				int num = 19;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
				{
					goto IL_0189;
				}
				SerializationEntry serializationEntry;
				JsonContract jsonContract;
				for (;;)
				{
					IL_021C:
					switch (num)
					{
					case 1:
						goto IL_00BD;
					case 2:
						goto IL_0021;
					case 3:
						goto IL_0168;
					case 4:
						goto IL_031C;
					case 5:
						return;
					case 6:
					case 14:
						goto IL_004E;
					case 7:
						if (!this.method_7(serializationEntry.Value, null, jsonContract, jsonISerializableContract_0, member))
						{
							goto Block_5;
						}
						goto IL_01DD;
					case 8:
						goto IL_0308;
					case 9:
					case 18:
					case 23:
						goto IL_0104;
					case 10:
						goto IL_01AA;
					case 11:
						goto IL_01DD;
					case 12:
						goto IL_0198;
					case 13:
						goto IL_028F;
					case 15:
						goto IL_0189;
					case 16:
						goto IL_01CF;
					case 17:
						goto IL_0089;
					case 19:
						this.method_12(jsonWriter_0, jsonISerializableContract_0, iserializable_0);
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
						{
							goto IL_0168;
						}
						continue;
					case 20:
						goto IL_02FE;
					case 21:
						goto IL_009F;
					case 22:
						goto IL_0067;
					case 24:
						this.method_13(jsonWriter_0, jsonISerializableContract_0, iserializable_0);
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
						{
							goto Block_3;
						}
						continue;
					case 25:
						goto IL_0006;
					}
					goto Block_6;
					IL_0168:
					this.list_0.Add(iserializable_0);
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
					{
						goto IL_0189;
					}
					continue;
					IL_01DD:
					jsonWriter_0.WritePropertyName(serializationEntry.Name);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
					{
						goto Block_4;
					}
				}
				Block_3:
				goto IL_0021;
				Block_5:
				goto IL_004E;
				Block_6:
				Block_4:
				goto IL_00E1;
				IL_0006:
				jsonWriter_0.WriteEndObject();
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
				{
					goto IL_021C;
				}
				IL_0021:
				this.list_0.RemoveAt(this.list_0.Count - 1);
				num = 24;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					goto IL_004E;
				}
				goto IL_021C;
				IL_0067:
				jsonWriter_0.WritePropertyName(serializationEntry.Name);
				num = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
				{
					goto IL_0089;
				}
				goto IL_021C;
				IL_004E:
				if (this.method_9(jsonWriter_0, serializationEntry.Value, null, jsonContract, jsonISerializableContract_0, member))
				{
					goto IL_0067;
				}
				goto IL_0104;
				IL_009F:
				SerializationInfoEnumerator enumerator;
				serializationEntry = enumerator.Current;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
				{
					goto IL_00BD;
				}
				goto IL_021C;
				IL_0104:
				if (enumerator.MoveNext())
				{
					goto IL_009F;
				}
				num = 15;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
				{
					goto IL_0006;
				}
				goto IL_021C;
				IL_01CF:
				SerializationInfo serializationInfo;
				enumerator = serializationInfo.GetEnumerator();
				goto IL_0104;
				IL_0089:
				this.method_5(jsonWriter_0, serializationEntry.Value, jsonContract, null, jsonISerializableContract_0, member);
				goto IL_0104;
				IL_00BD:
				jsonContract = this.method_2(serializationEntry.Value);
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
				{
					goto IL_021C;
				}
				IL_00E1:
				this.method_10(jsonWriter_0, serializationEntry.Value);
				num = 16;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
				{
					goto IL_0104;
				}
				goto IL_021C;
				IL_01AA:
				iserializable_0.GetObjectData(serializationInfo, this.Serializer._context);
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
				{
					goto IL_01CF;
				}
				goto IL_021C;
				IL_0198:
				serializationInfo = new SerializationInfo(jsonISerializableContract_0.UnderlyingType, new FormatterConverter());
				goto IL_01AA;
				IL_0189:
				this.method_16(jsonWriter_0, iserializable_0, jsonISerializableContract_0, member, collectionContract, containerProperty);
				goto IL_0198;
				IL_028F:
				text = Class15.smethod_17(1793899538 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a) + Environment.NewLine + Class15.smethod_17(1396528204 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7) + Environment.NewLine;
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
				{
					goto IL_00E1;
				}
				goto IL_021C;
			}
			IL_0308:
			text = text.FormatWith(CultureInfo.InvariantCulture, iserializable_0.GetType());
			IL_031C:
			throw JsonSerializationException.Create(null, jsonWriter_0.ContainerPath, text, null);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x000664DC File Offset: 0x000646DC
		private void method_29(JsonWriter jsonWriter_0, IDynamicMetaObjectProvider idynamicMetaObjectProvider_0, JsonDynamicContract jsonDynamicContract_0, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
			for (;;)
			{
				IL_0001:
				this.method_12(jsonWriter_0, jsonDynamicContract_0, idynamicMetaObjectProvider_0);
				for (;;)
				{
					IL_000A:
					this.list_0.Add(idynamicMetaObjectProvider_0);
					for (;;)
					{
						IL_0016:
						this.method_16(jsonWriter_0, idynamicMetaObjectProvider_0, jsonDynamicContract_0, member, collectionContract, containerProperty);
						for (;;)
						{
							IL_0025:
							int top = jsonWriter_0.Top;
							for (;;)
							{
								IL_002D:
								int num = 0;
								for (;;)
								{
									IL_0030:
									if (num < jsonDynamicContract_0.Properties.Count)
									{
										goto IL_00A2;
									}
									int num2 = 9;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
									{
										continue;
									}
									for (;;)
									{
										IL_0053:
										switch (num2)
										{
										case 1:
											goto IL_00C3;
										case 2:
											goto IL_0016;
										case 3:
											goto IL_01FB;
										case 4:
											goto IL_0453;
										case 5:
										case 12:
											goto IL_0030;
										case 6:
											this.list_0.RemoveAt(this.list_0.Count - 1);
											num2 = 0;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
											{
												continue;
											}
											break;
										case 7:
											goto IL_00E4;
										case 8:
											goto IL_002D;
										case 9:
											goto IL_0412;
										case 10:
											goto IL_01E0;
										case 11:
											return;
										case 13:
											goto IL_000A;
										case 14:
											goto IL_0001;
										case 15:
											goto IL_00A2;
										case 16:
											goto IL_0025;
										}
										goto Block_2;
									}
									IL_00A2:
									JsonProperty jsonProperty = jsonDynamicContract_0.Properties[num];
									num2 = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
									{
										goto IL_0053;
									}
									IL_00C3:
									if (!jsonProperty.HasMemberAttribute)
									{
										goto IL_0453;
									}
									num2 = 6;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
									{
										goto IL_00E4;
									}
									goto IL_0053;
									IL_01E0:
									jsonWriter_0.WriteEndObject();
									num2 = 6;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
									{
										goto IL_0053;
									}
									IL_01FB:
									IEnumerator<string> enumerator;
									try
									{
										for (;;)
										{
											IL_03B7:
											if (!enumerator.MoveNext())
											{
												goto IL_03A0;
											}
											goto IL_023F;
											int num3;
											string text;
											object obj;
											for (;;)
											{
												IL_0223:
												switch (num3)
												{
												case 1:
													goto IL_03B7;
												case 2:
													goto IL_03C7;
												case 3:
													if (!jsonDynamicContract_0.TryGetMember(idynamicMetaObjectProvider_0, text, out obj))
													{
														goto IL_03B7;
													}
													num3 = 0;
													if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
													{
														continue;
													}
													break;
												case 4:
													goto IL_023F;
												}
												break;
											}
											IL_0260:
											try
											{
												JsonContract jsonContract = this.method_2(obj);
												int num4 = 1;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
												{
													for (;;)
													{
														string text2;
														switch (num4)
														{
														default:
															goto IL_0318;
														case 1:
															if (!this.method_30(obj))
															{
																goto IL_0318;
															}
															num4 = 5;
															if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
															{
																goto IL_02B9;
															}
															continue;
														case 2:
															goto IL_031E;
														case 3:
															goto IL_02AA;
														case 4:
														case 5:
															goto IL_02B9;
														case 6:
															goto IL_032D;
														case 7:
															IL_0286:
															jsonWriter_0.WritePropertyName(text2);
															num4 = 2;
															if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
															{
																goto Block_25;
															}
															continue;
														case 8:
															goto IL_02A2;
														case 9:
															goto IL_0282;
														}
														IL_0284:
														string text3;
														text2 = text3;
														goto IL_0286;
														IL_0282:
														text3 = text;
														goto IL_0284;
														IL_02A2:
														if (jsonDynamicContract_0.PropertyNameResolver != null)
														{
															goto IL_02AA;
														}
														goto IL_0282;
														IL_02B9:
														if (this.method_9(jsonWriter_0, obj, null, jsonContract, jsonDynamicContract_0, member))
														{
															goto IL_02A2;
														}
														goto IL_032D;
														IL_02AA:
														text3 = jsonDynamicContract_0.PropertyNameResolver(text);
														goto IL_0284;
													}
													Block_25:
													IL_031E:
													this.method_5(jsonWriter_0, obj, jsonContract, null, jsonDynamicContract_0, member);
													IL_032D:;
												}
												IL_0318:
												continue;
											}
											catch (Exception ex)
											{
												int num5 = 0;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
												{
													goto IL_0365;
												}
												goto IL_037D;
												IL_0348:
												this.method_34(jsonWriter_0, top);
												num5 = 0;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
												{
													continue;
												}
												goto IL_037D;
												IL_0365:
												if (!base.IsErrorHandled(idynamicMetaObjectProvider_0, jsonDynamicContract_0, text, null, jsonWriter_0.ContainerPath, ex))
												{
													goto IL_039C;
												}
												goto IL_0348;
												IL_037D:
												switch (num5)
												{
												case 0:
													goto IL_0365;
												case 1:
													goto IL_0348;
												case 2:
												case 4:
													break;
												case 3:
													continue;
												default:
													goto IL_0365;
												}
												IL_039C:
												throw;
												continue;
											}
											goto IL_03A0;
											goto IL_0260;
											IL_023F:
											text = enumerator.Current;
											num3 = 3;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
											{
												continue;
											}
											goto IL_0223;
											IL_03A0:
											num3 = 2;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
											{
												break;
											}
											goto IL_0223;
										}
										IL_03C7:
										goto IL_01E0;
									}
									finally
									{
										if (enumerator != null)
										{
											goto IL_03F8;
										}
										int num6 = 0;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
										{
											goto IL_0411;
										}
										IL_03E4:
										switch (num6)
										{
										case 1:
											IL_03F8:
											enumerator.Dispose();
											num6 = 2;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
											{
												goto IL_03E4;
											}
											break;
										}
										IL_0411:;
									}
									IL_0412:
									enumerator = idynamicMetaObjectProvider_0.GetDynamicMemberNames().GetEnumerator();
									goto IL_01FB;
									IL_00E4:
									try
									{
										JsonContract jsonContract2;
										object obj2;
										if (this.method_15(jsonWriter_0, idynamicMetaObjectProvider_0, jsonDynamicContract_0, member, jsonProperty, out jsonContract2, out obj2))
										{
											for (;;)
											{
												jsonProperty.WritePropertyName(jsonWriter_0);
												int num7 = 1;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
												{
													goto IL_00FB;
												}
												IL_011C:
												switch (num7)
												{
												case 1:
													IL_00FB:
													this.method_5(jsonWriter_0, obj2, jsonContract2, jsonProperty, jsonDynamicContract_0, member);
													num7 = 0;
													if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
													{
														goto IL_011C;
													}
													break;
												case 3:
												case 4:
													continue;
												}
												break;
											}
										}
										goto IL_0453;
									}
									catch (Exception ex2)
									{
										int num8 = 2;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
										{
											goto IL_0173;
										}
										for (;;)
										{
											IL_01BB:
											switch (num8)
											{
											case 1:
												this.method_34(jsonWriter_0, top);
												num8 = 0;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
												{
													continue;
												}
												break;
											case 2:
												goto IL_01D9;
											case 3:
												goto IL_0173;
											}
											break;
										}
										goto IL_01DB;
										IL_0173:
										if (base.IsErrorHandled(idynamicMetaObjectProvider_0, jsonDynamicContract_0, jsonProperty.PropertyName, null, jsonWriter_0.ContainerPath, ex2))
										{
											num8 = 1;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
											{
												goto IL_01DB;
											}
											goto IL_01BB;
										}
										IL_01D9:
										throw;
										IL_01DB:
										goto IL_0453;
									}
									goto IL_01E0;
									IL_0453:
									num++;
									num2 = 12;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
									{
										goto IL_0053;
									}
								}
							}
						}
					}
				}
			}
			Block_2:
			this.method_13(jsonWriter_0, jsonDynamicContract_0, idynamicMetaObjectProvider_0);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x000669B4 File Offset: 0x00064BB4
		[NullableContext(2)]
		private bool method_30(object object_0)
		{
			for (;;)
			{
				IL_00A2:
				if (this.Serializer._nullValueHandling == NullValueHandling.Ignore)
				{
					goto IL_0071;
				}
				for (;;)
				{
					IL_008B:
					if (this.method_20(this.Serializer._defaultValueHandling, DefaultValueHandling.Ignore))
					{
						goto IL_006A;
					}
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
					{
						goto IL_0040;
					}
					IL_0017:
					switch (num)
					{
					case 1:
						return true;
					case 2:
						goto IL_0071;
					case 3:
						goto IL_00A2;
					case 4:
						IL_006A:
						if (object_0 == null)
						{
							num = 7;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
							{
								return false;
							}
							goto IL_0017;
						}
						break;
					case 5:
					case 8:
						return false;
					case 6:
						return false;
					case 7:
						continue;
					}
					IL_0040:
					if (!MiscellaneousUtils.ValueEquals(object_0, ReflectionUtils.GetDefaultValue(object_0.GetType())))
					{
						return true;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
					{
						goto IL_0017;
					}
					break;
				}
				IL_0071:
				if (object_0 != null)
				{
					goto IL_008B;
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00066A7C File Offset: 0x00064C7C
		[NullableContext(2)]
		private bool method_31(TypeNameHandling typeNameHandling_0, [Nullable(1)] JsonContract contract, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
		{
			for (;;)
			{
				IL_034A:
				if (jsonProperty_0 == null)
				{
					goto IL_003D;
				}
				TypeNameHandling? typeNameHandling = jsonProperty_0.TypeNameHandling;
				goto IL_032D;
				int num;
				for (;;)
				{
					IL_029F:
					switch (num)
					{
					case 1:
						goto IL_0192;
					case 2:
						goto IL_0213;
					case 3:
						goto IL_009A;
					case 4:
						goto IL_032B;
					case 5:
						goto IL_024F;
					case 6:
						goto IL_00C8;
					case 7:
						goto IL_0138;
					case 8:
						goto IL_003D;
					case 9:
						goto IL_034A;
					case 10:
						goto IL_0234;
					case 11:
						goto IL_01DD;
					case 12:
						goto IL_027C;
					case 13:
						return true;
					case 14:
					case 26:
						return true;
					case 15:
						if (jsonProperty_0 == null)
						{
							goto IL_0234;
						}
						goto IL_024F;
					case 16:
					case 24:
						return false;
					case 17:
						goto IL_01F6;
					case 18:
						goto IL_01D4;
					case 19:
						goto IL_019E;
					case 20:
						goto IL_0066;
					case 21:
						return true;
					case 22:
						goto IL_008D;
					case 23:
						goto IL_00EB;
					case 25:
						goto IL_0171;
					case 27:
						goto IL_016A;
					case 28:
						goto IL_010D;
					case 29:
						return true;
					case 30:
						goto IL_005F;
					case 31:
						goto IL_0011;
					}
					goto Block_18;
					IL_0011:
					JsonContract jsonContract;
					if (!(contract.NonNullableUnderlyingType != jsonContract.CreatedType))
					{
						return false;
					}
					num = 21;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
					{
						goto IL_003D;
					}
					continue;
					IL_010D:
					if (this.list_0.Count != this.int_0)
					{
						return false;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
					{
						goto IL_0138;
					}
					continue;
					IL_0234:
					if (jsonContainerContract_0 != null)
					{
						goto IL_027C;
					}
					if (!(this.type_0 != null))
					{
						goto Block_14;
					}
					goto IL_010D;
					IL_0138:
					jsonContract = this.Serializer._contractResolver.ResolveContract(this.type_0);
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
					{
						goto IL_0011;
					}
					continue;
					IL_019E:
					if (contract.NonNullableUnderlyingType != jsonContainerContract_0.ItemContract.CreatedType)
					{
						return true;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
					{
						goto Block_11;
					}
					continue;
					IL_027C:
					if (jsonContainerContract_0.ItemContract != null)
					{
						goto IL_019E;
					}
					num = 26;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
					{
						goto Block_17;
					}
					continue;
					IL_024F:
					if (!(contract.NonNullableUnderlyingType != jsonProperty_0.PropertyContract.CreatedType))
					{
						return false;
					}
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
					{
						goto IL_027C;
					}
				}
				IL_016A:
				TypeNameHandling? typeNameHandling3;
				TypeNameHandling? typeNameHandling2 = typeNameHandling3;
				goto IL_006D;
				Block_17:
				goto IL_00C8;
				Block_18:
				goto IL_0084;
				IL_00EB:
				typeNameHandling3 = null;
				num = 27;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
				{
					continue;
				}
				goto IL_029F;
				IL_005F:
				if (jsonContainerContract_0 != null)
				{
					goto IL_0066;
				}
				goto IL_00EB;
				IL_0171:
				TypeNameHandling? typeNameHandling4;
				if (typeNameHandling4 == null)
				{
					goto IL_005F;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
				{
					goto IL_0192;
				}
				goto IL_029F;
				IL_021E:
				TypeNameHandling? typeNameHandling5;
				typeNameHandling4 = typeNameHandling5;
				goto IL_0171;
				IL_0213:
				TypeNameHandling? typeNameHandling6;
				typeNameHandling5 = typeNameHandling6;
				goto IL_021E;
				IL_01F6:
				typeNameHandling6 = null;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto IL_0213;
				}
				goto IL_029F;
				IL_01DD:
				if (jsonProperty_1 != null)
				{
					typeNameHandling5 = jsonProperty_1.ItemTypeNameHandling;
					goto IL_021E;
				}
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
				{
					goto IL_01F6;
				}
				goto IL_029F;
				IL_01D4:
				TypeNameHandling? typeNameHandling7;
				if (typeNameHandling7 == null)
				{
					goto IL_01DD;
				}
				TypeNameHandling typeNameHandling8 = typeNameHandling7.GetValueOrDefault();
				goto IL_0098;
				IL_032D:
				typeNameHandling7 = typeNameHandling;
				num = 16;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
				{
					goto IL_01D4;
				}
				goto IL_029F;
				IL_003D:
				typeNameHandling4 = null;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
				{
					goto IL_029F;
				}
				IL_032B:
				typeNameHandling = typeNameHandling4;
				goto IL_032D;
				IL_006D:
				typeNameHandling6 = typeNameHandling2;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
				{
					goto IL_0084;
				}
				goto IL_029F;
				IL_0066:
				typeNameHandling2 = jsonContainerContract_0.ItemTypeNameHandling;
				goto IL_006D;
				IL_009A:
				TypeNameHandling typeNameHandling9;
				if (!this.method_22(typeNameHandling9, typeNameHandling_0))
				{
					if (!this.method_22(typeNameHandling9, TypeNameHandling.Auto))
					{
						return false;
					}
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
					{
						goto IL_00C8;
					}
					goto IL_029F;
				}
				else
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
					{
						break;
					}
					goto IL_029F;
				}
				IL_0098:
				typeNameHandling9 = typeNameHandling8;
				goto IL_009A;
				IL_0192:
				typeNameHandling8 = typeNameHandling4.GetValueOrDefault();
				goto IL_0098;
				IL_00C8:
				typeNameHandling8 = typeNameHandling6.GetValueOrDefault();
				goto IL_0098;
				IL_0084:
				if (typeNameHandling6 != null)
				{
					goto IL_00C8;
				}
				IL_008D:
				typeNameHandling8 = this.Serializer._typeNameHandling;
				goto IL_0098;
			}
			return true;
			Block_11:
			Block_14:
			return false;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00066DEC File Offset: 0x00064FEC
		private void method_32(JsonWriter jsonWriter_0, IDictionary idictionary_0, JsonDictionaryContract jsonDictionaryContract_0, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty)
		{
			object obj;
			for (;;)
			{
				IL_0407:
				Interface1 @interface = idictionary_0 as Interface1;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
				{
					goto IL_0341;
				}
				for (;;)
				{
					IL_03B0:
					switch (num)
					{
					case 1:
						goto IL_0341;
					case 2:
						goto IL_0407;
					case 3:
						goto IL_0305;
					case 4:
						goto IL_034E;
					case 5:
						goto IL_0063;
					case 6:
						goto IL_005B;
					case 7:
						goto IL_0048;
					case 8:
						this.list_0.Add(obj);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
						{
							goto Block_8;
						}
						continue;
					case 9:
						goto IL_02F7;
					case 10:
						goto IL_0427;
					case 11:
						goto IL_02C8;
					case 12:
						this.list_0.RemoveAt(this.list_0.Count - 1);
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
						{
							goto Block_7;
						}
						continue;
					case 13:
					case 17:
						goto IL_0053;
					case 14:
						goto IL_0348;
					case 15:
						return;
					case 16:
						goto IL_02AB;
					case 18:
						goto IL_0006;
					}
					break;
				}
				goto IL_0024;
				Block_8:
				goto IL_034E;
				IL_000D:
				object obj2;
				obj = obj2;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
				{
					goto IL_0024;
				}
				goto IL_03B0;
				IL_0006:
				obj2 = @interface.UnderlyingDictionary;
				goto IL_000D;
				IL_0341:
				if (@interface == null)
				{
					goto IL_0348;
				}
				goto IL_0006;
				IL_0024:
				this.method_12(jsonWriter_0, jsonDictionaryContract_0, obj);
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
				{
					goto IL_034E;
				}
				goto IL_03B0;
				IL_02AB:
				jsonWriter_0.WriteEndObject();
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
				{
					goto IL_02F7;
				}
				goto IL_03B0;
				IL_0063:
				IDictionaryEnumerator enumerator;
				int top;
				try
				{
					for (;;)
					{
						if (!enumerator.MoveNext())
						{
							goto IL_023A;
						}
						goto IL_00DA;
						IL_0086:
						int num2;
						DictionaryEntry entry;
						string text;
						bool flag;
						switch (num2)
						{
						case 0:
							goto IL_00DA;
						case 1:
							goto IL_00E6;
						case 2:
							goto IL_00F5;
						case 3:
							goto IL_00AE;
						case 4:
							IL_00F9:
							try
							{
								object value = entry.Value;
								JsonContract jsonContract2;
								for (;;)
								{
									IL_019A:
									JsonContract jsonContract;
									if ((jsonContract = jsonDictionaryContract_0.FinalItemContract) == null)
									{
										goto IL_018E;
									}
									IL_0196:
									jsonContract2 = jsonContract;
									IL_017B:
									while (this.method_7(value, null, jsonContract2, jsonDictionaryContract_0, member))
									{
										for (;;)
										{
											jsonWriter_0.WritePropertyName(text, flag);
											int num3 = 0;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
											{
												goto IL_0108;
											}
											IL_0125:
											switch (num3)
											{
											case 1:
											case 3:
												goto IL_01BA;
											case 2:
												goto IL_01C4;
											case 4:
											case 10:
												goto IL_01D3;
											case 5:
												goto IL_019A;
											case 6:
												goto IL_017B;
											case 7:
												goto IL_01A9;
											case 8:
												continue;
											case 9:
												goto IL_018E;
											case 11:
												goto IL_01D5;
											}
											IL_0108:
											this.method_10(jsonWriter_0, value);
											num3 = 10;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
											{
												goto IL_0125;
											}
											goto IL_01A6;
										}
									}
									goto IL_01A9;
									IL_018E:
									jsonContract = this.method_2(value);
									goto IL_0196;
								}
								IL_01A6:
								continue;
								IL_01A9:
								if (!this.method_9(jsonWriter_0, value, null, jsonContract2, jsonDictionaryContract_0, member))
								{
									continue;
								}
								IL_01BA:
								jsonWriter_0.WritePropertyName(text, flag);
								IL_01C4:
								this.method_5(jsonWriter_0, value, jsonContract2, null, jsonDictionaryContract_0, member);
								IL_01D3:
								IL_01D5:
								continue;
							}
							catch (Exception ex)
							{
								int num4 = 2;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
								{
									goto IL_0212;
								}
								IL_01EB:
								if (!base.IsErrorHandled(obj, jsonDictionaryContract_0, text, null, jsonWriter_0.ContainerPath, ex))
								{
									goto IL_0236;
								}
								num4 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
								{
									goto IL_022B;
								}
								IL_0212:
								switch (num4)
								{
								case 0:
									goto IL_0236;
								case 1:
									break;
								case 2:
									goto IL_01EB;
								case 3:
									continue;
								default:
									goto IL_0236;
								}
								IL_022B:
								this.method_34(jsonWriter_0, top);
								continue;
								IL_0236:
								throw;
								continue;
							}
							goto IL_023A;
						case 5:
							break;
						case 6:
							goto IL_0263;
						case 7:
							continue;
						default:
							goto IL_00DA;
						}
						IL_006A:
						if (jsonDictionaryContract_0.DictionaryKeyResolver == null)
						{
							goto IL_00F5;
						}
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
						{
							goto IL_0086;
						}
						goto IL_00E6;
						IL_00F7:
						string text2;
						text = text2;
						goto IL_00F9;
						IL_00E6:
						text2 = jsonDictionaryContract_0.DictionaryKeyResolver(text);
						goto IL_00F7;
						IL_00AE:
						text = this.method_33(jsonWriter_0, entry.Key, jsonDictionaryContract_0.KeyContract, out flag);
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
						{
							goto IL_006A;
						}
						goto IL_0086;
						IL_00DA:
						entry = enumerator.Entry;
						goto IL_00AE;
						IL_023A:
						num2 = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
						{
							goto IL_00F9;
						}
						goto IL_0086;
						IL_00F5:
						text2 = text;
						goto IL_00F7;
					}
					IL_0263:;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num5;
					if (disposable == null)
					{
						num5 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
						{
							goto IL_02AA;
						}
					}
					else
					{
						disposable.Dispose();
						num5 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
						{
							goto IL_02AA;
						}
					}
					switch (num5)
					{
					default:
						IL_02AA:
						break;
					}
				}
				goto IL_02AB;
				IL_005B:
				enumerator = idictionary_0.GetEnumerator();
				goto IL_0063;
				IL_0053:
				top = jsonWriter_0.Top;
				goto IL_005B;
				IL_0048:
				if (jsonDictionaryContract_0.KeyContract != null)
				{
					goto IL_0053;
				}
				goto IL_0305;
				IL_02F7:
				if (jsonDictionaryContract_0.ItemContract == null)
				{
					goto IL_02C8;
				}
				goto IL_0048;
				IL_034E:
				this.method_16(jsonWriter_0, obj, jsonDictionaryContract_0, member, collectionContract, containerProperty);
				goto IL_02F7;
				IL_02C8:
				jsonDictionaryContract_0.ItemContract = this.Serializer._contractResolver.ResolveContract(jsonDictionaryContract_0.DictionaryValueType ?? typeof(object));
				goto IL_0048;
				IL_0305:
				jsonDictionaryContract_0.KeyContract = this.Serializer._contractResolver.ResolveContract(jsonDictionaryContract_0.DictionaryKeyType ?? typeof(object));
				num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
				{
					goto IL_0341;
				}
				goto IL_03B0;
				IL_0348:
				obj2 = idictionary_0;
				goto IL_000D;
			}
			Block_7:
			IL_0427:
			this.method_13(jsonWriter_0, jsonDictionaryContract_0, obj);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00067260 File Offset: 0x00065460
		private string method_33(JsonWriter jsonWriter_0, object object_0, JsonContract jsonContract_0, out bool bool_0)
		{
			DateTime dateTime;
			for (;;)
			{
				int num;
				string text;
				if (jsonContract_0.ContractType == JsonContractType.Primitive)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
					{
						goto IL_0118;
					}
				}
				else
				{
					if (!JsonSerializerInternalWriter.TryConvertToString(object_0, object_0.GetType(), out text))
					{
						goto IL_0275;
					}
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
					{
						goto IL_00EF;
					}
				}
				IL_0122:
				JsonPrimitiveContract jsonPrimitiveContract;
				string text2;
				switch (num)
				{
				case 1:
				case 11:
					goto IL_01A9;
				case 2:
					IL_0118:
					jsonPrimitiveContract = (JsonPrimitiveContract)jsonContract_0;
					goto IL_010A;
				case 3:
					continue;
				case 4:
					goto IL_01C4;
				case 5:
					goto IL_01C0;
				case 6:
					goto IL_0218;
				case 7:
					goto IL_00A3;
				case 8:
					goto IL_024B;
				case 9:
					goto IL_009F;
				case 10:
					return text2;
				case 12:
					goto IL_01F2;
				case 13:
					goto IL_0279;
				case 14:
					goto IL_010A;
				case 15:
					IL_00EF:
					bool_0 = true;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
					{
						goto IL_0122;
					}
					break;
				case 16:
					goto IL_01EE;
				case 17:
					goto IL_00C3;
				case 18:
					goto IL_0247;
				case 19:
					goto IL_0060;
				case 20:
					goto IL_0033;
				}
				return text;
				IL_0033:
				dateTime = DateTimeUtils.EnsureDateTime((DateTime)object_0, jsonWriter_0.DateTimeZoneHandling);
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
				{
					break;
				}
				goto IL_0122;
				IL_0060:
				PrimitiveTypeCode typeCode;
				switch (typeCode)
				{
				case PrimitiveTypeCode.Single:
				case PrimitiveTypeCode.SingleNullable:
					goto IL_01B8;
				case PrimitiveTypeCode.Double:
				case PrimitiveTypeCode.DoubleNullable:
					goto IL_01E6;
				case PrimitiveTypeCode.DateTime:
				case PrimitiveTypeCode.DateTimeNullable:
					goto IL_0033;
				case PrimitiveTypeCode.DateTimeOffset:
				case PrimitiveTypeCode.DateTimeOffsetNullable:
					goto IL_0214;
				default:
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
					{
						goto IL_009F;
					}
					goto IL_0122;
				}
				IL_010A:
				typeCode = jsonPrimitiveContract.TypeCode;
				goto IL_0060;
				IL_00A3:
				if (jsonPrimitiveContract.IsEnum)
				{
					goto IL_00C3;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
				{
					goto Block_6;
				}
				goto IL_0122;
				IL_009F:
				bool_0 = true;
				goto IL_00A3;
				IL_00C3:
				if (EnumUtils.TryToString(jsonPrimitiveContract.NonNullableUnderlyingType, object_0, null, out text2))
				{
					return text2;
				}
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
				{
					goto Block_8;
				}
				goto IL_0122;
			}
			goto IL_0247;
			Block_6:
			Block_8:
			IL_01A9:
			return Convert.ToString(object_0, CultureInfo.InvariantCulture);
			IL_01B8:
			float num2 = (float)object_0;
			IL_01C0:
			bool_0 = false;
			IL_01C4:
			return num2.ToString(Class15.smethod_17(277633232 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98), CultureInfo.InvariantCulture);
			IL_01E6:
			double num3 = (double)object_0;
			IL_01EE:
			bool_0 = false;
			IL_01F2:
			return num3.ToString(Class15.smethod_17(1788638134 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1), CultureInfo.InvariantCulture);
			IL_0214:
			bool_0 = false;
			IL_0218:
			StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
			DateTimeUtils.WriteDateTimeOffsetString(stringWriter, (DateTimeOffset)object_0, jsonWriter_0.DateFormatHandling, jsonWriter_0.DateFormatString, jsonWriter_0.Culture);
			return stringWriter.ToString();
			IL_0247:
			bool_0 = false;
			IL_024B:
			StringWriter stringWriter2 = new StringWriter(CultureInfo.InvariantCulture);
			DateTimeUtils.WriteDateTimeString(stringWriter2, dateTime, jsonWriter_0.DateFormatHandling, jsonWriter_0.DateFormatString, jsonWriter_0.Culture);
			return stringWriter2.ToString();
			IL_0275:
			bool_0 = true;
			IL_0279:
			return object_0.ToString();
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x000674EC File Offset: 0x000656EC
		private void method_34(JsonWriter jsonWriter_0, int int_1)
		{
			for (;;)
			{
				IL_0063:
				base.ClearErrorContext();
				for (;;)
				{
					IL_0057:
					if (jsonWriter_0.WriteState == WriteState.Property)
					{
						goto IL_0042;
					}
					IL_004B:
					while (jsonWriter_0.Top > int_1)
					{
						for (;;)
						{
							jsonWriter_0.WriteEnd();
							int num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
							{
								switch (num)
								{
								case 1:
									return;
								case 2:
									goto IL_0057;
								case 3:
									goto IL_0063;
								case 5:
								case 7:
									continue;
								case 6:
									goto IL_0042;
								}
								break;
							}
							break;
						}
					}
					return;
					IL_0042:
					jsonWriter_0.WriteNull();
					goto IL_004B;
				}
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00067564 File Offset: 0x00065764
		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target)
		{
			while (property.ShouldSerialize != null)
			{
				bool flag = property.ShouldSerialize(target);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
				{
					goto IL_0023;
				}
				IL_003C:
				switch (num)
				{
				case 1:
					IL_0023:
					if (this.TraceWriter == null)
					{
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
						{
							goto IL_003C;
						}
						return flag;
					}
					break;
				case 2:
				case 3:
				case 5:
					return flag;
				case 4:
					goto IL_0080;
				case 6:
					return true;
				case 7:
					continue;
				}
				if (this.TraceWriter.LevelFilter < TraceLevel.Verbose)
				{
					return flag;
				}
				IL_0080:
				this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(null, writer.Path, Class15.smethod_17(2071439452 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808).FormatWith(CultureInfo.InvariantCulture, property.PropertyName, property.DeclaringType, flag)), null);
				return flag;
			}
			return true;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00067640 File Offset: 0x00065840
		private bool method_35(JsonWriter jsonWriter_0, JsonProperty jsonProperty_0, object object_0)
		{
			IL_0095:
			while (jsonProperty_0.GetIsSpecified != null)
			{
				int num = 6;
				bool flag;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
				{
					for (;;)
					{
						IL_006D:
						switch (num)
						{
						case 1:
						case 5:
							return flag;
						case 2:
							goto IL_002B;
						case 3:
							goto IL_00A6;
						case 4:
							return true;
						case 6:
							flag = jsonProperty_0.GetIsSpecified(object_0);
							goto IL_002B;
						case 7:
							goto IL_0095;
						}
						IL_005C:
						while (this.TraceWriter.LevelFilter < TraceLevel.Verbose)
						{
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
							{
								goto IL_006D;
							}
						}
						break;
						IL_002B:
						if (this.TraceWriter == null)
						{
							return flag;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
						{
							goto IL_005C;
						}
					}
					IL_00A6:
					this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(null, jsonWriter_0.Path, Class15.smethod_17(41469515 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d).FormatWith(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName, jsonProperty_0.DeclaringType, flag)), null);
				}
				return flag;
			}
			return true;
		}

		// Token: 0x040005A1 RID: 1441
		[Nullable(2)]
		private Type type_0;

		// Token: 0x040005A2 RID: 1442
		private int int_0;

		// Token: 0x040005A3 RID: 1443
		private readonly List<object> list_0 = new List<object>();
	}
}
