using System;

// Token: 0x020004E3 RID: 1251
internal sealed class Delegate723 : MulticastDelegate
{
	// Token: 0x06002320 RID: 8992
	public extern string Invoke(ref int int_0, IFormatProvider iformatProvider_0);

	// Token: 0x06002321 RID: 8993 RVA: 0x0000C950 File Offset: 0x0000AB50
	public static string smethod_0(ref int int_0, IFormatProvider iformatProvider_0, Delegate723 delegate723_1)
	{
		return delegate723_1(ref int_0, iformatProvider_0);
	}

	// Token: 0x06002322 RID: 8994
	public extern Delegate723(object object_0, IntPtr intptr_0);

	// Token: 0x06002323 RID: 8995 RVA: 0x0000C95D File Offset: 0x0000AB5D
	static Delegate723()
	{
		Class15.smethod_14(typeof(Delegate723).TypeHandle);
	}

	// Token: 0x04000CB3 RID: 3251
	internal static Delegate723 delegate723_0;
}
