using System;

// Token: 0x0200053E RID: 1342
internal sealed class Delegate814 : MulticastDelegate
{
	// Token: 0x0600248C RID: 9356
	public extern int Invoke(ref int int_0);

	// Token: 0x0600248D RID: 9357 RVA: 0x0000D246 File Offset: 0x0000B446
	public static int smethod_0(ref int int_0, Delegate814 delegate814_1)
	{
		return delegate814_1(ref int_0);
	}

	// Token: 0x0600248E RID: 9358
	public extern Delegate814(object object_0, IntPtr intptr_0);

	// Token: 0x0600248F RID: 9359 RVA: 0x0000D251 File Offset: 0x0000B451
	static Delegate814()
	{
		Class15.smethod_14(typeof(Delegate814).TypeHandle);
	}

	// Token: 0x04000D0E RID: 3342
	internal static Delegate814 delegate814_0;
}
