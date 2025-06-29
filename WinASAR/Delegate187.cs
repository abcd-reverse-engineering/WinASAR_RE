using System;

// Token: 0x020002CB RID: 715
internal sealed class Delegate187 : MulticastDelegate
{
	// Token: 0x06001AC0 RID: 6848
	public extern void Invoke(object object_0);

	// Token: 0x06001AC1 RID: 6849 RVA: 0x000093AF File Offset: 0x000075AF
	public static void smethod_0(object object_0, Delegate187 delegate187_1)
	{
		delegate187_1(object_0);
	}

	// Token: 0x06001AC2 RID: 6850
	public extern Delegate187(object object_0, IntPtr intptr_0);

	// Token: 0x06001AC3 RID: 6851 RVA: 0x000093BA File Offset: 0x000075BA
	static Delegate187()
	{
		Class15.smethod_14(typeof(Delegate187).TypeHandle);
	}

	// Token: 0x04000A9B RID: 2715
	internal static Delegate187 delegate187_0;
}
