using System;

// Token: 0x0200051B RID: 1307
internal sealed class Delegate779 : MulticastDelegate
{
	// Token: 0x06002400 RID: 9216
	public extern int Invoke(object object_0);

	// Token: 0x06002401 RID: 9217 RVA: 0x0000CECE File Offset: 0x0000B0CE
	public static int smethod_0(object object_0, Delegate779 delegate779_1)
	{
		return delegate779_1(object_0);
	}

	// Token: 0x06002402 RID: 9218
	public extern Delegate779(object object_0, IntPtr intptr_0);

	// Token: 0x06002403 RID: 9219 RVA: 0x0000CED9 File Offset: 0x0000B0D9
	static Delegate779()
	{
		Class15.smethod_14(typeof(Delegate779).TypeHandle);
	}

	// Token: 0x04000CEB RID: 3307
	internal static Delegate779 delegate779_0;
}
