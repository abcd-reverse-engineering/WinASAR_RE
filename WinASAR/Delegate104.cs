using System;

// Token: 0x02000278 RID: 632
internal sealed class Delegate104 : MulticastDelegate
{
	// Token: 0x06001974 RID: 6516
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001975 RID: 6517 RVA: 0x00008B91 File Offset: 0x00006D91
	public static void smethod_0(object object_0, bool bool_0, Delegate104 delegate104_1)
	{
		delegate104_1(object_0, bool_0);
	}

	// Token: 0x06001976 RID: 6518
	public extern Delegate104(object object_0, IntPtr intptr_0);

	// Token: 0x06001977 RID: 6519 RVA: 0x00008B9E File Offset: 0x00006D9E
	static Delegate104()
	{
		Class15.smethod_14(typeof(Delegate104).TypeHandle);
	}

	// Token: 0x04000A48 RID: 2632
	internal static Delegate104 delegate104_0;
}
