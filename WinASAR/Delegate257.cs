using System;

// Token: 0x02000311 RID: 785
internal sealed class Delegate257 : MulticastDelegate
{
	// Token: 0x06001BD8 RID: 7128
	public extern int Invoke(object object_0);

	// Token: 0x06001BD9 RID: 7129 RVA: 0x00009AA3 File Offset: 0x00007CA3
	public static int smethod_0(object object_0, Delegate257 delegate257_1)
	{
		return delegate257_1(object_0);
	}

	// Token: 0x06001BDA RID: 7130
	public extern Delegate257(object object_0, IntPtr intptr_0);

	// Token: 0x06001BDB RID: 7131 RVA: 0x00009AAE File Offset: 0x00007CAE
	static Delegate257()
	{
		Class15.smethod_14(typeof(Delegate257).TypeHandle);
	}

	// Token: 0x04000AE1 RID: 2785
	internal static Delegate257 delegate257_0;
}
