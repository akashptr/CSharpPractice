namespace Practice_Mosh.Intermediate.Workflow
{
    public class Workflow : IWorkflow
    {
        private readonly List<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }
    }
}
