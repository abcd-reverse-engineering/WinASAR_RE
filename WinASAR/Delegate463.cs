using System;

// Token: 0x020003DF RID: 991
internal sealed class Delegate463 : MulticastDelegate
{
	// Token: 0x06001F10 RID: 7952
	public extern decimal Invoke(decimal decimal_0, decimal decimal_1);

	// Token: 0x06001F11 RID: 7953 RVA: 0x0000AF69 File Offset: 0x00009169
	public static decimal smethod_0(decimal decimal_0, decimal decimal_1, Delegate463 delegate463_1)
	{
		return delegate463_1(decimal_0, decimal_1);
	}

	// Token: 0x06001F12 RID: 7954
	public extern Delegate463(object object_0, IntPtr intptr_0);

	// Token: 0x06001F13 RID: 7955 RVA: 0x0000AF76 File Offset: 0x00009176
	static Delegate463()
	{
		Class15.smethod_14(typeof(Delegate463).TypeHandle);
	}

	// Token: 0x04000BAF RID: 2991
	internal static Delegate463 delegate463_0;
}
