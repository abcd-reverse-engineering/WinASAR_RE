using System;
using System.Xml;

// Token: 0x02000565 RID: 1381
internal sealed class Delegate853 : MulticastDelegate
{
	// Token: 0x06002528 RID: 9512
	public extern XmlText Invoke(object object_0, string string_0);

	// Token: 0x06002529 RID: 9513 RVA: 0x0000D62E File Offset: 0x0000B82E
	public static XmlText smethod_0(object object_0, string string_0, Delegate853 delegate853_1)
	{
		return delegate853_1(object_0, string_0);
	}

	// Token: 0x0600252A RID: 9514
	public extern Delegate853(object object_0, IntPtr intptr_0);

	// Token: 0x0600252B RID: 9515 RVA: 0x0000D63B File Offset: 0x0000B83B
	static Delegate853()
	{
		Class15.smethod_14(typeof(Delegate853).TypeHandle);
	}

	// Token: 0x04000D35 RID: 3381
	internal static Delegate853 delegate853_0;
}
