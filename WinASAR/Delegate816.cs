using System;

// Token: 0x02000540 RID: 1344
internal sealed class Delegate816 : MulticastDelegate
{
	// Token: 0x06002494 RID: 9364
	public extern int Invoke(string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06002495 RID: 9365 RVA: 0x0000D278 File Offset: 0x0000B478
	public static int smethod_0(string string_0, IFormatProvider iformatProvider_0, Delegate816 delegate816_1)
	{
		return delegate816_1(string_0, iformatProvider_0);
	}

	// Token: 0x06002496 RID: 9366
	public extern Delegate816(object object_0, IntPtr intptr_0);

	// Token: 0x06002497 RID: 9367 RVA: 0x0000D285 File Offset: 0x0000B485
	static Delegate816()
	{
		Class15.smethod_14(typeof(Delegate816).TypeHandle);
	}

	// Token: 0x04000D10 RID: 3344
	internal static Delegate816 delegate816_0;
}
