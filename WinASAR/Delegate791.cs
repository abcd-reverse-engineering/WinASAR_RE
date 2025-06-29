using System;
using System.Numerics;

// Token: 0x02000527 RID: 1319
internal sealed class Delegate791 : MulticastDelegate
{
	// Token: 0x06002430 RID: 9264
	public extern uint Invoke(BigInteger bigInteger_0);

	// Token: 0x06002431 RID: 9265 RVA: 0x0000CFFA File Offset: 0x0000B1FA
	public static uint smethod_0(BigInteger bigInteger_0, Delegate791 delegate791_1)
	{
		return delegate791_1(bigInteger_0);
	}

	// Token: 0x06002432 RID: 9266
	public extern Delegate791(object object_0, IntPtr intptr_0);

	// Token: 0x06002433 RID: 9267 RVA: 0x0000D005 File Offset: 0x0000B205
	static Delegate791()
	{
		Class15.smethod_14(typeof(Delegate791).TypeHandle);
	}

	// Token: 0x04000CF7 RID: 3319
	internal static Delegate791 delegate791_0;
}
