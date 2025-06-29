using System;

// Token: 0x0200024E RID: 590
internal sealed class Delegate62 : MulticastDelegate
{
	// Token: 0x060018CC RID: 6348
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x060018CD RID: 6349 RVA: 0x00008765 File Offset: 0x00006965
	public static void smethod_0(object object_0, bool bool_0, Delegate62 delegate62_1)
	{
		delegate62_1(object_0, bool_0);
	}

	// Token: 0x060018CE RID: 6350
	public extern Delegate62(object object_0, IntPtr intptr_0);

	// Token: 0x060018CF RID: 6351 RVA: 0x00008772 File Offset: 0x00006972
	static Delegate62()
	{
		Class15.smethod_14(typeof(Delegate62).TypeHandle);
	}

	// Token: 0x04000A1E RID: 2590
	internal static Delegate62 delegate62_0;
}
