using System;
using System.Data;

// Token: 0x02000552 RID: 1362
internal sealed class Delegate834 : MulticastDelegate
{
	// Token: 0x060024DC RID: 9436
	public extern DataColumn Invoke(object object_0, string string_0);

	// Token: 0x060024DD RID: 9437 RVA: 0x0000D43E File Offset: 0x0000B63E
	public static DataColumn smethod_0(object object_0, string string_0, Delegate834 delegate834_1)
	{
		return delegate834_1(object_0, string_0);
	}

	// Token: 0x060024DE RID: 9438
	public extern Delegate834(object object_0, IntPtr intptr_0);

	// Token: 0x060024DF RID: 9439 RVA: 0x0000D44B File Offset: 0x0000B64B
	static Delegate834()
	{
		Class15.smethod_14(typeof(Delegate834).TypeHandle);
	}

	// Token: 0x04000D22 RID: 3362
	internal static Delegate834 delegate834_0;
}
