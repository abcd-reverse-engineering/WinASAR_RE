using System;

// Token: 0x020003B8 RID: 952
internal sealed class Delegate424 : MulticastDelegate
{
	// Token: 0x06001E74 RID: 7796
	public extern int Invoke(object object_0);

	// Token: 0x06001E75 RID: 7797 RVA: 0x0000AB75 File Offset: 0x00008D75
	public static int smethod_0(object object_0, Delegate424 delegate424_1)
	{
		return delegate424_1(object_0);
	}

	// Token: 0x06001E76 RID: 7798
	public extern Delegate424(object object_0, IntPtr intptr_0);

	// Token: 0x06001E77 RID: 7799 RVA: 0x0000AB80 File Offset: 0x00008D80
	static Delegate424()
	{
		Class15.smethod_14(typeof(Delegate424).TypeHandle);
	}

	// Token: 0x04000B88 RID: 2952
	internal static Delegate424 delegate424_0;
}
