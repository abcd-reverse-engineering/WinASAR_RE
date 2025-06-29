using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200015B RID: 347
	[NullableContext(1)]
	[Nullable(0)]
	public class GClass0 : PropertyDescriptor
	{
		// Token: 0x06000F0D RID: 3853 RVA: 0x0007A4DC File Offset: 0x000786DC
		public GClass0(string name)
			: base(name, null)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0000617F File Offset: 0x0000437F
		private static JObject smethod_0(JObject jobject_0)
		{
			return (JObject)jobject_0;
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00003453 File Offset: 0x00001653
		public override bool CanResetValue(object component)
		{
			return false;
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0007A510 File Offset: 0x00078710
		[NullableContext(2)]
		public override object GetValue(object component)
		{
			JObject jobject;
			for (;;)
			{
				jobject = component as JObject;
				if (jobject != null)
				{
					goto IL_002F;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
					break;
				}
				break;
			}
			return null;
			IL_002F:
			return jobject[this.Name];
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00002420 File Offset: 0x00000620
		public override void ResetValue(object component)
		{
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0007A558 File Offset: 0x00078758
		[NullableContext(2)]
		public override void SetValue(object component, object value)
		{
			for (;;)
			{
				IL_00A5:
				JObject jobject = component as JObject;
				for (;;)
				{
					IL_009B:
					if (jobject != null)
					{
						goto IL_0006;
					}
					int num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
					{
						return;
					}
					JToken jtoken;
					for (;;)
					{
						IL_0063:
						switch (num)
						{
						case 1:
							jobject[this.Name] = jtoken;
							num = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_0006;
						case 3:
						case 4:
							return;
						case 5:
							goto IL_009B;
						case 6:
							goto IL_00A5;
						}
						break;
					}
					goto IL_005B;
					IL_0006:
					JToken jtoken2;
					if ((jtoken2 = value as JToken) == null)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
						{
							goto IL_005B;
						}
						goto IL_0063;
					}
					IL_0047:
					jtoken = jtoken2;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
					{
						goto IL_0063;
					}
					IL_005B:
					jtoken2 = new JValue(value);
					goto IL_0047;
				}
			}
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00003453 File Offset: 0x00001653
		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x00006187 File Offset: 0x00004387
		public override Type ComponentType
		{
			get
			{
				return typeof(JObject);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x00003453 File Offset: 0x00001653
		public override bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x00006193 File Offset: 0x00004393
		public override Type PropertyType
		{
			get
			{
				return typeof(object);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x0000619F File Offset: 0x0000439F
		protected override int NameHashCode
		{
			get
			{
				return base.NameHashCode;
			}
		}
	}
}
