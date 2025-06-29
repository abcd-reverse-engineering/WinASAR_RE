using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x0200017E RID: 382
	[Nullable(0)]
	[NullableContext(2)]
	internal abstract class PathFilter
	{
		// Token: 0x06001138 RID: 4408
		[NullableContext(1)]
		public abstract IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings);

		// Token: 0x06001139 RID: 4409 RVA: 0x00089AB0 File Offset: 0x00087CB0
		protected static JToken GetTokenIndex([Nullable(1)] JToken t, JsonSelectSettings settings, int index)
		{
			JArray jarray;
			JConstructor jconstructor;
			for (;;)
			{
				IL_0105:
				jarray = t as JArray;
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
				{
					goto IL_0069;
				}
				for (;;)
				{
					IL_00B9:
					switch (num)
					{
					case 1:
						goto IL_0087;
					case 2:
						goto IL_0189;
					case 3:
						goto IL_0128;
					case 4:
						goto IL_0069;
					case 5:
						goto IL_0105;
					case 6:
						goto IL_002A;
					case 7:
						goto IL_0186;
					case 8:
						goto IL_01BC;
					case 9:
						goto IL_0191;
					case 10:
						goto IL_01BF;
					case 11:
						if (!settings.ErrorWhenNoMatch)
						{
							goto IL_01F5;
						}
						num = 15;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
						{
							goto Block_6;
						}
						continue;
					case 12:
						goto IL_0137;
					case 13:
						goto IL_0178;
					case 14:
						goto IL_0140;
					case 15:
						goto IL_0142;
					case 16:
						goto IL_0006;
					}
					goto Block_11;
				}
				IL_0006:
				if (jarray.Count <= index)
				{
					goto IL_002A;
				}
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
				{
					break;
				}
				goto IL_00B9;
				IL_0069:
				if (jarray != null)
				{
					goto IL_0006;
				}
				jconstructor = t as JConstructor;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
				{
					goto IL_0087;
				}
				goto IL_00B9;
				IL_002A:
				if (settings == null)
				{
					goto IL_01F5;
				}
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
				{
					goto Block_4;
				}
				goto IL_00B9;
				IL_0087:
				if (jconstructor != null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
					{
						break;
					}
					goto IL_00B9;
				}
				else
				{
					if (settings == null)
					{
						goto IL_0140;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
					{
						goto IL_00B9;
					}
					goto IL_0127;
				}
			}
			goto IL_016E;
			Block_4:
			goto IL_01BF;
			Block_6:
			goto IL_0137;
			Block_11:
			goto IL_016E;
			IL_0127:
			IL_0128:
			if (!settings.ErrorWhenNoMatch)
			{
				goto IL_0140;
			}
			goto IL_01BF;
			IL_0137:
			return jarray[index];
			IL_0140:
			return null;
			IL_0142:
			throw new JsonException(Class15.smethod_17(635792341 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2).FormatWith(CultureInfo.InvariantCulture, index));
			IL_016E:
			if (jconstructor.Count <= index)
			{
				goto IL_0186;
			}
			IL_0178:
			return jconstructor[index];
			IL_0186:
			if (settings == null)
			{
				goto IL_01BC;
			}
			IL_0189:
			if (!settings.ErrorWhenNoMatch)
			{
				goto IL_01BC;
			}
			IL_0191:
			throw new JsonException(Class15.smethod_17(635791979 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2).FormatWith(CultureInfo.InvariantCulture, index));
			IL_01BC:
			return null;
			IL_01BF:
			throw new JsonException(Class15.smethod_17(2021162690 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8).FormatWith(CultureInfo.InvariantCulture, index, t.GetType().Name));
			IL_01F5:
			return null;
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00089CB4 File Offset: 0x00087EB4
		protected static JToken GetNextScanValue([Nullable(1)] JToken originalParent, JToken container, JToken value)
		{
			for (;;)
			{
				IL_00CE:
				if (container != null)
				{
					goto IL_009E;
				}
				for (;;)
				{
					IL_00C7:
					if (value != null)
					{
						goto IL_0097;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
					{
						goto IL_0091;
					}
					IL_0047:
					switch (num)
					{
					case 0:
					case 13:
						goto IL_0091;
					case 1:
						IL_0097:
						if (value != originalParent)
						{
							goto IL_0025;
						}
						goto IL_0091;
					case 2:
						goto IL_0025;
					case 3:
						break;
					case 4:
						goto IL_00D7;
					case 5:
						goto IL_009E;
					case 6:
						goto IL_00CE;
					case 7:
					case 8:
						continue;
					case 9:
						goto IL_00E1;
					case 10:
					case 12:
						return value;
					case 11:
						goto IL_00A9;
					default:
						goto IL_0091;
					}
					IL_0087:
					if (value == originalParent)
					{
						goto Block_4;
					}
					value = value.Next;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
					{
						goto Block_1;
					}
					goto IL_0047;
					IL_00A9:
					value = value.Parent;
					continue;
					IL_0025:
					if (value == value.Parent.Last)
					{
						goto IL_00A9;
					}
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
					{
						goto IL_0047;
					}
					break;
					IL_0091:
					if (value != null)
					{
						goto IL_0087;
					}
					goto IL_00E1;
				}
				continue;
				IL_009E:
				if (!container.HasValues)
				{
					goto IL_00C7;
				}
				goto IL_00D7;
			}
			Block_1:
			return value;
			Block_4:
			goto IL_00E1;
			IL_00D7:
			value = container.First;
			return value;
			IL_00E1:
			return null;
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00089DA4 File Offset: 0x00087FA4
		protected PathFilter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
