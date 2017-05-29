using System.Collections.ObjectModel;

namespace HierarchicalDataTemplateDemo
{
    public class StudySampleSequence
    {
        public string Sequence { get; set; }

        public int Number { get; set; }

        public ObservableCollection<SequenceObj> SequenceObjs { get; set; }
      
    }

    public class SequenceObj
    {
        public ObservableCollection<StudySample> StudySamples { get; set; }

        public ObservableCollection<WorkflowOperation> WorkflowOperations { get; set; }
    }
}