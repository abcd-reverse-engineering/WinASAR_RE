using System;

// Token: 0x0200045D RID: 1117
internal sealed class Delegate589 : MulticastDelegate
{
	// Token: 0x06002108 RID: 8456
	public extern string Invoke(object object_0);

	// Token: 0x06002109 RID: 8457 RVA: 0x0000BC0F File Offset: 0x00009E0F
	public static string smethod_0(object object_0, Delegate589 delegate589_1)
	{
		return delegate589_1(object_0);
	}

	// Token: 0x0600210A RID: 8458
	public extern Delegate589(object object_0, IntPtr intptr_0);

	// Token: 0x0600210B RID: 8459 RVA: 0x0000BC1A File Offset: 0x00009E1A
	static Delegate589()
	{
		Class15.smethod_14(typeof(Delegate589).TypeHandle);
	}

	// Token: 0x04000C2D RID: 3117
	internal static Delegate589 delegate589_0;
}
