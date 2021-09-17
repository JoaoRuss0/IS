using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationLibrary
{
    interface IPrintable
    {
        string Print();
        string PrintHTML();
        string PrintXML();
    }
}
