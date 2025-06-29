using System;
using System.Reflection;

// Token: 0x020004E7 RID: 1255
internal sealed class Delegate727 : MulticastDelegate
{
	// Token: 0x06002330 RID: 9008
	public extern Assembly[] Invoke(object object_0);

	// Token: 0x06002331 RID: 9009 RVA: 0x0000C9B2 File Offset: 0x0000ABB2
	public static Assembly[] smethod_0(object object_0, Delegate727 delegate727_1)
	{
		return delegate727_1(object_0);
	}

	// Token: 0x06002332 RID: 9010
	public extern Delegate727(object object_0, IntPtr intptr_0);

	// Token: 0x06002333 RID: 9011 RVA: 0x0000C9BD File Offset: 0x0000ABBD
	static Delegate727()
	{
		Class15.smethod_14(typeof(Delegate727).TypeHandle);
	}

	// Token: 0x04000CB7 RID: 3255
	internal static Delegate727 delegate727_0;
}
