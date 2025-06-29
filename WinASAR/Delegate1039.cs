using System;

// Token: 0x0200061F RID: 1567
internal sealed class Delegate1039 : MulticastDelegate
{
	// Token: 0x06002810 RID: 10256
	public extern bool Invoke(IntPtr intptr_0, IntPtr intptr_1);

	// Token: 0x06002811 RID: 10257 RVA: 0x0000E89A File Offset: 0x0000CA9A
	public static bool smethod_0(IntPtr intptr_0, IntPtr intptr_1, Delegate1039 delegate1039_0)
	{
		return delegate1039_0(intptr_0, intptr_1);
	}

	// Token: 0x06002812 RID: 10258
	public extern Delegate1039(object object_0, IntPtr intptr_0);

	// Token: 0x06002813 RID: 10259 RVA: 0x0000E8A7 File Offset: 0x0000CAA7
	static Delegate1039()
	{
		Class15.smethod_14(typeof(Delegate1039).TypeHandle);
	}

	// Token: 0x04000DEF RID: 3567
	internal static Delegate1039 nLqWlDeUiu4;
}
