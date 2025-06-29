using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001C4 RID: 452
	internal class BsonProperty
	{
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x0000706D File Offset: 0x0000526D
		// (set) Token: 0x060013BA RID: 5050 RVA: 0x0009A4B0 File Offset: 0x000986B0
		public BsonString Name
		{
			[CompilerGenerated]
			get
			{
				return this.bsonString_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bsonString_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
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

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x00007075 File Offset: 0x00005275
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x0009A4E8 File Offset: 0x000986E8
		public BsonToken Value
		{
			[CompilerGenerated]
			get
			{
				return this.bsonToken_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bsonToken_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
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

		// Token: 0x060013BD RID: 5053 RVA: 0x0004CCB0 File Offset: 0x0004AEB0
		public BsonProperty()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0400087C RID: 2172
		[CompilerGenerated]
		private BsonString bsonString_0;

		// Token: 0x0400087D RID: 2173
		[CompilerGenerated]
		private BsonToken bsonToken_0;
	}
}
