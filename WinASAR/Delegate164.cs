using System;

// Token: 0x020002B4 RID: 692
internal sealed class Delegate164 : MulticastDelegate
{
	// Token: 0x06001A64 RID: 6756
	public extern void Invoke(string string_0);

	// Token: 0x06001A65 RID: 6757 RVA: 0x0000916B File Offset: 0x0000736B
	public static void smethod_0(string string_0, Delegate164 delegate164_1)
	{
		delegate164_1(string_0);
	}

	// Token: 0x06001A66 RID: 6758
	public extern Delegate164(object object_0, IntPtr intptr_0);

	// Token: 0x06001A67 RID: 6759 RVA: 0x00009176 File Offset: 0x00007376
	static Delegate164()
	{
		Class15.smethod_14(typeof(Delegate164).TypeHandle);
	}

	// Token: 0x04000A84 RID: 2692
	internal static Delegate164 delegate164_0;
}
