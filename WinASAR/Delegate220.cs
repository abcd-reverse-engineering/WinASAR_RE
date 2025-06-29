using System;
using System.Windows.Forms;

// Token: 0x020002EC RID: 748
internal sealed class Delegate220 : MulticastDelegate
{
	// Token: 0x06001B44 RID: 6980
	public extern void Invoke(object object_0, Keys keys_0);

	// Token: 0x06001B45 RID: 6981 RVA: 0x000096EF File Offset: 0x000078EF
	public static void smethod_0(object object_0, Keys keys_0, Delegate220 delegate220_1)
	{
		delegate220_1(object_0, keys_0);
	}

	// Token: 0x06001B46 RID: 6982
	public extern Delegate220(object object_0, IntPtr intptr_0);

	// Token: 0x06001B47 RID: 6983 RVA: 0x000096FC File Offset: 0x000078FC
	static Delegate220()
	{
		Class15.smethod_14(typeof(Delegate220).TypeHandle);
	}

	// Token: 0x04000ABC RID: 2748
	internal static Delegate220 delegate220_0;
}
