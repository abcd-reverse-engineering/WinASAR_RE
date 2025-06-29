using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001BF RID: 447
	internal class BsonValue : BsonToken
	{
		// Token: 0x06001399 RID: 5017 RVA: 0x0009A178 File Offset: 0x00098378
		public BsonValue(object value, BsonType type)
		{
			for (;;)
			{
				this.object_0 = value;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
				{
					goto IL_000A;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					return;
				case 2:
					continue;
				}
				IL_000A:
				this.bsonType_0 = type;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
				{
					goto IL_0022;
				}
				break;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00007031 File Offset: 0x00005231
		public object Value
		{
			get
			{
				return this.object_0;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x00007039 File Offset: 0x00005239
		public override BsonType Type
		{
			get
			{
				return this.bsonType_0;
			}
		}

		// Token: 0x0400086E RID: 2158
		private readonly object object_0;

		// Token: 0x0400086F RID: 2159
		private readonly BsonType bsonType_0;
	}
}
