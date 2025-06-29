using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000B7 RID: 183
	[Nullable(0)]
	[NullableContext(1)]
	internal static class ILGeneratorExtensions
	{
		// Token: 0x0600076A RID: 1898 RVA: 0x0004BF14 File Offset: 0x0004A114
		public static void PushInstance(this ILGenerator generator, Type type)
		{
			for (;;)
			{
				IL_005F:
				generator.Emit(OpCodes.Ldarg_0);
				for (;;)
				{
					if (type.IsValueType())
					{
						goto IL_0003;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
					{
						goto Block_2;
					}
					IL_0020:
					switch (num)
					{
					case 1:
						return;
					case 2:
						continue;
					case 3:
						goto IL_005F;
					case 4:
						IL_0003:
						generator.Emit(OpCodes.Unbox, type);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
						{
							goto IL_0020;
						}
						break;
					case 5:
						return;
					}
					goto Block_1;
				}
			}
			Block_1:
			Block_2:
			generator.Emit(OpCodes.Castclass, type);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0004BFA0 File Offset: 0x0004A1A0
		public static void PushArrayInstance(this ILGenerator generator, int argsIndex, int arrayIndex)
		{
			for (;;)
			{
				IL_0057:
				generator.Emit(OpCodes.Ldarg, argsIndex);
				for (;;)
				{
					generator.Emit(OpCodes.Ldc_I4, arrayIndex);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
					{
						goto IL_0003;
					}
					IL_001F:
					switch (num)
					{
					case 1:
						return;
					case 2:
						continue;
					case 3:
						goto IL_0057;
					}
					IL_0003:
					generator.Emit(OpCodes.Ldelem_Ref);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
					{
						goto IL_001F;
					}
					return;
				}
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0004C014 File Offset: 0x0004A214
		public static void BoxIfNeeded(this ILGenerator generator, Type type)
		{
			for (;;)
			{
				if (type.IsValueType())
				{
					goto IL_0003;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					break;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				case 3:
					IL_0003:
					generator.Emit(OpCodes.Box, type);
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
					{
						goto IL_0020;
					}
					return;
				case 4:
					return;
				}
				break;
			}
			generator.Emit(OpCodes.Castclass, type);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0004C08C File Offset: 0x0004A28C
		public static void UnboxIfNeeded(this ILGenerator generator, Type type)
		{
			while (type.IsValueType())
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
				{
					goto IL_0015;
				}
				IL_0032:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				case 3:
					return;
				}
				IL_0015:
				generator.Emit(OpCodes.Unbox_Any, type);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
				{
					goto IL_0032;
				}
				return;
			}
			generator.Emit(OpCodes.Castclass, type);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0004C0FC File Offset: 0x0004A2FC
		public static void CallMethod(this ILGenerator generator, MethodInfo methodInfo)
		{
			for (;;)
			{
				if (!methodInfo.IsFinal)
				{
					goto IL_0003;
				}
				goto IL_005A;
				IL_003A:
				int num;
				switch (num)
				{
				case 1:
					return;
				case 2:
					goto IL_005A;
				case 3:
					goto IL_001D;
				case 4:
					IL_0003:
					if (!methodInfo.IsVirtual)
					{
						goto IL_005A;
					}
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
					{
						goto IL_001D;
					}
					goto IL_003A;
				case 5:
					continue;
				}
				break;
				IL_001D:
				generator.Emit(OpCodes.Callvirt, methodInfo);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
				{
					goto IL_003A;
				}
				return;
				IL_005A:
				generator.Emit(OpCodes.Call, methodInfo);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
				{
					break;
				}
				goto IL_003A;
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0004C194 File Offset: 0x0004A394
		public static void Return(this ILGenerator generator)
		{
			for (;;)
			{
				generator.Emit(OpCodes.Ret);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
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
}
