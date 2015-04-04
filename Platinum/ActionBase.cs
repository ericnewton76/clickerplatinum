using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Platinum
{
    public abstract class ActionBase : IAction
    {

        public abstract ActionResult Execute();

        private int _replayBranch;
        public int ReplayBranch
        {
            get { return this._replayBranch; }
            set { this._replayBranch = value; }
        }

        protected ContinuationResult Continue()
        {
            return new ContinuationResult();
        }

    }
}
