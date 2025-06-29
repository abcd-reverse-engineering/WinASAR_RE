using System;
using System.Text.RegularExpressions;

// Token: 0x0200055E RID: 1374
internal sealed class Delegate846 : MulticastDelegate
{
	// Token: 0x0600250C RID: 9484
	public extern RegexOptions Invoke(object object_0);

	// Token: 0x0600250D RID: 9485 RVA: 0x0000D57C File Offset: 0x0000B77C
	public static RegexOptions smethod_0(object object_0, Delegate846 delegate846_1)
	{
		return delegate846_1(object_0);
	}

	// Token: 0x0600250E RID: 9486
	public extern Delegate846(object object_0, IntPtr intptr_0);

	// Token: 0x0600250F RID: 9487 RVA: 0x0000D587 File Offset: 0x0000B787
	static Delegate846()
	{
		Class15.smethod_14(typeof(Delegate846).TypeHandle);
	}

	// Token: 0x04000D2E RID: 3374
	internal static Delegate846 delegate846_0;
}
