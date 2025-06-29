using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000150 RID: 336
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, IList, ICollection, INotifyCollectionChanged
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000DF8 RID: 3576 RVA: 0x000744A0 File Offset: 0x000726A0
		// (remove) Token: 0x06000DF9 RID: 3577 RVA: 0x000744E8 File Offset: 0x000726E8
		public event ListChangedEventHandler ListChanged
		{
			add
			{
				for (;;)
				{
					this._listChanged = (ListChangedEventHandler)Delegate.Combine(this._listChanged, value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
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
			remove
			{
				for (;;)
				{
					this._listChanged = (ListChangedEventHandler)Delegate.Remove(this._listChanged, value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
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

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000DFA RID: 3578 RVA: 0x00074530 File Offset: 0x00072730
		// (remove) Token: 0x06000DFB RID: 3579 RVA: 0x00074578 File Offset: 0x00072778
		public event AddingNewEventHandler AddingNew
		{
			add
			{
				for (;;)
				{
					this._addingNew = (AddingNewEventHandler)Delegate.Combine(this._addingNew, value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
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
			remove
			{
				for (;;)
				{
					this._addingNew = (AddingNewEventHandler)Delegate.Remove(this._addingNew, value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
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

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000DFC RID: 3580 RVA: 0x000745C0 File Offset: 0x000727C0
		// (remove) Token: 0x06000DFD RID: 3581 RVA: 0x00074608 File Offset: 0x00072808
		[Nullable(2)]
		public event NotifyCollectionChangedEventHandler CollectionChanged
		{
			[NullableContext(2)]
			add
			{
				for (;;)
				{
					this._collectionChanged = (NotifyCollectionChangedEventHandler)Delegate.Combine(this._collectionChanged, value);
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
			[NullableContext(2)]
			remove
			{
				for (;;)
				{
					this._collectionChanged = (NotifyCollectionChangedEventHandler)Delegate.Remove(this._collectionChanged, value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
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

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000DFE RID: 3582
		protected abstract IList<JToken> ChildrenTokens { get; }

		// Token: 0x06000DFF RID: 3583 RVA: 0x00074650 File Offset: 0x00072850
		internal JContainer()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00074684 File Offset: 0x00072884
		internal JContainer(JContainer other, [Nullable(2)] JsonCloneSettings settings)
			: this()
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(other, Class15.smethod_17(1396509010 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
				{
					goto IL_000A;
				}
				IL_001E:
				switch (num)
				{
				case 1:
					goto IL_0086;
				case 2:
					goto IL_0098;
				case 3:
					goto IL_008D;
				case 4:
					goto IL_00A0;
				case 5:
					return;
				case 6:
					goto IL_0089;
				case 7:
					IL_000A:
					if (settings == null)
					{
						goto IL_0086;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
					{
						goto IL_001E;
					}
					break;
				case 8:
					continue;
				case 9:
					goto IL_0095;
				}
				break;
			}
			bool flag = settings.CopyAnnotations;
			goto IL_0087;
			IL_0086:
			flag = true;
			IL_0087:
			bool flag2 = flag;
			IL_0089:
			if (!flag2)
			{
				goto IL_0095;
			}
			IL_008D:
			base.CopyAnnotations(this, other);
			IL_0095:
			int num2 = 0;
			IL_0098:
			IEnumerator<JToken> enumerator = ((IEnumerable<JToken>)other).GetEnumerator();
			IL_00A0:
			try
			{
				for (;;)
				{
					if (enumerator.MoveNext())
					{
						goto IL_00FF;
					}
					int num3 = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
					{
						break;
					}
					goto IL_00E3;
					IL_00A7:
					num2++;
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
					{
						continue;
					}
					goto IL_00E3;
					IL_00C1:
					JToken jtoken;
					this.TryAddInternal(num2, jtoken, false, flag2);
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
					{
						goto IL_00A7;
					}
					IL_00E3:
					switch (num3)
					{
					case 0:
						goto IL_00C1;
					case 1:
						goto IL_00A7;
					case 2:
						IL_00FF:
						jtoken = enumerator.Current;
						num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
						{
							goto IL_00C1;
						}
						goto IL_00E3;
					case 3:
						break;
					case 4:
						goto IL_0140;
					default:
						goto IL_00C1;
					}
				}
				IL_0140:;
			}
			finally
			{
				if (enumerator != null)
				{
					goto IL_016E;
				}
				int num4 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
				{
					goto IL_0187;
				}
				IL_015A:
				switch (num4)
				{
				case 2:
					IL_016E:
					enumerator.Dispose();
					num4 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
					{
						goto IL_015A;
					}
					break;
				}
				IL_0187:;
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0007482C File Offset: 0x00072A2C
		internal void CheckReentrancy()
		{
			while (!this.bool_0)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
				{
					switch (num)
					{
					case 0:
						goto IL_0036;
					case 1:
						break;
					case 2:
						continue;
					default:
						goto IL_0036;
					}
				}
				return;
			}
			IL_0036:
			throw new InvalidOperationException(Class15.smethod_17(277658640 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98).FormatWith(CultureInfo.InvariantCulture, base.GetType()));
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00005DA9 File Offset: 0x00003FA9
		internal virtual IList<JToken> CreateChildrenCollection()
		{
			return new List<JToken>();
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0007489C File Offset: 0x00072A9C
		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
			for (;;)
			{
				AddingNewEventHandler addingNew = this._addingNew;
				int num;
				if (addingNew != null)
				{
					addingNew(this, e);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
					{
						break;
					}
				}
				else
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
					{
						goto Block_2;
					}
				}
				switch (num)
				{
				case 1:
					return;
				case 2:
					continue;
				}
				break;
			}
			return;
			Block_2:;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x000748F8 File Offset: 0x00072AF8
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
			for (;;)
			{
				IL_0056:
				ListChangedEventHandler listChanged = this._listChanged;
				for (;;)
				{
					if (listChanged != null)
					{
						goto IL_0003;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
					{
						goto Block_2;
					}
					IL_001B:
					switch (num)
					{
					case 1:
						goto IL_0064;
					case 3:
						IL_0003:
						this.bool_0 = true;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
						{
							goto IL_001B;
						}
						goto IL_0063;
					case 4:
						continue;
					case 5:
						goto IL_0056;
					}
					goto Block_1;
				}
			}
			Block_1:
			Block_2:
			return;
			IL_0063:
			IL_0064:
			try
			{
				ListChangedEventHandler listChanged;
				listChanged(this, e);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
				{
					switch (num2)
					{
					}
				}
			}
			finally
			{
				this.bool_0 = false;
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
				{
					switch (num3)
					{
					}
				}
			}
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x000749C8 File Offset: 0x00072BC8
		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
			NotifyCollectionChangedEventHandler collectionChanged;
			for (;;)
			{
				IL_0056:
				collectionChanged = this._collectionChanged;
				for (;;)
				{
					if (collectionChanged != null)
					{
						goto IL_0003;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						goto IL_0060;
					}
					IL_001B:
					switch (num)
					{
					case 1:
					case 5:
						return;
					case 2:
						continue;
					case 3:
						goto IL_0056;
					case 4:
						IL_0003:
						this.bool_0 = true;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
						{
							goto IL_001B;
						}
						break;
					}
					goto Block_1;
				}
			}
			Block_1:
			goto IL_0064;
			IL_0060:
			return;
			IL_0064:
			try
			{
				collectionChanged(this, e);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
				{
					switch (num2)
					{
					}
				}
			}
			finally
			{
				this.bool_0 = false;
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
				{
					switch (num3)
					{
					}
				}
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x00005DB0 File Offset: 0x00003FB0
		public override bool HasValues
		{
			get
			{
				return this.ChildrenTokens.Count > 0;
			}
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00074A98 File Offset: 0x00072C98
		internal bool ContentsEqual(JContainer container)
		{
			for (;;)
			{
				IL_0107:
				IList<JToken> childrenTokens;
				if (container != this)
				{
					childrenTokens = this.ChildrenTokens;
					goto IL_00D4;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					return true;
				}
				int num2;
				IList<JToken> childrenTokens2;
				for (;;)
				{
					IL_00A0:
					switch (num)
					{
					case 1:
						return true;
					case 2:
						goto IL_0107;
					case 3:
						goto IL_0070;
					case 4:
						goto IL_00D4;
					case 5:
					case 10:
						goto IL_0013;
					case 6:
					case 8:
						if (childrenTokens[num2].DeepEquals(childrenTokens2[num2]))
						{
							goto IL_0068;
						}
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
						{
							goto Block_4;
						}
						continue;
					case 7:
						return false;
					case 9:
						return false;
					}
					goto Block_7;
				}
				IL_0068:
				num2++;
				IL_0013:
				if (num2 >= childrenTokens.Count)
				{
					return true;
				}
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
				{
					continue;
				}
				goto IL_00A0;
				IL_0070:
				if (childrenTokens.Count != childrenTokens2.Count)
				{
					goto Block_5;
				}
				num2 = 0;
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
				{
					goto IL_0013;
				}
				goto IL_00A0;
				IL_00D4:
				childrenTokens2 = container.ChildrenTokens;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
				{
					goto IL_0070;
				}
				goto IL_00A0;
			}
			Block_4:
			return false;
			Block_5:
			return false;
			Block_7:
			return true;
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x00074BC0 File Offset: 0x00072DC0
		[Nullable(2)]
		public override JToken First
		{
			[NullableContext(2)]
			get
			{
				IList<JToken> childrenTokens;
				for (;;)
				{
					childrenTokens = this.ChildrenTokens;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
					{
						goto IL_0003;
					}
					IL_001E:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_005A;
					}
					IL_0003:
					if (childrenTokens.Count > 0)
					{
						goto IL_0051;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
					{
						goto IL_001E;
					}
					break;
				}
				goto IL_005A;
				IL_0051:
				return childrenTokens[0];
				IL_005A:
				return null;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00074C28 File Offset: 0x00072E28
		[Nullable(2)]
		public override JToken Last
		{
			[NullableContext(2)]
			get
			{
				IList<JToken> childrenTokens;
				int count;
				for (;;)
				{
					childrenTokens = this.ChildrenTokens;
					int num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
					{
						goto IL_001C;
					}
					IL_0027:
					switch (num)
					{
					case 1:
						goto IL_0060;
					case 2:
						IL_001C:
						count = childrenTokens.Count;
						goto IL_0003;
					case 3:
						continue;
					case 4:
						goto IL_0003;
					}
					goto Block_3;
					IL_0003:
					if (count <= 0)
					{
						goto IL_006C;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
					{
						break;
					}
					goto IL_0027;
				}
				goto IL_0060;
				Block_3:
				goto IL_006C;
				IL_0060:
				return childrenTokens[count - 1];
				IL_006C:
				return null;
			}
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00005DC0 File Offset: 0x00003FC0
		[return: Nullable(new byte[] { 0, 1 })]
		public override JEnumerable<JToken> Children()
		{
			return new JEnumerable<JToken>(this.ChildrenTokens);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00005DCD File Offset: 0x00003FCD
		[NullableContext(2)]
		[return: Nullable(new byte[] { 1, 2 })]
		public override IEnumerable<T> Values<T>()
		{
			return this.ChildrenTokens.Convert<JToken, T>();
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00005DDA File Offset: 0x00003FDA
		public IEnumerable<JToken> Descendants()
		{
			return this.GetDescendants(false);
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00005DE3 File Offset: 0x00003FE3
		public IEnumerable<JToken> DescendantsAndSelf()
		{
			return this.GetDescendants(true);
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00005DEC File Offset: 0x00003FEC
		internal IEnumerable<JToken> GetDescendants(bool self)
		{
			JContainer.<GetDescendants>d__34 <GetDescendants>d__ = new JContainer.<GetDescendants>d__34(-2);
			<GetDescendants>d__.<>4__this = this;
			<GetDescendants>d__.<>3__self = self;
			return <GetDescendants>d__;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00074CA4 File Offset: 0x00072EA4
		[NullableContext(2)]
		internal bool IsMultiContent([NotNullWhen(true)] object content)
		{
			while (content is IEnumerable)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
				{
					goto IL_0015;
				}
				goto IL_004E;
				IL_0043:
				while (!(content is JToken))
				{
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
					{
						goto IL_004E;
					}
				}
				break;
				IL_004E:
				switch (num)
				{
				case 0:
					goto IL_0043;
				case 1:
					IL_0015:
					if (content is string)
					{
						return false;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
					{
						goto IL_0043;
					}
					goto IL_004E;
				case 2:
					break;
				case 3:
					return !(content is byte[]);
				default:
					goto IL_0043;
				}
			}
			return false;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00074D30 File Offset: 0x00072F30
		internal JToken EnsureParentToken([Nullable(2)] JToken item, bool skipParentCheck, bool copyAnnotations)
		{
			IL_00D5:
			while (item != null)
			{
				int num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
				{
					goto IL_001D;
				}
				for (;;)
				{
					IL_0092:
					switch (num)
					{
					case 1:
						goto IL_0083;
					case 2:
						goto IL_001D;
					case 3:
					case 7:
						return item;
					case 4:
						return item;
					case 5:
					case 13:
						goto IL_001A;
					case 6:
						goto IL_008B;
					case 8:
						goto IL_0062;
					case 9:
						if (skipParentCheck)
						{
							return item;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
						{
							goto IL_0083;
						}
						continue;
					case 10:
						goto IL_00D5;
					case 11:
						goto IL_005A;
					case 12:
						goto IL_00E3;
					}
					break;
				}
				goto IL_0039;
				IL_001A:
				if (!copyAnnotations)
				{
					goto IL_001D;
				}
				JsonCloneSettings jsonCloneSettings = null;
				goto IL_0025;
				IL_008B:
				if (item != this)
				{
					goto IL_005A;
				}
				goto IL_001A;
				IL_0083:
				if (item.Parent == null)
				{
					goto IL_008B;
				}
				goto IL_001A;
				IL_0062:
				if (base.Root == item)
				{
					goto IL_001A;
				}
				return item;
				IL_005A:
				if (item.HasValues)
				{
					goto IL_0062;
				}
				return item;
				IL_0025:
				JsonCloneSettings jsonCloneSettings2 = jsonCloneSettings;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
				{
					goto IL_0039;
				}
				goto IL_0092;
				IL_001D:
				jsonCloneSettings = JsonCloneSettings.SkipCopyAnnotations;
				goto IL_0025;
				IL_0039:
				item = item.CloneToken(jsonCloneSettings2);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
				{
					goto IL_0092;
				}
				return item;
			}
			IL_00E3:
			return JValue.CreateNull();
		}

		// Token: 0x06000E11 RID: 3601
		[NullableContext(2)]
		internal abstract int IndexOfItem(JToken item);

		// Token: 0x06000E12 RID: 3602 RVA: 0x00074E28 File Offset: 0x00073028
		[NullableContext(2)]
		internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations)
		{
			for (;;)
			{
				IL_020E:
				IList<JToken> childrenTokens = this.ChildrenTokens;
				int num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
				{
					goto IL_0105;
				}
				JToken jtoken2;
				JToken jtoken3;
				for (;;)
				{
					IL_019B:
					JToken jtoken;
					switch (num)
					{
					case 1:
						this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, index));
						num = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
						{
							continue;
						}
						goto IL_0230;
					case 2:
					case 23:
						goto IL_009A;
					case 3:
						goto IL_00DF;
					case 4:
					case 18:
						goto IL_000A;
					case 6:
						goto IL_00D9;
					case 7:
						return true;
					case 8:
						goto IL_0042;
					case 9:
						IL_016F:
						this.ValidateToken(item, null);
						goto IL_014C;
					case 10:
						goto IL_0027;
					case 11:
						goto IL_005F;
					case 12:
						goto IL_012C;
					case 13:
						goto IL_0162;
					case 14:
						goto IL_0085;
					case 15:
						goto IL_0234;
					case 16:
						if (index != childrenTokens.Count)
						{
							goto IL_0162;
						}
						jtoken = null;
						goto IL_016D;
					case 17:
						goto IL_008D;
					case 19:
						goto IL_014C;
					case 20:
						goto IL_00DC;
					case 21:
						goto IL_0105;
					case 22:
						goto IL_020E;
					case 24:
						goto IL_00BC;
					case 25:
						if (jtoken2 == null)
						{
							goto IL_000A;
						}
						goto IL_0042;
					}
					break;
					IL_000A:
					item.Next = jtoken3;
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
					{
						continue;
					}
					IL_0027:
					if (jtoken3 != null)
					{
						goto IL_005F;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
					{
						break;
					}
					continue;
					IL_0042:
					jtoken2.Next = item;
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
					{
						goto IL_005F;
					}
					continue;
					IL_00BC:
					item.Previous = jtoken2;
					num = 25;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
					{
						goto IL_00D9;
					}
					continue;
					IL_014C:
					item.Parent = this;
					goto IL_00BC;
					IL_016D:
					jtoken3 = jtoken;
					goto IL_016F;
					IL_0162:
					jtoken = childrenTokens[index];
					goto IL_016D;
				}
				goto IL_0067;
				IL_00D9:
				if (index != 0)
				{
					goto IL_00DF;
				}
				IL_00DC:
				JToken jtoken4 = null;
				goto IL_00E9;
				IL_0067:
				childrenTokens.Insert(index, item);
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
				{
					goto IL_0085;
				}
				goto IL_019B;
				IL_005F:
				jtoken3.Previous = item;
				goto IL_0067;
				IL_009A:
				if (this._collectionChanged == null)
				{
					return true;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
				{
					goto IL_0067;
				}
				goto IL_019B;
				IL_008D:
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, index));
				goto IL_009A;
				IL_0085:
				if (this._listChanged != null)
				{
					goto IL_008D;
				}
				goto IL_009A;
				IL_00E9:
				jtoken2 = jtoken4;
				num = 16;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
				{
					goto IL_005F;
				}
				goto IL_019B;
				IL_00DF:
				jtoken4 = childrenTokens[index - 1];
				goto IL_00E9;
				IL_0105:
				if (index > childrenTokens.Count)
				{
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
					{
						break;
					}
					goto IL_019B;
				}
				else
				{
					this.CheckReentrancy();
				}
				IL_012C:
				item = this.EnsureParentToken(item, skipParentCheck, copyAnnotations);
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
				{
					goto IL_00DF;
				}
				goto IL_019B;
			}
			goto IL_0234;
			IL_0230:
			return true;
			IL_0234:
			throw new ArgumentOutOfRangeException(Class15.smethod_17(649977186 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff), Class15.smethod_17(82253748 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909));
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0007509C File Offset: 0x0007329C
		internal virtual void RemoveItemAt(int index)
		{
			for (;;)
			{
				IL_01E3:
				IList<JToken> childrenTokens = this.ChildrenTokens;
				IL_01D8:
				while (index >= 0)
				{
					int num = 22;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
					{
						goto IL_00EB;
					}
					JToken jtoken;
					JToken jtoken2;
					for (;;)
					{
						IL_0161:
						switch (num)
						{
						case 1:
							IL_00CD:
							if (index == childrenTokens.Count - 1)
							{
								goto IL_00F7;
							}
							num = 5;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
							{
								goto IL_00EB;
							}
							continue;
						case 2:
						case 8:
							goto IL_002D;
						case 3:
						case 10:
							return;
						case 4:
							goto IL_0133;
						case 5:
							goto IL_01D8;
						case 6:
							goto IL_01E3;
						case 7:
						case 23:
							goto IL_00A5;
						case 9:
							goto IL_00EB;
						case 11:
							goto IL_0157;
						case 12:
							goto IL_01ED;
						case 13:
							jtoken.Previous = null;
							goto IL_0157;
						case 14:
							goto IL_007F;
						case 15:
							goto IL_013E;
						case 16:
							goto IL_0114;
						case 17:
							goto IL_0038;
						case 18:
							goto IL_011E;
						case 19:
							goto IL_00FA;
						case 20:
							goto IL_0136;
						case 21:
							goto IL_021D;
						case 22:
							if (index < childrenTokens.Count)
							{
								this.CheckReentrancy();
								goto IL_0114;
							}
							goto IL_01ED;
						case 24:
							goto IL_00AC;
						case 25:
							goto IL_0061;
						case 26:
							goto IL_0020;
						}
						break;
						IL_0038:
						this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, jtoken, index));
						num = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
						{
							goto Block_2;
						}
						continue;
						IL_002D:
						if (this._collectionChanged != null)
						{
							goto IL_0038;
						}
						return;
						IL_0020:
						this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
						goto IL_002D;
						IL_013E:
						if (this._listChanged == null)
						{
							goto IL_002D;
						}
						goto IL_0020;
						IL_0136:
						childrenTokens.RemoveAt(index);
						goto IL_013E;
						IL_0157:
						jtoken.Next = null;
						goto IL_0136;
						IL_00B6:
						JToken jtoken3;
						jtoken2 = jtoken3;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
						{
							goto IL_00CD;
						}
						continue;
						IL_0133:
						jtoken3 = null;
						goto IL_00B6;
						IL_00AC:
						jtoken3 = childrenTokens[index - 1];
						goto IL_00B6;
						IL_011E:
						if (index != 0)
						{
							goto IL_00AC;
						}
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
						{
							goto IL_0133;
						}
						continue;
						IL_0114:
						jtoken = childrenTokens[index];
						goto IL_011E;
					}
					goto IL_009C;
					Block_2:
					goto IL_01E3;
					IL_00F7:
					JToken jtoken4 = null;
					goto IL_00F8;
					IL_0061:
					JToken jtoken5;
					jtoken5.Previous = jtoken2;
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
					{
						goto IL_007F;
					}
					goto IL_0161;
					IL_00A5:
					if (jtoken5 != null)
					{
						goto IL_0061;
					}
					goto IL_007F;
					IL_00FA:
					if (jtoken2 == null)
					{
						goto IL_00A5;
					}
					goto IL_009C;
					IL_00F8:
					jtoken5 = jtoken4;
					goto IL_00FA;
					IL_00EB:
					jtoken4 = childrenTokens[index + 1];
					goto IL_00F8;
					IL_009C:
					jtoken2.Next = jtoken5;
					goto IL_00A5;
					IL_007F:
					jtoken.Parent = null;
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						goto IL_009C;
					}
					goto IL_0161;
				}
				goto IL_021D;
			}
			IL_01ED:
			throw new ArgumentOutOfRangeException(Class15.smethod_17(2071415550 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808), Class15.smethod_17(2057029751 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48));
			IL_021D:
			throw new ArgumentOutOfRangeException(Class15.smethod_17(1760326535 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039), Class15.smethod_17(1471412245 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e));
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x000752F8 File Offset: 0x000734F8
		[NullableContext(2)]
		internal virtual bool RemoveItem(JToken item)
		{
			for (;;)
			{
				if (item != null)
				{
					goto IL_004B;
				}
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
				{
					goto Block_5;
				}
				IL_0027:
				int num2;
				switch (num)
				{
				case 0:
					goto IL_001F;
				case 1:
					IL_004B:
					num2 = this.IndexOfItem(item);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
					{
						goto IL_001F;
					}
					goto IL_0027;
				case 2:
					break;
				case 3:
					return true;
				case 4:
				case 5:
					return false;
				case 6:
					continue;
				default:
					goto IL_001F;
				}
				IL_0003:
				this.RemoveItemAt(num2);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
				{
					break;
				}
				goto IL_0027;
				IL_001F:
				if (num2 < 0)
				{
					goto Block_2;
				}
				goto IL_0003;
			}
			return true;
			Block_2:
			Block_5:
			return false;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00005E03 File Offset: 0x00004003
		internal virtual JToken GetItem(int index)
		{
			return this.ChildrenTokens[index];
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00075390 File Offset: 0x00073590
		[NullableContext(2)]
		internal virtual void SetItem(int index, JToken item)
		{
			for (;;)
			{
				IL_02B1:
				IList<JToken> childrenTokens = this.ChildrenTokens;
				IL_02A6:
				while (index >= 0)
				{
					int num = 23;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
					{
						goto IL_003F;
					}
					goto IL_0223;
					IL_00AD:
					while (this._listChanged != null)
					{
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
						{
							goto IL_0223;
						}
					}
					goto IL_00B5;
					JToken jtoken;
					JToken jtoken3;
					JToken jtoken4;
					for (;;)
					{
						IL_0223:
						JToken jtoken2;
						switch (num)
						{
						case 1:
							this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, item, jtoken, index));
							num = 6;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
							{
								continue;
							}
							goto IL_02BB;
						case 2:
							goto IL_00AD;
						case 3:
							goto IL_00B5;
						case 4:
							goto IL_0192;
						case 5:
							goto IL_02A6;
						case 6:
							goto IL_02B1;
						case 7:
							return;
						case 8:
							goto IL_008E;
						case 9:
							jtoken2 = childrenTokens[index + 1];
							goto IL_00E3;
						case 10:
							IL_00E5:
							item.Parent = this;
							num = 29;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
							{
								goto IL_0101;
							}
							continue;
						case 11:
							goto IL_02BF;
						case 12:
							goto IL_010A;
						case 13:
							goto IL_003F;
						case 14:
							goto IL_0175;
						case 15:
							goto IL_02F0;
						case 16:
							return;
						case 17:
							goto IL_0070;
						case 18:
							goto IL_010D;
						case 19:
							goto IL_0155;
						case 20:
							goto IL_0101;
						case 21:
						case 22:
							goto IL_0047;
						case 23:
							if (index < childrenTokens.Count)
							{
								jtoken = childrenTokens[index];
								goto IL_0142;
							}
							num = 6;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
							{
								goto Block_10;
							}
							continue;
						case 24:
							jtoken.Parent = null;
							goto IL_0175;
						case 25:
							goto IL_0142;
						case 26:
							IL_011C:
							if (index == childrenTokens.Count - 1)
							{
								jtoken2 = null;
								goto IL_00E3;
							}
							num = 9;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
							{
								goto Block_6;
							}
							continue;
						case 27:
							goto IL_0053;
						case 28:
							goto IL_004F;
						case 29:
							item.Previous = jtoken3;
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
							{
								continue;
							}
							break;
						}
						break;
						IL_00E3:
						jtoken4 = jtoken2;
						goto IL_00E5;
						IL_011A:
						JToken jtoken5;
						jtoken3 = jtoken5;
						goto IL_011C;
						IL_010A:
						if (index != 0)
						{
							goto IL_010D;
						}
						jtoken5 = null;
						goto IL_011A;
						IL_0101:
						this.ValidateToken(item, jtoken);
						goto IL_010A;
						IL_010D:
						jtoken5 = childrenTokens[index - 1];
						goto IL_011A;
						IL_0155:
						item = this.EnsureParentToken(item, false, true);
						num = 20;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
						{
							goto IL_0175;
						}
						continue;
						IL_0142:
						if (!JContainer.IsTokenUnchanged(jtoken, item))
						{
							this.CheckReentrancy();
							goto IL_0155;
						}
						return;
						IL_0175:
						jtoken.Previous = null;
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
						{
							continue;
						}
						IL_0192:
						this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, index));
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
						{
							goto Block_8;
						}
					}
					goto IL_00D5;
					Block_8:
					goto IL_00B5;
					Block_6:
					goto IL_02B1;
					goto IL_00D5;
					IL_0053:
					jtoken4.Previous = item;
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
					{
						goto IL_0070;
					}
					goto IL_0223;
					IL_004F:
					if (jtoken4 != null)
					{
						goto IL_0053;
					}
					goto IL_0070;
					IL_0047:
					item.Next = jtoken4;
					goto IL_004F;
					IL_00D5:
					if (jtoken3 == null)
					{
						goto IL_0047;
					}
					IL_003F:
					jtoken3.Next = item;
					goto IL_0047;
					IL_0070:
					childrenTokens[index] = item;
					num = 24;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
					{
						goto IL_0223;
					}
					IL_008E:
					jtoken.Next = null;
					goto IL_00AD;
					IL_00B5:
					if (this._collectionChanged == null)
					{
						return;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
					{
						goto IL_00D5;
					}
					goto IL_0223;
				}
				goto IL_02F0;
			}
			Block_10:
			goto IL_02BF;
			IL_02BB:
			return;
			IL_02BF:
			throw new ArgumentOutOfRangeException(Class15.smethod_17(2128243238 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9), Class15.smethod_17(277658884 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98));
			IL_02F0:
			throw new ArgumentOutOfRangeException(Class15.smethod_17(552193306 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f), Class15.smethod_17(1678081154 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a));
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000756C0 File Offset: 0x000738C0
		internal virtual void ClearItems()
		{
			for (;;)
			{
				IL_017F:
				this.CheckReentrancy();
				for (;;)
				{
					IL_0175:
					IList<JToken> childrenTokens = this.ChildrenTokens;
					for (;;)
					{
						IL_016A:
						IEnumerator<JToken> enumerator = childrenTokens.GetEnumerator();
						for (;;)
						{
							IL_0164:
							try
							{
								for (;;)
								{
									if (enumerator.MoveNext())
									{
										goto IL_0009;
									}
									int num = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
									{
										goto IL_0009;
									}
									IL_0035:
									switch (num)
									{
									case 1:
										goto IL_006C;
									case 2:
										continue;
									}
									IL_0009:
									JToken jtoken = enumerator.Current;
									jtoken.Parent = null;
									jtoken.Previous = null;
									jtoken.Next = null;
									num = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
									{
										goto IL_0035;
									}
								}
								IL_006C:
								goto IL_015B;
							}
							finally
							{
								int num2;
								if (enumerator == null)
								{
									num2 = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
									{
										goto IL_00B5;
									}
									goto IL_0089;
								}
								do
								{
									IL_009A:
									enumerator.Dispose();
									num2 = 2;
								}
								while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0);
								IL_0089:
								switch (num2)
								{
								default:
									goto IL_009A;
								case 1:
								case 2:
									IL_00B5:
									break;
								}
							}
							goto IL_00B6;
							int num3;
							for (;;)
							{
								IL_00EA:
								switch (num3)
								{
								case 1:
									return;
								case 2:
									goto IL_0129;
								case 3:
								case 6:
									goto IL_011E;
								case 4:
									goto IL_0175;
								case 5:
									goto IL_017F;
								case 7:
									this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
									num3 = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
									{
										continue;
									}
									break;
								case 8:
									goto IL_014C;
								case 9:
									goto IL_016A;
								case 10:
									goto IL_0164;
								}
								break;
							}
							goto IL_015B;
							IL_00B6:
							num3 = 7;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
							{
								goto IL_015B;
							}
							goto IL_00EA;
							IL_014C:
							if (this._listChanged != null)
							{
								goto IL_0129;
							}
							num3 = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
							{
								goto IL_011E;
							}
							goto IL_00EA;
							IL_015B:
							childrenTokens.Clear();
							goto IL_014C;
							IL_011E:
							if (this._collectionChanged != null)
							{
								goto IL_00B6;
							}
							return;
							IL_0129:
							this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
							goto IL_011E;
						}
					}
				}
			}
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00075864 File Offset: 0x00073A64
		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
			while (existing != null)
			{
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
				{
					goto IL_0015;
				}
				IL_0055:
				int num2;
				switch (num)
				{
				case 0:
					return;
				case 1:
					return;
				case 2:
					break;
				case 3:
					IL_0015:
					if (existing.Parent != this)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
						{
							return;
						}
						goto IL_0055;
					}
					else
					{
						num2 = this.IndexOfItem(existing);
					}
					break;
				case 4:
					continue;
				default:
					return;
				}
				this.SetItem(num2, replacement);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
				{
					goto IL_0055;
				}
				return;
			}
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00005E11 File Offset: 0x00004011
		[NullableContext(2)]
		internal virtual bool ContainsItem(JToken item)
		{
			return this.IndexOfItem(item) != -1;
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x000758F0 File Offset: 0x00073AF0
		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
			for (;;)
			{
				int num;
				if (array == null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
					{
						goto Block_5;
					}
				}
				else
				{
					if (arrayIndex < 0)
					{
						goto IL_0199;
					}
					if (arrayIndex >= array.Length)
					{
						goto IL_0061;
					}
					goto IL_0064;
				}
				IL_002D:
				switch (num)
				{
				case 1:
					goto IL_00CF;
				case 2:
					goto IL_0199;
				case 3:
					goto IL_017E;
				case 4:
					return;
				case 5:
					goto IL_0098;
				case 6:
					continue;
				case 7:
					goto IL_00D2;
				case 8:
					goto IL_0064;
				case 9:
					goto IL_00DF;
				case 10:
					IL_0061:
					if (arrayIndex == 0)
					{
						goto IL_0064;
					}
					break;
				}
				break;
				IL_0064:
				if (this.Count > array.Length - arrayIndex)
				{
					goto IL_017E;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
				{
					goto IL_002D;
				}
				goto IL_00CE;
			}
			goto IL_00B3;
			Block_5:
			IL_0098:
			throw new ArgumentNullException(Class15.smethod_17(1953655151 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f));
			IL_00B3:
			throw new ArgumentException(Class15.smethod_17(613137189 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6));
			IL_00CE:
			IL_00CF:
			int num2 = 0;
			IL_00D2:
			IEnumerator<JToken> enumerator = this.ChildrenTokens.GetEnumerator();
			IL_00DF:
			try
			{
				IL_0130:
				while (enumerator.MoveNext())
				{
					for (;;)
					{
						JToken jtoken = enumerator.Current;
						for (;;)
						{
							IL_0116:
							array.SetValue(jtoken, arrayIndex + num2);
							for (;;)
							{
								num2++;
								int num3 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
								{
									switch (num3)
									{
									case 1:
										goto IL_0130;
									case 2:
										goto IL_0139;
									case 3:
										continue;
									case 4:
										goto IL_0116;
									}
									goto Block_10;
								}
								goto IL_012F;
							}
						}
						Block_10:;
					}
					IL_012F:;
				}
				IL_0139:
				return;
			}
			finally
			{
				if (enumerator != null)
				{
					int num4 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
					{
						goto IL_016C;
					}
					IL_0154:
					enumerator.Dispose();
					num4 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
					{
						goto IL_017D;
					}
					IL_016C:
					switch (num4)
					{
					case 0:
						goto IL_0154;
					case 1:
						break;
					default:
						goto IL_0154;
					}
				}
				IL_017D:;
			}
			IL_017E:
			throw new ArgumentException(Class15.smethod_17(974398341 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f));
			IL_0199:
			throw new ArgumentOutOfRangeException(Class15.smethod_17(82253014 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909), Class15.smethod_17(82253006 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909));
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00075AD8 File Offset: 0x00073CD8
		internal static bool IsTokenUnchanged(JToken currentValue, [Nullable(2)] JToken newValue)
		{
			JValue jvalue;
			for (;;)
			{
				jvalue = currentValue as JValue;
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
				{
					goto IL_0003;
				}
				IL_002D:
				switch (num)
				{
				case 1:
					goto IL_0062;
				case 2:
					IL_0003:
					if (jvalue == null)
					{
						return false;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
					{
						goto IL_002D;
					}
					break;
				case 3:
					continue;
				}
				if (newValue != null)
				{
					goto IL_006E;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					goto IL_002D;
				}
				break;
			}
			IL_0062:
			return jvalue.Type == JTokenType.Null;
			IL_006E:
			return jvalue.Equals(newValue);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00075B60 File Offset: 0x00073D60
		internal virtual void ValidateToken(JToken o, [Nullable(2)] JToken existing)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(o, Class15.smethod_17(82253070 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0064;
				}
				IL_0003:
				if (o.Type != JTokenType.Property)
				{
					return;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
				{
					goto IL_0020;
				}
				break;
			}
			IL_0064:
			throw new ArgumentException(Class15.smethod_17(1424591460 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf).FormatWith(CultureInfo.InvariantCulture, o.GetType(), base.GetType()));
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00075C04 File Offset: 0x00073E04
		[NullableContext(2)]
		public virtual void Add(object content)
		{
			for (;;)
			{
				this.TryAddInternal(this.ChildrenTokens.Count, content, false, true);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
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

		// Token: 0x06000E1E RID: 3614 RVA: 0x00005E20 File Offset: 0x00004020
		[NullableContext(2)]
		internal bool TryAdd(object content)
		{
			return this.TryAddInternal(this.ChildrenTokens.Count, content, false, true);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00075C4C File Offset: 0x00073E4C
		internal void AddAndSkipParentCheck(JToken token)
		{
			for (;;)
			{
				this.TryAddInternal(this.ChildrenTokens.Count, token, true, true);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
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

		// Token: 0x06000E20 RID: 3616 RVA: 0x00075C94 File Offset: 0x00073E94
		[NullableContext(2)]
		public void AddFirst(object content)
		{
			for (;;)
			{
				this.TryAddInternal(0, content, false, true);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
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

		// Token: 0x06000E21 RID: 3617 RVA: 0x00075CD0 File Offset: 0x00073ED0
		[NullableContext(2)]
		internal bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations)
		{
			JToken jtoken;
			for (;;)
			{
				if (this.IsMultiContent(content))
				{
					goto IL_001F;
				}
				jtoken = JContainer.CreateFromContent(content);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
				{
					break;
				}
				IL_0040:
				switch (num)
				{
				case 1:
					goto IL_0069;
				case 2:
					return true;
				case 3:
				{
					IL_001F:
					IEnumerable enumerable = (IEnumerable)content;
					int num2 = index;
					IEnumerator enumerator = enumerable.GetEnumerator();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
					{
						goto IL_0040;
					}
					break;
				}
				case 4:
					continue;
				}
				goto Block_2;
			}
			goto IL_0069;
			Block_2:
			goto IL_0077;
			IL_0069:
			return this.InsertItem(index, jtoken, skipParentCheck, copyAnnotations);
			IL_0077:
			try
			{
				IL_00DA:
				IEnumerator enumerator;
				while (enumerator.MoveNext())
				{
					int num2;
					for (;;)
					{
						object obj = enumerator.Current;
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
						{
							goto IL_007B;
						}
						IL_009A:
						switch (num3)
						{
						case 1:
							goto IL_00D4;
						case 2:
							goto IL_00DA;
						case 3:
							continue;
						case 4:
							goto IL_00E3;
						}
						IL_007B:
						this.TryAddInternal(num2, obj, skipParentCheck, copyAnnotations);
						num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
						{
							goto IL_009A;
						}
						break;
					}
					IL_00D4:
					num2++;
					continue;
					goto IL_00D4;
				}
				IL_00E3:;
			}
			finally
			{
				IEnumerator enumerator;
				IDisposable disposable = enumerator as IDisposable;
				int num4 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
				{
					goto IL_011D;
				}
				goto IL_0132;
				IL_0102:
				disposable.Dispose();
				num4 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
				{
					goto IL_014E;
				}
				goto IL_0132;
				IL_011D:
				if (disposable != null)
				{
					goto IL_0102;
				}
				num4 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
				{
					goto IL_014E;
				}
				IL_0132:
				switch (num4)
				{
				case 0:
					goto IL_011D;
				case 1:
				case 2:
					break;
				case 3:
					goto IL_0102;
				default:
					goto IL_011D;
				}
				IL_014E:;
			}
			return true;
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00075E40 File Offset: 0x00074040
		internal static JToken CreateFromContent([Nullable(2)] object content)
		{
			JToken jtoken;
			for (;;)
			{
				jtoken = content as JToken;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
				{
					switch (num)
					{
					case 1:
						goto IL_0033;
					case 2:
						continue;
					case 3:
						goto IL_003A;
					}
					break;
				}
				goto IL_0032;
			}
			return jtoken;
			IL_0032:
			IL_0033:
			if (jtoken == null)
			{
				goto IL_003A;
			}
			return jtoken;
			IL_003A:
			return new JValue(content);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00005E36 File Offset: 0x00004036
		public JsonWriter CreateWriter()
		{
			return new JTokenWriter(this);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00075E90 File Offset: 0x00074090
		public void ReplaceAll(object content)
		{
			for (;;)
			{
				this.ClearItems();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
				{
					goto IL_001E;
				}
				do
				{
					IL_0003:
					this.Add(content);
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0);
				IL_001E:
				switch (num)
				{
				case 0:
					goto IL_0003;
				case 1:
					break;
				case 2:
					return;
				default:
					goto IL_0003;
				}
			}
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00005D62 File Offset: 0x00003F62
		public void RemoveAll()
		{
			this.ClearItems();
		}

		// Token: 0x06000E26 RID: 3622
		internal abstract void MergeItem(object content, [Nullable(2)] JsonMergeSettings settings);

		// Token: 0x06000E27 RID: 3623 RVA: 0x00075EEC File Offset: 0x000740EC
		[NullableContext(2)]
		public void Merge(object content)
		{
			IL_0041:
			while (content != null)
			{
				for (;;)
				{
					IL_0038:
					this.ehYwiptaAd(content);
					for (;;)
					{
						this.MergeItem(content, null);
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
						{
							switch (num)
							{
							case 1:
								return;
							case 2:
								continue;
							case 3:
								goto IL_0038;
							case 4:
								goto IL_0041;
							}
							return;
						}
						return;
					}
				}
				return;
			}
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00075F44 File Offset: 0x00074144
		[NullableContext(2)]
		public void Merge(object content, JsonMergeSettings settings)
		{
			for (;;)
			{
				int num;
				if (content == null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
					{
						break;
					}
				}
				else
				{
					this.ehYwiptaAd(content);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
					{
						goto IL_001C;
					}
				}
				IL_0035:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				case 3:
					IL_001C:
					this.MergeItem(content, settings);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
					{
						goto IL_0035;
					}
					return;
				}
				break;
			}
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00075FBC File Offset: 0x000741BC
		private void ehYwiptaAd(object object_2)
		{
			while (!object_2.GetType().IsSubclassOf(typeof(JToken)))
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						return;
					case 2:
						break;
					case 3:
						continue;
					case 4:
						goto IL_0055;
					default:
						return;
					}
				}
				if (!this.IsMultiContent(object_2))
				{
					goto IL_0055;
				}
				return;
				IL_0055:
				throw new ArgumentException(Class15.smethod_17(1424592298 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf).FormatWith(CultureInfo.InvariantCulture, object_2.GetType()), Class15.smethod_17(1270967384 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112));
			}
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00076060 File Offset: 0x00074260
		internal void ReadTokenFrom(JsonReader reader, [Nullable(2)] JsonLoadSettings options)
		{
			for (;;)
			{
				IL_0063:
				int depth = reader.Depth;
				while (reader.Read())
				{
					this.ReadContentFrom(reader, options);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
					{
						goto IL_001D;
					}
					IL_0038:
					switch (num)
					{
					case 1:
						return;
					case 2:
						goto IL_0070;
					case 3:
						continue;
					case 4:
						goto IL_0063;
					case 5:
						goto IL_00A1;
					}
					IL_001D:
					if (reader.Depth > depth)
					{
						goto IL_00A1;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
					{
						goto IL_0038;
					}
					goto IL_006D;
				}
				break;
			}
			goto IL_0070;
			IL_006D:
			return;
			IL_0070:
			throw JsonReaderException.Create(reader, Class15.smethod_17(1387514892 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923).FormatWith(CultureInfo.InvariantCulture, base.GetType().Name));
			IL_00A1:
			throw JsonReaderException.Create(reader, Class15.smethod_17(1243234380 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95).FormatWith(CultureInfo.InvariantCulture, base.GetType().Name));
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00076140 File Offset: 0x00074340
		internal void ReadContentFrom(JsonReader r, [Nullable(2)] JsonLoadSettings settings)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(r, Class15.smethod_17(1807939062 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3));
				int num = 28;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
				{
					goto IL_036A;
				}
				IL_0401:
				JContainer jcontainer;
				JValue jvalue;
				IJsonLineInfo jsonLineInfo;
				switch (num)
				{
				case 1:
					goto IL_0288;
				case 2:
					goto IL_031F;
				case 3:
					return;
				case 4:
					goto IL_02F7;
				case 5:
				case 12:
					goto IL_0546;
				case 6:
					goto IL_02A2;
				case 7:
					goto IL_0301;
				case 8:
					return;
				case 9:
				case 16:
				case 18:
				case 21:
				case 30:
				case 32:
				case 33:
				case 34:
				case 35:
				case 37:
				case 42:
				case 49:
				case 55:
					goto IL_0394;
				case 10:
					goto IL_036A;
				case 11:
					goto IL_005D;
				case 13:
					goto IL_0240;
				case 14:
				case 24:
				case 25:
					goto IL_0069;
				case 15:
					goto IL_0128;
				case 17:
					goto IL_019A;
				case 19:
					goto IL_02EA;
				case 20:
				case 46:
					goto IL_017A;
				case 22:
					goto IL_010A;
				case 23:
					goto IL_0168;
				case 26:
					jcontainer.Add(jvalue);
					goto IL_0394;
				case 27:
					goto IL_021D;
				case 28:
					jsonLineInfo = r as IJsonLineInfo;
					goto IL_03E4;
				case 29:
					continue;
				case 31:
					goto IL_03E4;
				case 36:
					goto IL_0042;
				case 38:
					goto IL_00E2;
				case 39:
					goto IL_037C;
				case 40:
					goto IL_01F7;
				case 41:
					goto IL_0135;
				case 43:
					goto IL_025E;
				case 44:
					goto IL_033F;
				case 45:
					goto IL_01E8;
				case 47:
					return;
				case 48:
					goto IL_0157;
				case 50:
					goto IL_0386;
				case 51:
					goto IL_01C1;
				case 52:
					goto IL_015E;
				case 53:
					goto IL_0139;
				case 54:
					goto IL_0024;
				case 56:
					goto IL_01A0;
				case 57:
					goto IL_01FE;
				case 58:
					goto IL_00DB;
				case 59:
					return;
				case 60:
					goto IL_0171;
				case 61:
					goto IL_02D1;
				case 62:
					goto IL_00EC;
				case 63:
					goto IL_0086;
				case 64:
					goto IL_0006;
				}
				goto Block_23;
				IL_03E4:
				jcontainer = this;
				goto IL_0024;
				IL_0006:
				JConstructor jconstructor;
				jcontainer = jconstructor;
				num = 16;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
				{
					goto IL_0394;
				}
				goto IL_0401;
				IL_0386:
				jcontainer.Add(jconstructor);
				goto IL_0006;
				IL_037C:
				jconstructor.SetLineInfo(jsonLineInfo, settings);
				goto IL_0386;
				IL_036A:
				jconstructor = new JConstructor(r.Value.ToString());
				goto IL_037C;
				IL_0086:
				JsonToken tokenType;
				JObject jobject;
				JArray jarray;
				JProperty jproperty;
				switch (tokenType)
				{
				case JsonToken.None:
					goto IL_0394;
				case JsonToken.StartObject:
					IL_0157:
					jobject = new JObject();
					goto IL_015E;
				case JsonToken.StartArray:
					IL_00DB:
					jarray = new JArray();
					goto IL_00E2;
				case JsonToken.StartConstructor:
					goto IL_036A;
				case JsonToken.PropertyName:
					IL_0128:
					jproperty = JContainer.smethod_5(r, settings, jsonLineInfo, jcontainer);
					goto IL_0135;
				case JsonToken.Comment:
					IL_019A:
					if (settings != null)
					{
						goto IL_01A0;
					}
					goto IL_0394;
				case JsonToken.Integer:
				case JsonToken.Float:
				case JsonToken.String:
				case JsonToken.Boolean:
				case JsonToken.Date:
				case JsonToken.Bytes:
					IL_02EA:
					jvalue = new JValue(r.Value);
					goto IL_02F7;
				case JsonToken.Null:
					IL_01F7:
					jvalue = JValue.CreateNull();
					goto IL_01FE;
				case JsonToken.Undefined:
					IL_0240:
					jvalue = JValue.CreateUndefined();
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
					{
						goto IL_0288;
					}
					goto IL_0401;
				case JsonToken.EndObject:
					IL_025E:
					if (jcontainer != this)
					{
						jcontainer = jcontainer.Parent;
						goto IL_0394;
					}
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
					{
						goto IL_0288;
					}
					goto IL_0401;
				case JsonToken.EndArray:
					goto IL_0288;
				case JsonToken.EndConstructor:
					IL_02D1:
					if (jcontainer != this)
					{
						jcontainer = jcontainer.Parent;
						goto IL_0394;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
					{
						goto Block_21;
					}
					goto IL_0401;
				}
				break;
				IL_0024:
				JProperty jproperty2 = jcontainer as JProperty;
				num = 19;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
				{
					goto IL_0042;
				}
				goto IL_0401;
				IL_0394:
				if (r.Read())
				{
					goto IL_0024;
				}
				num = 24;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
				{
					goto Block_20;
				}
				goto IL_0401;
				IL_0042:
				if (jproperty2 != null)
				{
					goto IL_005D;
				}
				num = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					goto IL_0401;
				}
				IL_0069:
				tokenType = r.TokenType;
				num = 42;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
				{
					goto IL_0086;
				}
				goto IL_0401;
				IL_005D:
				if (jproperty2.Value == null)
				{
					goto IL_0069;
				}
				goto IL_033F;
				IL_00EC:
				jcontainer.Add(jarray);
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
				{
					goto IL_010A;
				}
				goto IL_0401;
				IL_00E2:
				jarray.SetLineInfo(jsonLineInfo, settings);
				goto IL_00EC;
				IL_010A:
				jcontainer = jarray;
				num = 34;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
				{
					goto IL_0069;
				}
				goto IL_0401;
				IL_0139:
				jcontainer = jproperty;
				num = 30;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
				{
					goto IL_0069;
				}
				goto IL_0401;
				IL_0135:
				if (jproperty != null)
				{
					goto IL_0139;
				}
				IL_017A:
				r.Skip();
				num = 29;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
				{
					goto IL_0394;
				}
				goto IL_0401;
				IL_01C1:
				jvalue = JValue.CreateComment(r.Value.ToString());
				num = 19;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
				{
					goto IL_01E8;
				}
				goto IL_0401;
				IL_01FE:
				jvalue.SetLineInfo(jsonLineInfo, settings);
				num = 11;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
				{
					goto IL_0401;
				}
				IL_021D:
				jcontainer.Add(jvalue);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
				{
					goto IL_0394;
				}
				goto IL_0401;
				IL_0288:
				if (jcontainer != this)
				{
					jcontainer = jcontainer.Parent;
					goto IL_0394;
				}
				num = 59;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
				{
					goto IL_0401;
				}
				IL_02A2:
				jvalue.SetLineInfo(jsonLineInfo, settings);
				num = 26;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
				{
					goto IL_02F7;
				}
				goto IL_0401;
				IL_0301:
				jcontainer.Add(jvalue);
				num = 21;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
				{
					goto IL_031F;
				}
				goto IL_0401;
				IL_02F7:
				jvalue.SetLineInfo(jsonLineInfo, settings);
				goto IL_0301;
				IL_031F:
				jcontainer.Add(jvalue);
				num = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
				{
					goto IL_0394;
				}
				goto IL_0401;
				IL_01E8:
				jvalue.SetLineInfo(jsonLineInfo, settings);
				goto IL_031F;
				IL_033F:
				if (jcontainer == this)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						goto Block_22;
					}
					goto IL_0401;
				}
				else
				{
					jcontainer = jcontainer.Parent;
					num = 24;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
					{
						goto IL_0394;
					}
					goto IL_0401;
				}
				IL_0171:
				jcontainer = jobject;
				goto IL_0394;
				IL_0168:
				jcontainer.Add(jobject);
				goto IL_0171;
				IL_015E:
				jobject.SetLineInfo(jsonLineInfo, settings);
				goto IL_0168;
				IL_01A0:
				if (settings.CommentHandling != CommentHandling.Load)
				{
					goto IL_0394;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
				{
					goto IL_01C1;
				}
				goto IL_0401;
			}
			goto IL_0546;
			Block_20:
			return;
			Block_21:
			return;
			Block_22:
			Block_23:
			return;
			IL_0546:
			throw new InvalidOperationException(Class15.smethod_17(1985327636 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba).FormatWith(CultureInfo.InvariantCulture, r.TokenType));
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x000766C8 File Offset: 0x000748C8
		[NullableContext(2)]
		private static JProperty smethod_5([Nullable(1)] JsonReader r, JsonLoadSettings jsonLoadSettings_0, IJsonLineInfo ijsonLineInfo_0, [Nullable(1)] JContainer parent)
		{
			JProperty jproperty;
			string text;
			for (;;)
			{
				IL_0134:
				if (jsonLoadSettings_0 != null)
				{
					goto IL_0112;
				}
				goto IL_0131;
				IL_0118:
				DuplicatePropertyNameHandling duplicatePropertyNameHandling2;
				DuplicatePropertyNameHandling duplicatePropertyNameHandling = duplicatePropertyNameHandling2;
				int num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
				{
					goto IL_0062;
				}
				for (;;)
				{
					IL_00D2:
					switch (num)
					{
					case 1:
						parent.Add(jproperty);
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0042;
					case 3:
						goto IL_0131;
					case 4:
						goto IL_0095;
					case 6:
						goto IL_007F;
					case 7:
						goto IL_0024;
					case 8:
						goto IL_013D;
					case 9:
						goto IL_013F;
					case 10:
						goto IL_0062;
					case 11:
						goto IL_0006;
					case 12:
						goto IL_0112;
					case 13:
						goto IL_0134;
					}
					goto Block_7;
				}
				IL_0006:
				jproperty.SetLineInfo(ijsonLineInfo_0, jsonLoadSettings_0);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
				{
					goto IL_0024;
				}
				goto IL_00D2;
				IL_00AB:
				jproperty = new JProperty(text);
				goto IL_0006;
				IL_007F:
				JProperty jproperty2;
				if (jproperty2 == null)
				{
					goto IL_00AB;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
				{
					goto IL_0095;
				}
				goto IL_00D2;
				IL_0062:
				JObject jobject = (JObject)parent;
				text = r.Value.ToString();
				jproperty2 = jobject.Property(text, StringComparison.Ordinal);
				goto IL_007F;
				IL_0024:
				if (jproperty2 == null)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						break;
					}
					goto IL_00D2;
				}
				IL_0042:
				jproperty2.Replace(jproperty);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
				{
					break;
				}
				goto IL_00D2;
				IL_0095:
				if (duplicatePropertyNameHandling == DuplicatePropertyNameHandling.Ignore)
				{
					goto Block_5;
				}
				if (duplicatePropertyNameHandling == DuplicatePropertyNameHandling.Error)
				{
					goto Block_6;
				}
				goto IL_00AB;
				IL_0131:
				duplicatePropertyNameHandling2 = DuplicatePropertyNameHandling.Replace;
				goto IL_0118;
				IL_0112:
				duplicatePropertyNameHandling2 = jsonLoadSettings_0.DuplicatePropertyNameHandling;
				goto IL_0118;
			}
			return jproperty;
			Block_5:
			goto IL_013D;
			Block_6:
			goto IL_013F;
			Block_7:
			return jproperty;
			IL_013D:
			return null;
			IL_013F:
			throw JsonReaderException.Create(r, Class15.smethod_17(543275232 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89).FormatWith(CultureInfo.InvariantCulture, text));
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00076844 File Offset: 0x00074A44
		internal int ContentsHashCode()
		{
			int num;
			for (;;)
			{
				num = 0;
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
				{
					switch (num2)
					{
					case 1:
						continue;
					case 2:
						return num;
					case 3:
						goto IL_003B;
					}
					break;
				}
				break;
			}
			IEnumerator<JToken> enumerator = this.ChildrenTokens.GetEnumerator();
			IL_003B:
			try
			{
				for (;;)
				{
					IL_00A8:
					if (enumerator.MoveNext())
					{
						goto IL_0074;
					}
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
					{
						break;
					}
					JToken jtoken;
					for (;;)
					{
						IL_005C:
						switch (num3)
						{
						case 1:
							goto IL_00A8;
						case 2:
							goto IL_0074;
						case 3:
							num ^= jtoken.GetDeepHashCode();
							num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
							{
								continue;
							}
							goto IL_0091;
						}
						goto Block_4;
					}
					IL_0091:
					continue;
					IL_0074:
					jtoken = enumerator.Current;
					num3 = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
					{
						break;
					}
					goto IL_005C;
				}
				Block_4:;
			}
			finally
			{
				if (enumerator != null)
				{
					int num4 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
					{
						goto IL_00E8;
					}
					IL_00D0:
					enumerator.Dispose();
					num4 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
					{
						goto IL_00F9;
					}
					IL_00E8:
					switch (num4)
					{
					case 0:
						goto IL_00D0;
					case 1:
						break;
					default:
						goto IL_00D0;
					}
				}
				IL_00F9:;
			}
			return num;
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00005E3E File Offset: 0x0000403E
		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			return string.Empty;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00076960 File Offset: 0x00074B60
		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			PropertyDescriptorCollection propertyDescriptorCollection;
			for (;;)
			{
				ICustomTypeDescriptor customTypeDescriptor = this.First as ICustomTypeDescriptor;
				int num;
				if (customTypeDescriptor == null)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						goto IL_0022;
					}
				}
				else
				{
					if ((propertyDescriptorCollection = customTypeDescriptor.GetProperties()) == null)
					{
						goto IL_0023;
					}
					return propertyDescriptorCollection;
				}
				IL_0035:
				switch (num)
				{
				case 1:
					IL_0022:
					goto IL_0023;
				case 2:
					continue;
				}
				break;
				IL_0023:
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
				{
					goto IL_0035;
				}
				break;
			}
			propertyDescriptorCollection = new PropertyDescriptorCollection(CollectionUtils.ArrayEmpty<PropertyDescriptor>());
			return propertyDescriptorCollection;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00005D59 File Offset: 0x00003F59
		int IList<JToken>.IndexOf(JToken item)
		{
			return this.IndexOfItem(item);
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x000769CC File Offset: 0x00074BCC
		void IList<JToken>.Insert(int index, JToken item)
		{
			for (;;)
			{
				this.InsertItem(index, item, false, true);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
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

		// Token: 0x06000E32 RID: 3634 RVA: 0x00076A08 File Offset: 0x00074C08
		void IList<JToken>.RemoveAt(int index)
		{
			for (;;)
			{
				this.RemoveItemAt(index);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
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

		// Token: 0x1700020E RID: 526
		JToken IList<JToken>.this[int index]
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
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

		// Token: 0x06000E35 RID: 3637 RVA: 0x00076A78 File Offset: 0x00074C78
		void ICollection<JToken>.Add(JToken item)
		{
			for (;;)
			{
				this.Add(item);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
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

		// Token: 0x06000E36 RID: 3638 RVA: 0x00005D62 File Offset: 0x00003F62
		void ICollection<JToken>.Clear()
		{
			this.ClearItems();
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00005D6A File Offset: 0x00003F6A
		bool ICollection<JToken>.Contains(JToken item)
		{
			return this.ContainsItem(item);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00076AB0 File Offset: 0x00074CB0
		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex)
		{
			for (;;)
			{
				this.CopyItemsTo(array, arrayIndex);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
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

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00003453 File Offset: 0x00001653
		bool ICollection<JToken>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00005D73 File Offset: 0x00003F73
		bool ICollection<JToken>.Remove(JToken item)
		{
			return this.RemoveItem(item);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00076AE8 File Offset: 0x00074CE8
		[NullableContext(2)]
		private JToken method_0(object object_2)
		{
			while (object_2 != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
				{
					goto IL_0015;
				}
				IL_002E:
				JToken jtoken;
				switch (num)
				{
				case 1:
					goto IL_0073;
				case 2:
					return jtoken;
				case 3:
					IL_0015:
					jtoken = object_2 as JToken;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
					{
						goto IL_002E;
					}
					break;
				case 4:
					continue;
				}
				if (jtoken == null)
				{
					throw new ArgumentException(Class15.smethod_17(1471414233 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e));
				}
				return jtoken;
			}
			IL_0073:
			return null;
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00076B6C File Offset: 0x00074D6C
		[NullableContext(2)]
		int IList.Add(object value)
		{
			for (;;)
			{
				this.Add(this.method_0(value));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
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
			return this.Count - 1;
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00005D62 File Offset: 0x00003F62
		void IList.Clear()
		{
			this.ClearItems();
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00005E45 File Offset: 0x00004045
		[NullableContext(2)]
		bool IList.Contains(object value)
		{
			return this.ContainsItem(this.method_0(value));
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00005E54 File Offset: 0x00004054
		[NullableContext(2)]
		int IList.IndexOf(object value)
		{
			return this.IndexOfItem(this.method_0(value));
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00076BB4 File Offset: 0x00074DB4
		[NullableContext(2)]
		void IList.Insert(int index, object value)
		{
			for (;;)
			{
				this.InsertItem(index, this.method_0(value), false, false);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
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

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x00003453 File Offset: 0x00001653
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00003453 File Offset: 0x00001653
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00076BF8 File Offset: 0x00074DF8
		[NullableContext(2)]
		void IList.Remove(object value)
		{
			for (;;)
			{
				this.RemoveItem(this.method_0(value));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
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

		// Token: 0x06000E44 RID: 3652 RVA: 0x00076C38 File Offset: 0x00074E38
		void IList.RemoveAt(int index)
		{
			for (;;)
			{
				this.RemoveItemAt(index);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
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

		// Token: 0x17000212 RID: 530
		[Nullable(2)]
		object IList.this[int index]
		{
			[NullableContext(2)]
			get
			{
				return this.GetItem(index);
			}
			[NullableContext(2)]
			set
			{
				for (;;)
				{
					this.SetItem(index, this.method_0(value));
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
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

		// Token: 0x06000E47 RID: 3655 RVA: 0x00076CB0 File Offset: 0x00074EB0
		void ICollection.CopyTo(Array array, int index)
		{
			for (;;)
			{
				this.CopyItemsTo(array, index);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
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

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00005E63 File Offset: 0x00004063
		public int Count
		{
			get
			{
				return this.ChildrenTokens.Count;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00003453 File Offset: 0x00001653
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00076CE8 File Offset: 0x00074EE8
		object ICollection.SyncRoot
		{
			get
			{
				IL_003E:
				while (this.object_1 == null)
				{
					for (;;)
					{
						Interlocked.CompareExchange(ref this.object_1, new object(), null);
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
						{
							switch (num)
							{
							case 1:
								continue;
							case 3:
								goto IL_003E;
							}
							break;
						}
						break;
					}
					IL_004A:
					return this.object_1;
				}
				goto IL_004A;
			}
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00002420 File Offset: 0x00000620
		void IBindingList.AddIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00076D48 File Offset: 0x00074F48
		object IBindingList.AddNew()
		{
			JToken jtoken;
			for (;;)
			{
				IL_009B:
				AddingNewEventArgs addingNewEventArgs = new AddingNewEventArgs();
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
				{
					goto IL_0006;
				}
				for (;;)
				{
					IL_0073:
					switch (num)
					{
					case 1:
						return jtoken;
					case 2:
						goto IL_006C;
					case 3:
						if (addingNewEventArgs.NewObject != null)
						{
							jtoken = addingNewEventArgs.NewObject as JToken;
							goto IL_006C;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
						{
							continue;
						}
						break;
					case 4:
						goto IL_0025;
					case 5:
						goto IL_00E8;
					case 6:
						goto IL_0006;
					case 7:
						goto IL_009B;
					}
					goto Block_6;
					IL_0025:
					this.Add(jtoken);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
					{
						goto Block_2;
					}
					continue;
					IL_006C:
					if (jtoken != null)
					{
						goto IL_0025;
					}
					goto IL_00E8;
				}
				IL_0006:
				this.OnAddingNew(addingNewEventArgs);
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
				{
					break;
				}
				goto IL_0073;
			}
			return jtoken;
			Block_2:
			Block_6:
			throw new JsonException(Class15.smethod_17(1788802629 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c).FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			IL_00E8:
			throw new JsonException(Class15.smethod_17(299903365 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e).FormatWith(CultureInfo.InvariantCulture, typeof(JToken)));
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00002C18 File Offset: 0x00000E18
		bool IBindingList.AllowEdit
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00002C18 File Offset: 0x00000E18
		bool IBindingList.AllowNew
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00002C18 File Offset: 0x00000E18
		bool IBindingList.AllowRemove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00003CF7 File Offset: 0x00001EF7
		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00003CF7 File Offset: 0x00001EF7
		int IBindingList.Find(PropertyDescriptor property, object key)
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00003453 File Offset: 0x00001653
		bool IBindingList.IsSorted
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00002420 File Offset: 0x00000620
		void IBindingList.RemoveIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00003CF7 File Offset: 0x00001EF7
		void IBindingList.RemoveSort()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00003453 File Offset: 0x00001653
		ListSortDirection IBindingList.SortDirection
		{
			get
			{
				return ListSortDirection.Ascending;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00003C0E File Offset: 0x00001E0E
		[Nullable(2)]
		PropertyDescriptor IBindingList.SortProperty
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00002C18 File Offset: 0x00000E18
		bool IBindingList.SupportsChangeNotification
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00003453 File Offset: 0x00001653
		bool IBindingList.SupportsSearching
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00003453 File Offset: 0x00001653
		bool IBindingList.SupportsSorting
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00076E70 File Offset: 0x00075070
		internal static void MergeEnumerableContent(JContainer target, IEnumerable content, [Nullable(2)] JsonMergeSettings settings)
		{
			IL_0111:
			while (settings != null)
			{
				IEnumerator enumerator;
				for (;;)
				{
					IL_0107:
					MergeArrayHandling mergeArrayHandling = settings.MergeArrayHandling;
					for (;;)
					{
						int num;
						switch (mergeArrayHandling)
						{
						case MergeArrayHandling.Concat:
							goto IL_04BC;
						case MergeArrayHandling.Union:
						{
							IL_0041:
							HashSet<JToken> hashSet = new HashSet<JToken>(target, JToken.EqualityComparer);
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
							{
								goto IL_0062;
							}
							break;
						}
						case MergeArrayHandling.Replace:
							IL_0006:
							if (target != content)
							{
								goto IL_000D;
							}
							return;
						case MergeArrayHandling.Merge:
						{
							IL_00D1:
							int num2 = 0;
							goto IL_00B5;
						}
						default:
							num = 16;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
							{
								goto Block_5;
							}
							goto IL_0062;
						}
						do
						{
							IL_0025:
							enumerator = content.GetEnumerator();
							num = 1;
						}
						while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0);
						IL_0062:
						switch (num)
						{
						case 0:
							goto IL_0025;
						case 1:
							goto IL_0123;
						case 2:
							goto IL_01EC;
						case 3:
							goto IL_00B5;
						case 4:
							goto IL_04BC;
						case 5:
							goto IL_04B9;
						case 6:
							continue;
						case 7:
							goto IL_04C4;
						case 8:
							goto IL_0107;
						case 9:
							goto IL_0111;
						case 10:
							break;
						case 11:
							goto IL_0041;
						case 12:
							goto IL_01F4;
						case 13:
							goto IL_02DF;
						case 14:
							goto IL_0006;
						case 15:
						case 16:
							goto IL_0489;
						case 17:
							goto IL_00D1;
						default:
							goto IL_0025;
						}
						IL_000D:
						target.ClearItems();
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
						{
							goto IL_0025;
						}
						goto IL_0062;
						IL_00B5:
						enumerator = content.GetEnumerator();
						num = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
						{
							goto Block_4;
						}
						goto IL_0062;
					}
				}
				Block_4:
				break;
				Block_5:
				IL_0123:
				try
				{
					for (;;)
					{
						if (enumerator.MoveNext())
						{
							goto IL_015D;
						}
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
						{
							break;
						}
						IL_0145:
						object obj;
						switch (num3)
						{
						case 0:
							continue;
						case 1:
							goto IL_018C;
						case 2:
							break;
						case 3:
							IL_015D:
							obj = enumerator.Current;
							break;
						default:
							continue;
						}
						target.Add(JContainer.CreateFromContent(obj));
						num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
						{
							goto IL_0145;
						}
					}
					IL_018C:
					return;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					for (;;)
					{
						if (disposable != null)
						{
							goto IL_019C;
						}
						int num4 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
						{
							break;
						}
						IL_01B4:
						switch (num4)
						{
						case 2:
							IL_019C:
							disposable.Dispose();
							num4 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
							{
								goto IL_01B4;
							}
							break;
						case 3:
							continue;
						}
						break;
					}
				}
				IL_01EC:
				enumerator = content.GetEnumerator();
				IL_01F4:
				try
				{
					for (;;)
					{
						if (enumerator.MoveNext())
						{
							goto IL_0245;
						}
						int num5 = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
						{
							break;
						}
						goto IL_0225;
						IL_01FB:
						JToken jtoken;
						target.Add(jtoken);
						num5 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
						{
							continue;
						}
						goto IL_0225;
						IL_0217:
						HashSet<JToken> hashSet;
						if (!hashSet.Add(jtoken))
						{
							continue;
						}
						goto IL_01FB;
						IL_0245:
						jtoken = JContainer.CreateFromContent(enumerator.Current);
						num5 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
						{
							goto IL_0217;
						}
						IL_0225:
						switch (num5)
						{
						case 1:
							goto IL_0217;
						case 2:
							goto IL_01FB;
						case 3:
							goto IL_0245;
						case 4:
							goto IL_028B;
						}
					}
					IL_028B:
					return;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num6 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
					{
						for (;;)
						{
							switch (num6)
							{
							case 1:
								if (disposable == null)
								{
									goto IL_02DE;
								}
								num6 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
								{
									continue;
								}
								break;
							case 2:
								goto IL_02DE;
							}
							break;
						}
					}
					disposable.Dispose();
					IL_02DE:;
				}
				IL_02DF:
				try
				{
					for (;;)
					{
						IL_0422:
						if (enumerator.MoveNext())
						{
							goto IL_03F1;
						}
						int num7 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
						{
							break;
						}
						for (;;)
						{
							IL_03A5:
							int num2;
							switch (num7)
							{
							case 0:
								goto IL_0375;
							case 1:
								goto IL_042F;
							case 2:
								goto IL_035D;
							case 3:
								goto IL_0325;
							case 4:
							case 7:
								goto IL_0301;
							case 5:
								goto IL_03F1;
							case 6:
								goto IL_0422;
							case 8:
								goto IL_0393;
							case 9:
								goto IL_031C;
							case 10:
								goto IL_0330;
							case 11:
							case 12:
							case 14:
							case 16:
								break;
							case 13:
								goto IL_0371;
							case 15:
								if (num2 >= target.Count)
								{
									goto IL_0393;
								}
								num7 = 2;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
								{
									goto IL_035D;
								}
								continue;
							default:
								goto IL_0375;
							}
							IL_02E6:
							num2++;
							num7 = 6;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
							{
								continue;
							}
							IL_0301:
							object obj2;
							if (obj2 != null)
							{
								goto IL_031C;
							}
							num7 = 12;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
							{
								goto IL_02E6;
							}
							continue;
							IL_0371:
							JContainer jcontainer;
							if (jcontainer != null)
							{
								goto IL_0375;
							}
							goto IL_0301;
							IL_035D:
							jcontainer = target[num2] as JContainer;
							goto IL_0371;
							IL_0375:
							jcontainer.Merge(obj2, settings);
							num7 = 16;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
							{
								continue;
							}
							IL_0325:
							JToken jtoken2;
							if (jtoken2.Type != JTokenType.Null)
							{
								goto IL_0330;
							}
							goto IL_02E6;
							IL_031C:
							jtoken2 = JContainer.CreateFromContent(obj2);
							goto IL_0325;
							IL_0330:
							target[num2] = jtoken2;
							goto IL_02E6;
							IL_0393:
							target.Add(JContainer.CreateFromContent(obj2));
							goto IL_02E6;
						}
						for (;;)
						{
							IL_03F1:
							object obj2 = enumerator.Current;
							num7 = 15;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
							{
								goto IL_03A5;
							}
						}
					}
					IL_042F:
					return;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num8 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
					{
						goto IL_046C;
					}
					goto IL_0473;
					IL_0451:
					disposable.Dispose();
					num8 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
					{
						goto IL_0488;
					}
					goto IL_0473;
					IL_046C:
					if (disposable != null)
					{
						goto IL_0451;
					}
					goto IL_0488;
					IL_0473:
					switch (num8)
					{
					case 0:
						goto IL_046C;
					case 1:
						break;
					case 2:
						goto IL_0451;
					default:
						goto IL_046C;
					}
					IL_0488:;
				}
				IL_0489:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(1793906570 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a), Class15.smethod_17(41463787 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d));
				IL_04BC:
				enumerator = content.GetEnumerator();
				IL_04C4:
				try
				{
					for (;;)
					{
						if (enumerator.MoveNext())
						{
							goto IL_04C8;
						}
						int num9 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
						{
							break;
						}
						IL_04E2:
						object obj3;
						switch (num9)
						{
						case 1:
							goto IL_052D;
						case 2:
							target.Add(JContainer.CreateFromContent(obj3));
							continue;
						case 3:
							continue;
						}
						IL_04C8:
						obj3 = enumerator.Current;
						num9 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
						{
							goto IL_04E2;
						}
						break;
					}
					IL_052D:;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num10 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
					{
						goto IL_055F;
					}
					IL_054A:
					if (disposable == null)
					{
						goto IL_057B;
					}
					num10 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
					{
						goto IL_0574;
					}
					IL_055F:
					switch (num10)
					{
					case 1:
						goto IL_054A;
					case 2:
						goto IL_057B;
					}
					IL_0574:
					disposable.Dispose();
					IL_057B:;
				}
				return;
			}
			IL_04B9:
			goto IL_04BC;
		}

		// Token: 0x040006AD RID: 1709
		[Nullable(2)]
		internal ListChangedEventHandler _listChanged;

		// Token: 0x040006AE RID: 1710
		[Nullable(2)]
		internal AddingNewEventHandler _addingNew;

		// Token: 0x040006AF RID: 1711
		[Nullable(2)]
		internal NotifyCollectionChangedEventHandler _collectionChanged;

		// Token: 0x040006B0 RID: 1712
		[Nullable(2)]
		private object object_1;

		// Token: 0x040006B1 RID: 1713
		private bool bool_0;
	}
}
