using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000191 RID: 401
	public abstract class DateTimeConverterBase : JsonConverter
	{
		// Token: 0x060011CA RID: 4554 RVA: 0x0008DB58 File Offset: 0x0008BD58
		[NullableContext(1)]
		public override bool CanConvert(Type objectType)
		{
			IL_008E:
			while (!(objectType == typeof(DateTime)))
			{
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
				{
					for (;;)
					{
						IL_006A:
						switch (num)
						{
						case 1:
							goto IL_00AC;
						case 2:
							while (!(objectType == typeof(DateTime?)))
							{
								num = 5;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
								{
									goto IL_006A;
								}
							}
							return true;
						case 3:
							goto IL_008E;
						case 5:
							if (!(objectType == typeof(DateTimeOffset)))
							{
								goto IL_00AC;
							}
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
							{
								continue;
							}
							break;
						case 6:
							return true;
						}
						break;
					}
					return true;
				}
				IL_00AC:
				if (!(objectType == typeof(DateTimeOffset?)))
				{
					return false;
				}
				return true;
			}
			return true;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0008DC28 File Offset: 0x0008BE28
		protected DateTimeConverterBase()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
