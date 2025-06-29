using System;

// Token: 0x020005C8 RID: 1480
internal sealed class Delegate952 : MulticastDelegate
{
	// Token: 0x060026B4 RID: 9908
	public extern void Invoke(object object_0);

	// Token: 0x060026B5 RID: 9909 RVA: 0x0000DFCE File Offset: 0x0000C1CE
	public static void smethod_0(object object_0, Delegate952 delegate952_1)
	{
		delegate952_1(object_0);
	}

	// Token: 0x060026B6 RID: 9910
	public extern Delegate952(object object_0, IntPtr intptr_0);

	// Token: 0x060026B7 RID: 9911 RVA: 0x0000DFD9 File Offset: 0x0000C1D9
	static Delegate952()
	{
		Class15.smethod_14(typeof(Delegate952).TypeHandle);
	}

	// Token: 0x04000D98 RID: 3480
	internal static Delegate952 delegate952_0;
}
