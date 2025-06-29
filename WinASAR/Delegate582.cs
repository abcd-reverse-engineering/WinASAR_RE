using System;

// Token: 0x02000456 RID: 1110
internal sealed class Delegate582 : MulticastDelegate
{
	// Token: 0x060020EC RID: 8428
	public extern object Invoke(object object_0, object object_1);

	// Token: 0x060020ED RID: 8429 RVA: 0x0000BB5D File Offset: 0x00009D5D
	public static object smethod_0(object object_0, object object_1, Delegate582 delegate582_1)
	{
		return delegate582_1(object_0, object_1);
	}

	// Token: 0x060020EE RID: 8430
	public extern Delegate582(object object_0, IntPtr intptr_0);

	// Token: 0x060020EF RID: 8431 RVA: 0x0000BB6A File Offset: 0x00009D6A
	static Delegate582()
	{
		Class15.smethod_14(typeof(Delegate582).TypeHandle);
	}

	// Token: 0x04000C26 RID: 3110
	internal static Delegate582 delegate582_0;
}
