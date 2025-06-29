using System;

// Token: 0x02000385 RID: 901
internal sealed class Delegate373 : MulticastDelegate
{
	// Token: 0x06001DA8 RID: 7592
	public extern byte[] Invoke(char[] char_0, int int_0, int int_1);

	// Token: 0x06001DA9 RID: 7593 RVA: 0x0000A651 File Offset: 0x00008851
	public static byte[] smethod_0(char[] char_0, int int_0, int int_1, Delegate373 delegate373_1)
	{
		return delegate373_1(char_0, int_0, int_1);
	}

	// Token: 0x06001DAA RID: 7594
	public extern Delegate373(object object_0, IntPtr intptr_0);

	// Token: 0x06001DAB RID: 7595 RVA: 0x0000A660 File Offset: 0x00008860
	static Delegate373()
	{
		Class15.smethod_14(typeof(Delegate373).TypeHandle);
	}

	// Token: 0x04000B55 RID: 2901
	internal static Delegate373 delegate373_0;
}
