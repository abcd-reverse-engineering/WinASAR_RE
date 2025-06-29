using System;

// Token: 0x02000413 RID: 1043
internal sealed class Delegate515 : MulticastDelegate
{
	// Token: 0x06001FE0 RID: 8160
	public extern bool Invoke(object object_0);

	// Token: 0x06001FE1 RID: 8161 RVA: 0x0000B499 File Offset: 0x00009699
	public static bool smethod_0(object object_0, Delegate515 delegate515_1)
	{
		return delegate515_1(object_0);
	}

	// Token: 0x06001FE2 RID: 8162
	public extern Delegate515(object object_0, IntPtr intptr_0);

	// Token: 0x06001FE3 RID: 8163 RVA: 0x0000B4A4 File Offset: 0x000096A4
	static Delegate515()
	{
		Class15.smethod_14(typeof(Delegate515).TypeHandle);
	}

	// Token: 0x04000BE3 RID: 3043
	internal static Delegate515 delegate515_0;
}
