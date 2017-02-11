using System;
using System.ComponentModel.Composition
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;

namespace $rootnamespace$
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    public class Export$rootname$Attribute : ExportAttribute, I$rootname$Metadata
    {
    }

    public interface I$rootname$Metadata
    {
    
    }
}
