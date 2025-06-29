using System;
using System.IO;

// Token: 0x02000291 RID: 657
internal sealed class Delegate129 : MulticastDelegate
{
	// Token: 0x060019D8 RID: 6616
	public extern DirectoryInfo Invoke(object object_0);

	// Token: 0x060019D9 RID: 6617 RVA: 0x00008DFD File Offset: 0x00006FFD
	public static DirectoryInfo smethod_0(object object_0, Delegate129 delegate129_1)
	{
		return delegate129_1(object_0);
	}

	// Token: 0x060019DA RID: 6618
	public extern Delegate129(object object_0, IntPtr intptr_0);

	// Token: 0x060019DB RID: 6619 RVA: 0x00008E08 File Offset: 0x00007008
	static Delegate129()
	{
		Class15.smethod_14(typeof(Delegate129).TypeHandle);
	}

	// Token: 0x04000A61 RID: 2657
	internal static Delegate129 delegate129_0;
}
