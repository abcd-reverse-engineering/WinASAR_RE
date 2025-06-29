using System;

// Token: 0x020002E6 RID: 742
internal sealed class Delegate214 : MulticastDelegate
{
	// Token: 0x06001B2C RID: 6956
	public extern void Invoke(int int_0);

	// Token: 0x06001B2D RID: 6957 RVA: 0x00009659 File Offset: 0x00007859
	public static void smethod_0(int int_0, Delegate214 delegate214_1)
	{
		delegate214_1(int_0);
	}

	// Token: 0x06001B2E RID: 6958
	public extern Delegate214(object object_0, IntPtr intptr_0);

	// Token: 0x06001B2F RID: 6959 RVA: 0x00009664 File Offset: 0x00007864
	static Delegate214()
	{
		Class15.smethod_14(typeof(Delegate214).TypeHandle);
	}

	// Token: 0x04000AB6 RID: 2742
	internal static Delegate214 delegate214_0;
}
