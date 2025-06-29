using System;
using Microsoft.Win32;

// Token: 0x02000341 RID: 833
internal sealed class Delegate305 : MulticastDelegate
{
	// Token: 0x06001C98 RID: 7320
	public extern RegistryKey Invoke(object object_0, string string_0, bool bool_0);

	// Token: 0x06001C99 RID: 7321 RVA: 0x00009F5D File Offset: 0x0000815D
	public static RegistryKey smethod_0(object object_0, string string_0, bool bool_0, Delegate305 delegate305_1)
	{
		return delegate305_1(object_0, string_0, bool_0);
	}

	// Token: 0x06001C9A RID: 7322
	public extern Delegate305(object object_0, IntPtr intptr_0);

	// Token: 0x06001C9B RID: 7323 RVA: 0x00009F6C File Offset: 0x0000816C
	static Delegate305()
	{
		Class15.smethod_14(typeof(Delegate305).TypeHandle);
	}

	// Token: 0x04000B11 RID: 2833
	internal static Delegate305 delegate305_0;
}
