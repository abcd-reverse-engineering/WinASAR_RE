using System;

// Token: 0x0200046B RID: 1131
internal sealed class Delegate603 : MulticastDelegate
{
	// Token: 0x06002140 RID: 8512
	public extern bool Invoke(object object_0, Type type_0, bool bool_0);

	// Token: 0x06002141 RID: 8513 RVA: 0x0000BD6F File Offset: 0x00009F6F
	public static bool smethod_0(object object_0, Type type_0, bool bool_0, Delegate603 delegate603_1)
	{
		return delegate603_1(object_0, type_0, bool_0);
	}

	// Token: 0x06002142 RID: 8514
	public extern Delegate603(object object_0, IntPtr intptr_0);

	// Token: 0x06002143 RID: 8515 RVA: 0x0000BD7E File Offset: 0x00009F7E
	static Delegate603()
	{
		Class15.smethod_14(typeof(Delegate603).TypeHandle);
	}

	// Token: 0x04000C3B RID: 3131
	internal static Delegate603 delegate603_0;
}
