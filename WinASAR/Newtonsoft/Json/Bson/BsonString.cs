using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001C1 RID: 449
	internal class BsonString : BsonValue
	{
		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x00007041 File Offset: 0x00005241
		// (set) Token: 0x060013A4 RID: 5028 RVA: 0x0009A2AC File Offset: 0x000984AC
		public int ByteCount
		{
			[CompilerGenerated]
			get
			{
				return this.int_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.int_1 = value;
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
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x00007049 File Offset: 0x00005249
		public bool IncludeLength { get; }

		// Token: 0x060013A6 RID: 5030 RVA: 0x0009A2E4 File Offset: 0x000984E4
		public BsonString(object value, bool includeLength)
			: base(value, BsonType.String)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
			{
				goto IL_0034;
			}
			IL_001C:
			this.IncludeLength = includeLength;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
			{
				return;
			}
			IL_0034:
			switch (num)
			{
			case 1:
				goto IL_001C;
			}
		}

		// Token: 0x04000874 RID: 2164
		[CompilerGenerated]
		private int int_1;

		// Token: 0x04000875 RID: 2165
		[CompilerGenerated]
		private readonly bool bool_0;
	}
}
