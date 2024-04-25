using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DXAppSportSchool.Module.BusinessObjects;

namespace DXApplicationSportSchool2.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class HospitalCard : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public HospitalCard(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        string _fullName;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string FullName
        {
            get => _fullName;
            set => SetPropertyValue(nameof(FullName), ref _fullName, value);
        }
        string _addmissionToCompetitions;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string AddmissionToCompetitions
        {
            get => _addmissionToCompetitions;
            set => SetPropertyValue(nameof(AddmissionToCompetitions), ref _addmissionToCompetitions, value);
        }
        string _deseases;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Deseases
        {
            get => _deseases;
            set => SetPropertyValue(nameof(Deseases), ref _deseases, value);
        }
        Student _assignedTo;
        [Association("Student-HospitalCards")]
        public Student AssignedTo
        {
            get => _assignedTo;
            set => SetPropertyValue(nameof(AssignedTo), ref _assignedTo, value);
        }
    }
}