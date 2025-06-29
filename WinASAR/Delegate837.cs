using System;

// Token: 0x02000555 RID: 1365
internal sealed class Delegate837 : MulticastDelegate
{
	// Token: 0x060024E8 RID: 9448
	public extern void Invoke(object object_0, string string_0, object object_1);

	// Token: 0x060024E9 RID: 9449 RVA: 0x0000D48A File Offset: 0x0000B68A
	public static void smethod_0(object object_0, string string_0, object object_1, Delegate837 delegate837_1)
	{
		delegate837_1(object_0, string_0, object_1);
	}

	// Token: 0x060024EA RID: 9450
	public extern Delegate837(object object_0, IntPtr intptr_0);

	// Token: 0x060024EB RID: 9451 RVA: 0x0000D499 File Offset: 0x0000B699
	static Delegate837()
	{
		Class15.smethod_14(typeof(Delegate837).TypeHandle);
	}

	// Token: 0x04000D25 RID: 3365
	internal static Delegate837 delegate837_0;
}
