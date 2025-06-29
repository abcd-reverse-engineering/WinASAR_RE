using System;

// Token: 0x02000578 RID: 1400
internal sealed class Delegate872 : MulticastDelegate
{
	// Token: 0x06002574 RID: 9588
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06002575 RID: 9589 RVA: 0x0000D822 File Offset: 0x0000BA22
	public static void smethod_0(object object_0, string string_0, Delegate872 delegate872_1)
	{
		delegate872_1(object_0, string_0);
	}

	// Token: 0x06002576 RID: 9590
	public extern Delegate872(object object_0, IntPtr intptr_0);

	// Token: 0x06002577 RID: 9591 RVA: 0x0000D82F File Offset: 0x0000BA2F
	static Delegate872()
	{
		Class15.smethod_14(typeof(Delegate872).TypeHandle);
	}

	// Token: 0x04000D48 RID: 3400
	internal static Delegate872 delegate872_0;
}
