using System;

// Token: 0x02000508 RID: 1288
internal sealed class Delegate760 : MulticastDelegate
{
	// Token: 0x060023B4 RID: 9140
	public extern string Invoke(object object_0, string string_0);

	// Token: 0x060023B5 RID: 9141 RVA: 0x0000CCEA File Offset: 0x0000AEEA
	public static string smethod_0(object object_0, string string_0, Delegate760 delegate760_1)
	{
		return delegate760_1(object_0, string_0);
	}

	// Token: 0x060023B6 RID: 9142
	public extern Delegate760(object object_0, IntPtr intptr_0);

	// Token: 0x060023B7 RID: 9143 RVA: 0x0000CCF7 File Offset: 0x0000AEF7
	static Delegate760()
	{
		Class15.smethod_14(typeof(Delegate760).TypeHandle);
	}

	// Token: 0x04000CD8 RID: 3288
	internal static Delegate760 delegate760_0;
}
