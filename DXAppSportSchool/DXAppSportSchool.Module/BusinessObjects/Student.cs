using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace DXApplicationSportSchool2.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Student : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Student(Session session)
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
        string _sex;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Sex
        {
            get => _sex;
            set => SetPropertyValue(nameof(Sex), ref _sex, value);
        }
        int _age;
        public int Age
        {
            get => _age;
            set => SetPropertyValue(nameof(Age), ref _age, value);
        }
        string _photo;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Photo
        {
            get => _photo;
            set => SetPropertyValue(nameof(Photo), ref _photo, value);
        }
        string _phoneNumber;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => SetPropertyValue(nameof(PhoneNumber), ref _phoneNumber, value);
        }
        string _achievements;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Achievements
        {
            get => _achievements;
            set => SetPropertyValue(nameof(Achievements), ref _achievements, value);
        }
        [Association("Student-HospitalCards")]
        public XPCollection<HospitalCard> HospitalCards
        {
            get
            {
                return GetCollection<HospitalCard>(nameof(HospitalCards));
            }
        }
        CoachingStaff _assignedToCoachingStaff;
        [Association("CoachingStaff-Students")]
        public CoachingStaff AssignedToCoachingStaff
        {
            get => _assignedToCoachingStaff;
            set => SetPropertyValue(nameof(AssignedToCoachingStaff), ref _assignedToCoachingStaff, value);
        }
        KindOfSport _assignedToKindOfSport;
        [Association("KindOfSport-Students")]
        public KindOfSport AssignedToKindOfSport
        {
            get => _assignedToKindOfSport;
            set => SetPropertyValue(nameof(AssignedToKindOfSport), ref _assignedToKindOfSport, value);
        }
    }
}