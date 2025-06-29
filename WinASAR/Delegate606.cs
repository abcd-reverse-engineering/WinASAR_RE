using System;

// Token: 0x0200046E RID: 1134
internal sealed class Delegate606 : MulticastDelegate
{
	// Token: 0x0600214C RID: 8524
	public extern byte Invoke(bool bool_0);

	// Token: 0x0600214D RID: 8525 RVA: 0x0000BDBD File Offset: 0x00009FBD
	public static byte smethod_0(bool bool_0, Delegate606 delegate606_1)
	{
		return delegate606_1(bool_0);
	}

	// Token: 0x0600214E RID: 8526
	public extern Delegate606(object object_0, IntPtr intptr_0);

	// Token: 0x0600214F RID: 8527 RVA: 0x0000BDC8 File Offset: 0x00009FC8
	static Delegate606()
	{
		Class15.smethod_14(typeof(Delegate606).TypeHandle);
	}

	// Token: 0x04000C3E RID: 3134
	internal static Delegate606 delegate606_0;
}
