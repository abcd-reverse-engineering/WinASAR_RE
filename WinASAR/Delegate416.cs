using System;

// Token: 0x020003B0 RID: 944
internal sealed class Delegate416 : MulticastDelegate
{
	// Token: 0x06001E54 RID: 7764
	public extern bool Invoke(double double_0);

	// Token: 0x06001E55 RID: 7765 RVA: 0x0000AAAB File Offset: 0x00008CAB
	public static bool smethod_0(double double_0, Delegate416 delegate416_1)
	{
		return delegate416_1(double_0);
	}

	// Token: 0x06001E56 RID: 7766
	public extern Delegate416(object object_0, IntPtr intptr_0);

	// Token: 0x06001E57 RID: 7767 RVA: 0x0000AAB6 File Offset: 0x00008CB6
	static Delegate416()
	{
		Class15.smethod_14(typeof(Delegate416).TypeHandle);
	}

	// Token: 0x04000B80 RID: 2944
	internal static Delegate416 delegate416_0;
}
