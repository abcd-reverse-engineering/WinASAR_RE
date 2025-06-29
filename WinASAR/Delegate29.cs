using System;

// Token: 0x0200022D RID: 557
internal sealed class Delegate29 : MulticastDelegate
{
	// Token: 0x06001848 RID: 6216
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06001849 RID: 6217 RVA: 0x00008425 File Offset: 0x00006625
	public static void smethod_0(object object_0, string string_0, Delegate29 delegate29_1)
	{
		delegate29_1(object_0, string_0);
	}

	// Token: 0x0600184A RID: 6218
	public extern Delegate29(object object_0, IntPtr intptr_0);

	// Token: 0x0600184B RID: 6219 RVA: 0x00008432 File Offset: 0x00006632
	static Delegate29()
	{
		Class15.smethod_14(typeof(Delegate29).TypeHandle);
	}

	// Token: 0x040009FD RID: 2557
	internal static Delegate29 delegate29_0;
}
