using System;

// Token: 0x0200027C RID: 636
internal sealed class Delegate108 : MulticastDelegate
{
	// Token: 0x06001984 RID: 6532
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001985 RID: 6533 RVA: 0x00008BF7 File Offset: 0x00006DF7
	public static void smethod_0(object object_0, bool bool_0, Delegate108 delegate108_1)
	{
		delegate108_1(object_0, bool_0);
	}

	// Token: 0x06001986 RID: 6534
	public extern Delegate108(object object_0, IntPtr intptr_0);

	// Token: 0x06001987 RID: 6535 RVA: 0x00008C04 File Offset: 0x00006E04
	static Delegate108()
	{
		Class15.smethod_14(typeof(Delegate108).TypeHandle);
	}

	// Token: 0x04000A4C RID: 2636
	internal static Delegate108 delegate108_0;
}
