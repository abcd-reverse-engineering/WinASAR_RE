using System;

// Token: 0x02000389 RID: 905
internal sealed class Delegate377 : MulticastDelegate
{
	// Token: 0x06001DB8 RID: 7608
	public extern bool Invoke(char char_0);

	// Token: 0x06001DB9 RID: 7609 RVA: 0x0000A6C5 File Offset: 0x000088C5
	public static bool smethod_0(char char_0, Delegate377 delegate377_1)
	{
		return delegate377_1(char_0);
	}

	// Token: 0x06001DBA RID: 7610
	public extern Delegate377(object object_0, IntPtr intptr_0);

	// Token: 0x06001DBB RID: 7611 RVA: 0x0000A6D0 File Offset: 0x000088D0
	static Delegate377()
	{
		Class15.smethod_14(typeof(Delegate377).TypeHandle);
	}

	// Token: 0x04000B59 RID: 2905
	internal static Delegate377 delegate377_0;
}
