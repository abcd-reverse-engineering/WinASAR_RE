using System;
using Microsoft.Win32;

// Token: 0x0200033E RID: 830
internal sealed class Delegate302 : MulticastDelegate
{
	// Token: 0x06001C8C RID: 7308
	public extern RegistryKey Invoke(object object_0, string string_0);

	// Token: 0x06001C8D RID: 7309 RVA: 0x00009F0F File Offset: 0x0000810F
	public static RegistryKey smethod_0(object object_0, string string_0, Delegate302 delegate302_1)
	{
		return delegate302_1(object_0, string_0);
	}

	// Token: 0x06001C8E RID: 7310
	public extern Delegate302(object object_0, IntPtr intptr_0);

	// Token: 0x06001C8F RID: 7311 RVA: 0x00009F1C File Offset: 0x0000811C
	static Delegate302()
	{
		Class15.smethod_14(typeof(Delegate302).TypeHandle);
	}

	// Token: 0x04000B0E RID: 2830
	internal static Delegate302 delegate302_0;
}
