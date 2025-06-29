using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010B RID: 267
	[Nullable(0)]
	[NullableContext(1)]
	internal class JsonFormatterConverter : IFormatterConverter
	{
		// Token: 0x06000A2D RID: 2605 RVA: 0x0005A2AC File Offset: 0x000584AC
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, [Nullable(2)] JsonProperty member)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
			{
				goto IL_0038;
			}
			goto IL_00A5;
			IL_001F:
			this.jsonProperty_0 = member;
			num = 5;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
			{
				goto IL_00A5;
			}
			IL_0038:
			ValidationUtils.ArgumentNotNull(reader, Class15.smethod_17(299949347 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e));
			num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
			{
				goto IL_00A5;
			}
			IL_0065:
			ValidationUtils.ArgumentNotNull(contract, Class15.smethod_17(1788620170 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1));
			IL_0080:
			this.jsonSerializerInternalReader_0 = reader;
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
			{
				goto IL_00A5;
			}
			IL_0099:
			this.jsonISerializableContract_0 = contract;
			goto IL_001F;
			IL_00A5:
			switch (num)
			{
			case 0:
				goto IL_0038;
			case 1:
				goto IL_0099;
			case 2:
				goto IL_0065;
			case 3:
				goto IL_0080;
			case 4:
				goto IL_001F;
			case 5:
				return;
			default:
				goto IL_0038;
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0005A384 File Offset: 0x00058584
		private T method_0<[Nullable(2)] T>(object object_0)
		{
			ValidationUtils.ArgumentNotNull(object_0, Class15.smethod_17(552182932 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f));
			return (T)((object)global::System.Convert.ChangeType(((JValue)object_0).Value, typeof(T), CultureInfo.InvariantCulture));
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0005A3D0 File Offset: 0x000585D0
		public object Convert(object value, Type type)
		{
			JToken jtoken;
			for (;;)
			{
				IL_004F:
				ValidationUtils.ArgumentNotNull(value, Class15.smethod_17(1678088256 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a));
				for (;;)
				{
					IL_0033:
					jtoken = value as JToken;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
					{
						goto Block_3;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							if (jtoken != null)
							{
								goto IL_00A0;
							}
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_0033;
						case 3:
							goto IL_004F;
						}
						goto Block_2;
					}
				}
			}
			Block_2:
			Block_3:
			throw new ArgumentException(Class15.smethod_17(2060589016 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177), Class15.smethod_17(1396567236 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7));
			IL_00A0:
			return this.jsonSerializerInternalReader_0.CreateISerializableItem(jtoken, type, this.jsonISerializableContract_0, this.jsonProperty_0);
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0005A498 File Offset: 0x00058698
		public object Convert(object value, TypeCode typeCode)
		{
			JValue jvalue;
			for (;;)
			{
				IL_0041:
				ValidationUtils.ArgumentNotNull(value, Class15.smethod_17(635802687 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2));
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						jvalue = value as JValue;
						goto IL_0003;
					case 2:
						goto IL_0041;
					case 3:
						goto IL_007A;
					case 4:
						goto IL_0003;
					}
					goto Block_3;
					IL_0003:
					if (jvalue == null)
					{
						goto IL_007A;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
					{
						goto Block_2;
					}
				}
			}
			Block_2:
			Block_3:
			object obj = jvalue.Value;
			goto IL_007B;
			IL_007A:
			obj = value;
			IL_007B:
			return global::System.Convert.ChangeType(obj, typeCode, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00004CF3 File Offset: 0x00002EF3
		public bool ToBoolean(object value)
		{
			return this.method_0<bool>(value);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00004CFC File Offset: 0x00002EFC
		public byte ToByte(object value)
		{
			return this.method_0<byte>(value);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00004D05 File Offset: 0x00002F05
		public char ToChar(object value)
		{
			return this.method_0<char>(value);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00004D0E File Offset: 0x00002F0E
		public DateTime ToDateTime(object value)
		{
			return this.method_0<DateTime>(value);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00004D17 File Offset: 0x00002F17
		public decimal ToDecimal(object value)
		{
			return this.method_0<decimal>(value);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00004D20 File Offset: 0x00002F20
		public double ToDouble(object value)
		{
			return this.method_0<double>(value);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00004D29 File Offset: 0x00002F29
		public short ToInt16(object value)
		{
			return this.method_0<short>(value);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00004D32 File Offset: 0x00002F32
		public int ToInt32(object value)
		{
			return this.method_0<int>(value);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00004D3B File Offset: 0x00002F3B
		public long ToInt64(object value)
		{
			return this.method_0<long>(value);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00004D44 File Offset: 0x00002F44
		public sbyte ToSByte(object value)
		{
			return this.method_0<sbyte>(value);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00004D4D File Offset: 0x00002F4D
		public float ToSingle(object value)
		{
			return this.method_0<float>(value);
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00004D56 File Offset: 0x00002F56
		public string ToString(object value)
		{
			return this.method_0<string>(value);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00004D5F File Offset: 0x00002F5F
		public ushort ToUInt16(object value)
		{
			return this.method_0<ushort>(value);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00004D68 File Offset: 0x00002F68
		public uint ToUInt32(object value)
		{
			return this.method_0<uint>(value);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00004D71 File Offset: 0x00002F71
		public ulong ToUInt64(object value)
		{
			return this.method_0<ulong>(value);
		}

		// Token: 0x04000549 RID: 1353
		private readonly JsonSerializerInternalReader jsonSerializerInternalReader_0;

		// Token: 0x0400054A RID: 1354
		private readonly JsonISerializableContract jsonISerializableContract_0;

		// Token: 0x0400054B RID: 1355
		[Nullable(2)]
		private readonly JsonProperty jsonProperty_0;
	}
}
