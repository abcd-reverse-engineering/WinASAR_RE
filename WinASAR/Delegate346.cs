using System;

// Token: 0x0200036A RID: 874
internal sealed class Delegate346 : MulticastDelegate
{
	// Token: 0x06001D3C RID: 7484
	public extern bool Invoke(object object_0, string string_0, StringComparison stringComparison_0);

	// Token: 0x06001D3D RID: 7485 RVA: 0x0000A38B File Offset: 0x0000858B
	public static bool smethod_0(object object_0, string string_0, StringComparison stringComparison_0, Delegate346 delegate346_1)
	{
		return delegate346_1(object_0, string_0, stringComparison_0);
	}

	// Token: 0x06001D3E RID: 7486
	public extern Delegate346(object object_0, IntPtr intptr_0);

	// Token: 0x06001D3F RID: 7487 RVA: 0x0000A39A File Offset: 0x0000859A
	static Delegate346()
	{
		Class15.smethod_14(typeof(Delegate346).TypeHandle);
	}

	// Token: 0x04000B3A RID: 2874
	internal static Delegate346 delegate346_0;
}
