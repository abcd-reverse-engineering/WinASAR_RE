using System;

// Token: 0x02000451 RID: 1105
internal sealed class Delegate577 : MulticastDelegate
{
	// Token: 0x060020D8 RID: 8408
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x060020D9 RID: 8409 RVA: 0x0000BAD9 File Offset: 0x00009CD9
	public static void smethod_0(object object_0, bool bool_0, Delegate577 delegate577_1)
	{
		delegate577_1(object_0, bool_0);
	}

	// Token: 0x060020DA RID: 8410
	public extern Delegate577(object object_0, IntPtr intptr_0);

	// Token: 0x060020DB RID: 8411 RVA: 0x0000BAE6 File Offset: 0x00009CE6
	static Delegate577()
	{
		Class15.smethod_14(typeof(Delegate577).TypeHandle);
	}

	// Token: 0x04000C21 RID: 3105
	internal static Delegate577 delegate577_0;
}
