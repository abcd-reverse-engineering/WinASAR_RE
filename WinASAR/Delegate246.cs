using System;

// Token: 0x02000306 RID: 774
internal sealed class Delegate246 : MulticastDelegate
{
	// Token: 0x06001BAC RID: 7084
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001BAD RID: 7085 RVA: 0x0000998B File Offset: 0x00007B8B
	public static void smethod_0(object object_0, bool bool_0, Delegate246 delegate246_1)
	{
		delegate246_1(object_0, bool_0);
	}

	// Token: 0x06001BAE RID: 7086
	public extern Delegate246(object object_0, IntPtr intptr_0);

	// Token: 0x06001BAF RID: 7087 RVA: 0x00009998 File Offset: 0x00007B98
	static Delegate246()
	{
		Class15.smethod_14(typeof(Delegate246).TypeHandle);
	}

	// Token: 0x04000AD6 RID: 2774
	internal static Delegate246 delegate246_0;
}
