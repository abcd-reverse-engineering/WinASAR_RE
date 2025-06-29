using System;

// Token: 0x0200025F RID: 607
internal sealed class Delegate79 : MulticastDelegate
{
	// Token: 0x06001910 RID: 6416
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001911 RID: 6417 RVA: 0x00008917 File Offset: 0x00006B17
	public static void smethod_0(object object_0, bool bool_0, Delegate79 delegate79_1)
	{
		delegate79_1(object_0, bool_0);
	}

	// Token: 0x06001912 RID: 6418
	public extern Delegate79(object object_0, IntPtr intptr_0);

	// Token: 0x06001913 RID: 6419 RVA: 0x00008924 File Offset: 0x00006B24
	static Delegate79()
	{
		Class15.smethod_14(typeof(Delegate79).TypeHandle);
	}

	// Token: 0x04000A2F RID: 2607
	internal static Delegate79 delegate79_0;
}
