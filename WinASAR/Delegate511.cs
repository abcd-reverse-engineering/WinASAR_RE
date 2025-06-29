using System;
using System.Collections;

// Token: 0x0200040F RID: 1039
internal sealed class Delegate511 : MulticastDelegate
{
	// Token: 0x06001FD0 RID: 8144
	public extern object Invoke(ref DictionaryEntry dictionaryEntry_0);

	// Token: 0x06001FD1 RID: 8145 RVA: 0x0000B437 File Offset: 0x00009637
	public static object smethod_0(ref DictionaryEntry dictionaryEntry_0, Delegate511 delegate511_1)
	{
		return delegate511_1(ref dictionaryEntry_0);
	}

	// Token: 0x06001FD2 RID: 8146
	public extern Delegate511(object object_0, IntPtr intptr_0);

	// Token: 0x06001FD3 RID: 8147 RVA: 0x0000B442 File Offset: 0x00009642
	static Delegate511()
	{
		Class15.smethod_14(typeof(Delegate511).TypeHandle);
	}

	// Token: 0x04000BDF RID: 3039
	internal static Delegate511 delegate511_0;
}
