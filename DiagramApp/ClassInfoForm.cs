using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramApp
{
    public class ClassInfoForm
    {
        public string ClassName { get; set; }
        public string Values { get; set; }
        public string Methods { get; set; }
    }

    public class ActivityInfo
    {
        public string ActivityData { get; set; }
    }
     
    public class PackageName
    {
        public string PackageData { get; set; }
    }

    public class LineText1
    {
        public string LineInfo { get; set; }
    }

	public class DecisionFigForm {
			public string Condition { get; set; }
			public string yesCond { get; set; }
			public string noCond { get; set; }
	}
}
