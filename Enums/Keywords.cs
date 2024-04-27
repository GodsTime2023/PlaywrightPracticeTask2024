namespace PlaywrightPracticeTask2024.Enums
{
    public class Keywords
    {
        public enum KeyWordEnum
        {
            Tab,
            NewWindow
        }

        public enum KeyWordEnumValue
        {
            [EnumMember(Value = "Tab")]
            Tab,
            [EnumMember(Value = "Window")]
            Window
        }
    }
}
