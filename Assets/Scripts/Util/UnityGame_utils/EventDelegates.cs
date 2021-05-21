using System;
using UnityEngine;

namespace UnityUtils.alpha.delegates
{
    /// <summary>
    /// Delegate linker
    /// </summary>
    public class EventDelegates
    {
        public delegate void CommonHandle();
        public delegate bool ConditionHandle();
        public delegate bool ConditionHandleRef(GameObject go);
        //public delegate void OffenderHandle(GameObject gof); 
    }
}
