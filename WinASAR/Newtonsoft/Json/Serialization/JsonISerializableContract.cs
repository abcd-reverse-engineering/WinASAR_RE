using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010C RID: 268
	public class JsonISerializableContract : JsonContainerContract
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00004D7A File Offset: 0x00002F7A
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x00004D82 File Offset: 0x00002F82
		[Nullable(new byte[] { 2, 1 })]
		public ObjectConstructor<object> ObjectConstructor_0
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get;
			[param: Nullable(new byte[] { 2, 1 })]
			set;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0005A52C File Offset: 0x0005872C
		[NullableContext(1)]
		public JsonISerializableContract(Type underlyingType)
			: base(underlyingType)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
			{
				goto IL_0033;
			}
			IL_001B:
			this.ContractType = JsonContractType.Serializable;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
			{
				return;
			}
			IL_0033:
			switch (num)
			{
			case 1:
				goto IL_001B;
			}
		}

		// Token: 0x0400054D RID: 1357
		[CompilerGenerated]
		[Nullable(new byte[] { 2, 1 })]
		private ObjectConstructor<object> objectConstructor_0;
	}
}
