using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserActionsImitation.UserActions
{
    public class UserActionClear : UserActionTemplate
    {
        public override void MakeUserAction()
        {
          element.Clear();
        }
    }
}
