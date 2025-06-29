using System;

// Token: 0x02000239 RID: 569
internal sealed class Delegate41 : MulticastDelegate
{
	// Token: 0x06001878 RID: 6264
	public extern void Invoke(object object_0);

	// Token: 0x06001879 RID: 6265 RVA: 0x0000854F File Offset: 0x0000674F
	public static void smethod_0(object object_0, Delegate41 delegate41_1)
	{
		delegate41_1(object_0);
	}

	// Token: 0x0600187A RID: 6266
	public extern Delegate41(object object_0, IntPtr intptr_0);

	// Token: 0x0600187B RID: 6267 RVA: 0x0000855A File Offset: 0x0000675A
	static Delegate41()
	{
		Class15.smethod_14(typeof(Delegate41).TypeHandle);
	}

	// Token: 0x04000A09 RID: 2569
	internal static Delegate41 delegate41_0;
}
