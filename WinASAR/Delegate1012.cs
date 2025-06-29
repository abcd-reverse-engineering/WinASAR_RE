using System;

// Token: 0x02000604 RID: 1540
internal sealed class Delegate1012 : MulticastDelegate
{
	// Token: 0x060027A4 RID: 10148
	public extern string Invoke(object object_0, byte[] byte_0);

	// Token: 0x060027A5 RID: 10149 RVA: 0x0000E5FC File Offset: 0x0000C7FC
	public static string smethod_0(object object_0, byte[] byte_0, Delegate1012 delegate1012_1)
	{
		return delegate1012_1(object_0, byte_0);
	}

	// Token: 0x060027A6 RID: 10150
	public extern Delegate1012(object object_0, IntPtr intptr_0);

	// Token: 0x060027A7 RID: 10151 RVA: 0x0000E609 File Offset: 0x0000C809
	static Delegate1012()
	{
		Class15.smethod_14(typeof(Delegate1012).TypeHandle);
	}

	// Token: 0x04000DD4 RID: 3540
	internal static Delegate1012 delegate1012_0;
}
