using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Reflection;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;
using System.Windows.Forms;

[assembly: AssemblyVersion("3.0.0.4")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0")]

[assembly: ESAPIScript(IsWriteable = true)]

namespace VMS.TPS
{
    public class Script
    {
        private VMS.TPS.Common.Model.API.Application app;
        
        public void Execute(ScriptContext scriptContext)
        {
            FieldEvaluationOffset.ValidateAndRun.Run(scriptContext.PlanSetup, scriptContext.Patient, scriptContext.Course);
        }
    }
}