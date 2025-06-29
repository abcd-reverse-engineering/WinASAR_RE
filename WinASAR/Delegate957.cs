using System;

// Token: 0x020005CD RID: 1485
internal sealed class Delegate957 : MulticastDelegate
{
	// Token: 0x060026C8 RID: 9928
	public extern string Invoke(ref ulong ulong_0, IFormatProvider iformatProvider_0);

	// Token: 0x060026C9 RID: 9929 RVA: 0x0000E04C File Offset: 0x0000C24C
	public static string smethod_0(ref ulong ulong_0, IFormatProvider iformatProvider_0, Delegate957 delegate957_1)
	{
		return delegate957_1(ref ulong_0, iformatProvider_0);
	}

	// Token: 0x060026CA RID: 9930
	public extern Delegate957(object object_0, IntPtr intptr_0);

	// Token: 0x060026CB RID: 9931 RVA: 0x0000E059 File Offset: 0x0000C259
	static Delegate957()
	{
		Class15.smethod_14(typeof(Delegate957).TypeHandle);
	}

	// Token: 0x04000D9D RID: 3485
	internal static Delegate957 delegate957_0;
}
