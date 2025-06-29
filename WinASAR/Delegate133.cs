using System;

// Token: 0x02000295 RID: 661
internal sealed class Delegate133 : MulticastDelegate
{
	// Token: 0x060019E8 RID: 6632
	public extern bool Invoke(object object_0);

	// Token: 0x060019E9 RID: 6633 RVA: 0x00008E63 File Offset: 0x00007063
	public static bool smethod_0(object object_0, Delegate133 delegate133_1)
	{
		return delegate133_1(object_0);
	}

	// Token: 0x060019EA RID: 6634
	public extern Delegate133(object object_0, IntPtr intptr_0);

	// Token: 0x060019EB RID: 6635 RVA: 0x00008E6E File Offset: 0x0000706E
	static Delegate133()
	{
		Class15.smethod_14(typeof(Delegate133).TypeHandle);
	}

	// Token: 0x04000A65 RID: 2661
	internal static Delegate133 delegate133_0;
}
