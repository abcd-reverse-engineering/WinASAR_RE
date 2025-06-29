using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200014F RID: 335
	[NullableContext(1)]
	[Nullable(0)]
	public class JConstructor : JContainer
	{
		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x00005D84 File Offset: 0x00003F84
		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				return this.list_0;
			}
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00073CC4 File Offset: 0x00071EC4
		[NullableContext(2)]
		internal override int IndexOfItem(JToken item)
		{
			while (item == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return -1;
			}
			return this.list_0.IndexOfReference(item);
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00073D0C File Offset: 0x00071F0C
		internal override void MergeItem(object content, [Nullable(2)] JsonMergeSettings settings)
		{
			JConstructor jconstructor;
			for (;;)
			{
				jconstructor = content as JConstructor;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
				{
					goto IL_0024;
				}
				IL_0034:
				switch (num)
				{
				case 0:
					goto IL_0024;
				case 1:
					continue;
				case 2:
					goto IL_0072;
				case 3:
					return;
				case 4:
					return;
				case 5:
					break;
				default:
					goto IL_0024;
				}
				IL_0003:
				this.Name = jconstructor.Name;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
				{
					break;
				}
				goto IL_0034;
				IL_0024:
				if (jconstructor == null)
				{
					return;
				}
				if (jconstructor.Name != null)
				{
					goto IL_0003;
				}
				break;
			}
			IL_0072:
			JContainer.MergeEnumerableContent(this, jconstructor, settings);
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00005D8C File Offset: 0x00003F8C
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x00073D94 File Offset: 0x00071F94
		[Nullable(2)]
		public string Name
		{
			[NullableContext(2)]
			get
			{
				return this.string_0;
			}
			[NullableContext(2)]
			set
			{
				for (;;)
				{
					this.string_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
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
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00005D94 File Offset: 0x00003F94
		public override JTokenType Type
		{
			get
			{
				return JTokenType.Constructor;
			}
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00073DCC File Offset: 0x00071FCC
		public JConstructor()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00073E0C File Offset: 0x0007200C
		public JConstructor(JConstructor other)
			: base(other, null)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
			{
				goto IL_0044;
			}
			IL_0027:
			this.string_0 = other.Name;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
			{
				return;
			}
			IL_0044:
			switch (num)
			{
			case 1:
				goto IL_0027;
			}
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00073E70 File Offset: 0x00072070
		internal JConstructor(JConstructor other, [Nullable(2)] JsonCloneSettings settings)
			: base(other, settings)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
			{
				goto IL_0044;
			}
			IL_0027:
			this.string_0 = other.Name;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
			{
				return;
			}
			IL_0044:
			switch (num)
			{
			case 0:
				goto IL_0027;
			case 1:
				break;
			default:
				goto IL_0027;
			}
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00073ED4 File Offset: 0x000720D4
		public JConstructor(string name, params object[] content)
			: this(name, content)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00073F08 File Offset: 0x00072108
		public JConstructor(string name, object content)
			: this(name)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
			{
				goto IL_0033;
			}
			IL_001B:
			this.Add(content);
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
			{
				return;
			}
			IL_0033:
			switch (num)
			{
			case 1:
				goto IL_001B;
			}
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00073F5C File Offset: 0x0007215C
		public JConstructor(string name)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
			{
				goto IL_0062;
			}
			IL_005C:
			while (name != null)
			{
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					goto IL_0062;
				}
			}
			goto IL_00B1;
			for (;;)
			{
				IL_0062:
				switch (num)
				{
				case 1:
					if (name.Length == 0)
					{
						goto IL_0081;
					}
					this.string_0 = name;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						goto Block_3;
					}
					continue;
				case 2:
					return;
				case 3:
					goto IL_0081;
				case 4:
					goto IL_00B1;
				}
				goto Block_5;
			}
			Block_3:
			return;
			Block_5:
			goto IL_005C;
			IL_0081:
			throw new ArgumentException(Class15.smethod_17(1243232956 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95), Class15.smethod_17(613139619 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6));
			IL_00B1:
			throw new ArgumentNullException(Class15.smethod_17(1953655837 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f));
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00074038 File Offset: 0x00072238
		internal override bool DeepEquals(JToken node)
		{
			JConstructor jconstructor;
			for (;;)
			{
				IL_0066:
				jconstructor = node as JConstructor;
				for (;;)
				{
					if (jconstructor != null)
					{
						goto IL_0034;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
					{
						return false;
					}
					IL_0014:
					switch (num)
					{
					case 2:
						goto IL_0076;
					case 3:
						IL_0034:
						if (this.string_0 == jconstructor.Name)
						{
							goto IL_0076;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
						{
							goto IL_0014;
						}
						break;
					case 4:
						continue;
					case 5:
						goto IL_0066;
					}
					return false;
				}
			}
			return false;
			IL_0076:
			return base.ContentsEqual(jconstructor);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00005D97 File Offset: 0x00003F97
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings = null)
		{
			return new JConstructor(this, settings);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x000740C4 File Offset: 0x000722C4
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			for (;;)
			{
				IL_00CE:
				writer.WriteStartConstructor(this.string_0);
				for (;;)
				{
					IL_00AD:
					int count = this.list_0.Count;
					int num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						goto IL_005A;
					}
					int num2;
					for (;;)
					{
						IL_007A:
						switch (num)
						{
						case 1:
						case 2:
							goto IL_005A;
						case 3:
							goto IL_002C;
						case 4:
							num2 = 0;
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
							{
								goto Block_4;
							}
							continue;
						case 5:
							return;
						case 7:
							goto IL_00AD;
						case 8:
							goto IL_00CE;
						case 9:
							goto IL_00DC;
						}
						goto Block_5;
					}
					Block_4:
					goto IL_005A;
					Block_5:
					IL_0006:
					this.list_0[num2].WriteTo(writer, converters);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
					{
						goto IL_007A;
					}
					IL_002C:
					num2++;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
					{
						goto IL_007A;
					}
					IL_005A:
					if (num2 >= count)
					{
						goto IL_00DC;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
					{
						goto IL_0006;
					}
					goto IL_007A;
				}
			}
			IL_00DC:
			writer.WriteEndConstructor();
		}

		// Token: 0x17000209 RID: 521
		[Nullable(2)]
		public override JToken this[object key]
		{
			[return: Nullable(2)]
			get
			{
				int num2;
				for (;;)
				{
					ValidationUtils.ArgumentNotNull(key, Class15.smethod_17(299944805 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e));
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
					{
						goto IL_0003;
					}
					IL_0036:
					switch (num)
					{
					case 1:
						goto IL_0084;
					case 2:
						goto IL_00AF;
					case 3:
						IL_0003:
						if (!(key is int))
						{
							goto IL_0084;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
						{
							goto IL_0036;
						}
						break;
					case 4:
						continue;
					}
					num2 = (int)key;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
					{
						goto IL_0036;
					}
					break;
				}
				goto IL_00AF;
				IL_0084:
				throw new ArgumentException(Class15.smethod_17(538787403 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa).FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				IL_00AF:
				return this.GetItem(num2);
			}
			[param: Nullable(2)]
			set
			{
				for (;;)
				{
					IL_0078:
					ValidationUtils.ArgumentNotNull(key, Class15.smethod_17(2048529809 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18));
					IL_006D:
					while (key is int)
					{
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
						{
							goto IL_0034;
						}
						int num2;
						for (;;)
						{
							IL_004D:
							switch (num)
							{
							case 1:
								return;
							case 2:
								this.SetItem(num2, value);
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
								{
									goto Block_2;
								}
								continue;
							case 3:
								goto IL_009B;
							case 4:
								goto IL_006D;
							case 5:
								goto IL_0078;
							}
							break;
						}
						IL_0034:
						num2 = (int)key;
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
						{
							goto IL_004D;
						}
						goto IL_0095;
					}
					goto IL_009B;
				}
				Block_2:
				IL_0095:
				return;
				IL_009B:
				throw new ArgumentException(Class15.smethod_17(1829580217 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae).FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
			}
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0007434C File Offset: 0x0007254C
		internal override int GetDeepHashCode()
		{
			string text;
			for (;;)
			{
				text = this.string_0;
				if (text != null)
				{
					goto IL_0030;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
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
			int num2 = 0;
			goto IL_0035;
			IL_0030:
			num2 = text.GetHashCode();
			IL_0035:
			return num2 ^ base.ContentsHashCode();
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00005DA0 File Offset: 0x00003FA0
		public new static JConstructor Load(JsonReader reader)
		{
			return JConstructor.Load(reader, null);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00074398 File Offset: 0x00072598
		public new static JConstructor Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			for (;;)
			{
				IL_0075:
				if (reader.TokenType != JsonToken.None)
				{
					goto IL_0058;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					goto Block_5;
				}
				for (;;)
				{
					IL_0030:
					switch (num)
					{
					case 1:
						if (reader.Read())
						{
							goto IL_0058;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0075;
					case 3:
						goto IL_00A3;
					case 4:
						goto IL_004C;
					}
					goto Block_3;
				}
				IL_004C:
				if (reader.TokenType == JsonToken.StartConstructor)
				{
					goto IL_00D4;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
				{
					break;
				}
				goto IL_0030;
				IL_0058:
				reader.MoveToContent();
				goto IL_004C;
			}
			goto IL_00A3;
			Block_3:
			Block_5:
			throw JsonReaderException.Create(reader, Class15.smethod_17(2071443870 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808));
			IL_00A3:
			throw JsonReaderException.Create(reader, Class15.smethod_17(1396509076 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7).FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			IL_00D4:
			JConstructor jconstructor = new JConstructor((string)reader.Value);
			jconstructor.SetLineInfo(reader as IJsonLineInfo, settings);
			jconstructor.ReadTokenFrom(reader, settings);
			return jconstructor;
		}

		// Token: 0x040006AA RID: 1706
		[Nullable(2)]
		private string string_0;

		// Token: 0x040006AB RID: 1707
		private readonly List<JToken> list_0 = new List<JToken>();
	}
}
