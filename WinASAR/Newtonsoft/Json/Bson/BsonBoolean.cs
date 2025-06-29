using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001C0 RID: 448
	internal class BsonBoolean : BsonValue
	{
		// Token: 0x0600139F RID: 5023 RVA: 0x0009A1D8 File Offset: 0x000983D8
		private BsonBoolean(bool value)
			: base(value, BsonType.Boolean)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0009A214 File Offset: 0x00098414
		static BsonBoolean()
		{
			for (;;)
			{
				IL_0070:
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
				{
					goto IL_0003;
				}
				goto IL_0054;
				do
				{
					IL_0016:
					BsonBoolean.False = new BsonBoolean(false);
					num = 1;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0);
				for (;;)
				{
					IL_0054:
					switch (num)
					{
					case 1:
						for (;;)
						{
							BsonBoolean.True = new BsonBoolean(true);
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
							{
								goto IL_0054;
							}
						}
						break;
					case 2:
						return;
					case 3:
						goto IL_0003;
					case 4:
						goto IL_0070;
					}
					break;
				}
				goto IL_0016;
				IL_0003:
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
				{
					goto IL_0016;
				}
				goto IL_0054;
			}
		}

		// Token: 0x04000871 RID: 2161
		public static readonly BsonBoolean False;

		// Token: 0x04000872 RID: 2162
		public static readonly BsonBoolean True;
	}
}
