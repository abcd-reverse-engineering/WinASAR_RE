using System;

// Token: 0x020003E2 RID: 994
internal sealed class Delegate466 : MulticastDelegate
{
	// Token: 0x06001F1C RID: 7964
	public extern bool Invoke(decimal decimal_0, decimal decimal_1);

	// Token: 0x06001F1D RID: 7965 RVA: 0x0000AFB7 File Offset: 0x000091B7
	public static bool smethod_0(decimal decimal_0, decimal decimal_1, Delegate466 delegate466_1)
	{
		return delegate466_1(decimal_0, decimal_1);
	}

	// Token: 0x06001F1E RID: 7966
	public extern Delegate466(object object_0, IntPtr intptr_0);

	// Token: 0x06001F1F RID: 7967 RVA: 0x0000AFC4 File Offset: 0x000091C4
	static Delegate466()
	{
		Class15.smethod_14(typeof(Delegate466).TypeHandle);
	}

	// Token: 0x04000BB2 RID: 2994
	internal static Delegate466 delegate466_0;
}
