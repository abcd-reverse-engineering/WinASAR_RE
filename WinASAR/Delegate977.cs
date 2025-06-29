using System;

// Token: 0x020005E1 RID: 1505
internal sealed class Delegate977 : MulticastDelegate
{
	// Token: 0x06002718 RID: 10008
	public extern byte[] Invoke(object object_0, int int_0);

	// Token: 0x06002719 RID: 10009 RVA: 0x0000E262 File Offset: 0x0000C462
	public static byte[] smethod_0(object object_0, int int_0, Delegate977 delegate977_1)
	{
		return delegate977_1(object_0, int_0);
	}

	// Token: 0x0600271A RID: 10010
	public extern Delegate977(object object_0, IntPtr intptr_0);

	// Token: 0x0600271B RID: 10011 RVA: 0x0000E26F File Offset: 0x0000C46F
	static Delegate977()
	{
		Class15.smethod_14(typeof(Delegate977).TypeHandle);
	}

	// Token: 0x04000DB1 RID: 3505
	internal static Delegate977 delegate977_0;
}
