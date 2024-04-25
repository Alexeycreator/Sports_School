using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DXAppSportSchool.Module.BusinessObjects;

namespace DXApplicationSportSchool2.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class CoachingStaff : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public CoachingStaff(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        string _jobTitle;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string JobTitile
        {
            get => _jobTitle;
            set => SetPropertyValue(nameof(JobTitile), ref _jobTitle, value);
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
        [Association("CoachingStaff-Students")]
        public XPCollection<Student> Students
        {
            get
            {
                return GetCollection<Student>(nameof(Students));
            }
        }
    }
}