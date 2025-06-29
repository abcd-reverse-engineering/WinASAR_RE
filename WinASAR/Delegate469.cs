using System;

// Token: 0x020003E5 RID: 997
internal sealed class Delegate469 : MulticastDelegate
{
	// Token: 0x06001F28 RID: 7976
	public extern decimal Invoke(decimal decimal_0);

	// Token: 0x06001F29 RID: 7977 RVA: 0x0000B003 File Offset: 0x00009203
	public static decimal smethod_0(decimal decimal_0, Delegate469 delegate469_1)
	{
		return delegate469_1(decimal_0);
	}

	// Token: 0x06001F2A RID: 7978
	public extern Delegate469(object object_0, IntPtr intptr_0);

	// Token: 0x06001F2B RID: 7979 RVA: 0x0000B00E File Offset: 0x0000920E
	static Delegate469()
	{
		Class15.smethod_14(typeof(Delegate469).TypeHandle);
	}

	// Token: 0x04000BB5 RID: 2997
	internal static Delegate469 delegate469_0;
}
