using System;

// Token: 0x0200033A RID: 826
internal sealed class Delegate298 : MulticastDelegate
{
	// Token: 0x06001C7C RID: 7292
	public extern object[] Invoke(object object_0, Type type_0, bool bool_0);

	// Token: 0x06001C7D RID: 7293 RVA: 0x00009EA9 File Offset: 0x000080A9
	public static object[] smethod_0(object object_0, Type type_0, bool bool_0, Delegate298 delegate298_1)
	{
		return delegate298_1(object_0, type_0, bool_0);
	}

	// Token: 0x06001C7E RID: 7294
	public extern Delegate298(object object_0, IntPtr intptr_0);

	// Token: 0x06001C7F RID: 7295 RVA: 0x00009EB8 File Offset: 0x000080B8
	static Delegate298()
	{
		Class15.smethod_14(typeof(Delegate298).TypeHandle);
	}

	// Token: 0x04000B0A RID: 2826
	internal static Delegate298 delegate298_0;
}
