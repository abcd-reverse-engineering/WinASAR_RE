using System;

// Token: 0x020004BE RID: 1214
internal sealed class Delegate686 : MulticastDelegate
{
	// Token: 0x0600228C RID: 8844
	public extern bool Invoke(char char_0);

	// Token: 0x0600228D RID: 8845 RVA: 0x0000C5C6 File Offset: 0x0000A7C6
	public static bool smethod_0(char char_0, Delegate686 delegate686_1)
	{
		return delegate686_1(char_0);
	}

	// Token: 0x0600228E RID: 8846
	public extern Delegate686(object object_0, IntPtr intptr_0);

	// Token: 0x0600228F RID: 8847 RVA: 0x0000C5D1 File Offset: 0x0000A7D1
	static Delegate686()
	{
		Class15.smethod_14(typeof(Delegate686).TypeHandle);
	}

	// Token: 0x04000C8E RID: 3214
	internal static Delegate686 delegate686_0;
}
