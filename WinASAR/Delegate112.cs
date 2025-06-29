using System;

// Token: 0x02000280 RID: 640
internal sealed class Delegate112 : MulticastDelegate
{
	// Token: 0x06001994 RID: 6548
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001995 RID: 6549 RVA: 0x00008C59 File Offset: 0x00006E59
	public static void smethod_0(object object_0, bool bool_0, Delegate112 delegate112_1)
	{
		delegate112_1(object_0, bool_0);
	}

	// Token: 0x06001996 RID: 6550
	public extern Delegate112(object object_0, IntPtr intptr_0);

	// Token: 0x06001997 RID: 6551 RVA: 0x00008C66 File Offset: 0x00006E66
	static Delegate112()
	{
		Class15.smethod_14(typeof(Delegate112).TypeHandle);
	}

	// Token: 0x04000A50 RID: 2640
	internal static Delegate112 delegate112_0;
}
