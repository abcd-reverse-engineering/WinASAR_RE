using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	// Token: 0x02000053 RID: 83
	[Nullable(0)]
	[NullableContext(1)]
	public abstract class JsonConverter
	{
		// Token: 0x0600028F RID: 655
		public abstract void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer);

		// Token: 0x06000290 RID: 656
		[return: Nullable(2)]
		public abstract object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer);

		// Token: 0x06000291 RID: 657
		public abstract bool CanConvert(Type objectType);

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00002C18 File Offset: 0x00000E18
		public virtual bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00002C18 File Offset: 0x00000E18
		public virtual bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00028380 File Offset: 0x00026580
		protected JsonConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
