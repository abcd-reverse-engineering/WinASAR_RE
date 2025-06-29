using System;

// Token: 0x02000506 RID: 1286
internal sealed class Delegate758 : MulticastDelegate
{
	// Token: 0x060023AC RID: 9132
	public extern bool Invoke(object object_0);

	// Token: 0x060023AD RID: 9133 RVA: 0x0000CCBC File Offset: 0x0000AEBC
	public static bool smethod_0(object object_0, Delegate758 delegate758_1)
	{
		return delegate758_1(object_0);
	}

	// Token: 0x060023AE RID: 9134
	public extern Delegate758(object object_0, IntPtr intptr_0);

	// Token: 0x060023AF RID: 9135 RVA: 0x0000CCC7 File Offset: 0x0000AEC7
	static Delegate758()
	{
		Class15.smethod_14(typeof(Delegate758).TypeHandle);
	}

	// Token: 0x04000CD6 RID: 3286
	internal static Delegate758 delegate758_0;
}
