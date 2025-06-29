using System;

// Token: 0x02000521 RID: 1313
internal sealed class Delegate785 : MulticastDelegate
{
	// Token: 0x06002418 RID: 9240
	public extern short Invoke(object object_0, IFormatProvider iformatProvider_0);

	// Token: 0x06002419 RID: 9241 RVA: 0x0000CF62 File Offset: 0x0000B162
	public static short smethod_0(object object_0, IFormatProvider iformatProvider_0, Delegate785 delegate785_1)
	{
		return delegate785_1(object_0, iformatProvider_0);
	}

	// Token: 0x0600241A RID: 9242
	public extern Delegate785(object object_0, IntPtr intptr_0);

	// Token: 0x0600241B RID: 9243 RVA: 0x0000CF6F File Offset: 0x0000B16F
	static Delegate785()
	{
		Class15.smethod_14(typeof(Delegate785).TypeHandle);
	}

	// Token: 0x04000CF1 RID: 3313
	internal static Delegate785 delegate785_0;
}
