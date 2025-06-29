using System;

// Token: 0x0200034D RID: 845
internal sealed class Delegate317 : MulticastDelegate
{
	// Token: 0x06001CC8 RID: 7368
	public extern void Invoke(object object_0, char char_0);

	// Token: 0x06001CC9 RID: 7369 RVA: 0x0000A08D File Offset: 0x0000828D
	public static void smethod_0(object object_0, char char_0, Delegate317 delegate317_1)
	{
		delegate317_1(object_0, char_0);
	}

	// Token: 0x06001CCA RID: 7370
	public extern Delegate317(object object_0, IntPtr intptr_0);

	// Token: 0x06001CCB RID: 7371 RVA: 0x0000A09A File Offset: 0x0000829A
	static Delegate317()
	{
		Class15.smethod_14(typeof(Delegate317).TypeHandle);
	}

	// Token: 0x04000B1D RID: 2845
	internal static Delegate317 delegate317_0;
}
