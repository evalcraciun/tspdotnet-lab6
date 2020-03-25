using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF
{
    [ServiceContract]
    interface IPostComment: InterfacePost, InterfaceComment
    {

    }
}
