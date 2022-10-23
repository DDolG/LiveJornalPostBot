using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserActionsImitation.UserActions
{
    class UserActionClear : UserActionBase
    {
        public override void MakeUserAction()
        {
          element.Clear();
        }
    }
}
