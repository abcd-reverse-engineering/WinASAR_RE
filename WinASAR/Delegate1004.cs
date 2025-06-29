using System;
using System.Reflection;

// Token: 0x020005FC RID: 1532
internal sealed class Delegate1004 : MulticastDelegate
{
	// Token: 0x06002784 RID: 10116
	public extern MethodBase Invoke(object object_0, int int_0);

	// Token: 0x06002785 RID: 10117 RVA: 0x0000E534 File Offset: 0x0000C734
	public static MethodBase smethod_0(object object_0, int int_0, Delegate1004 delegate1004_1)
	{
		return delegate1004_1(object_0, int_0);
	}

	// Token: 0x06002786 RID: 10118
	public extern Delegate1004(object object_0, IntPtr intptr_0);

	// Token: 0x06002787 RID: 10119 RVA: 0x0000E541 File Offset: 0x0000C741
	static Delegate1004()
	{
		Class15.smethod_14(typeof(Delegate1004).TypeHandle);
	}

	// Token: 0x04000DCC RID: 3532
	internal static Delegate1004 delegate1004_0;
}
