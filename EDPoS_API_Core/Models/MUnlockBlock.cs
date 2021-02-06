using System;
using System.Collections.Generic;

namespace EDPoS_API_Core.Models
{
    public class MUnlockBlockBase
    {
        /// <summary>
        /// 20g0..
        /// </summary>
        public string addrFrom { get; set; }
        public DateTime date { get; set; }
    }
    public class MUnlockBlockReward
    {
        public string addrTo { get; set; }
        public Decimal balance { get; set; }
        public long timeSpan { get; set; }
        public int height { get; set; }
    }
    /// <summary>
    ///  解锁的块: id, addrTo, balance, timeSpan, height
    /// </summary>
    public class MUnlockBlock : MUnlockBlockBase
    {   
        public Int64 id { get; set; }
        public string addrTo { get; set; }
        public Decimal balance { get; set; }
        public long timeSpan { get; set; }
        public int height { get; set; }
    }

    /// <summary>
    /// 某个矿工(addrFrom)在某个日期(date)的解锁奖励数据(list: addrTo, balance, timSpan, height)
    /// </summary>
    public class MUnlockBlockLst : MUnlockBlockBase
    {
        public List<MUnlockBlockReward> balanceLst { get; set; }
    }

    public class MUnlockBlockLstWithSign : MValid
    {
        public List<MUnlockBlock> balanceLst { get; set; }
    }
}
