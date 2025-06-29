using System;

// Token: 0x020003C5 RID: 965
internal sealed class Delegate437 : MulticastDelegate
{
	// Token: 0x06001EA8 RID: 7848
	public extern int Invoke(object object_0, object object_1);

	// Token: 0x06001EA9 RID: 7849 RVA: 0x0000ACC1 File Offset: 0x00008EC1
	public static int smethod_0(object object_0, object object_1, Delegate437 delegate437_1)
	{
		return delegate437_1(object_0, object_1);
	}

	// Token: 0x06001EAA RID: 7850
	public extern Delegate437(object object_0, IntPtr intptr_0);

	// Token: 0x06001EAB RID: 7851 RVA: 0x0000ACCE File Offset: 0x00008ECE
	static Delegate437()
	{
		Class15.smethod_14(typeof(Delegate437).TypeHandle);
	}

	// Token: 0x04000B95 RID: 2965
	internal static Delegate437 delegate437_0;
}
