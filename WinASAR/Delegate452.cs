using System;

// Token: 0x020003D4 RID: 980
internal sealed class Delegate452 : MulticastDelegate
{
	// Token: 0x06001EE4 RID: 7908
	public extern object Invoke(object object_0, Type type_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001EE5 RID: 7909 RVA: 0x0000AE41 File Offset: 0x00009041
	public static object smethod_0(object object_0, Type type_0, IFormatProvider iformatProvider_0, Delegate452 delegate452_1)
	{
		return delegate452_1(object_0, type_0, iformatProvider_0);
	}

	// Token: 0x06001EE6 RID: 7910
	public extern Delegate452(object object_0, IntPtr intptr_0);

	// Token: 0x06001EE7 RID: 7911 RVA: 0x0000AE50 File Offset: 0x00009050
	static Delegate452()
	{
		Class15.smethod_14(typeof(Delegate452).TypeHandle);
	}

	// Token: 0x04000BA4 RID: 2980
	internal static Delegate452 delegate452_0;
}
