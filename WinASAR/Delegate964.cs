using System;

// Token: 0x020005D4 RID: 1492
internal sealed class Delegate964 : MulticastDelegate
{
	// Token: 0x060026E4 RID: 9956
	public extern byte[] Invoke(object object_0, string string_0);

	// Token: 0x060026E5 RID: 9957 RVA: 0x0000E10E File Offset: 0x0000C30E
	public static byte[] smethod_0(object object_0, string string_0, Delegate964 delegate964_1)
	{
		return delegate964_1(object_0, string_0);
	}

	// Token: 0x060026E6 RID: 9958
	public extern Delegate964(object object_0, IntPtr intptr_0);

	// Token: 0x060026E7 RID: 9959 RVA: 0x0000E11B File Offset: 0x0000C31B
	static Delegate964()
	{
		Class15.smethod_14(typeof(Delegate964).TypeHandle);
	}

	// Token: 0x04000DA4 RID: 3492
	internal static Delegate964 delegate964_0;
}
