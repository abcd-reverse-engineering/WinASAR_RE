using System;

// Token: 0x0200059F RID: 1439
internal sealed class Delegate911 : MulticastDelegate
{
	// Token: 0x06002610 RID: 9744
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06002611 RID: 9745 RVA: 0x0000DBDA File Offset: 0x0000BDDA
	public static void smethod_0(object object_0, string string_0, Delegate911 delegate911_1)
	{
		delegate911_1(object_0, string_0);
	}

	// Token: 0x06002612 RID: 9746
	public extern Delegate911(object object_0, IntPtr intptr_0);

	// Token: 0x06002613 RID: 9747 RVA: 0x0000DBE7 File Offset: 0x0000BDE7
	static Delegate911()
	{
		Class15.smethod_14(typeof(Delegate911).TypeHandle);
	}

	// Token: 0x04000D6F RID: 3439
	internal static Delegate911 delegate911_0;
}
