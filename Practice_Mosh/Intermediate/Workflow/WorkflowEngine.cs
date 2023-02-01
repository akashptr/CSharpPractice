using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Intermediate.Workflow
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach(IActivity activity in workflow.GetActivities())
                activity.Execute();
        }
    }
}
