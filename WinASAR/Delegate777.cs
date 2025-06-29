using System;
using System.ComponentModel;

// Token: 0x02000519 RID: 1305
internal sealed class Delegate777 : MulticastDelegate
{
	// Token: 0x060023F8 RID: 9208
	public extern PropertyDescriptorCollection Invoke(object object_0, Attribute[] attribute_0);

	// Token: 0x060023F9 RID: 9209 RVA: 0x0000CE9C File Offset: 0x0000B09C
	public static PropertyDescriptorCollection smethod_0(object object_0, Attribute[] attribute_0, Delegate777 delegate777_1)
	{
		return delegate777_1(object_0, attribute_0);
	}

	// Token: 0x060023FA RID: 9210
	public extern Delegate777(object object_0, IntPtr intptr_0);

	// Token: 0x060023FB RID: 9211 RVA: 0x0000CEA9 File Offset: 0x0000B0A9
	static Delegate777()
	{
		Class15.smethod_14(typeof(Delegate777).TypeHandle);
	}

	// Token: 0x04000CE9 RID: 3305
	internal static Delegate777 delegate777_0;
}
