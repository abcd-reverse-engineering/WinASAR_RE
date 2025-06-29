using System;

// Token: 0x02000390 RID: 912
internal sealed class Delegate384 : MulticastDelegate
{
	// Token: 0x06001DD4 RID: 7636
	public extern decimal Invoke(char char_0);

	// Token: 0x06001DD5 RID: 7637 RVA: 0x0000A771 File Offset: 0x00008971
	public static decimal smethod_0(char char_0, Delegate384 delegate384_1)
	{
		return delegate384_1(char_0);
	}

	// Token: 0x06001DD6 RID: 7638
	public extern Delegate384(object object_0, IntPtr intptr_0);

	// Token: 0x06001DD7 RID: 7639 RVA: 0x0000A77C File Offset: 0x0000897C
	static Delegate384()
	{
		Class15.smethod_14(typeof(Delegate384).TypeHandle);
	}

	// Token: 0x04000B60 RID: 2912
	internal static Delegate384 delegate384_0;
}
