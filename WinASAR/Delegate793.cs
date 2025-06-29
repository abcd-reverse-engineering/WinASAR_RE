using System;

// Token: 0x02000529 RID: 1321
internal sealed class Delegate793 : MulticastDelegate
{
	// Token: 0x06002438 RID: 9272
	public extern ulong Invoke(object object_0, IFormatProvider iformatProvider_0);

	// Token: 0x06002439 RID: 9273 RVA: 0x0000D02C File Offset: 0x0000B22C
	public static ulong smethod_0(object object_0, IFormatProvider iformatProvider_0, Delegate793 delegate793_1)
	{
		return delegate793_1(object_0, iformatProvider_0);
	}

	// Token: 0x0600243A RID: 9274
	public extern Delegate793(object object_0, IntPtr intptr_0);

	// Token: 0x0600243B RID: 9275 RVA: 0x0000D039 File Offset: 0x0000B239
	static Delegate793()
	{
		Class15.smethod_14(typeof(Delegate793).TypeHandle);
	}

	// Token: 0x04000CF9 RID: 3321
	internal static Delegate793 delegate793_0;
}
