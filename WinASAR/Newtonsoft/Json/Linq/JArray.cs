using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200014E RID: 334
	[Nullable(0)]
	[NullableContext(1)]
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x00005D1D File Offset: 0x00003F1D
		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				return this.list_0;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x00005D25 File Offset: 0x00003F25
		public override JTokenType Type
		{
			get
			{
				return JTokenType.Array;
			}
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0007345C File Offset: 0x0007165C
		public JArray()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0007349C File Offset: 0x0007169C
		public JArray(JArray other)
			: base(other, null)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x000734DC File Offset: 0x000716DC
		internal JArray(JArray other, [Nullable(2)] JsonCloneSettings settings)
			: base(other, settings)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0007351C File Offset: 0x0007171C
		public JArray(params object[] content)
			: this(content)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00073550 File Offset: 0x00071750
		public JArray(object content)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
			{
				goto IL_003D;
			}
			IL_0025:
			this.Add(content);
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
			{
				return;
			}
			IL_003D:
			switch (num)
			{
			case 1:
				goto IL_0025;
			}
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x000735AC File Offset: 0x000717AC
		internal override bool DeepEquals(JToken node)
		{
			JArray jarray;
			for (;;)
			{
				jarray = node as JArray;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
				{
					goto IL_0003;
				}
				IL_0018:
				switch (num)
				{
				case 1:
					IL_0003:
					if (jarray == null)
					{
						return false;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
					{
						goto IL_0018;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
			return base.ContentsEqual(jarray);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00005D28 File Offset: 0x00003F28
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings = null)
		{
			return new JArray(this, settings);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00005D31 File Offset: 0x00003F31
		public new static JArray Load(JsonReader reader)
		{
			return JArray.Load(reader, null);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0007360C File Offset: 0x0007180C
		public new static JArray Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			for (;;)
			{
				if (reader.TokenType == JsonToken.None)
				{
					goto IL_0017;
				}
				goto IL_005D;
				IL_0030:
				int num;
				switch (num)
				{
				case 0:
					goto IL_005D;
				case 1:
					goto IL_0074;
				case 2:
					IL_0017:
					if (!reader.Read())
					{
						goto IL_0074;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
					{
						goto IL_0030;
					}
					goto IL_005D;
				case 3:
					continue;
				case 4:
					break;
				case 5:
					goto IL_0090;
				default:
					goto IL_005D;
				}
				IL_0050:
				if (reader.TokenType == JsonToken.StartArray)
				{
					goto IL_00C1;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
				{
					break;
				}
				goto IL_0030;
				IL_005D:
				reader.MoveToContent();
				goto IL_0050;
			}
			goto IL_0090;
			IL_0074:
			throw JsonReaderException.Create(reader, Class15.smethod_17(197545713 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81));
			IL_0090:
			throw JsonReaderException.Create(reader, Class15.smethod_17(2021137934 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8).FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			IL_00C1:
			JArray jarray = new JArray();
			jarray.SetLineInfo(reader as IJsonLineInfo, settings);
			jarray.ReadTokenFrom(reader, settings);
			return jarray;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00005D3A File Offset: 0x00003F3A
		public new static JArray Parse(string json)
		{
			return JArray.Parse(json, null);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x000736F4 File Offset: 0x000718F4
		public new static JArray Parse(string json, [Nullable(2)] JsonLoadSettings settings)
		{
			for (;;)
			{
				JsonReader jsonReader = new JsonTextReader(new StringReader(json));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
				{
					switch (num)
					{
					case 1:
						goto IL_0037;
					case 2:
						continue;
					}
					break;
				}
				goto IL_0036;
			}
			JArray jarray;
			return jarray;
			IL_0036:
			IL_0037:
			try
			{
				JsonReader jsonReader;
				JArray jarray2 = JArray.Load(jsonReader, settings);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
				{
					switch (num2)
					{
					case 1:
						goto IL_0078;
					case 2:
						goto IL_007C;
					}
				}
				while (jsonReader.Read())
				{
				}
				IL_0078:
				jarray = jarray2;
				IL_007C:;
			}
			finally
			{
				JsonReader jsonReader;
				if (jsonReader != null)
				{
					int num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
					{
						goto IL_00AC;
					}
					IL_0094:
					((IDisposable)jsonReader).Dispose();
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
					{
						goto IL_00BD;
					}
					IL_00AC:
					switch (num3)
					{
					case 1:
						goto IL_0094;
					}
				}
				IL_00BD:;
			}
			return jarray;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00005D43 File Offset: 0x00003F43
		public new static JArray FromObject(object o)
		{
			return JArray.FromObject(o, JsonSerializer.CreateDefault());
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x000737D4 File Offset: 0x000719D4
		public new static JArray FromObject(object o, JsonSerializer jsonSerializer)
		{
			JToken jtoken;
			for (;;)
			{
				IL_0032:
				jtoken = JToken.FromObjectInternal(o, jsonSerializer);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						if (jtoken.Type == JTokenType.Array)
						{
							goto IL_0081;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0032;
					}
					goto Block_2;
				}
			}
			Block_2:
			throw new ArgumentException(Class15.smethod_17(486500132 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c).FormatWith(CultureInfo.InvariantCulture, jtoken.Type));
			IL_0081:
			return (JArray)jtoken;
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0007386C File Offset: 0x00071A6C
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			for (;;)
			{
				IL_0080:
				writer.WriteStartArray();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
				{
					goto IL_0043;
				}
				int num2;
				for (;;)
				{
					IL_0057:
					switch (num)
					{
					case 1:
						goto IL_0080;
					case 2:
					case 5:
						goto IL_0031;
					case 3:
						goto IL_000B;
					case 4:
						return;
					case 6:
						goto IL_009A;
					case 7:
						num2++;
						goto IL_0031;
					}
					break;
					IL_000B:
					this.list_0[num2].WriteTo(writer, converters);
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
					{
						continue;
					}
					IL_0031:
					if (num2 >= this.list_0.Count)
					{
						goto Block_1;
					}
					goto IL_000B;
				}
				IL_0043:
				num2 = 0;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					goto IL_0057;
				}
			}
			Block_1:
			IL_009A:
			writer.WriteEndArray();
		}

		// Token: 0x17000203 RID: 515
		[Nullable(2)]
		public override JToken this[object key]
		{
			[return: Nullable(2)]
			get
			{
				for (;;)
				{
					ValidationUtils.ArgumentNotNull(key, Class15.smethod_17(543250728 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89));
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
					{
						goto IL_0020;
					}
					IL_0015:
					while (!(key is int))
					{
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
						{
							goto IL_0020;
						}
					}
					goto IL_008E;
					IL_0020:
					switch (num)
					{
					case 0:
						goto IL_0015;
					case 1:
						break;
					case 2:
						goto IL_0063;
					default:
						goto IL_0015;
					}
				}
				IL_0063:
				throw new ArgumentException(Class15.smethod_17(1042134455 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad).FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				IL_008E:
				return this.GetItem((int)key);
			}
			[param: Nullable(2)]
			set
			{
				for (;;)
				{
					IL_0041:
					ValidationUtils.ArgumentNotNull(key, Class15.smethod_17(613113181 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6));
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
					{
						break;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							if (!(key is int))
							{
								goto IL_0073;
							}
							this.SetItem((int)key, value);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
							{
								continue;
							}
							break;
						case 2:
							goto IL_0041;
						case 3:
							goto IL_0073;
						}
						goto Block_2;
					}
				}
				Block_2:
				return;
				IL_0073:
				throw new ArgumentException(Class15.smethod_17(642160092 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba).FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
			}
		}

		// Token: 0x17000204 RID: 516
		public JToken this[int index]
		{
			get
			{
				return this.GetItem(index);
			}
			set
			{
				for (;;)
				{
					this.SetItem(index, value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
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

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00073AA8 File Offset: 0x00071CA8
		[NullableContext(2)]
		internal override int IndexOfItem(JToken item)
		{
			while (item != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
				{
					switch (num)
					{
					case 0:
						return -1;
					case 1:
						break;
					case 2:
						continue;
					default:
						return -1;
					}
				}
				return this.list_0.IndexOfReference(item);
			}
			return -1;
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00073AF4 File Offset: 0x00071CF4
		internal override void MergeItem(object content, [Nullable(2)] JsonMergeSettings settings)
		{
			for (;;)
			{
				if (base.IsMultiContent(content))
				{
					goto IL_0097;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
				{
					goto IL_003F;
				}
				IL_0058:
				IEnumerable enumerable;
				switch (num)
				{
				case 0:
					goto IL_003F;
				case 1:
					continue;
				case 2:
					break;
				case 3:
					IL_0006:
					if (enumerable == null)
					{
						return;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
					{
						goto IL_0058;
					}
					break;
				case 4:
					return;
				case 5:
					goto IL_007D;
				case 6:
					return;
				default:
					goto IL_003F;
				}
				JContainer.MergeEnumerableContent(this, enumerable, settings);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
				{
					break;
				}
				goto IL_0058;
				IL_003F:
				if (content is JArray)
				{
					goto IL_0097;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
				{
					goto IL_0058;
				}
				goto IL_007D;
				IL_007E:
				IEnumerable enumerable2;
				enumerable = enumerable2;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
				{
					goto IL_0006;
				}
				goto IL_0058;
				IL_0097:
				enumerable2 = (IEnumerable)content;
				goto IL_007E;
				IL_007D:
				enumerable2 = null;
				goto IL_007E;
			}
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00005D59 File Offset: 0x00003F59
		public int IndexOf(JToken item)
		{
			return this.IndexOfItem(item);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00073BC4 File Offset: 0x00071DC4
		public void Insert(int index, JToken item)
		{
			for (;;)
			{
				this.InsertItem(index, item, false, true);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
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

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00073C00 File Offset: 0x00071E00
		public void RemoveAt(int index)
		{
			for (;;)
			{
				this.RemoveItemAt(index);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
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

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00073C38 File Offset: 0x00071E38
		public IEnumerator<JToken> GetEnumerator()
		{
			return this.Children().GetEnumerator();
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00073C54 File Offset: 0x00071E54
		public void Add(JToken item)
		{
			for (;;)
			{
				this.Add(item);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
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

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00005D62 File Offset: 0x00003F62
		public void Clear()
		{
			this.ClearItems();
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00005D6A File Offset: 0x00003F6A
		public bool Contains(JToken item)
		{
			return this.ContainsItem(item);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00073C8C File Offset: 0x00071E8C
		public void CopyTo(JToken[] array, int arrayIndex)
		{
			for (;;)
			{
				this.CopyItemsTo(array, arrayIndex);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
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

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00003453 File Offset: 0x00001653
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00005D73 File Offset: 0x00003F73
		public bool Remove(JToken item)
		{
			return this.RemoveItem(item);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00005D7C File Offset: 0x00003F7C
		internal override int GetDeepHashCode()
		{
			return base.ContentsHashCode();
		}

		// Token: 0x040006A8 RID: 1704
		private readonly List<JToken> list_0 = new List<JToken>();
	}
}
