using System;

// Token: 0x0200044B RID: 1099
internal sealed class Delegate571 : MulticastDelegate
{
	// Token: 0x060020C0 RID: 8384
	public extern string Invoke(object object_0);

	// Token: 0x060020C1 RID: 8385 RVA: 0x0000BA3F File Offset: 0x00009C3F
	public static string smethod_0(object object_0, Delegate571 delegate571_1)
	{
		return delegate571_1(object_0);
	}

	// Token: 0x060020C2 RID: 8386
	public extern Delegate571(object object_0, IntPtr intptr_0);

	// Token: 0x060020C3 RID: 8387 RVA: 0x0000BA4A File Offset: 0x00009C4A
	static Delegate571()
	{
		Class15.smethod_14(typeof(Delegate571).TypeHandle);
	}

	// Token: 0x04000C1B RID: 3099
	internal static Delegate571 delegate571_0;
}
