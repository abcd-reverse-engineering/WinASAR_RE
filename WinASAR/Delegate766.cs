using System;

// Token: 0x0200050E RID: 1294
internal sealed class Delegate766 : MulticastDelegate
{
	// Token: 0x060023CC RID: 9164
	public extern Guid Invoke();

	// Token: 0x060023CD RID: 9165 RVA: 0x0000CD86 File Offset: 0x0000AF86
	public static Guid smethod_0(Delegate766 delegate766_1)
	{
		return delegate766_1();
	}

	// Token: 0x060023CE RID: 9166
	public extern Delegate766(object object_0, IntPtr intptr_0);

	// Token: 0x060023CF RID: 9167 RVA: 0x0000CD8F File Offset: 0x0000AF8F
	static Delegate766()
	{
		Class15.smethod_14(typeof(Delegate766).TypeHandle);
	}

	// Token: 0x04000CDE RID: 3294
	internal static Delegate766 delegate766_0;
}
