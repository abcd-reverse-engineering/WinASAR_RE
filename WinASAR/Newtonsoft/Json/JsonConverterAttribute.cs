using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	// Token: 0x02000055 RID: 85
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter, AllowMultiple = false)]
	public sealed class JsonConverterAttribute : Attribute
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00002C3E File Offset: 0x00000E3E
		public Type ConverterType
		{
			get
			{
				return this.type_0;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00002C46 File Offset: 0x00000E46
		[Nullable(new byte[] { 2, 1 })]
		public object[] ConverterParameters
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00028574 File Offset: 0x00026774
		public JsonConverterAttribute(Type converterType)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
			{
				goto IL_004F;
			}
			IL_001A:
			if (converterType == null)
			{
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
				{
					goto IL_0069;
				}
			}
			else
			{
				this.type_0 = converterType;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
				{
					return;
				}
			}
			IL_004F:
			switch (num)
			{
			case 0:
				goto IL_001A;
			case 1:
				return;
			case 2:
				break;
			default:
				goto IL_001A;
			}
			IL_0069:
			throw new ArgumentNullException(Class15.smethod_17(1243259688 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95));
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00028608 File Offset: 0x00026808
		public JsonConverterAttribute(Type converterType, params object[] converterParameters)
			: this(converterType)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
			{
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.ConverterParameters = converterParameters;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
						{
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x040001EA RID: 490
		private readonly Type type_0;

		// Token: 0x040001EB RID: 491
		[CompilerGenerated]
		[Nullable(new byte[] { 2, 1 })]
		private readonly object[] object_0;
	}
}
