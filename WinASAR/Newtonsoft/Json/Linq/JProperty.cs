using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000158 RID: 344
	[Nullable(0)]
	[NullableContext(1)]
	public class JProperty : JContainer
	{
		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x00006068 File Offset: 0x00004268
		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				return this.class9_0;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00006070 File Offset: 0x00004270
		public string Name
		{
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x00006078 File Offset: 0x00004278
		// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x00079930 File Offset: 0x00077B30
		public new JToken Value
		{
			get
			{
				return this.class9_0.jtoken_0;
			}
			set
			{
				JToken jtoken;
				for (;;)
				{
					base.CheckReentrancy();
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
					{
						goto IL_0054;
					}
					IL_006D:
					switch (num)
					{
					case 0:
						goto IL_0054;
					case 1:
						continue;
					case 2:
						goto IL_0039;
					case 3:
						IL_0029:
						if (this.class9_0.jtoken_0 != null)
						{
							goto Block_2;
						}
						break;
					case 4:
						return;
					case 5:
						break;
					case 6:
						return;
					case 7:
						goto IL_00B1;
					default:
						goto IL_0054;
					}
					this.InsertItem(0, jtoken, false, true);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						break;
					}
					goto IL_006D;
					IL_003E:
					JToken jtoken2;
					jtoken = jtoken2;
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
					{
						goto IL_0029;
					}
					goto IL_006D;
					IL_0054:
					jtoken2 = value;
					if (value != null)
					{
						goto IL_003E;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
					{
						goto IL_006D;
					}
					IL_0039:
					jtoken2 = JValue.CreateNull();
					goto IL_003E;
				}
				return;
				Block_2:
				IL_00B1:
				this.SetItem(0, jtoken);
			}
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x000799F8 File Offset: 0x00077BF8
		public JProperty(JProperty other)
			: base(other, null)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
			{
				goto IL_0044;
			}
			IL_0027:
			this.string_0 = other.Name;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
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

		// Token: 0x06000EDB RID: 3803 RVA: 0x00079A5C File Offset: 0x00077C5C
		internal JProperty(JProperty other, [Nullable(2)] JsonCloneSettings settings)
			: base(other, settings)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
			{
				goto IL_0047;
			}
			do
			{
				IL_0027:
				this.string_0 = other.Name;
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0);
			IL_0047:
			switch (num)
			{
			case 0:
				goto IL_0027;
			case 1:
				return;
			default:
				goto IL_0027;
			}
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00079AC0 File Offset: 0x00077CC0
		internal override JToken GetItem(int index)
		{
			while (index == 0)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
				{
					switch (num)
					{
					case 0:
						goto IL_0031;
					case 1:
						break;
					case 2:
						continue;
					default:
						goto IL_0031;
					}
				}
				return this.Value;
			}
			IL_0031:
			throw new ArgumentOutOfRangeException();
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00079B0C File Offset: 0x00077D0C
		[NullableContext(2)]
		internal override void SetItem(int index, JToken item)
		{
			JObject jobject;
			for (;;)
			{
				int num;
				if (index != 0)
				{
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
					{
						goto Block_5;
					}
				}
				else if (JContainer.IsTokenUnchanged(this.Value, item))
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
					{
						break;
					}
				}
				else
				{
					jobject = (JObject)base.Parent;
					if (jobject != null)
					{
						goto IL_009A;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
					{
						break;
					}
				}
				switch (num)
				{
				case 1:
					return;
				case 3:
					return;
				case 4:
					goto IL_0091;
				case 5:
					continue;
				case 6:
					return;
				case 7:
					goto IL_00A8;
				}
				break;
			}
			goto IL_00A0;
			Block_5:
			IL_0091:
			throw new ArgumentOutOfRangeException();
			goto IL_00A0;
			IL_009A:
			jobject.InternalPropertyChanging(this);
			IL_00A0:
			base.SetItem(0, item);
			IL_00A8:
			JObject jobject2 = (JObject)base.Parent;
			if (jobject2 == null)
			{
				return;
			}
			jobject2.InternalPropertyChanged(this);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00006085 File Offset: 0x00004285
		[NullableContext(2)]
		internal override bool RemoveItem(JToken item)
		{
			throw new JsonException(Class15.smethod_17(2128276872 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9).FormatWith(CultureInfo.InvariantCulture, typeof(JProperty)));
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x000060B5 File Offset: 0x000042B5
		internal override void RemoveItemAt(int index)
		{
			throw new JsonException(Class15.smethod_17(698956416 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a).FormatWith(CultureInfo.InvariantCulture, typeof(JProperty)));
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00079BD8 File Offset: 0x00077DD8
		[NullableContext(2)]
		internal override int IndexOfItem(JToken item)
		{
			while (item == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return -1;
			}
			return this.class9_0.IndexOf(item);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00079C20 File Offset: 0x00077E20
		[NullableContext(2)]
		internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations)
		{
			for (;;)
			{
				if (item != null)
				{
					goto IL_0030;
				}
				IL_003C:
				if (this.Value != null)
				{
					break;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
				{
					switch (num)
					{
					case 1:
						goto IL_0081;
					case 2:
						return false;
					case 3:
						goto IL_0030;
					case 4:
						continue;
					}
					break;
				}
				goto IL_004F;
				IL_0030:
				if (item.Type == JTokenType.Comment)
				{
					return false;
				}
				goto IL_003C;
			}
			goto IL_0052;
			IL_004F:
			goto IL_0081;
			IL_0052:
			throw new JsonException(Class15.smethod_17(2060625448 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177).FormatWith(CultureInfo.InvariantCulture, typeof(JProperty)));
			IL_0081:
			return base.InsertItem(0, item, false, copyAnnotations);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000060E5 File Offset: 0x000042E5
		[NullableContext(2)]
		internal override bool ContainsItem(JToken item)
		{
			return this.Value == item;
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00079CBC File Offset: 0x00077EBC
		internal override void MergeItem(object content, [Nullable(2)] JsonMergeSettings settings)
		{
			for (;;)
			{
				IL_0001:
				JProperty jproperty = content as JProperty;
				JToken jtoken;
				if (jproperty != null)
				{
					jtoken = jproperty.Value;
					goto IL_0066;
				}
				int num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
				{
					break;
				}
				JToken jtoken2;
				for (;;)
				{
					IL_007C:
					switch (num)
					{
					case 1:
					case 2:
						return;
					case 3:
						goto IL_0041;
					case 4:
						goto IL_0065;
					case 5:
						goto IL_0001;
					case 6:
						this.Value = jtoken2;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
						{
							continue;
						}
						break;
					}
					break;
				}
				goto IL_005E;
				IL_0065:
				jtoken = null;
				goto IL_0066;
				goto IL_005E;
				IL_0041:
				if (jtoken2.Type == JTokenType.Null)
				{
					break;
				}
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
				{
					goto IL_007C;
				}
				IL_005E:
				if (jtoken2 == null)
				{
					break;
				}
				goto IL_0041;
				IL_0066:
				jtoken2 = jtoken;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
				{
					goto IL_005E;
				}
				goto IL_007C;
			}
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x000060F0 File Offset: 0x000042F0
		internal override void ClearItems()
		{
			throw new JsonException(Class15.smethod_17(1603861506 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c).FormatWith(CultureInfo.InvariantCulture, typeof(JProperty)));
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00079D74 File Offset: 0x00077F74
		internal override bool DeepEquals(JToken node)
		{
			JProperty jproperty;
			for (;;)
			{
				IL_004E:
				jproperty = node as JProperty;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						if (jproperty != null)
						{
							goto IL_0003;
						}
						break;
					case 2:
						goto IL_004E;
					case 3:
						goto IL_0003;
					case 4:
						goto IL_006D;
					}
					return false;
					IL_0003:
					if (this.string_0 == jproperty.Name)
					{
						goto IL_006D;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
					{
						return false;
					}
				}
			}
			return false;
			IL_006D:
			return base.ContentsEqual(jproperty);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00006120 File Offset: 0x00004320
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings)
		{
			return new JProperty(this, settings);
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00006129 File Offset: 0x00004329
		public override JTokenType Type
		{
			get
			{
				return JTokenType.Property;
			}
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00079DF8 File Offset: 0x00077FF8
		internal JProperty(string name)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
			{
				goto IL_0051;
			}
			IL_0025:
			ValidationUtils.ArgumentNotNull(name, Class15.smethod_17(1396536430 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7));
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
			{
				goto IL_0066;
			}
			IL_0051:
			switch (num)
			{
			case 0:
				goto IL_0025;
			case 1:
				break;
			case 2:
				return;
			default:
				goto IL_0025;
			}
			IL_0066:
			this.string_0 = name;
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00079E74 File Offset: 0x00078074
		public JProperty(string name, params object[] content)
			: this(name, content)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00079EA8 File Offset: 0x000780A8
		public JProperty(string name, [Nullable(2)] object content)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
			{
				goto IL_006A;
			}
			IL_0025:
			ValidationUtils.ArgumentNotNull(name, Class15.smethod_17(82275072 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909));
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
			{
				goto IL_006A;
			}
			IL_0052:
			this.string_0 = name;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
			{
				goto IL_0083;
			}
			IL_006A:
			switch (num)
			{
			case 1:
				goto IL_0052;
			case 2:
				goto IL_0025;
			case 3:
				return;
			}
			IL_0083:
			this.Value = (base.IsMultiContent(content) ? new JArray(content) : JContainer.CreateFromContent(content));
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00079F58 File Offset: 0x00078158
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			JToken value;
			for (;;)
			{
				IL_0054:
				writer.WritePropertyName(this.string_0);
				for (;;)
				{
					value = this.Value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
					{
						goto IL_0003;
					}
					IL_0018:
					switch (num)
					{
					case 1:
						goto IL_006D;
					case 2:
						return;
					case 3:
						continue;
					case 4:
						goto IL_0054;
					case 5:
						return;
					}
					IL_0003:
					if (value == null)
					{
						goto IL_0065;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
					{
						goto IL_0018;
					}
					goto IL_0062;
				}
			}
			IL_0062:
			goto IL_006D;
			IL_0065:
			writer.WriteNull();
			return;
			IL_006D:
			value.WriteTo(writer, converters);
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0000612C File Offset: 0x0000432C
		internal override int GetDeepHashCode()
		{
			int hashCode = this.string_0.GetHashCode();
			JToken value = this.Value;
			return hashCode ^ ((value != null) ? value.GetDeepHashCode() : 0);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0000614C File Offset: 0x0000434C
		public new static JProperty Load(JsonReader reader)
		{
			return JProperty.Load(reader, null);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00079FE0 File Offset: 0x000781E0
		public new static JProperty Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			if (reader.TokenType == JsonToken.None && !reader.Read())
			{
				throw JsonReaderException.Create(reader, Class15.smethod_17(314819601 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927));
			}
			reader.MoveToContent();
			if (reader.TokenType != JsonToken.PropertyName)
			{
				throw JsonReaderException.Create(reader, Class15.smethod_17(1953635723 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f).FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			}
			JProperty jproperty = new JProperty((string)reader.Value);
			jproperty.SetLineInfo(reader as IJsonLineInfo, settings);
			jproperty.ReadTokenFrom(reader, settings);
			return jproperty;
		}

		// Token: 0x040006CF RID: 1743
		private readonly JProperty.Class9 class9_0 = new JProperty.Class9();

		// Token: 0x040006D0 RID: 1744
		private readonly string string_0;

		// Token: 0x02000159 RID: 345
		[Nullable(0)]
		private class Class9 : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
		{
			// Token: 0x06000EF2 RID: 3826 RVA: 0x00006155 File Offset: 0x00004355
			public IEnumerator<JToken> GetEnumerator()
			{
				int num;
				for (;;)
				{
					IL_00BD:
					int num2;
					num = num2;
					for (;;)
					{
						while (num == 0)
						{
							int num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
							{
								goto IL_005B;
							}
							IL_0075:
							switch (num3)
							{
							case 0:
								goto IL_005B;
							case 1:
								goto IL_0040;
							case 2:
								break;
							case 3:
								goto IL_00D2;
							case 4:
								goto IL_00CB;
							case 5:
							case 6:
								goto IL_00DB;
							case 7:
								continue;
							case 8:
								goto IL_00BD;
							case 9:
								goto IL_00CD;
							case 10:
								continue;
							default:
								goto IL_005B;
							}
							IL_0021:
							yield return this.jtoken_0;
							num3 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
							{
								goto IL_0040;
							}
							goto IL_0075;
							IL_005B:
							if (this.jtoken_0 != null)
							{
								goto IL_0021;
							}
							num3 = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
							{
								goto IL_0075;
							}
							goto IL_00C7;
							IL_0040:
							num3 = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
							{
								goto Block_2;
							}
							goto IL_0075;
						}
						goto Block_5;
					}
					IL_00CB:
					Block_2:;
				}
				Block_5:
				goto IL_00CD;
				IL_00C7:
				goto IL_00DB;
				IL_00CD:
				if (num == 1)
				{
					goto IL_00DB;
				}
				IL_00D2:
				yield break;
				IL_00DB:
				yield break;
			}

			// Token: 0x06000EF3 RID: 3827 RVA: 0x00006164 File Offset: 0x00004364
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x06000EF4 RID: 3828 RVA: 0x0007A080 File Offset: 0x00078280
			public void Add(JToken item)
			{
				for (;;)
				{
					this.jtoken_0 = item;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
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

			// Token: 0x06000EF5 RID: 3829 RVA: 0x0007A0B8 File Offset: 0x000782B8
			public void Clear()
			{
				for (;;)
				{
					this.jtoken_0 = null;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
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

			// Token: 0x06000EF6 RID: 3830 RVA: 0x0000616C File Offset: 0x0000436C
			public bool Contains(JToken item)
			{
				return this.jtoken_0 == item;
			}

			// Token: 0x06000EF7 RID: 3831 RVA: 0x0007A0F0 File Offset: 0x000782F0
			public void CopyTo(JToken[] array, int arrayIndex)
			{
				while (this.jtoken_0 == null)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
					{
						switch (num)
						{
						case 0:
							goto IL_003A;
						case 1:
						case 3:
							break;
						case 2:
							continue;
						default:
							goto IL_003A;
						}
					}
					return;
				}
				IL_003A:
				array[arrayIndex] = this.jtoken_0;
			}

			// Token: 0x06000EF8 RID: 3832 RVA: 0x0007A140 File Offset: 0x00078340
			public bool Remove(JToken item)
			{
				while (this.jtoken_0 == item)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
					{
						goto IL_0015;
					}
					IL_002D:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return true;
					}
					IL_0015:
					this.jtoken_0 = null;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
					{
						goto IL_002D;
					}
				}
				return false;
			}

			// Token: 0x1700022F RID: 559
			// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x0007A1A0 File Offset: 0x000783A0
			public int Count
			{
				get
				{
					while (this.jtoken_0 != null)
					{
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
						{
							switch (num)
							{
							case 1:
								continue;
							case 2:
								return 0;
							}
						}
						return 1;
					}
					return 0;
				}
			}

			// Token: 0x17000230 RID: 560
			// (get) Token: 0x06000EFA RID: 3834 RVA: 0x00003453 File Offset: 0x00001653
			public bool IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06000EFB RID: 3835 RVA: 0x0007A1E4 File Offset: 0x000783E4
			public int IndexOf(JToken item)
			{
				while (this.jtoken_0 != item)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return -1;
				}
				return 0;
			}

			// Token: 0x06000EFC RID: 3836 RVA: 0x0007A228 File Offset: 0x00078428
			public void Insert(int index, JToken item)
			{
				for (;;)
				{
					if (index == 0)
					{
						goto IL_0003;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
					{
						break;
					}
					IL_001B:
					switch (num)
					{
					case 1:
						IL_0003:
						this.jtoken_0 = item;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
						{
							goto IL_001B;
						}
						break;
					case 3:
						continue;
					}
					break;
				}
			}

			// Token: 0x06000EFD RID: 3837 RVA: 0x0007A288 File Offset: 0x00078488
			public void RemoveAt(int index)
			{
				IL_0033:
				while (index == 0)
				{
					for (;;)
					{
						this.jtoken_0 = null;
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
						{
							break;
						}
						switch (num)
						{
						case 1:
						case 2:
							return;
						case 3:
							goto IL_0033;
						}
					}
					return;
				}
			}

			// Token: 0x17000231 RID: 561
			public JToken this[int index]
			{
				get
				{
					while (index == 0)
					{
						int num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
						{
							switch (num)
							{
							case 0:
								goto IL_0031;
							case 1:
								break;
							case 2:
								continue;
							default:
								goto IL_0031;
							}
						}
						return this.jtoken_0;
					}
					IL_0031:
					throw new IndexOutOfRangeException();
				}
				set
				{
					IL_0033:
					while (index == 0)
					{
						for (;;)
						{
							this.jtoken_0 = value;
							int num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
							{
								switch (num)
								{
								case 1:
									goto IL_003C;
								case 2:
									continue;
								case 3:
									goto IL_0033;
								}
								break;
							}
							break;
						}
						return;
					}
					IL_003C:
					throw new IndexOutOfRangeException();
				}
			}

			// Token: 0x06000F00 RID: 3840 RVA: 0x0007A36C File Offset: 0x0007856C
			public Class9()
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
				{
					switch (num)
					{
					}
				}
			}

			// Token: 0x040006D2 RID: 1746
			[Nullable(2)]
			internal JToken jtoken_0;
		}
	}
}
