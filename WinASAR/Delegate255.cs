using System;

// Token: 0x0200030F RID: 783
internal sealed class Delegate255 : MulticastDelegate
{
	// Token: 0x06001BD0 RID: 7120
	public extern void Invoke(string string_0);

	// Token: 0x06001BD1 RID: 7121 RVA: 0x00009A75 File Offset: 0x00007C75
	public static void smethod_0(string string_0, Delegate255 delegate255_1)
	{
		delegate255_1(string_0);
	}

	// Token: 0x06001BD2 RID: 7122
	public extern Delegate255(object object_0, IntPtr intptr_0);

	// Token: 0x06001BD3 RID: 7123 RVA: 0x00009A80 File Offset: 0x00007C80
	static Delegate255()
	{
		Class15.smethod_14(typeof(Delegate255).TypeHandle);
	}

	// Token: 0x04000ADF RID: 2783
	internal static Delegate255 delegate255_0;
}
