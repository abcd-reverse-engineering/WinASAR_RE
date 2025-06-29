using System;

// Token: 0x02000423 RID: 1059
internal sealed class Delegate531 : MulticastDelegate
{
	// Token: 0x06002020 RID: 8224
	public extern Type Invoke(object object_0);

	// Token: 0x06002021 RID: 8225 RVA: 0x0000B645 File Offset: 0x00009845
	public static Type smethod_0(object object_0, Delegate531 delegate531_1)
	{
		return delegate531_1(object_0);
	}

	// Token: 0x06002022 RID: 8226
	public extern Delegate531(object object_0, IntPtr intptr_0);

	// Token: 0x06002023 RID: 8227 RVA: 0x0000B650 File Offset: 0x00009850
	static Delegate531()
	{
		Class15.smethod_14(typeof(Delegate531).TypeHandle);
	}

	// Token: 0x04000BF3 RID: 3059
	internal static Delegate531 delegate531_0;
}
