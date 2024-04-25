using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DXAppSportSchool.Module.BusinessObjects;

namespace DXApplicationSportSchool2.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class KindOfSport : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public KindOfSport(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        string _nameOfSport;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NameOfSport
        {
            get => _nameOfSport;
            set => SetPropertyValue(nameof(NameOfSport), ref _nameOfSport, value);
        }
        [Association("KindOfSport-Students")]
        public XPCollection<Student> Students
        {
            get
            {
                return GetCollection<Student>(nameof(Students));
            }
        }
    }
}