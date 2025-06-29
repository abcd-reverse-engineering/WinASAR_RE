using System;

// Token: 0x0200052F RID: 1327
internal sealed class Delegate799 : MulticastDelegate
{
	// Token: 0x06002450 RID: 9296
	public extern decimal Invoke(decimal decimal_0);

	// Token: 0x06002451 RID: 9297 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
	public static decimal smethod_0(decimal decimal_0, Delegate799 delegate799_1)
	{
		return delegate799_1(decimal_0);
	}

	// Token: 0x06002452 RID: 9298
	public extern Delegate799(object object_0, IntPtr intptr_0);

	// Token: 0x06002453 RID: 9299 RVA: 0x0000D0CF File Offset: 0x0000B2CF
	static Delegate799()
	{
		Class15.smethod_14(typeof(Delegate799).TypeHandle);
	}

	// Token: 0x04000CFF RID: 3327
	internal static Delegate799 delegate799_0;
}
