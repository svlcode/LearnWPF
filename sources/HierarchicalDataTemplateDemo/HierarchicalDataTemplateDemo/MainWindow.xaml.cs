using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HierarchicalDataTemplateDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<StudySampleSequence> StudySampleSequences { get; set; }

        public ObservableCollection<Conference> Conferences { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            InitSequenceCollection();
            //InitConfCollection();

        }

        private void InitConfCollection()
        {
            Conferences = new ObservableCollection<Conference>();

            var western = new Conference("Western")
            {
                Teams =
                {
                    new Team("Club Deportivo Chivas USA"),
                    new Team("Colorado Rapids"),
                    new Team("FC Dallas"),
                    new Team("Houston Dynamo"),
                    new Team("Los Angeles Galaxy"),
                    new Team("Real Salt Lake"),
                    new Team("San Jose Earthquakes"),
                    new Team("Seattle Sounders FC"),
                    new Team("Portland 2011"),
                    new Team("Vancouver 2011")
                }
            };

            var eastern = new Conference("Eastern")
            {
                Teams =
                {
                    new Team("Chicago Fire"),
                    new Team("Columbus Crew"),
                    new Team("D.C. United"),
                    new Team("Kansas City Wizards"),
                    new Team("New York Red Bulls"),
                    new Team("New England Revolution"),
                    new Team("Toronto FC"),
                    new Team("Philadelphia Union 2010")
                }
            };
            Conferences.Add(western);
            Conferences.Add(eastern);

            DataContext = Conferences;
        }


        private void InitSequenceCollection()
        {
            StudySampleSequences = new ObservableCollection<StudySampleSequence>();

            var ss = new ObservableCollection<StudySample>
            {
                new StudySample
                {
                    SampleNumber = "S12.12"
                },
                new StudySample
                {
                    SampleNumber = "S02.33"
                },
                 new StudySample
                {
                    SampleNumber = "S04.33"
                },
                 new StudySample
                {
                    SampleNumber = "S05.R3"
                }
            };

            var wo = new ObservableCollection<WorkflowOperation>
            {
                new WorkflowOperation
                {
                    Location = "AUS",
                    LocationType = "Lab",
                    Operation = "Aliquot",
                    Step = 1
                },
                new WorkflowOperation
                {
                    Location = "AUS",
                    LocationType = "Lab",
                    Operation = "SHIP STATE",
                    Step = 2
                },
                new WorkflowOperation
                {
                    Location = "AUS",
                    LocationType = "Lab",
                    Operation = "STORAGE",
                    Step = 3
                }
            };

            StudySampleSequences.Add(new StudySampleSequence
            {
                Number = 1,
                Sequence = "EDTA 3mL (violet)-A-0302_CTA_Whole Blood_SHIP STAT SITE_AMBIENT",
                SequenceObjs = new ObservableCollection<SequenceObj>(new[] { new SequenceObj { StudySamples = ss, WorkflowOperations = wo } })
            });

            StudySampleSequences.Add(new StudySampleSequence
            {
                Number = 2,
                Sequence = "EDTA 3mL (red)-A-0302_CTA_Whole Blood_SHIP STAT SITE_AMBIENT",
                SequenceObjs = new ObservableCollection<SequenceObj>(new[] { new SequenceObj { StudySamples = ss, WorkflowOperations = wo } })
            });

            StudySampleSequences.Add(new StudySampleSequence
            {
                Number = 3,
                Sequence = "EDTA 3mL (blue)-A-0302_CTA_Whole Blood_SHIP STAT SITE_AMBIENT",
                SequenceObjs = new ObservableCollection<SequenceObj>(new[] { new SequenceObj { StudySamples = ss, WorkflowOperations = wo } })
                
            });

            StudySampleSequences.Add(new StudySampleSequence
            {
                Number = 4,
                Sequence = "EDTA 3mL (green)-A-0302_CTA_Whole Blood_SHIP STAT SITE_AMBIENT",
                SequenceObjs = new ObservableCollection<SequenceObj>(new[] { new SequenceObj { StudySamples = ss, WorkflowOperations = wo } })
            });

            StudySampleSequences.Add(new StudySampleSequence
            {
                Number = 5,
                Sequence = "EDTA 5mL (green)-A-0302_CTA_Whole Blood_SHIP STAT SITE_AMBIENT",
                SequenceObjs = new ObservableCollection<SequenceObj>(new[] { new SequenceObj { StudySamples = ss, WorkflowOperations = wo } })
            });

            DataContext = StudySampleSequences;
        }
    }

    public class Conference
    {
        public Conference(string name)
        {
            Name = name;
            Teams = new ObservableCollection<Team>();
        }

        public ObservableCollection<Team> Teams { get; set; }

        public string Name { get; set; }

    }

    public class Team
    {
        public string TeamName { get; set; }

        public Team(string teamName)
        {
            TeamName = teamName;
        }
    }
}
