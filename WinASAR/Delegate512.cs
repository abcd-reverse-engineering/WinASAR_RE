using System;
using System.Collections;

// Token: 0x02000410 RID: 1040
internal sealed class Delegate512 : MulticastDelegate
{
	// Token: 0x06001FD4 RID: 8148
	public extern object Invoke(ref DictionaryEntry dictionaryEntry_0);

	// Token: 0x06001FD5 RID: 8149 RVA: 0x0000B44F File Offset: 0x0000964F
	public static object smethod_0(ref DictionaryEntry dictionaryEntry_0, Delegate512 delegate512_1)
	{
		return delegate512_1(ref dictionaryEntry_0);
	}

	// Token: 0x06001FD6 RID: 8150
	public extern Delegate512(object object_0, IntPtr intptr_0);

	// Token: 0x06001FD7 RID: 8151 RVA: 0x0000B45A File Offset: 0x0000965A
	static Delegate512()
	{
		Class15.smethod_14(typeof(Delegate512).TypeHandle);
	}

	// Token: 0x04000BE0 RID: 3040
	internal static Delegate512 delegate512_0;
}
