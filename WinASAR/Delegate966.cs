using System;

// Token: 0x020005D6 RID: 1494
internal sealed class Delegate966 : MulticastDelegate
{
	// Token: 0x060026EC RID: 9964
	public extern void Invoke(object object_0);

	// Token: 0x060026ED RID: 9965 RVA: 0x0000E142 File Offset: 0x0000C342
	public static void smethod_0(object object_0, Delegate966 delegate966_1)
	{
		delegate966_1(object_0);
	}

	// Token: 0x060026EE RID: 9966
	public extern Delegate966(object object_0, IntPtr intptr_0);

	// Token: 0x060026EF RID: 9967 RVA: 0x0000E14D File Offset: 0x0000C34D
	static Delegate966()
	{
		Class15.smethod_14(typeof(Delegate966).TypeHandle);
	}

	// Token: 0x04000DA6 RID: 3494
	internal static Delegate966 delegate966_0;
}
