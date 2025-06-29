using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001C3 RID: 451
	internal class BsonRegex : BsonToken
	{
		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x00007059 File Offset: 0x00005259
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x0009A3C4 File Offset: 0x000985C4
		public BsonString Pattern
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
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

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x00007061 File Offset: 0x00005261
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x0009A3FC File Offset: 0x000985FC
		public BsonString Options
		{
			[CompilerGenerated]
			get
			{
				return this.bsonString_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bsonString_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
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

		// Token: 0x060013B4 RID: 5044 RVA: 0x0009A434 File Offset: 0x00098634
		public BsonRegex(string pattern, string options)
		{
			int num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
			{
				goto IL_0057;
			}
			IL_001A:
			this.Pattern = new BsonString(pattern, false);
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
			{
				goto IL_0057;
			}
			IL_0039:
			this.Options = new BsonString(options, false);
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
			{
				return;
			}
			IL_0057:
			switch (num)
			{
			case 0:
				goto IL_0039;
			case 1:
				break;
			case 2:
				goto IL_001A;
			default:
				goto IL_0039;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x00007069 File Offset: 0x00005269
		public override BsonType Type
		{
			get
			{
				return BsonType.Regex;
			}
		}

		// Token: 0x04000879 RID: 2169
		[CompilerGenerated]
		private BsonString bsonString_0;

		// Token: 0x0400087A RID: 2170
		[CompilerGenerated]
		private BsonString bsonString_1;
	}
}
