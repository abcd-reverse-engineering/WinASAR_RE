using System;

// Token: 0x0200051D RID: 1309
internal sealed class Delegate781 : MulticastDelegate
{
	// Token: 0x06002408 RID: 9224
	public extern DateTimeOffset Invoke(string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06002409 RID: 9225 RVA: 0x0000CEFE File Offset: 0x0000B0FE
	public static DateTimeOffset smethod_0(string string_0, IFormatProvider iformatProvider_0, Delegate781 delegate781_1)
	{
		return delegate781_1(string_0, iformatProvider_0);
	}

	// Token: 0x0600240A RID: 9226
	public extern Delegate781(object object_0, IntPtr intptr_0);

	// Token: 0x0600240B RID: 9227 RVA: 0x0000CF0B File Offset: 0x0000B10B
	static Delegate781()
	{
		Class15.smethod_14(typeof(Delegate781).TypeHandle);
	}

	// Token: 0x04000CED RID: 3309
	internal static Delegate781 delegate781_0;
}
