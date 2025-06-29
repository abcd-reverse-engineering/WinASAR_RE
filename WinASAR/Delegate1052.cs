using System;
using System.Text;

// Token: 0x0200062C RID: 1580
internal sealed class Delegate1052 : MulticastDelegate
{
	// Token: 0x06002844 RID: 10308
	public extern StringBuilder Invoke(object object_0, object object_1);

	// Token: 0x06002845 RID: 10309 RVA: 0x0000E9E4 File Offset: 0x0000CBE4
	public static StringBuilder smethod_0(object object_0, object object_1, Delegate1052 delegate1052_1)
	{
		return delegate1052_1(object_0, object_1);
	}

	// Token: 0x06002846 RID: 10310
	public extern Delegate1052(object object_0, IntPtr intptr_0);

	// Token: 0x06002847 RID: 10311 RVA: 0x0000E9F1 File Offset: 0x0000CBF1
	static Delegate1052()
	{
		Class15.smethod_14(typeof(Delegate1052).TypeHandle);
	}

	// Token: 0x04000DFC RID: 3580
	internal static Delegate1052 delegate1052_0;
}
