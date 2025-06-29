using System;

// Token: 0x02000333 RID: 819
internal sealed class Delegate291 : MulticastDelegate
{
	// Token: 0x06001C60 RID: 7264
	public extern Type Invoke(object object_0);

	// Token: 0x06001C61 RID: 7265 RVA: 0x00009DF3 File Offset: 0x00007FF3
	public static Type smethod_0(object object_0, Delegate291 delegate291_1)
	{
		return delegate291_1(object_0);
	}

	// Token: 0x06001C62 RID: 7266
	public extern Delegate291(object object_0, IntPtr intptr_0);

	// Token: 0x06001C63 RID: 7267 RVA: 0x00009DFE File Offset: 0x00007FFE
	static Delegate291()
	{
		Class15.smethod_14(typeof(Delegate291).TypeHandle);
	}

	// Token: 0x04000B03 RID: 2819
	internal static Delegate291 delegate291_0;
}
