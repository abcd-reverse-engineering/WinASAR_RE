using System;
using System.IO;

// Token: 0x020005FF RID: 1535
internal sealed class Delegate1007 : MulticastDelegate
{
	// Token: 0x06002790 RID: 10128
	public extern Stream Invoke(object object_0);

	// Token: 0x06002791 RID: 10129 RVA: 0x0000E580 File Offset: 0x0000C780
	public static Stream smethod_0(object object_0, Delegate1007 delegate1007_1)
	{
		return delegate1007_1(object_0);
	}

	// Token: 0x06002792 RID: 10130
	public extern Delegate1007(object object_0, IntPtr intptr_0);

	// Token: 0x06002793 RID: 10131 RVA: 0x0000E58B File Offset: 0x0000C78B
	static Delegate1007()
	{
		Class15.smethod_14(typeof(Delegate1007).TypeHandle);
	}

	// Token: 0x04000DCF RID: 3535
	internal static Delegate1007 delegate1007_0;
}
