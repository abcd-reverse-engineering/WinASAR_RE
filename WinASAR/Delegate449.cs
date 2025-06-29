using System;
using System.Numerics;

// Token: 0x020003D1 RID: 977
internal sealed class Delegate449 : MulticastDelegate
{
	// Token: 0x06001ED8 RID: 7896
	public extern float Invoke(BigInteger bigInteger_0);

	// Token: 0x06001ED9 RID: 7897 RVA: 0x0000ADF9 File Offset: 0x00008FF9
	public static float smethod_0(BigInteger bigInteger_0, Delegate449 delegate449_1)
	{
		return delegate449_1(bigInteger_0);
	}

	// Token: 0x06001EDA RID: 7898
	public extern Delegate449(object object_0, IntPtr intptr_0);

	// Token: 0x06001EDB RID: 7899 RVA: 0x0000AE04 File Offset: 0x00009004
	static Delegate449()
	{
		Class15.smethod_14(typeof(Delegate449).TypeHandle);
	}

	// Token: 0x04000BA1 RID: 2977
	internal static Delegate449 delegate449_0;
}
