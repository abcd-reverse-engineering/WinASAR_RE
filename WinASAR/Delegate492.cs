using System;

// Token: 0x020003FC RID: 1020
internal sealed class Delegate492 : MulticastDelegate
{
	// Token: 0x06001F84 RID: 8068
	public extern string Invoke(ref long long_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001F85 RID: 8069 RVA: 0x0000B255 File Offset: 0x00009455
	public static string smethod_0(ref long long_0, IFormatProvider iformatProvider_0, Delegate492 delegate492_1)
	{
		return delegate492_1(ref long_0, iformatProvider_0);
	}

	// Token: 0x06001F86 RID: 8070
	public extern Delegate492(object object_0, IntPtr intptr_0);

	// Token: 0x06001F87 RID: 8071 RVA: 0x0000B262 File Offset: 0x00009462
	static Delegate492()
	{
		Class15.smethod_14(typeof(Delegate492).TypeHandle);
	}

	// Token: 0x04000BCC RID: 3020
	internal static Delegate492 delegate492_0;
}
