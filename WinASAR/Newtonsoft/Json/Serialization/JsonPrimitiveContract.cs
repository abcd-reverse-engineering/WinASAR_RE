using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010F RID: 271
	[Nullable(0)]
	[NullableContext(1)]
	public class JsonPrimitiveContract : JsonContract
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00004E19 File Offset: 0x00003019
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x0005AAB4 File Offset: 0x00058CB4
		internal PrimitiveTypeCode TypeCode
		{
			[CompilerGenerated]
			get
			{
				return this.primitiveTypeCode_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.primitiveTypeCode_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
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
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0005AAEC File Offset: 0x00058CEC
		public JsonPrimitiveContract(Type underlyingType)
			: base(underlyingType)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
			{
				goto IL_0044;
			}
			goto IL_004D;
			IL_001D:
			this.TypeCode = ConvertUtils.GetTypeCode(underlyingType);
			IL_0029:
			this.IsReadOnlyOrFixedSize = true;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
			{
				goto IL_0072;
			}
			goto IL_004D;
			IL_0044:
			this.ContractType = JsonContractType.Primitive;
			goto IL_001D;
			IL_004D:
			switch (num)
			{
			case 1:
				goto IL_0044;
			case 2:
			case 3:
				return;
			case 4:
				goto IL_0086;
			case 5:
				goto IL_0029;
			case 6:
				goto IL_001D;
			}
			IL_0072:
			ReadType readType;
			if (!JsonPrimitiveContract.dictionary_0.TryGetValue(this.NonNullableUnderlyingType, out readType))
			{
				return;
			}
			IL_0086:
			this.InternalReadType = readType;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0005AB88 File Offset: 0x00058D88
		static JsonPrimitiveContract()
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
				{
					goto IL_0121;
				}
				IL_0139:
				switch (num)
				{
				case 0:
					goto IL_0121;
				case 1:
					continue;
				case 2:
					break;
				case 3:
					return;
				default:
					goto IL_0121;
				}
				IL_0006:
				Dictionary<Type, ReadType> dictionary = new Dictionary<Type, ReadType>();
				Type typeFromHandle = typeof(byte[]);
				dictionary[typeFromHandle] = ReadType.ReadAsBytes;
				Type typeFromHandle2 = typeof(byte);
				dictionary[typeFromHandle2] = ReadType.const_1;
				Type typeFromHandle3 = typeof(short);
				dictionary[typeFromHandle3] = ReadType.const_1;
				Type typeFromHandle4 = typeof(int);
				dictionary[typeFromHandle4] = ReadType.const_1;
				Type typeFromHandle5 = typeof(decimal);
				dictionary[typeFromHandle5] = ReadType.ReadAsDecimal;
				Type typeFromHandle6 = typeof(bool);
				dictionary[typeFromHandle6] = ReadType.ReadAsBoolean;
				Type typeFromHandle7 = typeof(string);
				dictionary[typeFromHandle7] = ReadType.ReadAsString;
				Type typeFromHandle8 = typeof(DateTime);
				dictionary[typeFromHandle8] = ReadType.ReadAsDateTime;
				Type typeFromHandle9 = typeof(DateTimeOffset);
				dictionary[typeFromHandle9] = ReadType.ReadAsDateTimeOffset;
				Type typeFromHandle10 = typeof(float);
				dictionary[typeFromHandle10] = ReadType.ReadAsDouble;
				Type typeFromHandle11 = typeof(double);
				dictionary[typeFromHandle11] = ReadType.ReadAsDouble;
				Type typeFromHandle12 = typeof(long);
				dictionary[typeFromHandle12] = ReadType.const_2;
				JsonPrimitiveContract.dictionary_0 = dictionary;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					break;
				}
				goto IL_0139;
				IL_0121:
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
				{
					goto IL_0006;
				}
				goto IL_0139;
			}
		}

		// Token: 0x0400055F RID: 1375
		[CompilerGenerated]
		private PrimitiveTypeCode primitiveTypeCode_0;

		// Token: 0x04000560 RID: 1376
		private static readonly Dictionary<Type, ReadType> dictionary_0;
	}
}
