using System;

// Token: 0x02000610 RID: 1552
internal sealed class Delegate1024 : MulticastDelegate
{
	// Token: 0x060027D4 RID: 10196
	public extern string Invoke(ref long long_0);

	// Token: 0x060027D5 RID: 10197 RVA: 0x0000E72A File Offset: 0x0000C92A
	public static string smethod_0(ref long long_0, Delegate1024 delegate1024_1)
	{
		return delegate1024_1(ref long_0);
	}

	// Token: 0x060027D6 RID: 10198
	public extern Delegate1024(object object_0, IntPtr intptr_0);

	// Token: 0x060027D7 RID: 10199 RVA: 0x0000E735 File Offset: 0x0000C935
	static Delegate1024()
	{
		Class15.smethod_14(typeof(Delegate1024).TypeHandle);
	}

	// Token: 0x04000DE0 RID: 3552
	internal static Delegate1024 delegate1024_0;
}
