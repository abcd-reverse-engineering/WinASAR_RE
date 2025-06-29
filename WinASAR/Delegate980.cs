using System;

// Token: 0x020005E4 RID: 1508
internal sealed class Delegate980 : MulticastDelegate
{
	// Token: 0x06002724 RID: 10020
	public extern bool Invoke(object object_0);

	// Token: 0x06002725 RID: 10021 RVA: 0x0000E2AC File Offset: 0x0000C4AC
	public static bool smethod_0(object object_0, Delegate980 delegate980_1)
	{
		return delegate980_1(object_0);
	}

	// Token: 0x06002726 RID: 10022
	public extern Delegate980(object object_0, IntPtr intptr_0);

	// Token: 0x06002727 RID: 10023 RVA: 0x0000E2B7 File Offset: 0x0000C4B7
	static Delegate980()
	{
		Class15.smethod_14(typeof(Delegate980).TypeHandle);
	}

	// Token: 0x04000DB4 RID: 3508
	internal static Delegate980 delegate980_0;
}
