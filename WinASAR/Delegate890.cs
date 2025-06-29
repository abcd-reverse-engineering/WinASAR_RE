using System;

// Token: 0x0200058A RID: 1418
internal sealed class Delegate890 : MulticastDelegate
{
	// Token: 0x060025BC RID: 9660
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x060025BD RID: 9661 RVA: 0x0000D9D4 File Offset: 0x0000BBD4
	public static void smethod_0(object object_0, string string_0, Delegate890 delegate890_1)
	{
		delegate890_1(object_0, string_0);
	}

	// Token: 0x060025BE RID: 9662
	public extern Delegate890(object object_0, IntPtr intptr_0);

	// Token: 0x060025BF RID: 9663 RVA: 0x0000D9E1 File Offset: 0x0000BBE1
	static Delegate890()
	{
		Class15.smethod_14(typeof(Delegate890).TypeHandle);
	}

	// Token: 0x04000D5A RID: 3418
	internal static Delegate890 delegate890_0;
}
